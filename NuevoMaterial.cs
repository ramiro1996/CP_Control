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
    public partial class NuevoMaterial : Form
    {
        Consultas Cta = new Consultas();
        public event EventHandler materialInsertado;

        public NuevoMaterial()
        {
            InitializeComponent();
            CargaDrops();
        }

        public void CargaDrops()
        {
            Get_Unidad();
            Get_Proveedor();
            Get_CargaClasificacion();
        }

        public void Get_Unidad() 
        {
            DataTable dt = Cta.Get_UnidadMedida();
            if (dt != null && dt.Rows.Count>0)
            {
                D_UM.DisplayMember = "Descripcion";
                D_UM.ValueMember = "Unidad";
                D_UM.DataSource = dt;
            }
        }
        
        public void Get_Proveedor()
        {
            DataTable dt = Cta.Get_Proveedor();
            if (dt != null && dt.Rows.Count>0)
            {
                D_ProveedorM.DisplayMember = "RSocial";
                D_ProveedorM.ValueMember = "Id";
                D_ProveedorM.DataSource = dt;
            }

        }
        public void Get_CargaClasificacion() 
        {
            DataTable dt = Cta.Get_Clasificacion();
            if (dt != null && dt.Rows.Count>0)
            {
                D_ClasificacionM.DisplayMember = "Descripcion";
                D_ClasificacionM.ValueMember= "Id";
                D_ClasificacionM.DataSource = dt;
            }

        }

        private void Btn_GuardarM_Click(object sender, EventArgs e)
        {

        }
    }
}
