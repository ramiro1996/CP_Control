namespace CP_Control
{
    partial class Materiales
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
            this.D_Productos = new System.Windows.Forms.DataGridView();
            this.Btn_NuevoMaterial = new System.Windows.Forms.Button();
            this.Btn_CerrarM = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.D_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // D_Productos
            // 
            this.D_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.D_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Color,
            this.UM,
            this.Costo,
            this.Proveedor,
            this.Codigo,
            this.Status});
            this.D_Productos.Location = new System.Drawing.Point(48, 117);
            this.D_Productos.Name = "D_Productos";
            this.D_Productos.RowHeadersWidth = 82;
            this.D_Productos.RowTemplate.Height = 33;
            this.D_Productos.Size = new System.Drawing.Size(1047, 560);
            this.D_Productos.TabIndex = 3;
            this.D_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_NuevoMaterial
            // 
            this.Btn_NuevoMaterial.Location = new System.Drawing.Point(65, 41);
            this.Btn_NuevoMaterial.Name = "Btn_NuevoMaterial";
            this.Btn_NuevoMaterial.Size = new System.Drawing.Size(188, 45);
            this.Btn_NuevoMaterial.TabIndex = 1;
            this.Btn_NuevoMaterial.Text = "Nuevo material";
            this.Btn_NuevoMaterial.UseVisualStyleBackColor = true;
            this.Btn_NuevoMaterial.Click += new System.EventHandler(this.Btn_NuevoMaterial_Click);
            // 
            // Btn_CerrarM
            // 
            this.Btn_CerrarM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CerrarM.Location = new System.Drawing.Point(961, 722);
            this.Btn_CerrarM.Name = "Btn_CerrarM";
            this.Btn_CerrarM.Size = new System.Drawing.Size(127, 48);
            this.Btn_CerrarM.TabIndex = 2;
            this.Btn_CerrarM.Text = "Cerrar";
            this.Btn_CerrarM.UseVisualStyleBackColor = true;
            this.Btn_CerrarM.Click += new System.EventHandler(this.Btn_CerrarM_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descrpción";
            this.Descripcion.MinimumWidth = 10;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 10;
            this.Color.Name = "Color";
            this.Color.Width = 200;
            // 
            // UM
            // 
            this.UM.HeaderText = "Unidad";
            this.UM.MinimumWidth = 10;
            this.UM.Name = "UM";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 10;
            this.Costo.Name = "Costo";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 10;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            // 
            // Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 808);
            this.Controls.Add(this.Btn_CerrarM);
            this.Controls.Add(this.Btn_NuevoMaterial);
            this.Controls.Add(this.D_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materiales";
            this.Text = "Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.D_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView D_Productos;
        private System.Windows.Forms.Button Btn_NuevoMaterial;
        private System.Windows.Forms.Button Btn_CerrarM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}