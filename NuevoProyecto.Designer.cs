namespace CP_Control.CP_Control
{
    partial class NuevoProyecto
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
            this.L_Proyecto = new System.Windows.Forms.Label();
            this.Txt_Proyecto = new System.Windows.Forms.TextBox();
            this.L_Cliente = new System.Windows.Forms.Label();
            this.D_Cliente = new System.Windows.Forms.ComboBox();
            this.L_Diereccion = new System.Windows.Forms.Label();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.L_Codigo = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Btn_GuardarProyecto = new System.Windows.Forms.Button();
            this.Btn_FInicio = new System.Windows.Forms.Button();
            this.Txt_FRegistro = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Btn_FEntrega = new System.Windows.Forms.Button();
            this.Txt_FEntrega = new System.Windows.Forms.TextBox();
            this.L_IdProy = new System.Windows.Forms.Label();
            this.Txt_IdProy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_Proyecto
            // 
            this.L_Proyecto.AutoSize = true;
            this.L_Proyecto.Location = new System.Drawing.Point(28, 45);
            this.L_Proyecto.Name = "L_Proyecto";
            this.L_Proyecto.Size = new System.Drawing.Size(97, 25);
            this.L_Proyecto.TabIndex = 0;
            this.L_Proyecto.Text = "Proyecto";
            // 
            // Txt_Proyecto
            // 
            this.Txt_Proyecto.Location = new System.Drawing.Point(152, 39);
            this.Txt_Proyecto.Name = "Txt_Proyecto";
            this.Txt_Proyecto.Size = new System.Drawing.Size(428, 31);
            this.Txt_Proyecto.TabIndex = 1;
            // 
            // L_Cliente
            // 
            this.L_Cliente.AutoSize = true;
            this.L_Cliente.Location = new System.Drawing.Point(604, 42);
            this.L_Cliente.Name = "L_Cliente";
            this.L_Cliente.Size = new System.Drawing.Size(74, 25);
            this.L_Cliente.TabIndex = 2;
            this.L_Cliente.Text = "Ciente";
            // 
            // D_Cliente
            // 
            this.D_Cliente.FormattingEnabled = true;
            this.D_Cliente.Location = new System.Drawing.Point(700, 37);
            this.D_Cliente.Name = "D_Cliente";
            this.D_Cliente.Size = new System.Drawing.Size(441, 33);
            this.D_Cliente.TabIndex = 4;
            // 
            // L_Diereccion
            // 
            this.L_Diereccion.AutoSize = true;
            this.L_Diereccion.Location = new System.Drawing.Point(28, 101);
            this.L_Diereccion.Name = "L_Diereccion";
            this.L_Diereccion.Size = new System.Drawing.Size(102, 25);
            this.L_Diereccion.TabIndex = 5;
            this.L_Diereccion.Text = "Dirección";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(152, 101);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(989, 31);
            this.Txt_Direccion.TabIndex = 6;
            // 
            // L_Codigo
            // 
            this.L_Codigo.AutoSize = true;
            this.L_Codigo.Location = new System.Drawing.Point(28, 160);
            this.L_Codigo.Name = "L_Codigo";
            this.L_Codigo.Size = new System.Drawing.Size(80, 25);
            this.L_Codigo.TabIndex = 7;
            this.L_Codigo.Text = "Código";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(152, 154);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(428, 31);
            this.Txt_Codigo.TabIndex = 8;
            // 
            // Btn_GuardarProyecto
            // 
            this.Btn_GuardarProyecto.Location = new System.Drawing.Point(991, 210);
            this.Btn_GuardarProyecto.Name = "Btn_GuardarProyecto";
            this.Btn_GuardarProyecto.Size = new System.Drawing.Size(150, 39);
            this.Btn_GuardarProyecto.TabIndex = 9;
            this.Btn_GuardarProyecto.Text = "Guardar";
            this.Btn_GuardarProyecto.UseVisualStyleBackColor = true;
            this.Btn_GuardarProyecto.Click += new System.EventHandler(this.Btn_GuardarProyecto_Click);
            // 
            // Btn_FInicio
            // 
            this.Btn_FInicio.Location = new System.Drawing.Point(33, 205);
            this.Btn_FInicio.Name = "Btn_FInicio";
            this.Btn_FInicio.Size = new System.Drawing.Size(163, 38);
            this.Btn_FInicio.TabIndex = 10;
            this.Btn_FInicio.Text = "Fecha Inicio";
            this.Btn_FInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_FInicio.UseVisualStyleBackColor = true;
            this.Btn_FInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_FRegistro
            // 
            this.Txt_FRegistro.Location = new System.Drawing.Point(206, 207);
            this.Txt_FRegistro.Name = "Txt_FRegistro";
            this.Txt_FRegistro.Size = new System.Drawing.Size(159, 31);
            this.Txt_FRegistro.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(377, -16);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Btn_FEntrega
            // 
            this.Btn_FEntrega.Location = new System.Drawing.Point(377, 203);
            this.Btn_FEntrega.Name = "Btn_FEntrega";
            this.Btn_FEntrega.Size = new System.Drawing.Size(209, 42);
            this.Btn_FEntrega.TabIndex = 14;
            this.Btn_FEntrega.Text = "Fecha Entrega";
            this.Btn_FEntrega.UseVisualStyleBackColor = true;
            this.Btn_FEntrega.Click += new System.EventHandler(this.Btn_FEntrega_Click);
            // 
            // Txt_FEntrega
            // 
            this.Txt_FEntrega.Location = new System.Drawing.Point(592, 207);
            this.Txt_FEntrega.Name = "Txt_FEntrega";
            this.Txt_FEntrega.Size = new System.Drawing.Size(186, 31);
            this.Txt_FEntrega.TabIndex = 15;
            // 
            // L_IdProy
            // 
            this.L_IdProy.AutoSize = true;
            this.L_IdProy.Location = new System.Drawing.Point(28, 259);
            this.L_IdProy.Name = "L_IdProy";
            this.L_IdProy.Size = new System.Drawing.Size(114, 25);
            this.L_IdProy.TabIndex = 16;
            this.L_IdProy.Text = "IdProyecto";
            this.L_IdProy.Visible = false;
            // 
            // Txt_IdProy
            // 
            this.Txt_IdProy.Location = new System.Drawing.Point(152, 259);
            this.Txt_IdProy.Name = "Txt_IdProy";
            this.Txt_IdProy.Size = new System.Drawing.Size(105, 31);
            this.Txt_IdProy.TabIndex = 17;
            this.Txt_IdProy.Visible = false;
            // 
            // NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 320);
            this.Controls.Add(this.Txt_IdProy);
            this.Controls.Add(this.L_IdProy);
            this.Controls.Add(this.Txt_FEntrega);
            this.Controls.Add(this.Btn_FEntrega);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Txt_FRegistro);
            this.Controls.Add(this.Btn_FInicio);
            this.Controls.Add(this.Btn_GuardarProyecto);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.L_Codigo);
            this.Controls.Add(this.Txt_Direccion);
            this.Controls.Add(this.L_Diereccion);
            this.Controls.Add(this.D_Cliente);
            this.Controls.Add(this.L_Cliente);
            this.Controls.Add(this.Txt_Proyecto);
            this.Controls.Add(this.L_Proyecto);
            this.Name = "NuevoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo proyecto";
            this.Load += new System.EventHandler(this.NuevoProyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Proyecto;
        private System.Windows.Forms.TextBox Txt_Proyecto;
        private System.Windows.Forms.Label L_Cliente;
        private System.Windows.Forms.ComboBox D_Cliente;
        private System.Windows.Forms.Label L_Diereccion;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label L_Codigo;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Button Btn_GuardarProyecto;
        private System.Windows.Forms.Button Btn_FInicio;
        private System.Windows.Forms.TextBox Txt_FRegistro;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Btn_FEntrega;
        private System.Windows.Forms.TextBox Txt_FEntrega;
        private System.Windows.Forms.Label L_IdProy;
        private System.Windows.Forms.TextBox Txt_IdProy;
    }
}