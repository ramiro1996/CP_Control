namespace CP_Control
{
    partial class NuevoProveedor
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
            this.L_Proveedor = new System.Windows.Forms.Label();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.L_RFC = new System.Windows.Forms.Label();
            this.Txt_RFCP = new System.Windows.Forms.TextBox();
            this.Btn_GuardarP = new System.Windows.Forms.Button();
            this.L_TelefonoP = new System.Windows.Forms.Label();
            this.Txt_TelProv = new System.Windows.Forms.TextBox();
            this.L_ContactoP = new System.Windows.Forms.Label();
            this.Txt_ContactoP = new System.Windows.Forms.TextBox();
            this.L_CargoContP = new System.Windows.Forms.Label();
            this.Txt_CargoContP = new System.Windows.Forms.TextBox();
            this.L_TelContP = new System.Windows.Forms.Label();
            this.Txt_TelContP = new System.Windows.Forms.TextBox();
            this.L_DirecP = new System.Windows.Forms.Label();
            this.Txt_DireccionP = new System.Windows.Forms.TextBox();
            this.L_CPProv = new System.Windows.Forms.Label();
            this.Txt_CPP = new System.Windows.Forms.TextBox();
            this.L_CiudadP = new System.Windows.Forms.Label();
            this.Txt_CiudadP = new System.Windows.Forms.TextBox();
            this.L_CorreoP = new System.Windows.Forms.Label();
            this.Txt_CorreoP = new System.Windows.Forms.TextBox();
            this.L_TipoProv = new System.Windows.Forms.Label();
            this.D_TipoProv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // L_Proveedor
            // 
            this.L_Proveedor.AutoSize = true;
            this.L_Proveedor.Location = new System.Drawing.Point(12, 32);
            this.L_Proveedor.Name = "L_Proveedor";
            this.L_Proveedor.Size = new System.Drawing.Size(111, 25);
            this.L_Proveedor.TabIndex = 0;
            this.L_Proveedor.Text = "Proveedor";
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Location = new System.Drawing.Point(129, 29);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(500, 31);
            this.Txt_Proveedor.TabIndex = 1;
            // 
            // L_RFC
            // 
            this.L_RFC.AutoSize = true;
            this.L_RFC.Location = new System.Drawing.Point(639, 32);
            this.L_RFC.Name = "L_RFC";
            this.L_RFC.Size = new System.Drawing.Size(55, 25);
            this.L_RFC.TabIndex = 2;
            this.L_RFC.Text = "RFC";
            // 
            // Txt_RFCP
            // 
            this.Txt_RFCP.Location = new System.Drawing.Point(741, 26);
            this.Txt_RFCP.Name = "Txt_RFCP";
            this.Txt_RFCP.Size = new System.Drawing.Size(280, 31);
            this.Txt_RFCP.TabIndex = 3;
            // 
            // Btn_GuardarP
            // 
            this.Btn_GuardarP.Location = new System.Drawing.Point(835, 275);
            this.Btn_GuardarP.Name = "Btn_GuardarP";
            this.Btn_GuardarP.Size = new System.Drawing.Size(186, 44);
            this.Btn_GuardarP.TabIndex = 4;
            this.Btn_GuardarP.Text = "Guardar";
            this.Btn_GuardarP.UseVisualStyleBackColor = true;
            this.Btn_GuardarP.Click += new System.EventHandler(this.Btn_GuardarP_Click);
            // 
            // L_TelefonoP
            // 
            this.L_TelefonoP.AutoSize = true;
            this.L_TelefonoP.Location = new System.Drawing.Point(301, 125);
            this.L_TelefonoP.Name = "L_TelefonoP";
            this.L_TelefonoP.Size = new System.Drawing.Size(96, 25);
            this.L_TelefonoP.TabIndex = 5;
            this.L_TelefonoP.Text = "Teléfono";
            // 
            // Txt_TelProv
            // 
            this.Txt_TelProv.Location = new System.Drawing.Point(403, 125);
            this.Txt_TelProv.Name = "Txt_TelProv";
            this.Txt_TelProv.Size = new System.Drawing.Size(226, 31);
            this.Txt_TelProv.TabIndex = 6;
            this.Txt_TelProv.TextChanged += new System.EventHandler(this.Txt_TelProv_TextChanged);
            // 
            // L_ContactoP
            // 
            this.L_ContactoP.AutoSize = true;
            this.L_ContactoP.Location = new System.Drawing.Point(13, 170);
            this.L_ContactoP.Name = "L_ContactoP";
            this.L_ContactoP.Size = new System.Drawing.Size(98, 25);
            this.L_ContactoP.TabIndex = 7;
            this.L_ContactoP.Text = "Contacto";
            this.L_ContactoP.Click += new System.EventHandler(this.L_ContactoP_Click);
            // 
            // Txt_ContactoP
            // 
            this.Txt_ContactoP.Location = new System.Drawing.Point(129, 170);
            this.Txt_ContactoP.Name = "Txt_ContactoP";
            this.Txt_ContactoP.Size = new System.Drawing.Size(167, 31);
            this.Txt_ContactoP.TabIndex = 8;
            // 
            // L_CargoContP
            // 
            this.L_CargoContP.AutoSize = true;
            this.L_CargoContP.Location = new System.Drawing.Point(309, 170);
            this.L_CargoContP.Name = "L_CargoContP";
            this.L_CargoContP.Size = new System.Drawing.Size(158, 25);
            this.L_CargoContP.TabIndex = 9;
            this.L_CargoContP.Text = "Cargo contacto";
            // 
            // Txt_CargoContP
            // 
            this.Txt_CargoContP.Location = new System.Drawing.Point(479, 170);
            this.Txt_CargoContP.Name = "Txt_CargoContP";
            this.Txt_CargoContP.Size = new System.Drawing.Size(215, 31);
            this.Txt_CargoContP.TabIndex = 10;
            // 
            // L_TelContP
            // 
            this.L_TelContP.AutoSize = true;
            this.L_TelContP.Location = new System.Drawing.Point(700, 170);
            this.L_TelContP.Name = "L_TelContP";
            this.L_TelContP.Size = new System.Drawing.Size(140, 25);
            this.L_TelContP.TabIndex = 11;
            this.L_TelContP.Text = "Tel. Contacto";
            // 
            // Txt_TelContP
            // 
            this.Txt_TelContP.Location = new System.Drawing.Point(855, 167);
            this.Txt_TelContP.Name = "Txt_TelContP";
            this.Txt_TelContP.Size = new System.Drawing.Size(165, 31);
            this.Txt_TelContP.TabIndex = 12;
            this.Txt_TelContP.TextChanged += new System.EventHandler(this.Txt_TelContP_TextChanged);
            // 
            // L_DirecP
            // 
            this.L_DirecP.AutoSize = true;
            this.L_DirecP.Location = new System.Drawing.Point(12, 77);
            this.L_DirecP.Name = "L_DirecP";
            this.L_DirecP.Size = new System.Drawing.Size(102, 25);
            this.L_DirecP.TabIndex = 13;
            this.L_DirecP.Text = "Dirección";
            this.L_DirecP.Click += new System.EventHandler(this.L_DirecP_Click);
            // 
            // Txt_DireccionP
            // 
            this.Txt_DireccionP.Location = new System.Drawing.Point(128, 77);
            this.Txt_DireccionP.Name = "Txt_DireccionP";
            this.Txt_DireccionP.Size = new System.Drawing.Size(501, 31);
            this.Txt_DireccionP.TabIndex = 14;
            // 
            // L_CPProv
            // 
            this.L_CPProv.AutoSize = true;
            this.L_CPProv.Location = new System.Drawing.Point(12, 125);
            this.L_CPProv.Name = "L_CPProv";
            this.L_CPProv.Size = new System.Drawing.Size(41, 25);
            this.L_CPProv.TabIndex = 15;
            this.L_CPProv.Text = "CP";
            // 
            // Txt_CPP
            // 
            this.Txt_CPP.Location = new System.Drawing.Point(128, 125);
            this.Txt_CPP.Name = "Txt_CPP";
            this.Txt_CPP.Size = new System.Drawing.Size(167, 31);
            this.Txt_CPP.TabIndex = 16;
            // 
            // L_CiudadP
            // 
            this.L_CiudadP.AutoSize = true;
            this.L_CiudadP.Location = new System.Drawing.Point(639, 77);
            this.L_CiudadP.Name = "L_CiudadP";
            this.L_CiudadP.Size = new System.Drawing.Size(80, 25);
            this.L_CiudadP.TabIndex = 17;
            this.L_CiudadP.Text = "Ciudad";
            // 
            // Txt_CiudadP
            // 
            this.Txt_CiudadP.Location = new System.Drawing.Point(741, 77);
            this.Txt_CiudadP.Name = "Txt_CiudadP";
            this.Txt_CiudadP.Size = new System.Drawing.Size(279, 31);
            this.Txt_CiudadP.TabIndex = 18;
            // 
            // L_CorreoP
            // 
            this.L_CorreoP.AutoSize = true;
            this.L_CorreoP.Location = new System.Drawing.Point(12, 218);
            this.L_CorreoP.Name = "L_CorreoP";
            this.L_CorreoP.Size = new System.Drawing.Size(77, 25);
            this.L_CorreoP.TabIndex = 19;
            this.L_CorreoP.Text = "Correo";
            // 
            // Txt_CorreoP
            // 
            this.Txt_CorreoP.Location = new System.Drawing.Point(128, 218);
            this.Txt_CorreoP.Name = "Txt_CorreoP";
            this.Txt_CorreoP.Size = new System.Drawing.Size(351, 31);
            this.Txt_CorreoP.TabIndex = 20;
            // 
            // L_TipoProv
            // 
            this.L_TipoProv.AutoSize = true;
            this.L_TipoProv.Location = new System.Drawing.Point(494, 218);
            this.L_TipoProv.Name = "L_TipoProv";
            this.L_TipoProv.Size = new System.Drawing.Size(187, 25);
            this.L_TipoProv.TabIndex = 21;
            this.L_TipoProv.Text = "Tipo de proveedor";
            // 
            // D_TipoProv
            // 
            this.D_TipoProv.FormattingEnabled = true;
            this.D_TipoProv.Location = new System.Drawing.Point(692, 215);
            this.D_TipoProv.Name = "D_TipoProv";
            this.D_TipoProv.Size = new System.Drawing.Size(329, 33);
            this.D_TipoProv.TabIndex = 22;
            // 
            // NuevoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 351);
            this.Controls.Add(this.D_TipoProv);
            this.Controls.Add(this.L_TipoProv);
            this.Controls.Add(this.Txt_CorreoP);
            this.Controls.Add(this.L_CorreoP);
            this.Controls.Add(this.Txt_CiudadP);
            this.Controls.Add(this.L_CiudadP);
            this.Controls.Add(this.Txt_CPP);
            this.Controls.Add(this.L_CPProv);
            this.Controls.Add(this.Txt_DireccionP);
            this.Controls.Add(this.L_DirecP);
            this.Controls.Add(this.Txt_TelContP);
            this.Controls.Add(this.L_TelContP);
            this.Controls.Add(this.Txt_CargoContP);
            this.Controls.Add(this.L_CargoContP);
            this.Controls.Add(this.Txt_ContactoP);
            this.Controls.Add(this.L_ContactoP);
            this.Controls.Add(this.Txt_TelProv);
            this.Controls.Add(this.L_TelefonoP);
            this.Controls.Add(this.Btn_GuardarP);
            this.Controls.Add(this.Txt_RFCP);
            this.Controls.Add(this.L_RFC);
            this.Controls.Add(this.Txt_Proveedor);
            this.Controls.Add(this.L_Proveedor);
            this.Name = "NuevoProveedor";
            this.Text = "Nuevo proveedor";
            this.Load += new System.EventHandler(this.NuevoProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Proveedor;
        private System.Windows.Forms.TextBox Txt_Proveedor;
        private System.Windows.Forms.Label L_RFC;
        private System.Windows.Forms.TextBox Txt_RFCP;
        private System.Windows.Forms.Button Btn_GuardarP;
        private System.Windows.Forms.Label L_TelefonoP;
        private System.Windows.Forms.TextBox Txt_TelProv;
        private System.Windows.Forms.Label L_ContactoP;
        private System.Windows.Forms.TextBox Txt_ContactoP;
        private System.Windows.Forms.Label L_CargoContP;
        private System.Windows.Forms.TextBox Txt_CargoContP;
        private System.Windows.Forms.Label L_TelContP;
        private System.Windows.Forms.TextBox Txt_TelContP;
        private System.Windows.Forms.Label L_DirecP;
        private System.Windows.Forms.TextBox Txt_DireccionP;
        private System.Windows.Forms.Label L_CPProv;
        private System.Windows.Forms.TextBox Txt_CPP;
        private System.Windows.Forms.Label L_CiudadP;
        private System.Windows.Forms.TextBox Txt_CiudadP;
        private System.Windows.Forms.Label L_CorreoP;
        private System.Windows.Forms.TextBox Txt_CorreoP;
        private System.Windows.Forms.Label L_TipoProv;
        private System.Windows.Forms.ComboBox D_TipoProv;
    }
}