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
            string nombreT = Txt_NombreT.Text.Trim();
            string apePat = Txt_ApellidoPT.Text.Trim();
            string apeMat = Txt_ApellidoMT.Text.Trim();
            int puesto = Convert.ToInt32(D_Puesto.SelectedValue);
            int nivel = Convert.ToInt32(D_Nivel.SelectedValue);
            decimal sueldo = Convert.ToDecimal(Txt_SueldoT.Text.Trim());
            string usuario = Txt_UsuarioT.Text.Trim();
            string passUsr = Txt_PassT.Text.Trim();
            string tel =Txt_TelT.Text.Trim();
            string direccion = Txt_DireccionT.Text.Trim();
            string correo = Txt_CorreoT.Text.Trim();
            
            if (nombreT != "" || apePat !="") 
            {
                
                
            
            }

        }
    }
}
