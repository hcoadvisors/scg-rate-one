namespace SCG.SyncBCCR.ConfigurationHost
{
    partial class ServiceManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManager));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.configuracionGroupBox = new System.Windows.Forms.GroupBox();
            this.servidorLabel = new System.Windows.Forms.Label();
            this.servidorTextBox = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicioStatusStrip = new System.Windows.Forms.StatusStrip();
            this.servicioStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.verificarServicioTimer = new System.Windows.Forms.Timer(this.components);
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.servidorNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.servidorContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirSCGRMSWebSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerButton = new System.Windows.Forms.Button();
            this.iniciarButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fondoPictureBox = new System.Windows.Forms.PictureBox();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
            this.configuracionGroupBox.SuspendLayout();
            this.servicioStatusStrip.SuspendLayout();
            this.servidorContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.statusPictureBox);
            this.statusPanel.Controls.Add(this.statusLabel);
            this.statusPanel.Location = new System.Drawing.Point(8, 140);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(312, 51);
            this.statusPanel.TabIndex = 20;
            // 
            // statusPictureBox
            // 
            this.statusPictureBox.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.SyncEnCurso;
            this.statusPictureBox.Location = new System.Drawing.Point(38, 7);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.Size = new System.Drawing.Size(44, 38);
            this.statusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.statusPictureBox.TabIndex = 20;
            this.statusPictureBox.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(88, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(89, 13);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "Servicio detenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "SCG Rate One Service";
            // 
            // configuracionGroupBox
            // 
            this.configuracionGroupBox.Controls.Add(this.servidorLabel);
            this.configuracionGroupBox.Controls.Add(this.servidorTextBox);
            this.configuracionGroupBox.Location = new System.Drawing.Point(8, 89);
            this.configuracionGroupBox.Name = "configuracionGroupBox";
            this.configuracionGroupBox.Size = new System.Drawing.Size(312, 41);
            this.configuracionGroupBox.TabIndex = 53;
            this.configuracionGroupBox.TabStop = false;
            // 
            // servidorLabel
            // 
            this.servidorLabel.AutoSize = true;
            this.servidorLabel.Location = new System.Drawing.Point(2, 17);
            this.servidorLabel.Name = "servidorLabel";
            this.servidorLabel.Size = new System.Drawing.Size(94, 13);
            this.servidorLabel.TabIndex = 1;
            this.servidorLabel.Text = "Nombre de equipo";
            // 
            // servidorTextBox
            // 
            this.servidorTextBox.AceptaNegativos = false;
            this.servidorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.servidorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servidorTextBox.Enabled = false;
            this.servidorTextBox.EsMandatorio = false;
            this.servidorTextBox.EsMultilinea = false;
            this.servidorTextBox.EstiloSBO = true;
            this.servidorTextBox.Location = new System.Drawing.Point(125, 16);
            this.servidorTextBox.MaxDecimales = 0;
            this.servidorTextBox.MaxEnteros = 0;
            this.servidorTextBox.Millares = false;
            this.servidorTextBox.Multiline = true;
            this.servidorTextBox.Name = "servidorTextBox";
            this.servidorTextBox.ReadOnly = true;
            this.servidorTextBox.Size = new System.Drawing.Size(169, 14);
            this.servidorTextBox.Size_AdjustableHeight = 14;
            this.servidorTextBox.TabIndex = 0;
            this.servidorTextBox.Tag = "9999";
            this.servidorTextBox.TeclasDeshacer = true;
            this.servidorTextBox.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iniciar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Detener";
            // 
            // servicioStatusStrip
            // 
            this.servicioStatusStrip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicioStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicioStripStatusLabel,
            this.versionStripStatusLabel,
            this.toolStripStatusLabel1});
            this.servicioStatusStrip.Location = new System.Drawing.Point(0, 308);
            this.servicioStatusStrip.Name = "servicioStatusStrip";
            this.servicioStatusStrip.Size = new System.Drawing.Size(328, 22);
            this.servicioStatusStrip.SizingGrip = false;
            this.servicioStatusStrip.TabIndex = 57;
            // 
            // servicioStripStatusLabel
            // 
            this.servicioStripStatusLabel.AutoSize = false;
            this.servicioStripStatusLabel.Name = "servicioStripStatusLabel";
            this.servicioStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.servicioStripStatusLabel.Size = new System.Drawing.Size(215, 17);
            this.servicioStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionStripStatusLabel
            // 
            this.versionStripStatusLabel.AutoSize = false;
            this.versionStripStatusLabel.Name = "versionStripStatusLabel";
            this.versionStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.versionStripStatusLabel.Size = new System.Drawing.Size(110, 17);
            this.versionStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // verificarServicioTimer
            // 
            this.verificarServicioTimer.Tick += new System.EventHandler(this.verificarServicioTimer_Tick);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(57, 273);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(96, 23);
            this.btnConfig.TabIndex = 58;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(175, 273);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(96, 23);
            this.btnLogs.TabIndex = 59;
            this.btnLogs.Text = "Bitácora";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Visible = false;
            // 
            // servidorNotifyIcon
            // 
            this.servidorNotifyIcon.ContextMenuStrip = this.servidorContextMenuStrip;
            this.servidorNotifyIcon.Text = "SCGSync_BCCR";
            this.servidorNotifyIcon.Visible = true;
            this.servidorNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.servidorNotifyIcon_MouseDoubleClick);
            // 
            // servidorContextMenuStrip
            // 
            this.servidorContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSCGRMSWebSyncToolStripMenuItem,
            this.toolStripSeparator1,
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.servidorContextMenuStrip.Name = "servidorContextMenuStrip";
            this.servidorContextMenuStrip.Size = new System.Drawing.Size(227, 104);
            // 
            // abrirSCGRMSWebSyncToolStripMenuItem
            // 
            this.abrirSCGRMSWebSyncToolStripMenuItem.Name = "abrirSCGRMSWebSyncToolStripMenuItem";
            this.abrirSCGRMSWebSyncToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.abrirSCGRMSWebSyncToolStripMenuItem.Text = "Abrir SCG Sycn BCCR Service";
            this.abrirSCGRMSWebSyncToolStripMenuItem.Click += new System.EventHandler(this.abrirSCGRMSWebSyncToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // detenerButton
            // 
            this.detenerButton.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.detener;
            this.detenerButton.Location = new System.Drawing.Point(124, 230);
            this.detenerButton.Name = "detenerButton";
            this.detenerButton.Size = new System.Drawing.Size(30, 23);
            this.detenerButton.TabIndex = 55;
            this.detenerButton.UseVisualStyleBackColor = true;
            this.detenerButton.Click += new System.EventHandler(this.detenerButton_Click);
            // 
            // iniciarButton
            // 
            this.iniciarButton.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.iniciar;
            this.iniciarButton.Location = new System.Drawing.Point(124, 201);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(30, 23);
            this.iniciarButton.TabIndex = 54;
            this.iniciarButton.UseVisualStyleBackColor = true;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.Barra;
            this.pictureBox3.Location = new System.Drawing.Point(0, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(328, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.LogoSCGMiniDegradado;
            this.pictureBox2.Location = new System.Drawing.Point(218, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // fondoPictureBox
            // 
            this.fondoPictureBox.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.Encabezado2;
            this.fondoPictureBox.Location = new System.Drawing.Point(0, 24);
            this.fondoPictureBox.Name = "fondoPictureBox";
            this.fondoPictureBox.Size = new System.Drawing.Size(328, 56);
            this.fondoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoPictureBox.TabIndex = 39;
            this.fondoPictureBox.TabStop = false;
            // 
            // ServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 330);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.servicioStatusStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detenerButton);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.configuracionGroupBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fondoPictureBox);
            this.Controls.Add(this.statusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCG Rate One Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceManager_FormClosing);
            this.Load += new System.EventHandler(this.ServiceManager_Load);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
            this.configuracionGroupBox.ResumeLayout(false);
            this.configuracionGroupBox.PerformLayout();
            this.servicioStatusStrip.ResumeLayout(false);
            this.servicioStatusStrip.PerformLayout();
            this.servidorContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox statusPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox fondoPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox configuracionGroupBox;
        private System.Windows.Forms.Label servidorLabel;
        private UX.Windows.SCGTextBox servidorTextBox;
        private System.Windows.Forms.Button iniciarButton;
        private System.Windows.Forms.Button detenerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip servicioStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel servicioStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel versionStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer verificarServicioTimer;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.NotifyIcon servidorNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip servidorContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem abrirSCGRMSWebSyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}