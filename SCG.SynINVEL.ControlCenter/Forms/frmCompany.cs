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
using SCG.SyncBCCR.Config;
using SAPbobsCOM;
using SCG.Cifrado;


namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    public partial class frmCompany : Form
    {
        
        #region Declaraciones
        
        /// <summary>
        /// Declaraciones
        /// </summary>
        
        private List<DIOption> _dbServerTypes;
        private List<DIOption> _languages;
        private List<DIOption> _locations;
        private Settings.ConnectionCompanyRow _row;
        private EditMode _editMode;
        private Settings _settings;
        private const string LLAVE = "28AF0447C8C24547892C3EA083098FF0";
        private const string VECTOR = "C91F7F3B36564ac2BCC53B10";



        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>

        public frmCompany()
        {
            InitializeComponent();
        }


        public frmCompany(EditMode editMode, ref Settings settings, ref Settings.ConnectionCompanyRow row)
        {
            InitializeComponent();

            _editMode = editMode;
            _settings = settings;
            _row = row;
        }
        #endregion

        #region Metodos Privados
        /// <summary>
        /// Verifica si posible establecer conexión con la base de datos de SAP en base a los parámetros especificados
        /// </summary>
        private bool IsValidConnection(out int errorCode, out string errorMessage)
        {
            

            Company company = Utility.CreateDiConnection(txtServer.Text,
                                                         txtCompanyDB.Text,
                                                         cboDbServerType.SelectedValue.ToString(),
                                                         chkUseTrusted.Checked,
                                                         txtDbUserName.Text,
                                                         Cifra.DesEncripta(txtDbPassword.Text,LLAVE,VECTOR),
                                                         txtUserName.Text,
                                                         Cifra.DesEncripta(txtPassword.Text,LLAVE,VECTOR),
                                                         txtLicenseServer.Text,
                                                         Convert.ToInt16(cboLanguage.SelectedValue.ToString())
                                                         );

            int result = company.Connect();

            if (result != 0)
            {
                errorCode = result;
                errorMessage = company.GetLastErrorDescription();

                if (company != null)
                {
                    //Se agrego linea para mantenimiento y para liberar recursos
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(company);
                }
                return false;
            }
            else
            {
                errorCode = result;
                errorMessage = string.Empty;
                company.Disconnect();

                if (company != null)
                {
                    //Se agrego linea para mantenimiento y para liberar recursos
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(company);
                }
            
                return true;
            }

           

        }

        /// <summary>
        /// Guarda los datos en el archivo xml de configuración
        /// </summary>
        private void SaveData()
        {
            if (controlsValidator.Valida(true))
            {
                if (Message.Question("¿Desea guardar los cambios?") == System.Windows.Forms.DialogResult.Yes)
                {

                    int result = 0;
                    string errorMessage = string.Empty;

                    if (!IsValidConnection(out result, out errorMessage))
                    {
                        Message.Error("Error al intentar establecer conexión con la base de datos.\r\nCausa: " + result.ToString() + " - " + errorMessage);
                    }
                    else
                    {
                        string configPath = Utility.GetConfigFilePath();
                        if (_editMode == EditMode.Add)
                        {
                            _row.Code = _settings.ConnectionCompany.Count() + 1;
                        }
                        else 
                        {
                            _row.Code = int.Parse (txtCode.Text);
                        }

                        if (cboLocalizacion.SelectedValue.ToString().Equals("CR") || (cboLocalizacion.SelectedValue.ToString().Equals("CL") && !string.IsNullOrEmpty(txtWSUser.Text) && !string.IsNullOrEmpty(txtWSPass.Text)))
                        {
                            _row.Server = txtServer.Text;
                            _row.DbServerType = cboDbServerType.SelectedValue.ToString();
                            _row.CompanyDB = txtCompanyDB.Text;
                            _row.UseTrusted = chkUseTrusted.Checked;
                            _row.DbUserName = txtDbUserName.Text;
                            _row.DbPassword = txtDbPassword.Text;
                            _row.UserName = txtUserName.Text;
                            _row.Password = txtPassword.Text;
                            _row.LicenseServer = txtLicenseServer.Text;
                            _row.Language = cboLanguage.SelectedValue.ToString();
                            _row.Localizacion = cboLocalizacion.SelectedValue.ToString();
                            _row.WSUsername = txtWSUser.Text;
                            _row.WSPassword = txtWSPass.Text;
                            _row.MaxTime = txtmaxtime.Value.ToString("HH:mm");

                            if (_editMode == EditMode.Add)
                                _settings.ConnectionCompany.AddConnectionCompanyRow(_row);

                            _settings.WriteXml(configPath);

                            this.lblSuccessfulConnectio.Visible = true;

                            this.Refresh();

                            System.Threading.Thread.Sleep(2000);

                            this.Close();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtWSUser.Text))
                            {
                                Message.Error("El campo Usuario WS no puede estar vacio");
                            }
                            else
                            {
                                Message.Error("El campo Contraseña WS no puede estar vacio");
                            }
                            
                        }
                        

                    }


                }
            }


        }

        /// <summary>
        /// Enumeración para manejar los tipos de edición
        /// </summary>
        public enum EditMode
        {
            Add = 1,
            Edit = 2
        }

        /// <summary>
        /// Carga en el objeto los tipos de servidores y lenguajes permitidos
        /// </summary>
        private void LoadDIOptions()
        {
            _dbServerTypes = Utility.GetDiApiDbServerTypes();

            _languages = Utility.GetDiApiLanguages();

            _locations = Utility.GetLocations();

            cboDbServerType.DataSource = _dbServerTypes;
            cboDbServerType.DisplayMember = "Name";
            cboDbServerType.ValueMember = "Code";

            cboLanguage.DataSource = _languages;
            cboLanguage.DisplayMember = "Name";
            cboLanguage.ValueMember = "Code";

            cboLocalizacion.DataSource = _locations;
            cboLocalizacion.DisplayMember = "Name";
            cboLocalizacion.ValueMember = "Code";


        }

        /// <summary>
        /// Según el tipo de edición del formulario inicializa los controles de captura de datos o carga una configuración para su modificación
        /// </summary>
        private void LoadData()
        {
            if (_editMode == EditMode.Add)
            {
                txtCode.Clear();
                txtServer.Clear();
                cboDbServerType.SelectedIndex = 3;
                txtCompanyDB.Clear();
                chkUseTrusted.Checked = false;
                txtDbUserName.Clear();
                txtDbPassword.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                txtLicenseServer.Clear();
                cboLanguage.SelectedIndex = 2;
                txtCode.Focus();
                txtWSUser.Clear();
                cboLocalizacion.SelectedIndex = 0;
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

                if (!_row.IsUseTrustedNull())
                    chkUseTrusted.Checked = _row.UseTrusted;

                if (!_row.IsDbUserNameNull())
                    txtDbUserName.Text = _row.DbUserName;

                if (!_row.IsDbPasswordNull())
                    txtDbPassword.Text = _row.DbPassword;

                if (!_row.IsUserNameNull())
                    txtUserName.Text = _row.UserName;

                if (!_row.IsPasswordNull())
                    txtPassword.Text = _row.Password;

                if (!_row.IsLicenseServerNull())
                    txtLicenseServer.Text = _row.LicenseServer;

                if (!_row.IsLanguageNull())
                    cboLanguage.SelectedValue = _row.Language;

                if (!_row.IsLocalizacionNull())
                    cboLocalizacion.SelectedValue = _row.Localizacion;

                if (!_row.IsWSUsernameNull())
                    txtWSUser.Text = _row.WSUsername;

                if (!_row.IsWSPasswordNull())
                    txtWSPass.Text = _row.WSPassword;

                if (!_row.IsMaxTimeNull())
                    txtmaxtime.Text = _row.MaxTime;

            }

        }

        # endregion

        #region Eventos

        private void frmCompany_Load(object sender, EventArgs e)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (System.Data.ConstraintException)
            {
                Message.Error("El código: " + txtCode.Text + " ya existe, debe utilizar otro código.");
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
            }
        }

        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cboLocalizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocalizacion.SelectedIndex == 1)
            {
                txtWSUser.ReadOnly = false;
                txtWSUser.BackColor = Color.White;
                txtWSPass.ReadOnly = false;
                txtWSPass.BackColor = Color.White;
                txtmaxtime.Visible = true;
                lblhm.Visible = true;

            }
            else
            {
                txtWSUser.Text = "";
                txtWSUser.ReadOnly = true;
                txtWSUser.BackColor = Color.Gainsboro;
                txtWSPass.Text = "";
                txtWSPass.ReadOnly = true;
                txtWSPass.BackColor = Color.Gainsboro;
                txtmaxtime.Visible = false;
                lblhm.Visible = false;
                
            }

        }
    }
}
