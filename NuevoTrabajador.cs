using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CP_Control.CP_Control.Modelos;

namespace CP_Control
{
    public partial class NuevoTrabajador : Form
    {
        public event EventHandler TrabajadorInsertado;
        Consultas Cta = new Consultas();

        public int IdTra { get; set; }
        public string nomTra { get; set; }
        public string apPat { get; set; }
        public string apMat { get; set; }
        public string puestoTra { get; set; }
        public string nivelTra { get; set; }
        public decimal sueldoTra { get; set; }
        public string usuarioTra { get; set; }
        public string passTra { get; set; }
        public int telTra { get; set; }
        public string direcTra { get; set; }
        public string correoTra { get; set; }

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
            int IdTrab = Convert.ToInt32(Txt_IdTrabajador.Text.Trim());
            string nombreTra = Txt_NombreT.Text.Trim().ToUpper();
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
            
            if (nombreTra != "" || apePat !="") 
            {
                if (string.IsNullOrEmpty(Txt_IdTrabajador.Text))
                {
                    IdTrab = 0;
                }
                var nvoTrab = new TrabajadoresViewModel { 
                
                    IdT =IdTrab,
                    nombreT = nombreTra,
                    aPaternoT = apePat,
                    aMaternoT = apeMat,
                    puestoT = puesto,
                    nivelT = nivel,
                    sueldoT = sueldo,
                    usuarioT =usuario,
                    pswT = passUsr,
                    telT = tel,
                    direcT = direccion,
                    emailT = correo
                };
                 var accion = Cta.Set_InsertaTrabajador(nvoTrab);
                
                TrabajadorInsertado?.Invoke(sender, EventArgs.Empty);
                this.Close();

                if (accion == 1)
                {
                    MessageBox.Show("Trabajador registrado con éxito.");
                }
                else if (accion == 0)
                {
                    MessageBox.Show("Trabajador modificado con éxito.");

                }
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

        private void NuevoTrabajador_Load(object sender, EventArgs e)
        {
            Txt_IdTrabajador.Text = IdTra.ToString();
            Txt_NombreT.Text = nomTra;
            Txt_ApellidoPT.Text = apPat;
            Txt_ApellidoMT.Text = apMat;
            D_Puesto.Text = puestoTra;
            D_Nivel.Text = nivelTra;
            Txt_SueldoT.Text = sueldoTra.ToString();
            Txt_UsuarioT.Text = usuarioTra;
            Txt_PassT.Text = passTra;
            Txt_TelT.Text = telTra.ToString();
            Txt_DireccionT.Text = direcTra;
            Txt_CorreoT.Text = correoTra;
        }
    }
}
