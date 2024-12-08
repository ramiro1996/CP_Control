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

namespace CP_Control
{
    public partial class NuevoMaterial : Form
    {
        //public event EventHandler MaterialGuardado;
        Consultas Cta = new Consultas();
        public event EventHandler materialInsertado;


        public int IdMater {  get; set; }
        public string DescrMat {  get; set; }
        public string EspesorMat {  get; set; }
        public string ColMat {  get; set; }
        public string CodMat { get; set; }
        public decimal costMat { get; set; }
        public string provM {  get; set; }
        public string unidadM { get; set; }
        public string Clasifi {  get; set; }
        public string espesorM { get; set; }

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
        #region CargaMateriales
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
                D_ClasificacionM.ValueMember= "Tipo";
                D_ClasificacionM.DataSource = dt;
            }

        }
        #endregion

        private string creaCodigoMaterial(params TextBox[] textBoxes) 
        {
            string codigo = "";
            foreach(TextBox tb in textBoxes) 
            {
                if (!string.IsNullOrEmpty(tb.Text) && tb.Text.Length >= 2)
                {
                    codigo = tb.Text.Substring(0, 2).Trim().ToUpper();
                }
                else
                {
                    codigo += "--";
                }
            }
            return codigo;
        }
      

        private void Btn_GuardarM_Click(object sender, EventArgs e)
        {
            int idMater;
            string producto = Txt_DescripcionM.Text.Trim().ToUpper();
            string clasificacion = D_ClasificacionM.SelectedValue?.ToString();
            string espesor = Txt_EspesorM.Text.Trim().ToUpper();
            string color = Txt_ColorM.Text.Trim().ToUpper();
            int proveedor = Convert.ToInt32(D_ProveedorM.SelectedValue);
            string unidad = D_UM.SelectedValue?.ToString();
            decimal costo = Convert.ToDecimal(Txt_CostoM.Text.Trim());
            string codigo = Txt_CodigoM.Text.Trim().ToUpper();

            if (producto != null && producto !="")
            {
                if (codigo != null && codigo !="") 
                {
                    if (string.IsNullOrEmpty(Txt_IdMaterial.Text))
                    {
                        idMater = 0;
                    }
                    else
                    {
                        idMater = int.Parse(Txt_IdMaterial.Text);
                    }
                    var newProducto = new ProductosViewModel { 
                    Id = idMater,
                    Descripcion = producto,
                    Clasificacion = clasificacion,
                    Espesor = espesor,
                    Color = color,
                    IdProveedor = proveedor,
                    Unidad = unidad,
                    Costo = costo,
                    Codigo = codigo
                    };
                    var res = Cta.Set_InsertaMaterial(newProducto);
                    materialInsertado?.Invoke(sender, EventArgs.Empty);
                    this.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Producto insertado correctamente.");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("El código no puede estar vacío.");
                }
            }
            else
            {
                MessageBox.Show("Es necesario agregar una descripción.");
            }
        }

       

        private void NuevoMaterial_Load(object sender, EventArgs e)
        {
            Txt_IdMaterial.Text = IdMater.ToString();
            Txt_DescripcionM.Text = DescrMat;
            Txt_EspesorM.Text = EspesorMat;
            Txt_ColorM.Text = ColMat;
            Txt_CodigoM.Text = CodMat;
            Txt_CostoM.Text = costMat.ToString();
            
            if (provM != null)
            {
                D_ProveedorM.Text = provM.ToString();
                if (unidadM != null)
                {
                    D_UM.Text = unidadM.ToString();
                    if (Clasifi != null)
                    {
                        D_ClasificacionM.Text = Clasifi.ToString();
                    }
                }
            }
            else {
                CargaDrops();
            }
           
        }

        private void Txt_CostoM_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(Txt_CostoM.Text, out _))
            {
                Txt_CostoM.BackColor = Color.White;
                Txt_CostoM.ForeColor = Color.Black;
            }
            else
            {
                Txt_CostoM.BackColor= Color.LightCoral;
                Txt_CostoM.ForeColor= Color.White;
                MessageBox.Show("El campo solo acepta valores decimales.");
            }
        }
    }
}
