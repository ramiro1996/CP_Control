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
        private bool Btn_ModificaEmp;
        private bool Btn_EliminaEmp;

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
            G_Trabajadores.Columns["Password"].DataPropertyName = "Password";
            G_Trabajadores.Columns["Telefono"].DataPropertyName = "Telefono";
            G_Trabajadores.Columns["Direccion"].DataPropertyName = "Direccion";
            G_Trabajadores.Columns["Correo"].DataPropertyName = "Correo";

            if (!Btn_ModificaEmp) 
            {
                DataGridViewButtonColumn Btn_ModificaTrab = new DataGridViewButtonColumn();
                Btn_ModificaTrab.Name = "Btn_ModificaE";
                Btn_ModificaTrab.HeaderText = "Editar";
                Btn_ModificaTrab.Text = "Editar";
                Btn_ModificaTrab.UseColumnTextForButtonValue = true;
                G_Trabajadores.Columns.Add(Btn_ModificaTrab);
                G_Trabajadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Btn_ModificaEmp = true;
            }
            if (!Btn_EliminaEmp)
            {
                DataGridViewButtonColumn Btn_EliminaTrab = new DataGridViewButtonColumn();
                Btn_EliminaTrab.Name = "Btn_EliminaE";
                Btn_EliminaTrab.HeaderText = "Eliminar";
                Btn_EliminaTrab.Text = "Eliminar";
                Btn_EliminaTrab.UseColumnTextForButtonValue = true;
                G_Trabajadores.Columns.Add(Btn_EliminaTrab);
                G_Trabajadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Btn_EliminaEmp = true;
            }

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
            int idEmp = Convert.ToInt32(G_Trabajadores.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nomEmp = G_Trabajadores.Rows[e.RowIndex].Cells[1].Value.ToString();
            string apPaterno = G_Trabajadores.Rows[e.RowIndex].Cells[2].Value.ToString();
            string apMaterno = G_Trabajadores.Rows[e.RowIndex].Cells[3].Value.ToString();
            string puestoT = G_Trabajadores.Rows[e.RowIndex].Cells[4].Value.ToString();
            string nivelT = G_Trabajadores.Rows[e.RowIndex].Cells[5].Value.ToString();
            string usrT = G_Trabajadores.Rows[e.RowIndex].Cells[6].Value.ToString();
            decimal sueldoTr = Convert.ToDecimal(G_Trabajadores.Rows[e.RowIndex].Cells[7].Value);
            string pswT = G_Trabajadores.Rows[e.RowIndex].Cells[9].Value.ToString();
            int telT = Convert.ToInt32(G_Trabajadores.Rows[e.RowIndex ].Cells[10].Value);
            string direccT = G_Trabajadores.Rows[e.RowIndex].Cells[11].Value.ToString();
            string correoT = G_Trabajadores.Rows[e.RowIndex].Cells[12].Value.ToString();

            if (e.RowIndex >= 0 && G_Trabajadores.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (G_Trabajadores.Columns[e.ColumnIndex].Name=="Btn_ModificaE")
                {
                    var modTrabajador = new NuevoTrabajador
                    {
                        IdTra = idEmp,
                        nomTra = nomEmp,
                        apPat = apPaterno,
                        apMat = apMaterno,
                        puestoTra = puestoT,
                        sueldoTra = sueldoTr,
                        nivelTra = nivelT,
                        usuarioTra = usrT,
                        passTra = pswT,
                        telTra = telT,
                        direcTra = direccT,
                        correoTra = correoT                        
                    };
                    modTrabajador.TrabajadorInsertado += (s, args) => Get_Trabajadores();
                    modTrabajador.Show();
                }
                else if (G_Trabajadores.Columns[e.ColumnIndex].Name == "Btn_EliminaE")
                {
                    var opcion = MessageBox.Show("¿Estás seguro de que deseas continuar?",
                                                  "Confirmación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes)
                    {
                        var accion = Cta.Set_EliminaUsuario(idEmp);

                        if (accion == 1)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");
                            Get_Trabajadores();
                        }
                        else if (accion == 0)
                        {
                            MessageBox.Show("Ocurrio un error.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La acción ha sido cancelada.");
                    }

                }
            }
        }

        private void Btn_Trabajadores_Click(object sender, EventArgs e)
        {
            var nuevoTrabajadorForm = new NuevoTrabajador();
            nuevoTrabajadorForm.TrabajadorInsertado += (s, args) => Get_Trabajadores();
            nuevoTrabajadorForm.Show();
        }

        private void Txt_BuscaEmp_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)G_Trabajadores.DataSource;
            if (dt.Rows.Count > 0) 
            {
                dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%'",Txt_BuscaEmp.Text);
            }
        }
    }
}
