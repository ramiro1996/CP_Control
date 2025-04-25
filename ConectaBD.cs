using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CP_Control
{
    public class ConectaBD
    {
        //CADENA DE CONEXION
        
        private string connectionString = @"Server = LAPTOP-905179I3; Carpitectura_Pizana; Integrated Security = True;";

        //METODO PARA ABRIR LA CONEXION 

        public SqlConnection AbreConeccion()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Conectado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexion"+ex.Message);
            }
            return conn;
           
        }
        public void CerrarConexion(SqlConnection Conn)
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                    MessageBox.Show("Conexion cerrada correctamente.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cerrar la conexion."+e.Message);

            }
        }

        public DataTable EjecutarConsulta(string Consulta)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Conn = AbreConeccion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(Consulta, Conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta" + ex.Message);

                }
                finally
                {
                    CerrarConexion(Conn);
                }

            }
            return dt;
        }

        public bool EjecutaComando(string Consulta) 
        {
            bool bRet = false;
            using (SqlConnection Conn = AbreConeccion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(Consulta, Conn);
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0) { bRet = true; }
                    MessageBox.Show("Comando ejecutado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al ejecutar el comando");
                }
                finally
                {
                    CerrarConexion(Conn);
                }
            }
            return bRet;
        } 
    }
}
