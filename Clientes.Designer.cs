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
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Clientes = new System.Windows.Forms.Button();
            this.Btn_CerrarClientes = new System.Windows.Forms.Button();
            this.Txt_BuscaCliente = new System.Windows.Forms.TextBox();
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
            this.Correo,
            this.Ciudad,
            this.CP,
            this.Nombre_Contacto,
            this.Telefono});
            this.G_Clientes.Location = new System.Drawing.Point(48, 117);
            this.G_Clientes.Name = "G_Clientes";
            this.G_Clientes.RowHeadersWidth = 82;
            this.G_Clientes.RowTemplate.Height = 33;
            this.G_Clientes.Size = new System.Drawing.Size(1047, 560);
            this.G_Clientes.TabIndex = 0;
            this.G_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.G_Clientes_CellContentClick);
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.MinimumWidth = 10;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 50;
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
            this.RFC.Width = 150;
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
            this.Status.Width = 90;
            // 
            // FRegistro
            // 
            this.FRegistro.HeaderText = "Fecha registro";
            this.FRegistro.MinimumWidth = 10;
            this.FRegistro.Name = "FRegistro";
            this.FRegistro.Width = 90;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 10;
            this.Correo.Name = "Correo";
            this.Correo.Width = 200;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 10;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 200;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.MinimumWidth = 10;
            this.CP.Name = "CP";
            this.CP.Width = 200;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Contacto";
            this.Nombre_Contacto.MinimumWidth = 10;
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 10;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 200;
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.Location = new System.Drawing.Point(48, 41);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Size = new System.Drawing.Size(220, 49);
            this.Btn_Clientes.TabIndex = 1;
            this.Btn_Clientes.Text = "Nuevo cliente";
            this.Btn_Clientes.UseVisualStyleBackColor = true;
            this.Btn_Clientes.Click += new System.EventHandler(this.Btn_Clientes_Click);
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
            // Txt_BuscaCliente
            // 
            this.Txt_BuscaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_BuscaCliente.Location = new System.Drawing.Point(894, 58);
            this.Txt_BuscaCliente.Name = "Txt_BuscaCliente";
            this.Txt_BuscaCliente.Size = new System.Drawing.Size(201, 31);
            this.Txt_BuscaCliente.TabIndex = 3;
            this.Txt_BuscaCliente.TextChanged += new System.EventHandler(this.Txt_BuscaCliente_TextChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 808);
            this.Controls.Add(this.Txt_BuscaCliente);
            this.Controls.Add(this.Btn_CerrarClientes);
            this.Controls.Add(this.Btn_Clientes);
            this.Controls.Add(this.G_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.G_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.TextBox Txt_BuscaCliente;
    }
}