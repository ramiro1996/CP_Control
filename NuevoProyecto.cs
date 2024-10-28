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
    public partial class NuevoProyecto : Form
    {
        public event EventHandler ProyectoInsertado;
        Consultas Cta = new Consultas();
        private Proyectos _proyectos;
        public NuevoProyecto()
        {
            InitializeComponent();
            Set_Cliente();
        }
        

        public void Set_Cliente()
        {
            DataTable dt = Cta.Set_CargaClientes();
            if (dt != null && dt.Rows.Count > 0)
            {
                D_Cliente.DisplayMember = "Nombre";
                D_Cliente.ValueMember = "Id";
                D_Cliente.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Datos no encontrados");
            }

        }

        private void Btn_GuardarProyecto_Click(object sender, EventArgs e)
        {
            int idproyecto = 0;
            string Proyecto = Txt_Proyecto.Text.Trim();
            int Cliente = Convert.ToInt32(D_Cliente.SelectedValue);
            string Direccion = Txt_Direccion.Text.Trim();
            string Codigo = Txt_Codigo.Text.Trim();
            if (Proyecto != "" || Direccion != "" || Codigo != "")
            {
                Cta.Set_InsertaNuevoProyecto(idproyecto, Proyecto, Cliente, Direccion, Codigo);
                MessageBox.Show("Registro guardado correctamente");
                ProyectoInsertado?.Invoke(this, EventArgs.Empty);

                this.Close();

            }
            else
            {
                MessageBox.Show("Ocurrio un error.");

            }
        }
    }
}
