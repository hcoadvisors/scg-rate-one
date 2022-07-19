namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    partial class frmConfigurationExchangeRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurationExchangeRate));
            this.Settings = new SCG.SyncBCCR.Config.Settings();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCompanyDB = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cboDbServerType = new System.Windows.Forms.ComboBox();
            this.txtServer = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtCode = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExchangeRates = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settings1 = new SCG.SyncBCCR.Config.Settings();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.controlsValidator = new SCG.UX.Windows.ControlsValidator();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCCRCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings1)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.DataSetName = "Settings";
            this.Settings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.controlsValidator.SetOrden(this.label4, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label4, false);
            this.controlsValidator.SetRequerido(this.label4, false);
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Configuración - Tipos de Cambio\r\n";
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
            this.pictureBox3.Size = new System.Drawing.Size(498, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.LogoSCGMiniDegradado;
            this.pictureBox2.Location = new System.Drawing.Point(376, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.controlsValidator.SetOrden(this.pictureBox2, 0);
            this.controlsValidator.SetPuedeSerVacio(this.pictureBox2, false);
            this.controlsValidator.SetRequerido(this.pictureBox2, false);
            this.pictureBox2.Size = new System.Drawing.Size(110, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 57;
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
            this.pictureBox1.Size = new System.Drawing.Size(498, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // txtCompanyDB
            // 
            this.txtCompanyDB.AceptaNegativos = false;
            this.txtCompanyDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.txtCompanyDB.Enabled = false;
            this.txtCompanyDB.EsMandatorio = true;
            this.txtCompanyDB.EsMultilinea = false;
            this.txtCompanyDB.EstiloSBO = true;
            this.txtCompanyDB.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyDB.Location = new System.Drawing.Point(139, 137);
            this.txtCompanyDB.MaxDecimales = 0;
            this.txtCompanyDB.MaxEnteros = 0;
            this.txtCompanyDB.Millares = false;
            this.txtCompanyDB.Name = "txtCompanyDB";
            this.controlsValidator.SetOrden(this.txtCompanyDB, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtCompanyDB, false);
            this.controlsValidator.SetRequerido(this.txtCompanyDB, false);
            this.txtCompanyDB.Size = new System.Drawing.Size(186, 21);
            this.txtCompanyDB.Size_AdjustableHeight = 21;
            this.txtCompanyDB.TabIndex = 76;
            this.txtCompanyDB.TeclasDeshacer = true;
            this.txtCompanyDB.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 140);
            this.label11.Name = "label11";
            this.controlsValidator.SetOrden(this.label11, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label11, false);
            this.controlsValidator.SetRequerido(this.label11, false);
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Base de datos SAP";
            // 
            // cboDbServerType
            // 
            this.cboDbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDbServerType.Enabled = false;
            this.cboDbServerType.FormattingEnabled = true;
            this.cboDbServerType.Location = new System.Drawing.Point(139, 113);
            this.cboDbServerType.Name = "cboDbServerType";
            this.controlsValidator.SetOrden(this.cboDbServerType, 0);
            this.controlsValidator.SetPuedeSerVacio(this.cboDbServerType, false);
            this.controlsValidator.SetRequerido(this.cboDbServerType, false);
            this.cboDbServerType.Size = new System.Drawing.Size(186, 21);
            this.cboDbServerType.TabIndex = 75;
            // 
            // txtServer
            // 
            this.txtServer.AceptaNegativos = false;
            this.txtServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.txtServer.Enabled = false;
            this.txtServer.EsMandatorio = true;
            this.txtServer.EsMultilinea = false;
            this.txtServer.EstiloSBO = true;
            this.txtServer.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServer.Location = new System.Drawing.Point(139, 90);
            this.txtServer.MaxDecimales = 0;
            this.txtServer.MaxEnteros = 0;
            this.txtServer.Millares = false;
            this.txtServer.Name = "txtServer";
            this.controlsValidator.SetOrden(this.txtServer, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtServer, false);
            this.controlsValidator.SetRequerido(this.txtServer, false);
            this.txtServer.Size = new System.Drawing.Size(186, 21);
            this.txtServer.Size_AdjustableHeight = 21;
            this.txtServer.TabIndex = 74;
            this.txtServer.TeclasDeshacer = true;
            this.txtServer.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtCode
            // 
            this.txtCode.AceptaNegativos = false;
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.txtCode.Enabled = false;
            this.txtCode.EsMandatorio = true;
            this.txtCode.EsMultilinea = false;
            this.txtCode.EstiloSBO = true;
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCode.Location = new System.Drawing.Point(139, 67);
            this.txtCode.MaxDecimales = 0;
            this.txtCode.MaxEnteros = 0;
            this.txtCode.Millares = false;
            this.txtCode.Name = "txtCode";
            this.controlsValidator.SetOrden(this.txtCode, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtCode, false);
            this.controlsValidator.SetRequerido(this.txtCode, false);
            this.txtCode.Size = new System.Drawing.Size(186, 21);
            this.txtCode.Size_AdjustableHeight = 21;
            this.txtCode.TabIndex = 73;
            this.txtCode.TeclasDeshacer = true;
            this.txtCode.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.controlsValidator.SetOrden(this.label3, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label3, false);
            this.controlsValidator.SetRequerido(this.label3, false);
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tipo Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.controlsValidator.SetOrden(this.label2, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label2, false);
            this.controlsValidator.SetRequerido(this.label2, false);
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.controlsValidator.SetOrden(this.label1, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label1, false);
            this.controlsValidator.SetRequerido(this.label1, false);
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Código";
            // 
            // dgvExchangeRates
            // 
            this.dgvExchangeRates.AllowUserToAddRows = false;
            this.dgvExchangeRates.AllowUserToDeleteRows = false;
            this.dgvExchangeRates.AutoGenerateColumns = false;
            this.dgvExchangeRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExchangeRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.bCCRCodeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dgvExchangeRates.DataSource = this.bindingSource;
            this.dgvExchangeRates.Location = new System.Drawing.Point(27, 177);
            this.dgvExchangeRates.Name = "dgvExchangeRates";
            this.controlsValidator.SetOrden(this.dgvExchangeRates, 0);
            this.controlsValidator.SetPuedeSerVacio(this.dgvExchangeRates, false);
            this.dgvExchangeRates.ReadOnly = true;
            this.controlsValidator.SetRequerido(this.dgvExchangeRates, false);
            this.dgvExchangeRates.Size = new System.Drawing.Size(362, 150);
            this.dgvExchangeRates.TabIndex = 81;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "ExchangeRateTypes";
            this.bindingSource.DataSource = this.settings1;
            // 
            // settings1
            // 
            this.settings1.DataSetName = "Settings";
            this.settings1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(406, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.controlsValidator.SetOrden(this.btnAgregar, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnAgregar, false);
            this.controlsValidator.SetRequerido(this.btnAgregar, false);
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 83;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(406, 262);
            this.btnRemove.Name = "btnRemove";
            this.controlsValidator.SetOrden(this.btnRemove, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnRemove, false);
            this.controlsValidator.SetRequerido(this.btnRemove, false);
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 82;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(406, 233);
            this.btnEdit.Name = "btnEdit";
            this.controlsValidator.SetOrden(this.btnEdit, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnEdit, false);
            this.controlsValidator.SetRequerido(this.btnEdit, false);
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 84;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // controlsValidator
            // 
            this.controlsValidator.ColorError = System.Drawing.Color.Beige;
            this.controlsValidator.Duracion = 5000;
            this.controlsValidator.ErrorSub = null;
            this.controlsValidator.FormularioPadre = null;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Compañía";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Visible = false;
            // 
            // bCCRCodeDataGridViewTextBoxColumn
            // 
            this.bCCRCodeDataGridViewTextBoxColumn.DataPropertyName = "BCCRCode";
            this.bCCRCodeDataGridViewTextBoxColumn.HeaderText = "Código Banco";
            this.bCCRCodeDataGridViewTextBoxColumn.Name = "bCCRCodeDataGridViewTextBoxColumn";
            this.bCCRCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Código SAP";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmConfigurationExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 346);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvExchangeRates);
            this.Controls.Add(this.txtCompanyDB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboDbServerType);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfigurationExchangeRate";
            this.controlsValidator.SetOrden(this, 0);
            this.controlsValidator.SetPuedeSerVacio(this, false);
            this.controlsValidator.SetRequerido(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCG - Mantenimiento Tipos de Cambio";
            this.Load += new System.EventHandler(this.frmExchangeRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SCG.SyncBCCR.Config.Settings Settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UX.Windows.SCGTextBox txtCompanyDB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDbServerType;
        private UX.Windows.SCGTextBox txtServer;
        private UX.Windows.SCGTextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExchangeRates;
        private Config.Settings settings1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private UX.Windows.ControlsValidator controlsValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCCRCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
    }
}