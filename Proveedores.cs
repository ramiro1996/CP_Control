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
    public partial class Proveedores : Form
    {
        Consultas Cta = new Consultas();
        public Proveedores()
        {
            InitializeComponent();
            Get_Proveedor();
        }
        public void Get_Proveedor()
        {
            DataTable dta = Cta.Get_Proveedor();
            G_Proveedor.AutoGenerateColumns=false;

            G_Proveedor.Columns["Id"].DataPropertyName="ID";
            G_Proveedor.Columns["RSocial"].DataPropertyName="RSocial";
            G_Proveedor.Columns["NombreContacto"].DataPropertyName="Contacto";
            G_Proveedor.Columns["Telefono"].DataPropertyName = "Telefono";
            G_Proveedor.Columns["Direccion"].DataPropertyName = "Direccion";
            G_Proveedor.Columns["Correo"].DataPropertyName = "Correo";

            if (dta != null && dta.Rows.Count>0)
            {
                G_Proveedor.DataSource = dta;
            }
        }

        private void Btn_CerrarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_NuevoProveedor_Click(object sender, EventArgs e)
        {
            var NuevoProveedor = new NuevoProveedor();
            NuevoProveedor.ProveedorNuevo += (s, args)=> Get_Proveedor();
            NuevoProveedor.Show();

        }
    }
}
