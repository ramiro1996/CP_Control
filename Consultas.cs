using CP_Control.CP_Control;
using CP_Control.CP_Control.Modelos;
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

        #region Trabajadores
        public DataTable Consulta_Trabajadores()
        {
            string consulta = "EXEC CP_Usuarios_ConsultaUsuarios";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Get_Puesto() 
        {
            string consulta = "SELECT ID, Area FROM CP_Grupo";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Get_Nivel()
        {
            string consulta = "SELECT ID, Nivel FROM CP_Nivel";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public void Set_InsertaTrabajador(string Trabajador, string Ap_Paterno, string Ap_Materno, int puesto, int nivel, string usr,string pass, int tel, string direccion, string correo, decimal sueldo)
        {
            string consulta = "EXEC CP_Usuarios_UsuariosInserta @LC_Nombre = '"+Trabajador+"', @LC_Ap_Paterno ='"+Ap_Paterno+"', @LC_Ap_Materno ='"+Ap_Materno+"', @LC_Puesto ="+puesto+", @LC_Nivel ="+nivel+", @LC_Usuario ='"+usr+"', @LC_Password   ='"+pass+"', @LC_Telefono   ="+tel+",@LC_Direccion  ='"+direccion+"', @LC_Correo = '"+correo+"', @LC_Sueldo ="+sueldo+",@Lc_IdUsuariO  = 0  ";
             MBD.InsertaModificaBD(consulta);
        }
        #endregion

        #region Productos
        public DataTable Get_Productos()
        {
            string consulta = "EXEC CP_Productos_ConsultaProyectos";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Get_UnidadMedida() 
        {
            string consulta = "EXEC CP_Unidad_ConsultaUnidadMedida";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Get_Proveedor()
        {
            string consulta = "EXEC CP_Proveedor_ConsultaProveedor";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Get_Clasificacion() 
        {
            string consulta = "EXEC CP_Clasificacion_ConsultaClasificacion";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public void Set_InsertaMaterial(ProductosViewModel model) 
        {
            string consulta = "EXEC CP_Producto_ProductoInserta @CP_Articulo ='"+model.Descripcion+"', @CP_Espesor = '"+model.Unidad+"', @CP_Color ='"+model.Color+"', @CP_Clasificacion ='"+model.Clasificacion+"', @CP_UM = '"+model.Unidad+"',@CP_Costo ="+model.Costo+", @CP_IdProveedor = "+model.IdProveedor+", @CP_Codigo = '"+model.Codigo+"'";
            MBD.InsertaModificaBD(consulta);
        }

        #endregion
        #region Proveedores
        public DataTable Get_TProveedor() 
        {
            string consulta = "EXEC CP_Clasificacion_ConsultaClasificacion";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public void Set_InsertaProveedor(ProveedorViewModel model) 
        {
            string consulta = "EXEC CP_Proveedor_ProveedorInserta @CP_Proveedor = '"+model.Proveedor+"', @CP_RFC = '"+model.RFC+"', @CP_Telefono ="+model.Telefono+", @CP_Nombre_contacto ='"+model.Contacto+"', @CP_Cargo_Contacto  ='"+model.CargoContacto+"', @CP_Direccion = '"+model.Direccion+"', @CP_CP ='"+model.CP+"', @CP_Ciudad = '"+model.Ciudad+"', @CP_Telefono_Cont = "+model.TelContacto+", @CP_Correo = '"+model.Correo+"', @CP_Tipo_Proveedor  ="+model.TipoProveedor;
            MBD.InsertaModificaBD(consulta);
        }
        #endregion
    }
}
