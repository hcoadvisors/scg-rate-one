//Autor: Juan Barquero
//Fecha: 19/11/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAPbobsCOM;
using SCG.SyncBCCR.Config;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Reflection;


namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    public partial class frmConfigurationExchangeRate : Form
    {

        #region Declaraciones

        private List<DIOption> _dbServerTypes;
        private List<ExchangeRateTypeOption> _ExchangeRateTypeOptions;
        private List<DIOption> _languages;
        private Settings.ConnectionCompanyRow _row;
        private EditMode _editMode;
        private Settings _settings;



        #endregion

        # region Constructores




        public frmConfigurationExchangeRate()
        {
            InitializeComponent();
        }

        public frmConfigurationExchangeRate(EditMode editMode, ref Settings settings, ref Settings.ConnectionCompanyRow row)
        {
            InitializeComponent();

            _editMode = editMode;
            _settings = settings;
            _row = row;
        }

        # endregion

        #region Metodos Privados
       
        private static string GetConfigFilePath()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

            path = path.Replace(@"file:\", "");

            string configFile = Path.Combine(path, "Settings.xml");

            return configFile;
        }

        /// <summary>
        /// Según el tipo de edición del formulario inicializa los controles de captura de datos o carga una configuración para su modificación
        /// </summary>
        private void LoadData()
        {
            if (_editMode == EditMode.Add)
            {
                _row = _settings.ConnectionCompany.NewConnectionCompanyRow();

                txtCode.Clear();
                txtServer.Clear();
                cboDbServerType.SelectedIndex = -1;
                txtCompanyDB.Clear();


                txtCode.Focus();
            }
            else
            {
                txtCode.Text = _row.Code.ToString();

                if (!_row.IsServerNull())
                    txtServer.Text = _row.Server;

                if (!_row.IsDbServerTypeNull())
                    cboDbServerType.SelectedValue = _row.DbServerType;

                if (!_row.IsCompanyDBNull())
                    txtCompanyDB.Text = _row.CompanyDB;


            }

            //Cambiar codigo banco
            //if (_row.localizacion == "Chile")
            //{
            //    dgvExchangeRates.Columns[2].HeaderText = "Código Banco";

            //}
            //else if (_row.localizacion == "Costa Rica")
            //{
            //    dgvExchangeRates.Columns[2].HeaderText = "Código BCCR";
                
            //}
            
        }

        private void GetExchangeRates()
        {
            try
            {
                SCG.SyncBCCR.Config.Settings.ExchangeRateTypesRow row = null;
                SCG.SyncBCCR.Config.Settings dsSettings = new Config.Settings();
                dsSettings.ReadXml(GetConfigFilePath());
                this.settings1.ExchangeRateTypes.Clear();
                foreach (Config.Settings.ExchangeRateTypesRow ExchangeRateRow in dsSettings.ExchangeRateTypes)
                {
                    if (txtCode.Text.Trim() == ExchangeRateRow.Company.Trim())
                    {
                        row = this.settings1.ExchangeRateTypes.NewExchangeRateTypesRow();
                        row.Company = txtCode.Text;
                        row.Code = ExchangeRateRow.Code;
                        row.BCCRCode = ExchangeRateRow.BCCRCode;

                        row.Type = ExchangeRateRow.Type;
                        row.ID = ExchangeRateRow.ID;
                        this.settings1.ExchangeRateTypes.AddExchangeRateTypesRow(row);
                    }


                }
                row = null;
                dsSettings = null;
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }
            finally
            {


            }
        }

        private void DeleteExchangeRate()
        {
            try
            {

                if (dgvExchangeRates.CurrentRow != null && dgvExchangeRates.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    string code = dgvExchangeRates.CurrentRow.Cells[0].Value.ToString();

                    XmlDocument documento = new XmlDocument();

                    documento.Load(GetConfigFilePath());

                    XmlNamespaceManager nsmgr = new XmlNamespaceManager(documento.NameTable);
                    nsmgr.AddNamespace("ns", "http://tempuri.org/Settings.xsd");


                    XmlNode node = documento.SelectSingleNode("//ns:Settings//ns:ExchangeRateTypes[ns:ID = '" + code + "']", nsmgr);


                    if (node != null)
                    {
                        XmlNode parent = node.ParentNode;
                        parent.RemoveChild(node);

                    }

                    documento.Save(GetConfigFilePath());
                    Message.Show("La configuración del tipo de cambio para la moneda ha sido borrada con éxito.");


                }
                else
                {
                    Message.Show("Debe de seleccionar un elemento.");
                }

            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }


        }

        private void EditExchangeRate()
        {
            if (dgvExchangeRates.CurrentRow != null && dgvExchangeRates.CurrentRow.Cells[0].Value.ToString() != "")
            {
                string code = dgvExchangeRates.CurrentRow.Cells[0].Value.ToString();
                Settings.Clear();
                Settings.ReadXml(GetConfigFilePath());

                Settings.ExchangeRateTypesRow row = Settings.ExchangeRateTypes.FindByID(int.Parse(code));
                //Settings.ConnectionCompanyRow row = Settings.ConnectionCompany.FindByCode(code);


                frmExchangeRate ofrmCompany = new frmExchangeRate(SCG.SyncBCCR.ConfigurationHost.Forms.frmExchangeRate.EditMode.Edit, ref Settings, ref row);

                ofrmCompany.ShowDialog();
            }
            else
            {
                Message.Show("Debe de seleccionar un elemento.");
            }

        }

        private void AddExchangeRate()
        {

            Settings.Clear();


            Settings.ReadXml(GetConfigFilePath());

            Settings.ExchangeRateTypesRow row = Settings.ExchangeRateTypes.NewExchangeRateTypesRow();

            frmExchangeRate ofrmExchangeRate = new frmExchangeRate(SCG.SyncBCCR.ConfigurationHost.Forms.frmExchangeRate.EditMode.Add, ref Settings, ref row, int.Parse(txtCode.Text));

            ofrmExchangeRate.ShowDialog();

        }

        private void LoadExchangeTypeOptions()
        {
            _ExchangeRateTypeOptions = Utility.GetExchangeRateTypes();

            typeDataGridViewTextBoxColumn.DataSource = null;

            typeDataGridViewTextBoxColumn.DataSource = _ExchangeRateTypeOptions;


            typeDataGridViewTextBoxColumn.DisplayMember = "Name";
            typeDataGridViewTextBoxColumn.ValueMember = "Code";

        }

        private void LoadDIOptions()
        {
            _dbServerTypes = Utility.GetDiApiDbServerTypes();

            _languages = Utility.GetDiApiLanguages();

            cboDbServerType.DataSource = _dbServerTypes;
            cboDbServerType.DisplayMember = "Name";
            cboDbServerType.ValueMember = "Code";
            
        }

        public enum EditMode
        {
            Add = 1,
            Edit = 2
        }

        #endregion

        # region Eventos
        private void frmExchangeRate_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDIOptions();
                LoadExchangeTypeOptions();
                LoadData();
                GetExchangeRates();
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteExchangeRate();
            GetExchangeRates();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            AddExchangeRate();
            GetExchangeRates();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditExchangeRate();
            GetExchangeRates();
        }
        # endregion

     
    }
}
