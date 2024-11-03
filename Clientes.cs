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
    public partial class Clientes : Form
    {
        Consultas Cta = new Consultas();
        public Clientes()
        {
            InitializeComponent();
            Get_Clientes();
        }
        private void Get_Clientes()
        {
            DataTable dt = Cta.Consulta_Clientes();
            G_Clientes.AutoGenerateColumns = false;

            G_Clientes.Columns["IdCliente"].DataPropertyName = "Id";
            G_Clientes.Columns["Nombre"].DataPropertyName = "Nombre";
            G_Clientes.Columns["RFC"].DataPropertyName = "RFC";
            G_Clientes.Columns["Direccion"].DataPropertyName = "Direccion";
            G_Clientes.Columns["Status"].DataPropertyName = "Status";
            G_Clientes.Columns["FRegistro"].DataPropertyName = "FRegistro";
            G_Clientes.Columns["Correo"].DataPropertyName = "Correo";

            if (dt.Rows.Count > 0 && dt != null)
            {
                G_Clientes.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        private void Btn_CerrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            var nuevoClienteForm = new NuevoCliente();

            nuevoClienteForm.ClienteNuevo += (s, args) => Get_Clientes();
            
            nuevoClienteForm.Show();
        }
    }
}
