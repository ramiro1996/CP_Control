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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.L_Diereccion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.L_Codigo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_GuardarProyecto = new System.Windows.Forms.Button();
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
            this.Txt_Proyecto.Size = new System.Drawing.Size(317, 31);
            this.Txt_Proyecto.TabIndex = 1;
            // 
            // L_Cliente
            // 
            this.L_Cliente.AutoSize = true;
            this.L_Cliente.Location = new System.Drawing.Point(475, 45);
            this.L_Cliente.Name = "L_Cliente";
            this.L_Cliente.Size = new System.Drawing.Size(74, 25);
            this.L_Cliente.TabIndex = 2;
            this.L_Cliente.Text = "Ciente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(581, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 33);
            this.comboBox1.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 31);
            this.textBox1.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 31);
            this.textBox2.TabIndex = 8;
            // 
            // Btn_GuardarProyecto
            // 
            this.Btn_GuardarProyecto.Location = new System.Drawing.Point(310, 226);
            this.Btn_GuardarProyecto.Name = "Btn_GuardarProyecto";
            this.Btn_GuardarProyecto.Size = new System.Drawing.Size(150, 39);
            this.Btn_GuardarProyecto.TabIndex = 9;
            this.Btn_GuardarProyecto.Text = "Guardar";
            this.Btn_GuardarProyecto.UseVisualStyleBackColor = true;
            // 
            // NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 274);
            this.Controls.Add(this.Btn_GuardarProyecto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.L_Codigo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.L_Diereccion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.L_Cliente);
            this.Controls.Add(this.Txt_Proyecto);
            this.Controls.Add(this.L_Proyecto);
            this.Name = "NuevoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Proyecto;
        private System.Windows.Forms.TextBox Txt_Proyecto;
        private System.Windows.Forms.Label L_Cliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label L_Diereccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label L_Codigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_GuardarProyecto;
    }
}