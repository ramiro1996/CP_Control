using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Control.CP_Control
{
    class ManejadorBDSQL:ManejadorBaseDatos
    {
        public ManejadorBDSQL()
        {
           sqlconex = new SqlConnection(@"Data Source=AMTI00288-LAPTO; initial catalog=Carpitectura_Pizana; Integrated Security=true;");
        
        }

        SqlConnection sqlconex;
        SqlCommand sqlcom;
         public override System.Data.DataSet ConsultarTablaBD(string consulta)
        {
            try
            {
                System.Data.DataSet dataSet1 = new System.Data.DataSet();
                sqlcom = new SqlCommand(consulta, sqlconex);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                sqlconex.Open();
                dataAdapter.SelectCommand = sqlcom;
                dataAdapter.Fill(dataSet1, "Id");
                sqlconex.Close();
                return (dataSet1);
            }
            catch { sqlconex.Close(); return null; }
        }
        public override object ConsultaEscalarBD(string consulta)
        {
            object valor;
            sqlcom = new SqlCommand(consulta, sqlconex);
            sqlconex.Open();
            valor = sqlcom.ExecuteScalar();
            sqlconex.Close();
            return valor;
        }
        public override void InsertaModificaBD(string consulta)
        {
            sqlcom = new SqlCommand(consulta, sqlconex);
            sqlconex.Open();
            sqlcom.ExecuteNonQuery();
            sqlconex.Close();
        }
        public override int InsertaRegC(string consulta)
        {
            int filasAfectadas;
                try
            {
                sqlcom = new SqlCommand(consulta, sqlconex);
                sqlconex.Open();

                filasAfectadas = sqlcom.ExecuteNonQuery();
                sqlconex.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error de conexión"+e.Message);
                sqlconex.Close() ;  
                filasAfectadas = -1;
            }
            return filasAfectadas;
        }
    }
}
