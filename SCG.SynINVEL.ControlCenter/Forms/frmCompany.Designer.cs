namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    partial class frmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSuccessfulConnectio = new System.Windows.Forms.Label();
            this.txtCompanyDB = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboDbServerType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLicenseServer = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtPassword = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtUserName = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtDbPassword = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtDbUserName = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtServer = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtCode = new SCG.UX.Windows.SCGTextBox(this.components);
            this.chkUseTrusted = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlsValidator = new SCG.UX.Windows.ControlsValidator();
            this.cboLocalizacion = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWSUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWSPass = new System.Windows.Forms.TextBox();
            this.lblhm = new System.Windows.Forms.Label();
            this.txtmaxtime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.Barra;
            this.pictureBox3.Location = new System.Drawing.Point(0, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.controlsValidator.SetOrden(this.pictureBox3, 0);
            this.controlsValidator.SetPuedeSerVacio(this.pictureBox3, false);
            this.controlsValidator.SetRequerido(this.pictureBox3, false);
            this.pictureBox3.Size = new System.Drawing.Size(364, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.LogoSCGMiniDegradado;
            this.pictureBox2.Location = new System.Drawing.Point(242, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.controlsValidator.SetOrden(this.pictureBox2, 0);
            this.controlsValidator.SetPuedeSerVacio(this.pictureBox2, false);
            this.controlsValidator.SetRequerido(this.pictureBox2, false);
            this.pictureBox2.Size = new System.Drawing.Size(110, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.Encabezado2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.controlsValidator.SetOrden(this.pictureBox1, 0);
            this.controlsValidator.SetPuedeSerVacio(this.pictureBox1, false);
            this.controlsValidator.SetRequerido(this.pictureBox1, false);
            this.pictureBox1.Size = new System.Drawing.Size(364, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.controlsValidator.SetOrden(this.label4, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label4, false);
            this.controlsValidator.SetRequerido(this.label4, false);
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Configuración - Conexión SAP";
            // 
            // lblSuccessfulConnectio
            // 
            this.lblSuccessfulConnectio.AutoSize = true;
            this.lblSuccessfulConnectio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessfulConnectio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSuccessfulConnectio.Location = new System.Drawing.Point(213, 449);
            this.lblSuccessfulConnectio.Name = "lblSuccessfulConnectio";
            this.controlsValidator.SetOrden(this.lblSuccessfulConnectio, 0);
            this.controlsValidator.SetPuedeSerVacio(this.lblSuccessfulConnectio, false);
            this.controlsValidator.SetRequerido(this.lblSuccessfulConnectio, false);
            this.lblSuccessfulConnectio.Size = new System.Drawing.Size(113, 13);
            this.lblSuccessfulConnectio.TabIndex = 79;
            this.lblSuccessfulConnectio.Text = "Conexión exitosa...";
            this.lblSuccessfulConnectio.Visible = false;
            // 
            // txtCompanyDB
            // 
            this.txtCompanyDB.AceptaNegativos = false;
            this.txtCompanyDB.BackColor = System.Drawing.Color.White;
            this.txtCompanyDB.EsMandatorio = true;
            this.txtCompanyDB.EsMultilinea = false;
            this.txtCompanyDB.EstiloSBO = true;
            this.txtCompanyDB.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyDB.Location = new System.Drawing.Point(140, 137);
            this.txtCompanyDB.MaxDecimales = 0;
            this.txtCompanyDB.MaxEnteros = 0;
            this.txtCompanyDB.Millares = false;
            this.txtCompanyDB.Name = "txtCompanyDB";
            this.controlsValidator.SetOrden(this.txtCompanyDB, 4);
            this.controlsValidator.SetPuedeSerVacio(this.txtCompanyDB, false);
            this.controlsValidator.SetRequerido(this.txtCompanyDB, true);
            this.txtCompanyDB.Size = new System.Drawing.Size(186, 21);
            this.txtCompanyDB.Size_AdjustableHeight = 21;
            this.txtCompanyDB.TabIndex = 59;
            this.txtCompanyDB.TeclasDeshacer = true;
            this.txtCompanyDB.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 140);
            this.label11.Name = "label11";
            this.controlsValidator.SetOrden(this.label11, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label11, false);
            this.controlsValidator.SetRequerido(this.label11, false);
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Base de datos SAP";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(140, 303);
            this.cboLanguage.Name = "cboLanguage";
            this.controlsValidator.SetOrden(this.cboLanguage, 0);
            this.controlsValidator.SetPuedeSerVacio(this.cboLanguage, false);
            this.controlsValidator.SetRequerido(this.cboLanguage, true);
            this.cboLanguage.Size = new System.Drawing.Size(186, 21);
            this.cboLanguage.TabIndex = 66;
            // 
            // cboDbServerType
            // 
            this.cboDbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDbServerType.FormattingEnabled = true;
            this.cboDbServerType.Location = new System.Drawing.Point(140, 113);
            this.cboDbServerType.Name = "cboDbServerType";
            this.controlsValidator.SetOrden(this.cboDbServerType, 3);
            this.controlsValidator.SetPuedeSerVacio(this.cboDbServerType, false);
            this.controlsValidator.SetRequerido(this.cboDbServerType, true);
            this.cboDbServerType.Size = new System.Drawing.Size(186, 21);
            this.cboDbServerType.TabIndex = 58;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 442);
            this.btnCancel.Name = "btnCancel";
            this.controlsValidator.SetOrden(this.btnCancel, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnCancel, false);
            this.controlsValidator.SetRequerido(this.btnCancel, false);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 441);
            this.btnOK.Name = "btnOK";
            this.controlsValidator.SetOrden(this.btnOK, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnOK, false);
            this.controlsValidator.SetRequerido(this.btnOK, false);
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 67;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLicenseServer
            // 
            this.txtLicenseServer.AceptaNegativos = false;
            this.txtLicenseServer.BackColor = System.Drawing.Color.White;
            this.txtLicenseServer.EsMandatorio = true;
            this.txtLicenseServer.EsMultilinea = false;
            this.txtLicenseServer.EstiloSBO = true;
            this.txtLicenseServer.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLicenseServer.Location = new System.Drawing.Point(140, 280);
            this.txtLicenseServer.MaxDecimales = 0;
            this.txtLicenseServer.MaxEnteros = 0;
            this.txtLicenseServer.Millares = false;
            this.txtLicenseServer.Name = "txtLicenseServer";
            this.controlsValidator.SetOrden(this.txtLicenseServer, 9);
            this.controlsValidator.SetPuedeSerVacio(this.txtLicenseServer, false);
            this.controlsValidator.SetRequerido(this.txtLicenseServer, true);
            this.txtLicenseServer.Size = new System.Drawing.Size(186, 21);
            this.txtLicenseServer.Size_AdjustableHeight = 21;
            this.txtLicenseServer.TabIndex = 65;
            this.txtLicenseServer.TeclasDeshacer = true;
            this.txtLicenseServer.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtPassword
            // 
            this.txtPassword.AceptaNegativos = false;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.EsMandatorio = true;
            this.txtPassword.EsMultilinea = false;
            this.txtPassword.EstiloSBO = true;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Location = new System.Drawing.Point(140, 257);
            this.txtPassword.MaxDecimales = 0;
            this.txtPassword.MaxEnteros = 0;
            this.txtPassword.Millares = false;
            this.txtPassword.Name = "txtPassword";
            this.controlsValidator.SetOrden(this.txtPassword, 8);
            this.txtPassword.PasswordChar = '*';
            this.controlsValidator.SetPuedeSerVacio(this.txtPassword, false);
            this.controlsValidator.SetRequerido(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(186, 21);
            this.txtPassword.Size_AdjustableHeight = 21;
            this.txtPassword.TabIndex = 64;
            this.txtPassword.TeclasDeshacer = true;
            this.txtPassword.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtUserName
            // 
            this.txtUserName.AceptaNegativos = false;
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.EsMandatorio = true;
            this.txtUserName.EsMultilinea = false;
            this.txtUserName.EstiloSBO = true;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.Location = new System.Drawing.Point(140, 234);
            this.txtUserName.MaxDecimales = 0;
            this.txtUserName.MaxEnteros = 0;
            this.txtUserName.Millares = false;
            this.txtUserName.Name = "txtUserName";
            this.controlsValidator.SetOrden(this.txtUserName, 7);
            this.controlsValidator.SetPuedeSerVacio(this.txtUserName, false);
            this.controlsValidator.SetRequerido(this.txtUserName, true);
            this.txtUserName.Size = new System.Drawing.Size(186, 21);
            this.txtUserName.Size_AdjustableHeight = 21;
            this.txtUserName.TabIndex = 63;
            this.txtUserName.TeclasDeshacer = true;
            this.txtUserName.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.AceptaNegativos = false;
            this.txtDbPassword.BackColor = System.Drawing.Color.White;
            this.txtDbPassword.EsMandatorio = true;
            this.txtDbPassword.EsMultilinea = false;
            this.txtDbPassword.EstiloSBO = true;
            this.txtDbPassword.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDbPassword.Location = new System.Drawing.Point(140, 211);
            this.txtDbPassword.MaxDecimales = 0;
            this.txtDbPassword.MaxEnteros = 0;
            this.txtDbPassword.Millares = false;
            this.txtDbPassword.Name = "txtDbPassword";
            this.controlsValidator.SetOrden(this.txtDbPassword, 6);
            this.txtDbPassword.PasswordChar = '*';
            this.controlsValidator.SetPuedeSerVacio(this.txtDbPassword, false);
            this.controlsValidator.SetRequerido(this.txtDbPassword, true);
            this.txtDbPassword.Size = new System.Drawing.Size(186, 21);
            this.txtDbPassword.Size_AdjustableHeight = 21;
            this.txtDbPassword.TabIndex = 62;
            this.txtDbPassword.TeclasDeshacer = true;
            this.txtDbPassword.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtDbUserName
            // 
            this.txtDbUserName.AceptaNegativos = false;
            this.txtDbUserName.BackColor = System.Drawing.Color.White;
            this.txtDbUserName.EsMandatorio = true;
            this.txtDbUserName.EsMultilinea = false;
            this.txtDbUserName.EstiloSBO = true;
            this.txtDbUserName.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDbUserName.Location = new System.Drawing.Point(140, 188);
            this.txtDbUserName.MaxDecimales = 0;
            this.txtDbUserName.MaxEnteros = 0;
            this.txtDbUserName.Millares = false;
            this.txtDbUserName.Name = "txtDbUserName";
            this.controlsValidator.SetOrden(this.txtDbUserName, 5);
            this.controlsValidator.SetPuedeSerVacio(this.txtDbUserName, false);
            this.controlsValidator.SetRequerido(this.txtDbUserName, true);
            this.txtDbUserName.Size = new System.Drawing.Size(186, 21);
            this.txtDbUserName.Size_AdjustableHeight = 21;
            this.txtDbUserName.TabIndex = 61;
            this.txtDbUserName.TeclasDeshacer = true;
            this.txtDbUserName.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtServer
            // 
            this.txtServer.AceptaNegativos = false;
            this.txtServer.BackColor = System.Drawing.Color.White;
            this.txtServer.EsMandatorio = true;
            this.txtServer.EsMultilinea = false;
            this.txtServer.EstiloSBO = true;
            this.txtServer.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServer.Location = new System.Drawing.Point(140, 90);
            this.txtServer.MaxDecimales = 0;
            this.txtServer.MaxEnteros = 0;
            this.txtServer.Millares = false;
            this.txtServer.Name = "txtServer";
            this.controlsValidator.SetOrden(this.txtServer, 2);
            this.controlsValidator.SetPuedeSerVacio(this.txtServer, false);
            this.controlsValidator.SetRequerido(this.txtServer, false);
            this.txtServer.Size = new System.Drawing.Size(186, 21);
            this.txtServer.Size_AdjustableHeight = 21;
            this.txtServer.TabIndex = 57;
            this.txtServer.TeclasDeshacer = true;
            this.txtServer.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtCode
            // 
            this.txtCode.AceptaNegativos = false;
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Enabled = false;
            this.txtCode.EsMandatorio = true;
            this.txtCode.EsMultilinea = false;
            this.txtCode.EstiloSBO = true;
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCode.Location = new System.Drawing.Point(140, 67);
            this.txtCode.MaxDecimales = 0;
            this.txtCode.MaxEnteros = 0;
            this.txtCode.Millares = false;
            this.txtCode.Name = "txtCode";
            this.controlsValidator.SetOrden(this.txtCode, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtCode, false);
            this.controlsValidator.SetRequerido(this.txtCode, false);
            this.txtCode.Size = new System.Drawing.Size(186, 21);
            this.txtCode.Size_AdjustableHeight = 21;
            this.txtCode.TabIndex = 56;
            this.txtCode.TeclasDeshacer = true;
            this.txtCode.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // chkUseTrusted
            // 
            this.chkUseTrusted.AutoSize = true;
            this.chkUseTrusted.Location = new System.Drawing.Point(34, 166);
            this.chkUseTrusted.Name = "chkUseTrusted";
            this.controlsValidator.SetOrden(this.chkUseTrusted, 0);
            this.controlsValidator.SetPuedeSerVacio(this.chkUseTrusted, false);
            this.controlsValidator.SetRequerido(this.chkUseTrusted, false);
            this.chkUseTrusted.Size = new System.Drawing.Size(171, 17);
            this.chkUseTrusted.TabIndex = 60;
            this.chkUseTrusted.Text = "Usa autenticación de windows";
            this.chkUseTrusted.UseVisualStyleBackColor = true;
            this.chkUseTrusted.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 308);
            this.label9.Name = "label9";
            this.controlsValidator.SetOrden(this.label9, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label9, false);
            this.controlsValidator.SetRequerido(this.label9, false);
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Idioma";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 283);
            this.label10.Name = "label10";
            this.controlsValidator.SetOrden(this.label10, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label10, false);
            this.controlsValidator.SetRequerido(this.label10, false);
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Servidor de licencias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 260);
            this.label7.Name = "label7";
            this.controlsValidator.SetOrden(this.label7, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label7, false);
            this.controlsValidator.SetRequerido(this.label7, false);
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Contraseña SAP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 237);
            this.label8.Name = "label8";
            this.controlsValidator.SetOrden(this.label8, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label8, false);
            this.controlsValidator.SetRequerido(this.label8, false);
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Usuario SAP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 214);
            this.label6.Name = "label6";
            this.controlsValidator.SetOrden(this.label6, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label6, false);
            this.controlsValidator.SetRequerido(this.label6, false);
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Contraseña BD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 191);
            this.label5.Name = "label5";
            this.controlsValidator.SetOrden(this.label5, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label5, false);
            this.controlsValidator.SetRequerido(this.label5, false);
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Usuario BD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.controlsValidator.SetOrden(this.label3, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label3, false);
            this.controlsValidator.SetRequerido(this.label3, false);
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tipo Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.controlsValidator.SetOrden(this.label2, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label2, false);
            this.controlsValidator.SetRequerido(this.label2, false);
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.controlsValidator.SetOrden(this.label1, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label1, false);
            this.controlsValidator.SetRequerido(this.label1, false);
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Código";
            // 
            // controlsValidator
            // 
            this.controlsValidator.ColorError = System.Drawing.Color.Beige;
            this.controlsValidator.Duracion = 5000;
            this.controlsValidator.ErrorSub = null;
            this.controlsValidator.FormularioPadre = null;
            // 
            // cboLocalizacion
            // 
            this.cboLocalizacion.FormattingEnabled = true;
            this.cboLocalizacion.Location = new System.Drawing.Point(140, 328);
            this.cboLocalizacion.Name = "cboLocalizacion";
            this.controlsValidator.SetOrden(this.cboLocalizacion, 0);
            this.controlsValidator.SetPuedeSerVacio(this.cboLocalizacion, false);
            this.controlsValidator.SetRequerido(this.cboLocalizacion, false);
            this.cboLocalizacion.Size = new System.Drawing.Size(186, 21);
            this.cboLocalizacion.TabIndex = 80;
            this.cboLocalizacion.SelectedIndexChanged += new System.EventHandler(this.cboLocalizacion_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 332);
            this.label12.Name = "label12";
            this.controlsValidator.SetOrden(this.label12, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label12, false);
            this.controlsValidator.SetRequerido(this.label12, false);
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Localización";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 358);
            this.label13.Name = "label13";
            this.controlsValidator.SetOrden(this.label13, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label13, false);
            this.controlsValidator.SetRequerido(this.label13, false);
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Usuario WS";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtWSUser
            // 
            this.txtWSUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtWSUser.Location = new System.Drawing.Point(140, 354);
            this.txtWSUser.Name = "txtWSUser";
            this.controlsValidator.SetOrden(this.txtWSUser, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtWSUser, false);
            this.txtWSUser.ReadOnly = true;
            this.controlsValidator.SetRequerido(this.txtWSUser, false);
            this.txtWSUser.Size = new System.Drawing.Size(186, 20);
            this.txtWSUser.TabIndex = 83;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 382);
            this.label14.Name = "label14";
            this.controlsValidator.SetOrden(this.label14, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label14, false);
            this.controlsValidator.SetRequerido(this.label14, false);
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Contraseña WS";
            // 
            // txtWSPass
            // 
            this.txtWSPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtWSPass.Location = new System.Drawing.Point(140, 379);
            this.txtWSPass.Name = "txtWSPass";
            this.controlsValidator.SetOrden(this.txtWSPass, 0);
            this.txtWSPass.PasswordChar = '*';
            this.controlsValidator.SetPuedeSerVacio(this.txtWSPass, false);
            this.txtWSPass.ReadOnly = true;
            this.controlsValidator.SetRequerido(this.txtWSPass, false);
            this.txtWSPass.Size = new System.Drawing.Size(186, 20);
            this.txtWSPass.TabIndex = 85;
            // 
            // lblhm
            // 
            this.lblhm.AutoSize = true;
            this.lblhm.Location = new System.Drawing.Point(35, 407);
            this.lblhm.Name = "lblhm";
            this.controlsValidator.SetOrden(this.lblhm, 0);
            this.controlsValidator.SetPuedeSerVacio(this.lblhm, false);
            this.controlsValidator.SetRequerido(this.lblhm, false);
            this.lblhm.Size = new System.Drawing.Size(71, 13);
            this.lblhm.TabIndex = 86;
            this.lblhm.Text = "Hora máxima ";
            this.lblhm.Visible = false;
            // 
            // txtmaxtime
            // 
            this.txtmaxtime.CustomFormat = "HH:mm";
            this.txtmaxtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtmaxtime.Location = new System.Drawing.Point(140, 406);
            this.txtmaxtime.Name = "txtmaxtime";
            this.controlsValidator.SetOrden(this.txtmaxtime, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtmaxtime, false);
            this.controlsValidator.SetRequerido(this.txtmaxtime, false);
            this.txtmaxtime.ShowUpDown = true;
            this.txtmaxtime.Size = new System.Drawing.Size(186, 20);
            this.txtmaxtime.TabIndex = 88;
            this.txtmaxtime.Visible = false;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 480);
            this.Controls.Add(this.txtmaxtime);
            this.Controls.Add(this.lblhm);
            this.Controls.Add(this.txtWSPass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtWSUser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboLocalizacion);
            this.Controls.Add(this.lblSuccessfulConnectio);
            this.Controls.Add(this.txtCompanyDB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.cboDbServerType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLicenseServer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtDbPassword);
            this.Controls.Add(this.txtDbUserName);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.chkUseTrusted);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompany";
            this.controlsValidator.SetOrden(this, 0);
            this.controlsValidator.SetPuedeSerVacio(this, false);
            this.controlsValidator.SetRequerido(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCG -  Mantenimiento Compañías";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSuccessfulConnectio;
        private UX.Windows.SCGTextBox txtCompanyDB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboDbServerType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private UX.Windows.SCGTextBox txtLicenseServer;
        private UX.Windows.SCGTextBox txtPassword;
        private UX.Windows.SCGTextBox txtUserName;
        private UX.Windows.SCGTextBox txtDbPassword;
        private UX.Windows.SCGTextBox txtDbUserName;
        private UX.Windows.SCGTextBox txtServer;
        private UX.Windows.SCGTextBox txtCode;
        private System.Windows.Forms.CheckBox chkUseTrusted;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UX.Windows.ControlsValidator controlsValidator;
        private System.Windows.Forms.ComboBox cboLocalizacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWSUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWSPass;
        private System.Windows.Forms.Label lblhm;
        private System.Windows.Forms.DateTimePicker txtmaxtime;
    }
}