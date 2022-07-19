//Autor: José Alberto Fuentes Chacón
//Fecha: 25/11/2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Configuration;
using Microsoft.Win32;
using System.Management;
using System.Xml;
using System.Reflection;
using SCG.GenLic.WMI;
using SCG.SyncBCCR.Config;
using SCG.DAC;
using SCG.SyncBCCR.ConfigurationHost.Forms;

namespace SCG.SyncBCCR.ConfigurationHost
{
    public partial class ServiceManager : Form
    {

        #region Declaraciones

        private const string SOURCE = "SCGSyncBCCR";
        private HardwareProfile _hprofile;
        private Boolean _cerrarApp;


        #endregion

        #region Constructores

        public ServiceManager()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos privados

     
        /// <summary>
        /// Obtiene el nombre de la PC
        /// </summary>
        /// <returns></returns>
        private String GetPCName()
        {
            String pcName = "";
            _hprofile = new HardwareProfile();
            pcName = _hprofile.GetNombreEquipo();

            return pcName;
        }

        /// <summary>
        /// Verifica si el servicio esta instalado
        /// </summary>
        /// <param name="serviceName">Nombre del servicio a veridicar</param>
        /// <returns>Retorna un boolean indicando si esta o no instalado el servicio</returns>
        private Boolean ServiceInstalled(string serviceName)
        {
            // Obtiene la lista de servicios
            ServiceController[] services = ServiceController.GetServices();

            // Intenta buscar el servicio
            foreach (ServiceController service in services)
            {
                if (service.ServiceName == serviceName)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Inicia el servidor 
        /// </summary>
        private void StartServer()
        {
            ServiceController sc = new ServiceController(SOURCE);
            sc.Start();
            Refresh(sc);
            
        }

        /// <summary>
        /// Detiene el servidor
        /// </summary>
        private void StopServer()
        {
            ServiceController sc = new ServiceController(SOURCE);
            sc.Stop();
            Refresh(sc);
            sc = null;

        }

        /// <summary>
        /// Encargado de refrescar los estados de los controladores 
        /// </summary>
        /// <param name="sc"></param>
        private void Refresh(ServiceController sc)
        {
            sc.Refresh();

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                this.servidorNotifyIcon.Icon = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SV_3;
                this.servicioStripStatusLabel.Text = "Servicio Detenido";

                this.statusPictureBox.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SyncDetenida;
                this.statusLabel.Text = "Servicio detenido";

                this.iniciarButton.Enabled = true;
                this.detenerButton.Enabled = false;
                this.btnConfig.Enabled = true;
                this.iniciarToolStripMenuItem.Enabled = true;
                this.detenerToolStripMenuItem.Enabled = false;
                
            }

            if (sc.Status == ServiceControllerStatus.Running)
            {
                this.servidorNotifyIcon.Icon = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SV_2;
                this.servicioStripStatusLabel.Text = "Servicio en Ejecución";
                this.statusPictureBox.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SyncExitosa;
                this.statusLabel.Text = "Servicio en Ejecución";
                this.iniciarButton.Enabled = false;
                this.detenerButton.Enabled = true;
                this.btnLogs.Enabled = true;
                this.btnConfig.Enabled = false;
                this.iniciarToolStripMenuItem.Enabled = false;
                this.detenerToolStripMenuItem.Enabled = true;
                this.verificarServicioTimer.Enabled = true;
                
            }

            if (sc.Status == ServiceControllerStatus.StopPending)
            {
                this.servidorNotifyIcon.Icon = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SV_3;
                this.servicioStripStatusLabel.Text = "Deteniendo Servicio";
                this.statusPictureBox.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SyncDetenida;
                this.statusLabel.Text = "Deteniendo servicio";
                this.iniciarButton.Enabled = false;
                this.detenerButton.Enabled = false;
                this.btnConfig.Enabled = false;
                this.iniciarToolStripMenuItem.Enabled = false;
                this.detenerToolStripMenuItem.Enabled = false;
                    }

            if (sc.Status == ServiceControllerStatus.StartPending)
            {
                this.servidorNotifyIcon.Icon = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SV_2;
                this.servicioStripStatusLabel.Text = "Iniciando Servicio";

                this.statusPictureBox.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SyncPendiente;
                this.statusLabel.Text = "Sincronización pendiente";

                this.iniciarButton.Enabled = false;
                this.detenerButton.Enabled = false;
                this.iniciarToolStripMenuItem.Enabled = false;
                this.detenerToolStripMenuItem.Enabled = false;
            }
        }

        #endregion 

        #region Eventos

        private void ServiceManager_Load(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
             

                if (!ServiceInstalled(SOURCE))
                {
                    Message.Error("El servicio " + SOURCE + " no existe, reinstale la aplicación.");
                    this.iniciarButton.Enabled = false;
                    this.detenerButton.Enabled = false;
                    this.servicioStripStatusLabel.Text = "Servicio no Disponible";
                    Show();
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.verificarServicioTimer.Enabled = true;

                }

                servidorTextBox.Text = GetPCName();
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);

            }
        }

        private void iniciarButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Boolean cnxStatus = false;
            try
            {
                if (ServiceInstalled(SOURCE)) //verifica el servicio 
                {
                    cnxStatus = true; 
                 
                }
                else
                {
                    Message.Error("El servicio " + SOURCE + " no existe, reinstale la aplicación.");
                    cnxStatus = false;
                }

                if (cnxStatus == true)  
                {
                    StartServer();
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Arrow;
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }
            this.Cursor = Cursors.Arrow;
        }

        private void detenerButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                StopServer(); 
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Arrow;
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }
            this.Cursor = Cursors.Arrow; 
        }

        private void verificarServicioTimer_Tick(object sender, EventArgs e)
        {
            
            try
            {
                if (ServiceInstalled(SOURCE))
                {
                    ServiceController sc = new ServiceController(SOURCE);
                    Refresh(sc);
                }

            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }
           
        }

        private void servidorNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }
        }

        private void ServiceManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                _cerrarApp = true;

            if (!_cerrarApp)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.iniciarButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }
 
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.detenerButton_Click(sender, e);

            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }

        }

        private void abrirSCGRMSWebSyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (FormWindowState.Minimized == WindowState && this.Visible == true)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _cerrarApp = true;
                this.verificarServicioTimer.Enabled = false;
                this.Close();

            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }

        }

        private void mStripOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                
                frmConfiguration oFrmConfiguration = new frmConfiguration();
                oFrmConfiguration.ShowDialog();
            }
            catch (Exception ex)
            {
                Message.Error(ex.Message);
                ErrorLog.WriteError(ex);
            }
        }

        #endregion

        private void btnLogs_Click(object sender, EventArgs e)
        {

        }
    }
}
