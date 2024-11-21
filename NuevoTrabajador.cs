using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Control
{
    public partial class NuevoTrabajador : Form
    {
        public event EventHandler TrabajadorInsertado;
        Consultas Cta = new Consultas();
        public NuevoTrabajador()
        {
            InitializeComponent();
            Get_Puesto();
            Get_Nivel();
        }

        public void Get_Puesto()
        {
            DataTable dt = Cta.Get_Puesto();

            if (dt != null)
            {
                D_Puesto.DisplayMember = "Area";
                D_Puesto.ValueMember = "Id";
                D_Puesto.DataSource = dt;
            }
        }
        public void Get_Nivel()
        {
            DataTable dte = Cta.Get_Nivel();

            if (dte != null)
            {
                D_Nivel.DisplayMember = "Nivel";
                D_Nivel.ValueMember = "Id";
                D_Nivel.DataSource = dte;
            }
        }

        private void Btn_GuardarT_Click(object sender, EventArgs e)
        {
            string nombreT = Txt_NombreT.Text.Trim().ToUpper();
            string apePat = Txt_ApellidoPT.Text.Trim().ToUpper();
            string apeMat = Txt_ApellidoMT.Text.Trim().ToUpper();
            int puesto = Convert.ToInt32(D_Puesto.SelectedValue);
            int nivel = Convert.ToInt32(D_Nivel.SelectedValue);
            decimal sueldo = Convert.ToDecimal(Txt_SueldoT.Text.Trim());
            string usuario = Txt_UsuarioT.Text.Trim().ToUpper();
            string passUsr = Txt_PassT.Text.Trim();
            int tel = Convert.ToInt32(Txt_TelT.Text.Trim());
            string direccion = Txt_DireccionT.Text.Trim().ToUpper();
            string correo = Txt_CorreoT.Text.Trim();
            
            if (nombreT != "" || apePat !="") 
            {
                Cta.Set_InsertaTrabajador(nombreT,apePat,apeMat,puesto,nivel,usuario,passUsr,tel,direccion,correo,sueldo);    
                TrabajadorInsertado?.Invoke(sender, EventArgs.Empty);
                this.Close();
                MessageBox.Show("Trabajador registrado con éxito.");
            }


        }

        private void Txt_TelT_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_TelT.Text, out _))
            {
                Txt_TelT.BackColor = Color.White;
                Txt_TelT.ForeColor = Color.Black;
            }
            else
            {
                Txt_TelT.BackColor = Color.LightCoral;
                Txt_TelT.ForeColor = Color.White;
                MessageBox.Show("El campo solo acepta valores numericos y sin espacios.");
            }
        }
    }
}
