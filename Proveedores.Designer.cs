namespace CP_Control
{
    partial class Proveedores
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
            this.G_Proveedor = new System.Windows.Forms.DataGridView();
            this.Btn_NuevoProveedor = new System.Windows.Forms.Button();
            this.Btn_CerrarP = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.G_Proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // G_Proveedor
            // 
            this.G_Proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RSocial,
            this.NombreContacto,
            this.Telefono,
            this.Direccion,
            this.Correo});
            this.G_Proveedor.Location = new System.Drawing.Point(48, 117);
            this.G_Proveedor.Name = "G_Proveedor";
            this.G_Proveedor.RowHeadersWidth = 82;
            this.G_Proveedor.RowTemplate.Height = 33;
            this.G_Proveedor.Size = new System.Drawing.Size(1047, 560);
            this.G_Proveedor.TabIndex = 0;
            // 
            // Btn_NuevoProveedor
            // 
            this.Btn_NuevoProveedor.Location = new System.Drawing.Point(65, 41);
            this.Btn_NuevoProveedor.Name = "Btn_NuevoProveedor";
            this.Btn_NuevoProveedor.Size = new System.Drawing.Size(233, 45);
            this.Btn_NuevoProveedor.TabIndex = 1;
            this.Btn_NuevoProveedor.Text = "Nuevo proveedor";
            this.Btn_NuevoProveedor.UseVisualStyleBackColor = true;
            this.Btn_NuevoProveedor.Click += new System.EventHandler(this.Btn_NuevoProveedor_Click);
            // 
            // Btn_CerrarP
            // 
            this.Btn_CerrarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CerrarP.Location = new System.Drawing.Point(961, 722);
            this.Btn_CerrarP.Name = "Btn_CerrarP";
            this.Btn_CerrarP.Size = new System.Drawing.Size(127, 48);
            this.Btn_CerrarP.TabIndex = 2;
            this.Btn_CerrarP.Text = "Cerrar";
            this.Btn_CerrarP.UseVisualStyleBackColor = true;
            this.Btn_CerrarP.Click += new System.EventHandler(this.Btn_CerrarP_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // RSocial
            // 
            this.RSocial.HeaderText = "Proveedor";
            this.RSocial.MinimumWidth = 10;
            this.RSocial.Name = "RSocial";
            this.RSocial.Width = 200;
            // 
            // NombreContacto
            // 
            this.NombreContacto.HeaderText = "Contacto";
            this.NombreContacto.MinimumWidth = 10;
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 10;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 10;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 10;
            this.Correo.Name = "Correo";
            this.Correo.Width = 200;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 808);
            this.Controls.Add(this.Btn_CerrarP);
            this.Controls.Add(this.Btn_NuevoProveedor);
            this.Controls.Add(this.G_Proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.G_Proveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView G_Proveedor;
        private System.Windows.Forms.Button Btn_NuevoProveedor;
        private System.Windows.Forms.Button Btn_CerrarP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}