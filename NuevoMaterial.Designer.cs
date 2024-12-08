namespace CP_Control
{
    partial class NuevoMaterial
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
            this.L_DescripcionM = new System.Windows.Forms.Label();
            this.Txt_DescripcionM = new System.Windows.Forms.TextBox();
            this.L_EspesorM = new System.Windows.Forms.Label();
            this.Txt_EspesorM = new System.Windows.Forms.TextBox();
            this.L_ColorM = new System.Windows.Forms.Label();
            this.Txt_ColorM = new System.Windows.Forms.TextBox();
            this.L_ClasificaciónM = new System.Windows.Forms.Label();
            this.Txt_CostoM = new System.Windows.Forms.TextBox();
            this.D_ClasificacionM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.D_UM = new System.Windows.Forms.ComboBox();
            this.L_CostoM = new System.Windows.Forms.Label();
            this.L_ProveedorM = new System.Windows.Forms.Label();
            this.Txt_CodigoM = new System.Windows.Forms.TextBox();
            this.D_ProveedorM = new System.Windows.Forms.ComboBox();
            this.L_CodigoM = new System.Windows.Forms.Label();
            this.Btn_GuardarM = new System.Windows.Forms.Button();
            this.L_IdMaterial = new System.Windows.Forms.Label();
            this.Txt_IdMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_DescripcionM
            // 
            this.L_DescripcionM.AutoSize = true;
            this.L_DescripcionM.Location = new System.Drawing.Point(24, 37);
            this.L_DescripcionM.Name = "L_DescripcionM";
            this.L_DescripcionM.Size = new System.Drawing.Size(125, 25);
            this.L_DescripcionM.TabIndex = 0;
            this.L_DescripcionM.Text = "Descripción";
            // 
            // Txt_DescripcionM
            // 
            this.Txt_DescripcionM.Location = new System.Drawing.Point(164, 37);
            this.Txt_DescripcionM.Name = "Txt_DescripcionM";
            this.Txt_DescripcionM.Size = new System.Drawing.Size(681, 31);
            this.Txt_DescripcionM.TabIndex = 1;
            // 
            // L_EspesorM
            // 
            this.L_EspesorM.AutoSize = true;
            this.L_EspesorM.Location = new System.Drawing.Point(406, 83);
            this.L_EspesorM.Name = "L_EspesorM";
            this.L_EspesorM.Size = new System.Drawing.Size(91, 25);
            this.L_EspesorM.TabIndex = 2;
            this.L_EspesorM.Text = "Espesor";
            // 
            // Txt_EspesorM
            // 
            this.Txt_EspesorM.Location = new System.Drawing.Point(503, 84);
            this.Txt_EspesorM.Name = "Txt_EspesorM";
            this.Txt_EspesorM.Size = new System.Drawing.Size(154, 31);
            this.Txt_EspesorM.TabIndex = 3;
            // 
            // L_ColorM
            // 
            this.L_ColorM.AutoSize = true;
            this.L_ColorM.Location = new System.Drawing.Point(671, 80);
            this.L_ColorM.Name = "L_ColorM";
            this.L_ColorM.Size = new System.Drawing.Size(63, 25);
            this.L_ColorM.TabIndex = 4;
            this.L_ColorM.Text = "Color";
            // 
            // Txt_ColorM
            // 
            this.Txt_ColorM.Location = new System.Drawing.Point(740, 82);
            this.Txt_ColorM.Name = "Txt_ColorM";
            this.Txt_ColorM.Size = new System.Drawing.Size(105, 31);
            this.Txt_ColorM.TabIndex = 5;
            // 
            // L_ClasificaciónM
            // 
            this.L_ClasificaciónM.AutoSize = true;
            this.L_ClasificaciónM.Location = new System.Drawing.Point(24, 83);
            this.L_ClasificaciónM.Name = "L_ClasificaciónM";
            this.L_ClasificaciónM.Size = new System.Drawing.Size(134, 25);
            this.L_ClasificaciónM.TabIndex = 6;
            this.L_ClasificaciónM.Text = "Clasificación";
            // 
            // Txt_CostoM
            // 
            this.Txt_CostoM.Location = new System.Drawing.Point(164, 181);
            this.Txt_CostoM.Name = "Txt_CostoM";
            this.Txt_CostoM.Size = new System.Drawing.Size(227, 31);
            this.Txt_CostoM.TabIndex = 7;
            this.Txt_CostoM.TextChanged += new System.EventHandler(this.Txt_CostoM_TextChanged);
            // 
            // D_ClasificacionM
            // 
            this.D_ClasificacionM.FormattingEnabled = true;
            this.D_ClasificacionM.Location = new System.Drawing.Point(164, 82);
            this.D_ClasificacionM.Name = "D_ClasificacionM";
            this.D_ClasificacionM.Size = new System.Drawing.Size(227, 33);
            this.D_ClasificacionM.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "UM";
            // 
            // D_UM
            // 
            this.D_UM.FormattingEnabled = true;
            this.D_UM.Location = new System.Drawing.Point(740, 130);
            this.D_UM.Name = "D_UM";
            this.D_UM.Size = new System.Drawing.Size(105, 33);
            this.D_UM.TabIndex = 10;
            // 
            // L_CostoM
            // 
            this.L_CostoM.AutoSize = true;
            this.L_CostoM.Location = new System.Drawing.Point(24, 181);
            this.L_CostoM.Name = "L_CostoM";
            this.L_CostoM.Size = new System.Drawing.Size(68, 25);
            this.L_CostoM.TabIndex = 11;
            this.L_CostoM.Text = "Costo";
            // 
            // L_ProveedorM
            // 
            this.L_ProveedorM.AutoSize = true;
            this.L_ProveedorM.Location = new System.Drawing.Point(24, 130);
            this.L_ProveedorM.Name = "L_ProveedorM";
            this.L_ProveedorM.Size = new System.Drawing.Size(111, 25);
            this.L_ProveedorM.TabIndex = 12;
            this.L_ProveedorM.Text = "Proveedor";
            // 
            // Txt_CodigoM
            // 
            this.Txt_CodigoM.Location = new System.Drawing.Point(503, 181);
            this.Txt_CodigoM.Name = "Txt_CodigoM";
            this.Txt_CodigoM.Size = new System.Drawing.Size(154, 31);
            this.Txt_CodigoM.TabIndex = 13;
            // 
            // D_ProveedorM
            // 
            this.D_ProveedorM.FormattingEnabled = true;
            this.D_ProveedorM.Location = new System.Drawing.Point(164, 130);
            this.D_ProveedorM.Name = "D_ProveedorM";
            this.D_ProveedorM.Size = new System.Drawing.Size(493, 33);
            this.D_ProveedorM.TabIndex = 14;
            // 
            // L_CodigoM
            // 
            this.L_CodigoM.AutoSize = true;
            this.L_CodigoM.Location = new System.Drawing.Point(406, 181);
            this.L_CodigoM.Name = "L_CodigoM";
            this.L_CodigoM.Size = new System.Drawing.Size(80, 25);
            this.L_CodigoM.TabIndex = 15;
            this.L_CodigoM.Text = "Código";
            // 
            // Btn_GuardarM
            // 
            this.Btn_GuardarM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_GuardarM.Location = new System.Drawing.Point(664, 237);
            this.Btn_GuardarM.Name = "Btn_GuardarM";
            this.Btn_GuardarM.Size = new System.Drawing.Size(181, 46);
            this.Btn_GuardarM.TabIndex = 16;
            this.Btn_GuardarM.Text = "Guardar";
            this.Btn_GuardarM.UseVisualStyleBackColor = true;
            this.Btn_GuardarM.Click += new System.EventHandler(this.Btn_GuardarM_Click);
            // 
            // L_IdMaterial
            // 
            this.L_IdMaterial.AutoSize = true;
            this.L_IdMaterial.Location = new System.Drawing.Point(29, 237);
            this.L_IdMaterial.Name = "L_IdMaterial";
            this.L_IdMaterial.Size = new System.Drawing.Size(29, 25);
            this.L_IdMaterial.TabIndex = 17;
            this.L_IdMaterial.Text = "Id";
            this.L_IdMaterial.Visible = false;
            // 
            // Txt_IdMaterial
            // 
            this.Txt_IdMaterial.Location = new System.Drawing.Point(164, 237);
            this.Txt_IdMaterial.Name = "Txt_IdMaterial";
            this.Txt_IdMaterial.Size = new System.Drawing.Size(100, 31);
            this.Txt_IdMaterial.TabIndex = 18;
            this.Txt_IdMaterial.Visible = false;
            // 
            // NuevoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 300);
            this.Controls.Add(this.Txt_IdMaterial);
            this.Controls.Add(this.L_IdMaterial);
            this.Controls.Add(this.Btn_GuardarM);
            this.Controls.Add(this.L_CodigoM);
            this.Controls.Add(this.D_ProveedorM);
            this.Controls.Add(this.Txt_CodigoM);
            this.Controls.Add(this.L_ProveedorM);
            this.Controls.Add(this.L_CostoM);
            this.Controls.Add(this.D_UM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D_ClasificacionM);
            this.Controls.Add(this.Txt_CostoM);
            this.Controls.Add(this.L_ClasificaciónM);
            this.Controls.Add(this.Txt_ColorM);
            this.Controls.Add(this.L_ColorM);
            this.Controls.Add(this.Txt_EspesorM);
            this.Controls.Add(this.L_EspesorM);
            this.Controls.Add(this.Txt_DescripcionM);
            this.Controls.Add(this.L_DescripcionM);
            this.Name = "NuevoMaterial";
            this.Text = "Nuevo material";
            this.Load += new System.EventHandler(this.NuevoMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_DescripcionM;
        private System.Windows.Forms.TextBox Txt_DescripcionM;
        private System.Windows.Forms.Label L_EspesorM;
        private System.Windows.Forms.TextBox Txt_EspesorM;
        private System.Windows.Forms.Label L_ColorM;
        private System.Windows.Forms.TextBox Txt_ColorM;
        private System.Windows.Forms.Label L_ClasificaciónM;
        private System.Windows.Forms.TextBox Txt_CostoM;
        private System.Windows.Forms.ComboBox D_ClasificacionM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox D_UM;
        private System.Windows.Forms.Label L_CostoM;
        private System.Windows.Forms.Label L_ProveedorM;
        private System.Windows.Forms.TextBox Txt_CodigoM;
        private System.Windows.Forms.ComboBox D_ProveedorM;
        private System.Windows.Forms.Label L_CodigoM;
        private System.Windows.Forms.Button Btn_GuardarM;
        private System.Windows.Forms.Label L_IdMaterial;
        private System.Windows.Forms.TextBox Txt_IdMaterial;
    }
}