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
    public partial class NuevoProveedor : Form
    {
        public event  EventHandler ProveedorNuevo;
        Consultas Cta = new Consultas();    
        public NuevoProveedor()
        {
            InitializeComponent();
            Get_TipoProveedor();
        }

        public void Get_TipoProveedor()
        {
            DataTable dt = Cta.Get_Proveedor();
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
            if (Txt_Proveedor.Text != "")
            {

                var nuevoProveedor = new ProveedorViewModel
                {
                    Proveedor = Txt_Proveedor.Text.Trim(),
                    RFC = Txt_RFCP.Text.Trim(),
                    Direccion = Txt_DireccionP.Text.Trim(),
                    Ciudad = Txt_CiudadP.Text.Trim(),
                    CP = Txt_CPP.Text.Trim(),
                    Telefono = Convert.ToInt32(Txt_TelProv.Text.Trim()),
                    Contacto = Txt_ContactoP.Text.Trim(),
                    CargoContacto = Txt_CargoContP.Text.Trim(),
                    TelContacto = Convert.ToInt32(Txt_CargoContP.Text.Trim()),
                    Correo = Txt_CorreoP.Text.Trim(),
                    TipoProveedor = Convert.ToInt32(D_TipoProv.SelectedValue)
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
    }
}
