using CP_Control.CP_Control.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Control
{
    public partial class NuevoProveedor : Form
    {
        public event  EventHandler ProveedorNuevo;
        Consultas Cta = new Consultas();    

        public int IdPrv { get; set; }
        public string NomPrv { get; set; }
        public string RFCPrv { get; set; }  
        public string DirecPrv { get; set; }
        public string CiudadPrv { get; set; }
        public string CPPrv { get; set; }   
        public int TelPrv { get; set; }
        public string ContPrv   { get; set; }
        public string EmailPrv { get; set; }
        public string CargContPrv { get; set; }
        public string TelContPrv { get; set; } 
        public string TipoPrv { get; set; }

        public NuevoProveedor()
        {
            InitializeComponent();
            Get_TipoProveedor();
            
        }

        public void Get_TipoProveedor()
        {
            DataTable dt = Cta.Get_TProveedor();
            if (dt.Columns.Count > 0 && dt !=null) 
            {
                D_TipoProv.DisplayMember = "Descripcion";
                D_TipoProv.ValueMember = "Tipo";
                D_TipoProv.DataSource = dt;
            }
        }
        
        private void NuevoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void L_ContactoP_Click(object sender, EventArgs e)
        {

        }

        private void L_DirecP_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GuardarP_Click(object sender, EventArgs e)
        {
            string Prov = Txt_Proveedor.Text.Trim();
            string RFC = Txt_RFCP.Text.Trim();
            string DireccionP = Txt_DireccionP.Text.Trim();
            string CiudadP = Txt_CiudadP.Text.Trim();
            string CPP = Txt_CPP.Text.Trim();
            int TelefonoP = Convert.ToInt32(Txt_TelProv.Text.Trim());
            string ContactoP = Txt_ContactoP.Text.Trim();
            string CargoContactoP = Txt_CargoContP.Text.Trim();
            int TelContactoP = Convert.ToInt32(Txt_TelContP.Text.Trim());
            string CorreoP = Txt_CorreoP.Text.Trim();
            string TipoProveedorP = D_TipoProv.SelectedValue.ToString();

            if (Txt_Proveedor.Text != "")
            {

                var nuevoProveedor = new ProveedorViewModel
                {
                    Proveedor = Prov,
                    RFC = RFC,
                    Direccion = DireccionP,
                    Ciudad = CiudadP,
                    CP = CPP,
                    Telefono = TelefonoP,
                    Contacto = ContactoP,
                    CargoContacto = CargoContactoP,
                    TelContacto = TelContactoP,
                    Correo = CorreoP,
                    TipoProveedor = TipoProveedorP
                };
                Cta.Set_InsertaProveedor(nuevoProveedor);
                ProveedorNuevo?.Invoke(sender, EventArgs.Empty);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Debes ingresar el nombre del proveedor.");
            }
        }
       

        private void Txt_TelProv_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_TelProv.Text, out _))
            {
                Txt_TelProv.BackColor = Color.White;
                Txt_TelProv.ForeColor = Color.Black;
            }
            else
            {
                Txt_TelProv.BackColor = Color.LightCoral;
                Txt_TelProv.ForeColor = Color.White;
                MessageBox.Show("El campo solo acepta valores numericos y sin espacios");
            }
        }

        private void Txt_TelContP_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_TelContP.Text, out _))
            {
                Txt_TelContP.BackColor = Color.White;
                Txt_TelContP.ForeColor = Color.Black;
            }
            else
            {
                Txt_TelContP.BackColor = Color.LightCoral;
                Txt_TelContP.ForeColor = Color.White;
                MessageBox.Show("El campo solo acepta valores numericos y sin espacios");
            }
        }
    }
}
