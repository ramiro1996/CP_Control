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

        public int IdPryto { get; set; }
        public string NombreProy { get; set; }
        public string DirProy { get; set; }
        public string CodProy { get; set; }
        public string FechInicio { get; set; }
        public string FechEntrega { get; set; }
        public string NombreCliente { get; set; }
        public bool estadoCreado { get; set; }
        public string EstadoTex { get; set; }
        public int StatusProy {  get; set; }

        public NuevoProyecto()
        {
            InitializeComponent();
            Set_Cliente();
            Get_Status();
        }
        

        public void Set_Cliente()
        {
            DataTable dt = Cta.Set_CargaClientes();
            if (dt != null && dt.Rows.Count > 0)
            {
                D_Cliente.DisplayMember = "cliente_Nombre";
                D_Cliente.ValueMember = "cliente_Id";
                D_Cliente.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Datos no encontrados.");
            }

        }
        public void Get_Status() 
        {
            int plantilla = 1;
            int tipo = 1;
            DataTable dt = Cta.Get_parametrosGenerales(plantilla, tipo);
            if (dt != null && dt.Rows.Count > 0)
            {
                D_Estado.DisplayMember = "StatusProy_Descrip";
                D_Estado.ValueMember = "StatusProy_Id";
                D_Estado.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Datos no encontrados.");
            }
        }

        private void Btn_GuardarProyecto_Click(object sender, EventArgs e)
        {
            int idproyecto;
            string Proyecto = Txt_Proyecto.Text.Trim();
            int Cliente = Convert.ToInt32(D_Cliente.SelectedValue);
            string Direccion = Txt_Direccion.Text.Trim();
            string Codigo = Txt_Codigo.Text.Trim();
            string FInicio = Txt_FRegistro.Text.Trim();
            string FEntrega = Txt_FEntrega.Text.Trim();
            int st = Convert.ToInt32(D_Estado.SelectedValue);

            if (string.IsNullOrEmpty(FInicio)) 
            {
                FInicio = "";
                if (string.IsNullOrEmpty(FEntrega))
                {
                    FEntrega = "";
                }
            }
            
            if (Proyecto != "" || Direccion != "" || Codigo != "")
            {
                if (string.IsNullOrEmpty(Txt_IdProy.Text))
                {
                    idproyecto = 0;
                }
                else
                {
                    idproyecto = int.Parse(Txt_IdProy.Text);
                }
                var proyectoNuevo = new ProyectosViewModel 
                {
                    IdProyecto = idproyecto,
                    Proyecto = Proyecto,
                    Cliente = Cliente,
                    Direccion = Direccion,
                    Codigo = Codigo,
                    FInicio = FInicio,
                    FEntrega = FEntrega,
                    status = st
                };
                var resul = Cta.Set_InsertaNuevoProyecto(proyectoNuevo);
                ProyectoInsertado?.Invoke(this, EventArgs.Empty);
                this.Close();
                if (resul == 1)
                {
                    MessageBox.Show("Registro guardado correctamente.");
                }
                else if (resul == 2)
                {
                    MessageBox.Show("Registro modificado correctamente.");
                }

            }
            else
            {
                MessageBox.Show("Ocurrio un error.");

            }
        }

        private void NuevoProyecto_Load(object sender, EventArgs e)
        {
            Txt_IdProy.Text = IdPryto.ToString();
            Txt_Proyecto.Text = NombreProy;
            Txt_Direccion.Text = DirProy;
            Txt_Codigo.Text = CodProy;
            if (DateTime.TryParse(FechInicio, out DateTime fecha))
            {
                Txt_FRegistro.Text = fecha.ToString("yyyy-MM-dd");
            }
           
            if (DateTime.TryParse(FechEntrega, out DateTime fechaE))
            {
                Txt_FEntrega.Text = fechaE.ToString("yyyy-MM-dd");

            }
            
            if (NombreCliente != null)
            {
                D_Cliente.Text = NombreCliente.ToString();
            }
            else
            {
                Set_Cliente();
            }
            if (EstadoTex != null)
            {
                D_Estado.Text = EstadoTex.ToString();
            }
            else
            {
                Get_Status();
            }
            if (estadoCreado)
            {

                D_Estado.Visible = true;
                L_EstadoP.Visible = true;
            }
            else
            {
                D_Estado.Visible = false;
                L_EstadoP.Visible = false;
            }
            
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
