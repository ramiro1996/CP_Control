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
    public partial class Trabajadores : Form
    {
        Consultas Cta = new Consultas();
        public Trabajadores()
        {
            InitializeComponent();
            Get_Trabajadores();
        }

        private void Get_Trabajadores()
        {
            DataTable dt = Cta.Consulta_Trabajadores();
            G_Trabajadores.AutoGenerateColumns = false;
            G_Trabajadores.Columns["Id"].DataPropertyName = "Id";
            G_Trabajadores.Columns["Nombre"].DataPropertyName = "Nombre";
            G_Trabajadores.Columns["Apellido_p"].DataPropertyName = "Apellido_p";
            G_Trabajadores.Columns["Apellido_m"].DataPropertyName = "Apellido_m";
            G_Trabajadores.Columns["Puesto"].DataPropertyName = "Puesto";
            G_Trabajadores.Columns["Nivel"].DataPropertyName = "Nivel";
            G_Trabajadores.Columns["Usuario"].DataPropertyName="Usuario";
            G_Trabajadores.Columns["Sueldo"].DataPropertyName = "Sueldo";
            G_Trabajadores.Columns["Status"].DataPropertyName = "Status";

            if (dt.Rows.Count > 0)
            {
                G_Trabajadores.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        private void G_Trabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Btn_Trabajadores_Click(object sender, EventArgs e)
        {
            var nuevoTrabajadorForm = new NuevoTrabajador();

            nuevoTrabajadorForm.TrabajadorInsertado += (s, args) => Get_Trabajadores();

            nuevoTrabajadorForm.Show();
        }
    }
}
