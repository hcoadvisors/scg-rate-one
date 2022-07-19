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

namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    public partial class frmExchangeRate : Form
    {

        # region Constructores

        public frmExchangeRate()
        {
            InitializeComponent();
        }

        public frmExchangeRate(EditMode editMode, ref Settings settings, ref Settings.ExchangeRateTypesRow  row)
        {
            InitializeComponent();

            _editMode = editMode;
            _settings = settings;
            _row = row;

            //txtCompany.Text = row.Company;
        }

        public frmExchangeRate(EditMode editMode, ref Settings settings, ref Settings.ExchangeRateTypesRow row,int company)
        {
            InitializeComponent();

            _editMode = editMode;
            _settings = settings;
            _row = row;

            txtCompany.Text = company.ToString () ;
        }
        # endregion

        #region Declaraciones

        
        private List<ExchangeRateTypeOption> _ExchangeRateTypeOptions;
        private Settings.ExchangeRateTypesRow  _row;
        private EditMode _editMode;
        private Settings _settings;



        #endregion

        # region Metodos privados

        public enum EditMode
        {
            Add = 1,
            Edit = 2
        }


        /// <summary>
        /// Guarda los datos de la linea de tipo de cambio en el archivo xml de configuración
        /// </summary>
        private void SaveData()
        {
            if (controlsValidator .Valida (true))
            {
                if (Message.Question("¿Desea guardar los cambios?") == System.Windows.Forms.DialogResult.Yes)
            {

                //int result = 0;
                string errorMessage = string.Empty;

                string configPath = Utility.GetConfigFilePath();

                if (_editMode == EditMode.Add)
                {
                    _row.ID = _settings.ExchangeRateTypes.Count() + 1;
                }
                else
                {
                    _row.ID = int.Parse(txtID.Text);
                }

                _row.Company = txtCompany.Text;
                _row.BCCRCode = txtBCCRCode.Text;
                _row.Code = txtCurrCode.Text;
                _row.Type = cboType.SelectedValue.ToString();


                if (_editMode == EditMode.Add)
                    _settings.ExchangeRateTypes.AddExchangeRateTypesRow(_row);
                    
                _settings.WriteXml(configPath);

                this.Refresh();

                System.Threading.Thread.Sleep(100);

                this.Close();
                


            }
            }
            

        }

            private void LoadData()
        {
            if (_editMode == EditMode.Add)
            {
                _row = _settings.ExchangeRateTypes.NewExchangeRateTypesRow();

                txtCompany.Text = txtCompany .Text ;
               
                
                txtCurrCode.Clear();
                txtBCCRCode.Clear();
                cboType.SelectedIndex = 1;
                txtCurrCode.Focus();
                
            }
            else
            {
                txtID.Text = _row.ID.ToString ();

                if (!_row.IsBCCRCodeNull())
                    txtBCCRCode.Text = _row.BCCRCode;

                if (!_row.IsTypeNull())
                    cboType.SelectedIndex = int.Parse(_row.Type);
                if (!_row.IsCompanyNull ())
                    txtCompany .Text  = _row.Company;

                if (!_row.IsCodeNull())
                    txtCurrCode.Text = _row.Code;

              
               

            }

        }

            private void LoadDIOptions()

            {
                _ExchangeRateTypeOptions = Utility.GetExchangeRateTypes();

                cboType.DataSource = _ExchangeRateTypeOptions;
                cboType.DisplayMember = "Name";
                cboType.ValueMember = "Code";
            
            }

           # endregion

        # region Eventos
           private void frmExchangeRate_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDIOptions();
                LoadData();
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (System.Data.ConstraintException)
            {
                Message.Error("El código: " + txtID.Text + " ya existe, debe utilizar otro código.");
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }
        }

        #endregion

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
