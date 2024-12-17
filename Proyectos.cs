using CP_Control.CP_Control.IRepositorios;
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
        private bool btn_ModProyecto = false;
         
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

            if (!btn_ModProyecto)
            {
                DataGridViewButtonColumn buttonEditaProyecto = new DataGridViewButtonColumn();
                buttonEditaProyecto.Name = "Btn_EditaProyecto";
                buttonEditaProyecto.HeaderText = "Acción";
                buttonEditaProyecto.Text = "Editar";
                buttonEditaProyecto.UseColumnTextForButtonValue = true;
                DGV_Proyectos.Columns.Add(buttonEditaProyecto);
                DGV_Proyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                btn_ModProyecto = true;
            }
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
            int IdProy = Convert.ToInt32(DGV_Proyectos.Rows[e.RowIndex].Cells[0].Value.ToString());
            string Proy = DGV_Proyectos.Rows[e.RowIndex].Cells[1].Value.ToString();
            string CodProy = DGV_Proyectos.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Cliente = DGV_Proyectos.Rows[e.RowIndex].Cells[3].Value.ToString();
            string direc = DGV_Proyectos.Rows[e.RowIndex].Cells[4].Value.ToString();
            string FInic = DGV_Proyectos.Rows[e.RowIndex].Cells[5].Value.ToString();
            string FEntr = DGV_Proyectos.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (e.RowIndex >= 0 && DGV_Proyectos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (DGV_Proyectos.Columns[e.ColumnIndex].Name == "Btn_EditaProyecto")
                {
                    var nuevoProy = new NuevoProyecto
                    {
                    IdPryto = IdProy,
                    NombreProy = Proy,
                    CodProy = CodProy,
                    NombreCliente = Cliente,
                    DirProy = direc,
                    FechInicio = FInic,
                    FechEntrega = FEntr
                    };
                    nuevoProy.ProyectoInsertado += (s, args) => Get_Proyectos();
                    nuevoProy.Show();
                }
            }

        }

        private void Btn_NuevoProyecto_Click(object sender, EventArgs e)
        {
           
            var nuevoProyectoForm = new NuevoProyecto();
            nuevoProyectoForm.ProyectoInsertado += (s, args) => Get_Proyectos();
            nuevoProyectoForm.Show();
        }

        private void Txt_BuscaProy_TextChanged(object sender, EventArgs e)
        {
            DataTable dt =  (DataTable)DGV_Proyectos.DataSource;
            if (dt != null) 
            {
                dt.DefaultView.RowFilter = string.Format("Proyecto like '%{0}%' OR Estado like '%{0}%'", Txt_BuscaProy.Text);
            }
        }
    }
}
