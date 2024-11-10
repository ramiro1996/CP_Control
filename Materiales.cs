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
    public partial class Materiales : Form
    {
        Consultas Cta = new Consultas();
        public Materiales()
        {
            InitializeComponent();
            Get_ObtenProductos();
        }

        private void Get_ObtenProductos() 
        {
            DataTable DTA = Cta.Get_Productos();
            D_Productos.AutoGenerateColumns = false;
            D_Productos.Columns["Id"].DataPropertyName = "ID";
            D_Productos.Columns["Descripcion"].DataPropertyName = "Descripcion";
            D_Productos.Columns["Color"].DataPropertyName = "Color";
            D_Productos.Columns["UM"].DataPropertyName = "UM";
            D_Productos.Columns["Costo"].DataPropertyName = "Costo";
            D_Productos.Columns["Proveedor"].DataPropertyName = "Proveedor";
            D_Productos.Columns["Codigo"].DataPropertyName = "Codigo";
            D_Productos.Columns["Status"].DataPropertyName = "Status";

            if (DTA != null && DTA.Rows.Count>0)
            {
                D_Productos.DataSource = DTA;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_CerrarM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_NuevoMaterial_Click(object sender, EventArgs e)
        {
            var nuevoMaterial = new NuevoMaterial();
            nuevoMaterial.materialInsertado += (s, args) => Get_ObtenProductos();
            nuevoMaterial.Show();

        }
    }
}
