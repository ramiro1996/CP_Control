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
        private bool Btn_EditClient = false;
        private bool Btn_DeleteClient = false;

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
            G_Clientes.Columns["Ciudad"].DataPropertyName = "Ciudad";
            G_Clientes.Columns["CP"].DataPropertyName = "CP";
            G_Clientes.Columns["Nombre_Contacto"].DataPropertyName = "Nombre_Contacto";
            G_Clientes.Columns["Telefono"].DataPropertyName = "Telefono";
            if (!Btn_EditClient)
            {
                DataGridViewButtonColumn buttonEditaCliente = new DataGridViewButtonColumn();
                buttonEditaCliente.Name = "Btn_EditaCliente";
                buttonEditaCliente.HeaderText = "Editar";
                buttonEditaCliente.Text = "Editar";
                buttonEditaCliente.UseColumnTextForButtonValue = true;
                G_Clientes.Columns.Add(buttonEditaCliente);
                G_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Btn_EditClient = true;
            }
            if (!Btn_DeleteClient)
            {
                DataGridViewButtonColumn buttonEliminaCliente = new DataGridViewButtonColumn();
                buttonEliminaCliente.Name = "Btn_EliminaCliente";
                buttonEliminaCliente.HeaderText = "Eliminar";
                buttonEliminaCliente.Text = "Eliminar";
                buttonEliminaCliente.UseColumnTextForButtonValue = true;
                G_Clientes.Columns.Add(buttonEliminaCliente);
                G_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Btn_DeleteClient = true;
            }


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

        private void G_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdClien = Convert.ToInt32(G_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            string NomCliente = G_Clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            string RFCClte = G_Clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            string DirecClient = G_Clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            string CorreoC = G_Clientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            string Ciudad = G_Clientes.Rows[e.RowIndex].Cells[7].Value.ToString();
            string CP = G_Clientes.Rows[e.RowIndex].Cells[8].Value.ToString();
            string Contact = G_Clientes.Rows[e.RowIndex ].Cells[9].Value.ToString();
            string telC = G_Clientes.Rows[e.RowIndex].Cells[10].Value.ToString();

            if (e.RowIndex >= 0 && G_Clientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (G_Clientes.Columns[e.ColumnIndex].Name == "Btn_EditaCliente")
                {
                    var ModCliente = new NuevoCliente {
                    
                        IdCli = IdClien,
                        NomCliente = NomCliente,
                        RFCClien = RFCClte,
                        DirecCliente = DirecClient,
                        CDCliente = Ciudad,
                        EmailC = CorreoC,
                        CPClient = CP,
                        ContClient = Contact,
                        TelCont = telC
                    };
                 
                    ModCliente.ClienteNuevo += (s, args) => Get_Clientes();
                    ModCliente.Show();
                }
                else if (G_Clientes.Columns[e.ColumnIndex].Name == "Btn_EliminaCliente")
                {
                    var result = MessageBox.Show("¿Estas seguro de que quieres continuar?", "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       var accion = Cta.Set_EliminaCliente(IdClien);
                        if (accion == 1)
                        {
                            MessageBox.Show("Registro eliminado correctamente");
                            Get_Clientes();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al eliminar el registro.");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("La acción ha sido cancelada.");
                    }
                }
            }
        }

        private void Txt_BuscaCliente_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)G_Clientes.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%'", Txt_BuscaCliente.Text);
            }
        }
    }
}
