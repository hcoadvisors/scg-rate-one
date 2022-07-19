namespace SCG.SyncBCCR.ConfigurationHost.Forms
{
    partial class frmExchangeRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchangeRate));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBCCRCode = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtCurrCode = new SCG.UX.Windows.SCGTextBox(this.components);
            this.txtCompany = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtID = new SCG.UX.Windows.SCGTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.controlsValidator = new SCG.UX.Windows.ControlsValidator();
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
            this.pictureBox3.Size = new System.Drawing.Size(332, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SCG.SyncBCCR.ConfigurationHost.Properties.Resources.LogoSCGMiniDegradado;
            this.pictureBox2.Location = new System.Drawing.Point(222, 0);
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
            this.pictureBox1.Size = new System.Drawing.Size(332, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.controlsValidator.SetOrden(this.label4, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label4, false);
            this.controlsValidator.SetRequerido(this.label4, false);
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Configuración - Tipo de Cambio";
            // 
            // txtBCCRCode
            // 
            this.txtBCCRCode.AceptaNegativos = false;
            this.txtBCCRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.controlsValidator.SetDescripcion(this.txtBCCRCode, "Código BCCR");
            this.txtBCCRCode.EsMandatorio = true;
            this.txtBCCRCode.EsMultilinea = false;
            this.txtBCCRCode.EstiloSBO = true;
            this.txtBCCRCode.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBCCRCode.Location = new System.Drawing.Point(131, 136);
            this.txtBCCRCode.MaxDecimales = 0;
            this.txtBCCRCode.MaxEnteros = 0;
            this.txtBCCRCode.Millares = false;
            this.txtBCCRCode.Name = "txtBCCRCode";
            this.controlsValidator.SetOrden(this.txtBCCRCode, 2);
            this.controlsValidator.SetPuedeSerVacio(this.txtBCCRCode, false);
            this.controlsValidator.SetRequerido(this.txtBCCRCode, true);
            this.txtBCCRCode.Size = new System.Drawing.Size(186, 21);
            this.txtBCCRCode.Size_AdjustableHeight = 21;
            this.txtBCCRCode.TabIndex = 4;
            this.txtBCCRCode.TeclasDeshacer = true;
            this.txtBCCRCode.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 163);
            this.label11.Name = "label11";
            this.controlsValidator.SetOrden(this.label11, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label11, false);
            this.controlsValidator.SetRequerido(this.label11, false);
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Tipo";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 199);
            this.btnCancel.Name = "btnCancel";
            this.controlsValidator.SetOrden(this.btnCancel, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnCancel, false);
            this.controlsValidator.SetRequerido(this.btnCancel, false);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(23, 199);
            this.btnOK.Name = "btnOK";
            this.controlsValidator.SetOrden(this.btnOK, 0);
            this.controlsValidator.SetPuedeSerVacio(this.btnOK, false);
            this.controlsValidator.SetRequerido(this.btnOK, false);
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Agregar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCurrCode
            // 
            this.txtCurrCode.AceptaNegativos = false;
            this.txtCurrCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.controlsValidator.SetDescripcion(this.txtCurrCode, "Código moneda SAP");
            this.txtCurrCode.EsMandatorio = true;
            this.txtCurrCode.EsMultilinea = false;
            this.txtCurrCode.EstiloSBO = true;
            this.txtCurrCode.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurrCode.Location = new System.Drawing.Point(131, 113);
            this.txtCurrCode.MaxDecimales = 0;
            this.txtCurrCode.MaxEnteros = 0;
            this.txtCurrCode.Millares = false;
            this.txtCurrCode.Name = "txtCurrCode";
            this.controlsValidator.SetOrden(this.txtCurrCode, 1);
            this.controlsValidator.SetPuedeSerVacio(this.txtCurrCode, false);
            this.controlsValidator.SetRequerido(this.txtCurrCode, true);
            this.txtCurrCode.Size = new System.Drawing.Size(186, 21);
            this.txtCurrCode.Size_AdjustableHeight = 21;
            this.txtCurrCode.TabIndex = 3;
            this.txtCurrCode.TeclasDeshacer = true;
            this.txtCurrCode.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // txtCompany
            // 
            this.txtCompany.AceptaNegativos = false;
            this.txtCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.txtCompany.Enabled = false;
            this.txtCompany.EsMandatorio = true;
            this.txtCompany.EsMultilinea = false;
            this.txtCompany.EstiloSBO = true;
            this.txtCompany.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompany.Location = new System.Drawing.Point(131, 90);
            this.txtCompany.MaxDecimales = 0;
            this.txtCompany.MaxEnteros = 0;
            this.txtCompany.Millares = false;
            this.txtCompany.Name = "txtCompany";
            this.controlsValidator.SetOrden(this.txtCompany, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtCompany, false);
            this.controlsValidator.SetRequerido(this.txtCompany, false);
            this.txtCompany.Size = new System.Drawing.Size(186, 21);
            this.txtCompany.Size_AdjustableHeight = 21;
            this.txtCompany.TabIndex = 2;
            this.txtCompany.TeclasDeshacer = true;
            this.txtCompany.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.controlsValidator.SetOrden(this.label3, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label3, false);
            this.controlsValidator.SetRequerido(this.label3, false);
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Código Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.controlsValidator.SetOrden(this.label2, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label2, false);
            this.controlsValidator.SetRequerido(this.label2, false);
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Código moneda SAP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.controlsValidator.SetOrden(this.label1, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label1, false);
            this.controlsValidator.SetRequerido(this.label1, false);
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Compañia";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Enabled = false;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(131, 160);
            this.cboType.Name = "cboType";
            this.controlsValidator.SetOrden(this.cboType, 0);
            this.controlsValidator.SetPuedeSerVacio(this.cboType, false);
            this.controlsValidator.SetRequerido(this.cboType, false);
            this.cboType.Size = new System.Drawing.Size(186, 21);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.AceptaNegativos = false;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(243)))));
            this.txtID.Enabled = false;
            this.txtID.EsMandatorio = true;
            this.txtID.EsMultilinea = false;
            this.txtID.EstiloSBO = true;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 10.77023F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Location = new System.Drawing.Point(131, 66);
            this.txtID.MaxDecimales = 0;
            this.txtID.MaxEnteros = 0;
            this.txtID.Millares = false;
            this.txtID.Name = "txtID";
            this.controlsValidator.SetOrden(this.txtID, 0);
            this.controlsValidator.SetPuedeSerVacio(this.txtID, false);
            this.controlsValidator.SetRequerido(this.txtID, false);
            this.txtID.Size = new System.Drawing.Size(186, 21);
            this.txtID.Size_AdjustableHeight = 21;
            this.txtID.TabIndex = 1;
            this.txtID.TeclasDeshacer = true;
            this.txtID.Tipo_TextBox = SCG.UX.Windows.SCGTextBox.Tipo_Text.AllSimbols;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 69);
            this.label5.Name = "label5";
            this.controlsValidator.SetOrden(this.label5, 0);
            this.controlsValidator.SetPuedeSerVacio(this.label5, false);
            this.controlsValidator.SetRequerido(this.label5, false);
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "ID";
            // 
            // controlsValidator
            // 
            this.controlsValidator.ColorError = System.Drawing.Color.Beige;
            this.controlsValidator.Duracion = 5000;
            this.controlsValidator.ErrorSub = null;
            this.controlsValidator.FormularioPadre = null;
            // 
            // frmExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 236);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBCCRCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCurrCode);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExchangeRate";
            this.controlsValidator.SetOrden(this, 0);
            this.controlsValidator.SetPuedeSerVacio(this, false);
            this.controlsValidator.SetRequerido(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCG - Tipo de Cambio";
            this.Load += new System.EventHandler(this.frmExchangeRate_Load);
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
        private UX.Windows.SCGTextBox txtBCCRCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private UX.Windows.SCGTextBox txtCurrCode;
        private UX.Windows.SCGTextBox txtCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
        private UX.Windows.SCGTextBox txtID;
        private System.Windows.Forms.Label label5;
        private UX.Windows.ControlsValidator controlsValidator;
    }
}