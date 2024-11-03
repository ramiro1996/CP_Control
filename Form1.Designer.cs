namespace CP_Control
{
    partial class Clientes
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
            this.G_Clientes = new System.Windows.Forms.DataGridView();
            this.Btn_Clientes = new System.Windows.Forms.Button();
            this.Btn_CerrarClientes = new System.Windows.Forms.Button();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.G_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // G_Clientes
            // 
            this.G_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.RFC,
            this.Direccion,
            this.Status,
            this.FRegistro,
            this.Correo});
            this.G_Clientes.Location = new System.Drawing.Point(48, 117);
            this.G_Clientes.Name = "G_Clientes";
            this.G_Clientes.RowHeadersWidth = 82;
            this.G_Clientes.RowTemplate.Height = 33;
            this.G_Clientes.Size = new System.Drawing.Size(1047, 560);
            this.G_Clientes.TabIndex = 0;
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.Location = new System.Drawing.Point(48, 41);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Size = new System.Drawing.Size(220, 49);
            this.Btn_Clientes.TabIndex = 1;
            this.Btn_Clientes.Text = "Nuevo cliente";
            this.Btn_Clientes.UseVisualStyleBackColor = true;
            // 
            // Btn_CerrarClientes
            // 
            this.Btn_CerrarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CerrarClientes.Location = new System.Drawing.Point(844, 701);
            this.Btn_CerrarClientes.Name = "Btn_CerrarClientes";
            this.Btn_CerrarClientes.Size = new System.Drawing.Size(169, 46);
            this.Btn_CerrarClientes.TabIndex = 2;
            this.Btn_CerrarClientes.Text = "Cerrar";
            this.Btn_CerrarClientes.UseVisualStyleBackColor = true;
            this.Btn_CerrarClientes.Click += new System.EventHandler(this.Btn_CerrarClientes_Click);
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.MinimumWidth = 10;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Cliente";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 10;
            this.RFC.Name = "RFC";
            this.RFC.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 10;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.Width = 200;
            // 
            // FRegistro
            // 
            this.FRegistro.HeaderText = "Fecha registro";
            this.FRegistro.MinimumWidth = 10;
            this.FRegistro.Name = "FRegistro";
            this.FRegistro.Width = 200;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 10;
            this.Correo.Name = "Correo";
            this.Correo.Width = 200;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 808);
            this.Controls.Add(this.Btn_CerrarClientes);
            this.Controls.Add(this.Btn_Clientes);
            this.Controls.Add(this.G_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.G_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView G_Clientes;
        private System.Windows.Forms.Button Btn_Clientes;
        private System.Windows.Forms.Button Btn_CerrarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}