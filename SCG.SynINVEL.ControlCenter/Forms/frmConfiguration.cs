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
using System.Configuration;
using System.Xml;
using System.IO;
using System.Reflection;
using SCG.SyncBCCR.Config;



namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    public partial class frmConfiguration : Form
    {
       
        #region Declaraciones
            /// <summary>
            /// Declaraciones
            /// </summary>
            /// 
           private Configuration _config ;
           List<DIOption> _dbServerTypes;

        #endregion
      
        # region Metodos Privados

        /// <summary>
        /// Carga en el objeto los tipos de servidores y lenguajes permitidos
        /// </summary>
        private void LoadDIOptions()
        {
            _dbServerTypes = Utility.GetDiApiDbServerTypes();

            //_languages = Utility.GetDiApiLanguages();

            ColServerType.DataSource = _dbServerTypes;
            ColServerType.DisplayMember = "Name";
            ColServerType.ValueMember = "Code";


        }

        /// <summary>
        /// Guarda en el XML la configuración de la compañia
        /// </summary>
        private void SaveAllData()
        {

            if (nudTimeWait.Value > 0)
            {
                if (Message.Question("¿Desea guardar los cambios?") == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveCnx();
                    Message.Show("Parametros actualizado con éxito");

                }
            }


        }

        /// <summary>
        /// Guarda los datos en el xml
        /// </summary>
        private void SaveCnx()
        {

            _config.AppSettings.Settings.Remove("SyncTime");

            _config.AppSettings.Settings.Add("SyncTime", nudTimeWait.Value.ToString());

            _config.Save(ConfigurationSaveMode.Full);

            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Obtiene la ubicación del archivo XML
        /// </summary>
        public static string GetConfigFilePath()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

            path = path.Replace(@"file:\", "");

            string configFile = Path.Combine(path, "Settings.xml");

            return configFile;
        }

        /// <summary>
        /// Obtiene la configuración de las compañias.
        /// </summary>
        private void GetCnx()
        {
            nudTimeWait.Value = Convert.ToDecimal(_config.AppSettings.Settings["SyncTime"].Value);
            GetCompanys();
        }

        /// <summary>
        /// Obtiene las compañias configuradas en el XML
        /// </summary>
        private void GetCompanys()
        {
            try
            {
                SCG.SyncBCCR.Config.Settings.ConnectionCompanyRow row = null;
                SCG.SyncBCCR.Config.Settings dsSettings = new Config.Settings();
                dsSettings.ReadXml(GetConfigFilePath());
                this._settings.ConnectionCompany.Clear();
                foreach (Config.Settings.ConnectionCompanyRow companyRow in dsSettings.ConnectionCompany)
                {
                    row = this._settings.ConnectionCompany.NewConnectionCompanyRow();

                    row.Code = companyRow.Code;
                    row.Server = companyRow.Server;
                    row.LicenseServer = companyRow.LicenseServer;
                    row.CompanyDB = companyRow.CompanyDB;
                    row.Language = companyRow.Language;
                    row.Password = companyRow.Password;
                    row.UserName = companyRow.UserName;
                    row.DbPassword = companyRow.DbPassword;
                    row.DbUserName = companyRow.DbUserName;
                    row.UseTrusted = companyRow.UseTrusted;
                    row.DbServerType = companyRow.DbServerType;
                    row.Localizacion = companyRow.Localizacion;
                    row.WSUsername = companyRow.WSUsername;
                    row.WSPassword = companyRow.WSPassword;

                    this._settings.ConnectionCompany.AddConnectionCompanyRow(row);
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

        /// <summary>
        /// Agrega una compañia en el XML
        /// </summary>
        private void AddCompany()
        {

            Settings.Clear();


            Settings.ReadXml(GetConfigFilePath());

            Settings.ConnectionCompanyRow row = Settings.ConnectionCompany.NewConnectionCompanyRow();

            frmCompany ofrmCompany = new frmCompany(SCG.SyncBCCR.ConfigurationHost.Forms.frmCompany.EditMode.Add, ref Settings, ref row);

            ofrmCompany.ShowDialog();


        }

        /// <summary>
        /// Edita una compañia del XML
        /// </summary>
        private void EditCompany()
        {
            if (dgvCompañias.CurrentRow != null && dgvCompañias.CurrentRow.Cells[0].Value.ToString() != "")
            {
                string code = dgvCompañias.CurrentRow.Cells[0].Value.ToString();
                Settings.Clear();
                Settings.ReadXml(GetConfigFilePath());
                Settings.ConnectionCompanyRow row = Settings.ConnectionCompany.FindByCode(int.Parse(code));


                frmCompany ofrmCompany = new frmCompany(SCG.SyncBCCR.ConfigurationHost.Forms.frmCompany.EditMode.Edit, ref Settings, ref row);

                ofrmCompany.ShowDialog();


            }
            else
            {
                Message.Show("Debe de seleccionar un elemento.");
            }

        }

        /// <summary>
        /// Elimina una compañia del XML
        /// </summary>
        private void DeleteCompany()
        {
            try
            {

                if (dgvCompañias.CurrentRow != null && dgvCompañias.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    string code = dgvCompañias.CurrentRow.Cells[0].Value.ToString();

                    XmlDocument documento = new XmlDocument();

                    documento.Load(GetConfigFilePath());

                    XmlNamespaceManager nsmgr = new XmlNamespaceManager(documento.NameTable);
                    nsmgr.AddNamespace("ns", "http://tempuri.org/Settings.xsd");


                    XmlNode Childnode = documento.SelectSingleNode("//ns:Settings//ns:ExchangeRateTypes[ns:Company = '" + code + "']", nsmgr);

                    if (Childnode != null)
                    {
                        XmlNode parent = Childnode.ParentNode;
                        parent.RemoveChild(Childnode);

                    }

                    documento.Save(GetConfigFilePath());

                    documento = new XmlDocument();

                    documento.Load(GetConfigFilePath());

                    XmlNode node = documento.SelectSingleNode("//ns:Settings//ns:ConnectionCompany[ns:Code = '" + code + "']", nsmgr);




                    if (node != null)
                    {
                        XmlNode parent = node.ParentNode;
                        parent.RemoveChild(node);

                    }

                    documento.Save(GetConfigFilePath());

                    Message.Show("La conexión a la compañía ha sido borrada con éxito.");

                }
                else
                {
                    Message.Show("Debe de seleccionar una compañía.");

                }

            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }


        }

        /// <summary>
        /// Carga la información de la compañia, para cargar el formulario de tipos de cambio
        /// </summary>
        private void EditExchangeRate()
        {
            if (dgvCompañias.CurrentRow != null && dgvCompañias.CurrentRow.Cells[0].Value.ToString() != "")
            {
                string code = dgvCompañias.CurrentRow.Cells[0].Value.ToString();
                Settings.Clear();
                Settings.ReadXml(GetConfigFilePath());
                Settings.ConnectionCompanyRow row = Settings.ConnectionCompany.FindByCode(int.Parse(code));


                frmConfigurationExchangeRate ofrmCompany = new frmConfigurationExchangeRate(SCG.SyncBCCR.ConfigurationHost.Forms.frmConfigurationExchangeRate.EditMode.Edit, ref Settings, ref row);

                ofrmCompany.ShowDialog();
            }

        }

        # endregion
  
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
         public frmConfiguration()
        {
            InitializeComponent();
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        #endregion

        #region Eventos
         private void btnSave_Click(object sender, EventArgs e)
         {
             try
             {
                 this.Cursor = Cursors.WaitCursor;
                 SaveAllData();
                 this.Cursor = Cursors.Arrow;
                 this.Close();

             }
             catch (System.Data.ConstraintException)
             {
                 //Message.Error("El código: " + txtCode.Text + " ya existe, debe utilizar otro código.");
             }
             catch (Exception ex)
             {
                 Message.Error(ex.Message);
             }
         }

         private void frmConfiguration_Load(object sender, EventArgs e)
         {
             LoadDIOptions();
             GetCnx();
         }

         private void btnRemove_Click(object sender, EventArgs e)
         {
             DeleteCompany();
             GetCompanys();
         }

         private void btnAgregar_Click(object sender, EventArgs e)
         {
             AddCompany();
             GetCompanys();
         }

         private void dgvCompañias_DoubleClick(object sender, EventArgs e)
         {
             EditExchangeRate();
         }

         private void btnEdit_Click(object sender, EventArgs e)
         {
             EditCompany();
             GetCompanys();
         }

         private void btnAddExchangeRate_Click(object sender, EventArgs e)
         {
             EditExchangeRate();
             GetCompanys();
         }
        # endregion
    }
}
