using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

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
        private bool botonAgregado = false;
        private bool botonElimina = false;

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
            D_Productos.Columns["Clasificacion"].DataPropertyName = "Clasificacion";
            D_Productos.Columns["Espesor"].DataPropertyName = "Espesor";
            // Agregar una columna de botón
            if (!botonAgregado)
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Btn_Modifica";
                editButtonColumn.HeaderText = "Acción";
                editButtonColumn.Text = "Editar";
                editButtonColumn.UseColumnTextForButtonValue = true; // Hace que el texto sea visible
                D_Productos.Columns.Add(editButtonColumn);
                D_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                botonAgregado = true;
            }
            if (!botonElimina)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Btn_Elimina";
                deleteButtonColumn.HeaderText = "Acción";
                deleteButtonColumn.Text = "Eliminar";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                D_Productos.Columns.Add(deleteButtonColumn);
                D_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                botonElimina = true;
            }

            // Ajustar las columnas si es necesario
            //D_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (DTA != null && DTA.Rows.Count>0)
            {
                D_Productos.DataSource = DTA;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdMat = Convert.ToInt32(D_Productos.Rows[e.RowIndex].Cells[0].Value);
            string Descr = D_Productos.Rows[e.RowIndex].Cells[1].Value.ToString();
            string colM = D_Productos.Rows[e.RowIndex].Cells[2].Value.ToString();
            string unidad = D_Productos.Rows[e.RowIndex].Cells[3].Value.ToString();
            decimal costM = Convert.ToDecimal(D_Productos.Rows[e.RowIndex].Cells[4].Value);
            string prov = D_Productos.Rows[e.RowIndex].Cells[5].Value.ToString();
            string codM = D_Productos.Rows[e.RowIndex].Cells[6].Value.ToString();
            string clasifM = D_Productos.Rows[e.RowIndex].Cells[8].Value.ToString();
            string espesor = D_Productos.Rows[e.RowIndex].Cells[9].Value.ToString();

            if (e.RowIndex >= 0 && D_Productos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (D_Productos.Columns[e.ColumnIndex].Name == "Btn_Modifica")
                {
                    var nuevoMaterial = new NuevoMaterial
                    {
                        IdMater = IdMat,
                        DescrMat = Descr,
                        ColMat = colM,
                        costMat = costM,
                        CodMat = codM,
                        provM = prov,
                        unidadM = unidad,
                        Clasifi = clasifM,
                        EspesorMat = espesor
                    };

                    nuevoMaterial.materialInsertado += (s, args) => Get_ObtenProductos();
                    nuevoMaterial.Show();
                }
                else if (D_Productos.Columns[e.ColumnIndex].Name == "Btn_Elimina")
                {
                    var result = MessageBox.Show("¿Estás seguro de que deseas continuar?",
                             "Confirmación",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Acción a realizar si el usuario selecciona "Sí"
                        var res = Cta.Set_EliminaMaterial(IdMat);
                        if (res == 1)
                        {
                            MessageBox.Show("El material se eliminó correctamente.");
                            Get_ObtenProductos();
                        }
                    }
                    else
                    {
                        // Acción a realizar si el usuario selecciona "No"
                        MessageBox.Show("La acción ha sido cancelada.");
                    }

                }
            }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)D_Productos.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("Descripcion like '%{0}%'", Txt_Busca.Text);
            }
        }
    }
}
