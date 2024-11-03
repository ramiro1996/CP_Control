using CP_Control.CP_Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Control
{
    public class Consultas
    {
        ManejadorBDSQL MBD;
        public Consultas() { 
        
            MBD = new ManejadorBDSQL();
        }

        #region Proyectos
        public DataTable ConsultaProyectos()
        {
            string consulta = "EXEC CP_Proyectos_ConsultaProyectos";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Set_CargaClientes()
        {
            string consulta = "SELECT Id,Nombre FROM CP_CLIENTES";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public void Set_InsertaNuevoProyecto(int idProyecto, string proyecto, int idCliente, string direccion, string codigo)
        {
            string consulta = "EXEC CP_Proyectos_InsertaModifica @CP_idProyecto="+idProyecto+", @CP_Proyecto='"+proyecto+"',@CP_IdCliente="+idCliente+", @CP_Direccion='"+direccion+"',@CP_Codigo='"+codigo+"'";
             MBD.InsertaModificaBD(consulta);
        }
        #endregion

        #region Clientes
        public DataTable Consulta_Clientes()
        {
            string consulta = "EXEC CP_Clientes_ConsultaClientes";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }

        public void Set_InsertaCliente(string cliente, string RFC, string direccion, string ciudad, string cp, string correo, string contacto, string telContacto) 
        {
            string consulta = "EXEC CP_Clientes_InsertaClientes @CP_IdCliente = 0, @CP_Nombre ='"+cliente+"', @CP_RFC='"+RFC+"',@CP_Direccion='"+direccion+"' ,@CP_Ciudad ='"+ciudad+"', @CP_CP ='"+cp+"', @CP_Nombre_contacto ='"+contacto+"',@CP_Correo ='"+correo+"', @CP_IdRegistro =1, @CP_TelContacto ='"+telContacto+"'";
            MBD.InsertaModificaBD(consulta);
        }
        #endregion
    }
}
