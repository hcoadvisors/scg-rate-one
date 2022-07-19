namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    partial class frmConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguration));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTimeWait = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCompañias = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColServerType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.useTrustedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dbUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCompanys = new System.Windows.Forms.BindingSource(this.components);
            this._settings = new SCG.SyncBCCR.Config.Settings();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Settings = new SCG.SyncBCCR.Config.Settings();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddExchangeRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompañias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompanys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.Barra;
            this.pictureBox3.Location = new System.Drawing.Point(0, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(647, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.LogoSCGMiniDegradado;
            this.pictureBox2.Location = new System.Drawing.Point(525, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Configuración - Servicio de sincronización";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.Encabezado2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Configuración de la sincronización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Intervalo de sincronización (minutos):";
            // 
            // nudTimeWait
            // 
            this.nudTimeWait.Location = new System.Drawing.Point(222, 99);
            this.nudTimeWait.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudTimeWait.Name = "nudTimeWait";
            this.nudTimeWait.Size = new System.Drawing.Size(80, 20);
            this.nudTimeWait.TabIndex = 56;
            this.nudTimeWait.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCompañias
            // 
            this.dgvCompañias.AllowUserToAddRows = false;
            this.dgvCompañias.AllowUserToDeleteRows = false;
            this.dgvCompañias.AutoGenerateColumns = false;
            this.dgvCompañias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompañias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.serverDataGridViewTextBoxColumn,
            this.ColServerType,
            this.useTrustedDataGridViewCheckBoxColumn,
            this.dbUserNameDataGridViewTextBoxColumn,
            this.dbPasswordDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.licenseServerDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.companyDBDataGridViewTextBoxColumn});
            this.dgvCompañias.DataSource = this.bsCompanys;
            this.dgvCompañias.Location = new System.Drawing.Point(18, 161);
            this.dgvCompañias.MultiSelect = false;
            this.dgvCompañias.Name = "dgvCompañias";
            this.dgvCompañias.ReadOnly = true;
            this.dgvCompañias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCompañias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompañias.Size = new System.Drawing.Size(517, 134);
            this.dgvCompañias.TabIndex = 58;
            this.dgvCompañias.DoubleClick += new System.EventHandler(this.dgvCompañias_DoubleClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 50;
            // 
            // serverDataGridViewTextBoxColumn
            // 
            this.serverDataGridViewTextBoxColumn.DataPropertyName = "Server";
            this.serverDataGridViewTextBoxColumn.FillWeight = 150F;
            this.serverDataGridViewTextBoxColumn.HeaderText = "Servidor";
            this.serverDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.serverDataGridViewTextBoxColumn.Name = "serverDataGridViewTextBoxColumn";
            this.serverDataGridViewTextBoxColumn.ReadOnly = true;
            this.serverDataGridViewTextBoxColumn.Width = 150;
            // 
            // ColServerType
            // 
            this.ColServerType.DataPropertyName = "DbServerType";
            this.ColServerType.HeaderText = "Tipo";
            this.ColServerType.MinimumWidth = 100;
            this.ColServerType.Name = "ColServerType";
            this.ColServerType.ReadOnly = true;
            this.ColServerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColServerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // useTrustedDataGridViewCheckBoxColumn
            // 
            this.useTrustedDataGridViewCheckBoxColumn.DataPropertyName = "UseTrusted";
            this.useTrustedDataGridViewCheckBoxColumn.HeaderText = "UseTrusted";
            this.useTrustedDataGridViewCheckBoxColumn.Name = "useTrustedDataGridViewCheckBoxColumn";
            this.useTrustedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.useTrustedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dbUserNameDataGridViewTextBoxColumn
            // 
            this.dbUserNameDataGridViewTextBoxColumn.DataPropertyName = "DbUserName";
            this.dbUserNameDataGridViewTextBoxColumn.HeaderText = "DbUserName";
            this.dbUserNameDataGridViewTextBoxColumn.Name = "dbUserNameDataGridViewTextBoxColumn";
            this.dbUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dbUserNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dbPasswordDataGridViewTextBoxColumn
            // 
            this.dbPasswordDataGridViewTextBoxColumn.DataPropertyName = "DbPassword";
            this.dbPasswordDataGridViewTextBoxColumn.HeaderText = "DbPassword";
            this.dbPasswordDataGridViewTextBoxColumn.Name = "dbPasswordDataGridViewTextBoxColumn";
            this.dbPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.dbPasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // licenseServerDataGridViewTextBoxColumn
            // 
            this.licenseServerDataGridViewTextBoxColumn.DataPropertyName = "LicenseServer";
            this.licenseServerDataGridViewTextBoxColumn.HeaderText = "LicenseServer";
            this.licenseServerDataGridViewTextBoxColumn.Name = "licenseServerDataGridViewTextBoxColumn";
            this.licenseServerDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseServerDataGridViewTextBoxColumn.Visible = false;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            this.languageDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyDBDataGridViewTextBoxColumn
            // 
            this.companyDBDataGridViewTextBoxColumn.DataPropertyName = "CompanyDB";
            this.companyDBDataGridViewTextBoxColumn.FillWeight = 250F;
            this.companyDBDataGridViewTextBoxColumn.HeaderText = "Nombre de la Base de datos";
            this.companyDBDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.companyDBDataGridViewTextBoxColumn.Name = "companyDBDataGridViewTextBoxColumn";
            this.companyDBDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDBDataGridViewTextBoxColumn.Width = 250;
            // 
            // bsCompanys
            // 
            this.bsCompanys.DataMember = "ConnectionCompany";
            this.bsCompanys.DataSource = this._settings;
            // 
            // _settings
            // 
            this._settings.DataSetName = "Settings";
            this._settings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Configuración de las compañias:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(541, 242);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 23);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(542, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 23);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Settings
            // 
            this.Settings.DataSetName = "Settings";
            this.Settings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(541, 215);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 23);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddExchangeRate
            // 
            this.btnAddExchangeRate.Location = new System.Drawing.Point(541, 271);
            this.btnAddExchangeRate.Name = "btnAddExchangeRate";
            this.btnAddExchangeRate.Size = new System.Drawing.Size(96, 23);
            this.btnAddExchangeRate.TabIndex = 63;
            this.btnAddExchangeRate.Text = "Tipos de Cambio";
            this.btnAddExchangeRate.UseVisualStyleBackColor = true;
            this.btnAddExchangeRate.Click += new System.EventHandler(this.btnAddExchangeRate_Click);
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 334);
            this.Controls.Add(this.btnAddExchangeRate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCompañias);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudTimeWait);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCG - Rate One - Configuración";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompañias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompanys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SCG.SyncBCCR.Config.Settings Settings;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTimeWait;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCompañias;
        private System.Windows.Forms.BindingSource bsCompanys;
        private Config.Settings _settings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColServerType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useTrustedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseServerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddExchangeRate;
    }
}