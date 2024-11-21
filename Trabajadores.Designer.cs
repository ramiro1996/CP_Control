namespace CP_Control
{
    partial class Trabajadores
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
            this.Btn_Trabajadores = new System.Windows.Forms.Button();
            this.G_Trabajadores = new System.Windows.Forms.DataGridView();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.G_Trabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Trabajadores
            // 
            this.Btn_Trabajadores.Location = new System.Drawing.Point(48, 43);
            this.Btn_Trabajadores.Name = "Btn_Trabajadores";
            this.Btn_Trabajadores.Size = new System.Drawing.Size(233, 40);
            this.Btn_Trabajadores.TabIndex = 0;
            this.Btn_Trabajadores.Text = "Nuevo trabajador";
            this.Btn_Trabajadores.UseVisualStyleBackColor = true;
            this.Btn_Trabajadores.Click += new System.EventHandler(this.Btn_Trabajadores_Click);
            // 
            // G_Trabajadores
            // 
            this.G_Trabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_Trabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_Trabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido_p,
            this.Apellido_m,
            this.Puesto,
            this.Nivel,
            this.Usuario,
            this.Sueldo,
            this.Status});
            this.G_Trabajadores.Location = new System.Drawing.Point(48, 117);
            this.G_Trabajadores.Name = "G_Trabajadores";
            this.G_Trabajadores.RowHeadersWidth = 82;
            this.G_Trabajadores.RowTemplate.Height = 33;
            this.G_Trabajadores.Size = new System.Drawing.Size(1047, 560);
            this.G_Trabajadores.TabIndex = 1;
            this.G_Trabajadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.G_Trabajadores_CellContentClick);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(831, 711);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(200, 43);
            this.Btn_Cerrar.TabIndex = 2;
            this.Btn_Cerrar.Text = "cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Apellido_p
            // 
            this.Apellido_p.HeaderText = "Apellido paterno";
            this.Apellido_p.MinimumWidth = 10;
            this.Apellido_p.Name = "Apellido_p";
            this.Apellido_p.Width = 200;
            // 
            // Apellido_m
            // 
            this.Apellido_m.HeaderText = "Apellido Materno";
            this.Apellido_m.MinimumWidth = 10;
            this.Apellido_m.Name = "Apellido_m";
            this.Apellido_m.Width = 200;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 10;
            this.Puesto.Name = "Puesto";
            this.Puesto.Width = 150;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 10;
            this.Nivel.Name = "Nivel";
            this.Nivel.Width = 150;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 10;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 150;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.MinimumWidth = 10;
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 808);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.G_Trabajadores);
            this.Controls.Add(this.Btn_Trabajadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trabajadores";
            this.Text = "Trabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.G_Trabajadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Trabajadores;
        private System.Windows.Forms.DataGridView G_Trabajadores;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}