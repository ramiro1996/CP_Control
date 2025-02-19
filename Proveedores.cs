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
    public partial class Proveedores : Form
    {
        Consultas Cta = new Consultas();

        bool Btn_EditaPrv = false;
        bool Btn_EliminaPrv = false;

        public Proveedores()
        {
            InitializeComponent();
            Get_Proveedor();
        }
        public void Get_Proveedor()
        {
            DataTable dta = Cta.Get_Proveedor();
            G_Proveedor.AutoGenerateColumns=false;

            G_Proveedor.Columns["Id"].DataPropertyName="ID";
            G_Proveedor.Columns["RSocial"].DataPropertyName="RSocial";
            G_Proveedor.Columns["NombreContacto"].DataPropertyName="Contacto";
            G_Proveedor.Columns["Telefono"].DataPropertyName = "Telefono";
            G_Proveedor.Columns["Direccion"].DataPropertyName = "Direccion";
            G_Proveedor.Columns["Correo"].DataPropertyName = "Correo";
            G_Proveedor.Columns["RFC"].DataPropertyName = "RFC";
            G_Proveedor.Columns["Cargo_Contacto"].DataPropertyName = "Cargo_Contacto";
            G_Proveedor.Columns["CP"].DataPropertyName = "CP";
            G_Proveedor.Columns["Ciudad"].DataPropertyName = "Ciudad";
            G_Proveedor.Columns["Telefono_Cont"].DataPropertyName = "Telefono_Cont";
            G_Proveedor.Columns["Descripcion"].DataPropertyName = "Descripcion";

            if (!Btn_EditaPrv)
            {
                DataGridViewButtonColumn BtnEditaPrv = new DataGridViewButtonColumn();
                BtnEditaPrv.Name = "Edita_Prv";
                BtnEditaPrv.HeaderText = "Edita";
                BtnEditaPrv.Text = "Edita";
                BtnEditaPrv.UseColumnTextForButtonValue = true;
                G_Proveedor.Columns.Add(BtnEditaPrv);
                G_Proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                Btn_EditaPrv = true;

            }

            if (dta != null && dta.Rows.Count>0)
            {
                G_Proveedor.DataSource = dta;
            }
        }

        private void Btn_CerrarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_NuevoProveedor_Click(object sender, EventArgs e)
        {
            var NuevoProveedor = new NuevoProveedor();
            NuevoProveedor.ProveedorNuevo += (s, args)=> Get_Proveedor();
            NuevoProveedor.Show();

        }

        private void G_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idP = Convert.ToInt32(G_Proveedor.Rows[e.RowIndex].Cells[0].Value);
            string NomP = G_Proveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            string NomContP = G_Proveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            string TelP = G_Proveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
            string DirecP = G_Proveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            string CorreoP = G_Proveedor.Rows[e.ColumnIndex].Cells[5].ToString();
            string RFCP = G_Proveedor.Rows[e.RowIndex ].Cells[6].ToString();
            string CargoContP = G_Proveedor.Rows[e.RowIndex].Cells[7].ToString();
            string CPP = G_Proveedor.Rows[e.RowIndex].Cells[8].Value.ToString();
            string CiudadP = G_Proveedor.Rows[e.RowIndex].Cells[9].Value.ToString();
            string TelContP = G_Proveedor.Rows[e.RowIndex].Cells[10].Value.ToString();
            string TipoP = G_Proveedor.Rows[e.RowIndex].Cells[11].Value.ToString();

            if (e.RowIndex > 0 && G_Proveedor.Columns[e.ColumnIndex] is DataGridViewColumn)
            {
                if (G_Proveedor.Columns[e.ColumnIndex].Name == "Edita_Prv")
                {
                    var nvoProveedor = new NuevoProveedor 
                    {
                        IdPrv = idP,
                        NomPrv = NomP,
                        ContPrv = NomContP,
                        TelPrv = Convert.ToInt32(TelP),
                        DirecPrv = DirecP,
                        EmailPrv = CorreoP,
                        RFCPrv = RFCP,
                        CargContPrv = CargoContP,
                        CPPrv = CPP,
                        CiudadPrv = CiudadP, 
                        TelContPrv = TelContP,
                        TipoPrv = TipoP                        
                    };
                }

            }
        }
    }
}
