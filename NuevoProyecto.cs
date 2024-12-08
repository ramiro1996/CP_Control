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
    public partial class NuevoProyecto : Form
    {
        public event EventHandler ProyectoInsertado;
        Consultas Cta = new Consultas();
        private Proyectos _proyectos;
        private string OpcionParaCalendario = "";

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
            string FInicio = Txt_FRegistro.Text.Trim();
            string FEntrega = Txt_FEntrega.Text.Trim();
            if (string.IsNullOrEmpty(FInicio)) 
            {
                FInicio = "0";
                if (string.IsNullOrEmpty(FEntrega))
                {
                    FEntrega = "0";
                }
            }

            if (Proyecto != "" || Direccion != "" || Codigo != "")
            {
                var proyectoNuevo = new ProyectosViewModel 
                {
                    IdProyecto = idproyecto,
                    Proyecto = Proyecto,
                    Cliente = Cliente,
                    Direccion = Direccion,
                    Codigo = Codigo,
                    FInicio = FInicio,
                    FEntrega = FEntrega
                };
                var resul = Cta.Set_InsertaNuevoProyecto(proyectoNuevo);
                ProyectoInsertado?.Invoke(this, EventArgs.Empty);
                this.Close();
                if (resul == 2)
                {
                    MessageBox.Show("Registro guardado correctamente");
                }

            }
            else
            {
                MessageBox.Show("Ocurrio un error.");

            }
        }

        private void NuevoProyecto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcionParaCalendario = "FInicio";
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (OpcionParaCalendario == "FInicio")
            {
                Txt_FRegistro.Text = e.Start.ToString("yyyy-MM-dd");
            }
            else if (OpcionParaCalendario == "FEntrega")
            {
                Txt_FEntrega.Text = e.Start.ToString("yyyy-MM-dd");
            }
            monthCalendar1.Visible = false;
        }

        private void Btn_FEntrega_Click(object sender, EventArgs e)
        {
            OpcionParaCalendario = "FEntrega";
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }
    }
}
