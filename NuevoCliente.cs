using CP_Control.CP_Control.Modelos;
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
    public partial class NuevoCliente : Form
    {
        public event EventHandler ClienteNuevo;
        Consultas Cta = new Consultas();

        public int IdCli { get; set; }
        public string NomCliente { get; set; }
        public string RFCClien { get; set; }
        public string DirecCliente { get; set; }
        public string CPClient { get; set; }
        public string CDCliente { get; set; }
        public string EmailC { get; set; }
        public string ContClient { get; set; }
        public string TelCont { get; set; }

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void Btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            int IdCliente = Convert.ToInt32(Txt_IdClte.Text);
            string nombre      = Txt_NombreCliente.Text.Trim();
            string rfc         = Txt_RFCCliente.Text.Trim();
            string direccion   = Txt_DireccionCliente.Text.Trim();
            string ciudad      = Txt_CiudadCliente.Text.Trim();
            string cp          = Txt_CPCliente.Text.Trim();
            string correo      = Txt_CorreoCliente.Text.Trim();
            string nomContacto = Txt_ContactoCliente.Text.Trim();
            string telContacto = Txt_TelContactoCliente.Text.Trim();
            if (nombre != null || nombre != "")
            {
                if (string.IsNullOrEmpty(Txt_IdClte.Text))
                {
                    IdCliente = 0;
                }
                var NuevoCliente = new ClienteViewModel
                {
                    IdCiente = IdCliente,
                    Cliente = nombre,
                    RFCCli = rfc,
                    DirClien = direccion,
                    CiudClien = ciudad, 
                    CPClien = cp,
                    CorreoC = correo,
                    ContaClnt = nomContacto,
                    TelConClient = telContacto
                };

                var mRegMod = Cta.Set_InsertaCliente(NuevoCliente);
                ClienteNuevo?.Invoke(this, EventArgs.Empty);
                this.Close();
                if (mRegMod == 1)
                {
                    MessageBox.Show("Registro creado correctamente.");
                }
                else if (mRegMod == 0)
                {
                    MessageBox.Show("Registro modificado correctamente");
                }
            }

        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            Txt_IdClte.Text = IdCli.ToString();
            Txt_NombreCliente.Text = NomCliente;
            Txt_RFCCliente.Text = RFCClien;
            Txt_DireccionCliente.Text = DirecCliente;
            Txt_CiudadCliente.Text = CDCliente;
            Txt_CPCliente.Text = CPClient;
            Txt_CorreoCliente.Text = EmailC;
            Txt_ContactoCliente.Text = ContClient;
            Txt_TelContactoCliente.Text = TelCont;
        }
    }
}
