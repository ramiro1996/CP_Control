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
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void Btn_GuardarCliente_Click(object sender, EventArgs e)
        {            
            string nombre      = Txt_NombreCliente.Text.Trim();
            string rfc         = Txt_RFCCliente.Text.Trim();
            string direccion   = Txt_DireccionCliente.Text.Trim();
            string ciudad      = Txt_CiudadCliente.Text.Trim();
            string cp          = Txt_CPCliente.Text.Trim();
            string correo      =Txt_CorreoCliente.Text.Trim();
            string nomContacto = Txt_ContactoCliente.Text.Trim();
            string telContacto = Txt_TelContactoCliente.Text.Trim();
            if (nombre != null || nombre != "")
            {
                Cta.Set_InsertaCliente(nombre, rfc, direccion, ciudad, cp, correo, nomContacto, telContacto);
                MessageBox.Show("Registro creado correctamente.");
                ClienteNuevo?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
    }
}
