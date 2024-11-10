using CP_Control.CP_Control.IRepositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CP_Control.CP_Control
{
    public partial class Proyectos : Form
    {
        Consultas Cta = new Consultas();
        
        public Proyectos()
        {
           
            InitializeComponent();
            Get_Proyectos();
        }
         
        private void Get_Proyectos()
        {
            DataTable dt = Cta.ConsultaProyectos();
            DGV_Proyectos.AutoGenerateColumns = false;

            // Asigna los DataPropertyName a las columnas antes de asignar el DataSource
            DGV_Proyectos.Columns["Id"].DataPropertyName = "ID";
            DGV_Proyectos.Columns["Proyecto"].DataPropertyName = "Proyecto";
            DGV_Proyectos.Columns["Codigo"].DataPropertyName = "Codigo";
            DGV_Proyectos.Columns["Id_Cliente"].DataPropertyName = "Id_Cliente";
            DGV_Proyectos.Columns["Direccion"].DataPropertyName = "Direccion";
            DGV_Proyectos.Columns["FInicio"].DataPropertyName = "FInicio";
            DGV_Proyectos.Columns["FEntrega"].DataPropertyName = "FEntrega";
            DGV_Proyectos.Columns["Estado"].DataPropertyName = "Estado";
            DGV_Proyectos.Columns["FRegistro"].DataPropertyName = "FRegistro";

            // Verificar si el DataTable tiene filas
            if (dt != null && dt.Rows.Count > 0)
            {
                DGV_Proyectos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron datos");
            }
        }
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Proyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Btn_NuevoProyecto_Click(object sender, EventArgs e)
        {
            //Form NuevoProyecto = new NuevoProyecto();
            //NuevoProyecto.Show();
            var nuevoProyectoForm = new NuevoProyecto();

            // Suscríbete al evento ProyectoInsertado
            nuevoProyectoForm.ProyectoInsertado += (s, args) => Get_Proyectos();

            // Muestra el formulario de NuevoProyecto
            nuevoProyectoForm.Show();
        }
    }
}
