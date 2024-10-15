namespace CP_Control.CP_Control
{
    partial class Proyectos
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
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_NuevoProyecto = new System.Windows.Forms.Button();
            this.DGV_Proyectos = new System.Windows.Forms.DataGridView();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Proyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(844, 701);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(169, 46);
            this.Btn_Cerrar.TabIndex = 5;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_NuevoProyecto
            // 
            this.Btn_NuevoProyecto.Location = new System.Drawing.Point(48, 41);
            this.Btn_NuevoProyecto.Name = "Btn_NuevoProyecto";
            this.Btn_NuevoProyecto.Size = new System.Drawing.Size(220, 49);
            this.Btn_NuevoProyecto.TabIndex = 4;
            this.Btn_NuevoProyecto.Text = "Nuevo proyecto";
            this.Btn_NuevoProyecto.UseVisualStyleBackColor = true;
            this.Btn_NuevoProyecto.Click += new System.EventHandler(this.Btn_NuevoProyecto_Click);
            // 
            // DGV_Proyectos
            // 
            this.DGV_Proyectos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Proyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Proyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proyecto,
            this.Codigo,
            this.Cliente,
            this.Direccion,
            this.Finicio,
            this.FEntrega});
            this.DGV_Proyectos.Location = new System.Drawing.Point(48, 117);
            this.DGV_Proyectos.Name = "DGV_Proyectos";
            this.DGV_Proyectos.RowHeadersWidth = 82;
            this.DGV_Proyectos.RowTemplate.Height = 33;
            this.DGV_Proyectos.Size = new System.Drawing.Size(1047, 560);
            this.DGV_Proyectos.TabIndex = 3;
            this.DGV_Proyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Proyectos_CellContentClick);
            // 
            // Proyecto
            // 
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.MinimumWidth = 10;
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 200;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 10;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 10;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // Finicio
            // 
            this.Finicio.HeaderText = "Fecha inicio";
            this.Finicio.MinimumWidth = 10;
            this.Finicio.Name = "Finicio";
            this.Finicio.Width = 200;
            // 
            // FEntrega
            // 
            this.FEntrega.HeaderText = "Fecha entrega";
            this.FEntrega.MinimumWidth = 10;
            this.FEntrega.Name = "FEntrega";
            this.FEntrega.Width = 200;
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 808);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_NuevoProyecto);
            this.Controls.Add(this.DGV_Proyectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proyectos";
            this.Text = "Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Proyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_NuevoProyecto;
        private System.Windows.Forms.DataGridView DGV_Proyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEntrega;
    }
}