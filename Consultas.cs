
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
        public int Set_InsertaNuevoProyecto(ProyectosViewModel model)
        {
            string consulta = "EXEC CP_Proyectos_InsertaModifica @CP_idProyecto=" + model.IdProyecto + ", " +
                "@CP_Proyecto='" + model.Proyecto + "',@CP_IdCliente=" + model.Cliente + ", " +
                "@CP_Direccion='" + model.Direccion + "',@CP_Codigo='" + model.Codigo + "', " +
                "@CP_FInicio    = '" + model.FInicio + "', @CP_FEntrega   = '" + model.FEntrega + "' ";
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
        }
        public int Set_EliminaProyectos(int idProyecto) 
        {
            string consulta = "EXEC CP_Proyectos_EliminaProyecto @CP_IdProyecto = "+idProyecto;
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
        }
        #endregion

        #region Clientes
        public DataTable Consulta_Clientes()
        {
            string consulta = "EXEC CP_Clientes_Sel";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }

        public int Set_InsertaCliente(ClienteViewModel model) 
        {
            string consulta = "EXEC CP_Clientes_InsertaClientes @CP_IdCliente = "+model.IdCiente+", @CP_Nombre ='"+model.Cliente+"', @CP_RFC='"+model.RFCCli+"',@CP_Direccion='"+model.DirClien+"' ,@CP_Ciudad ='"+model.CiudClien+"', @CP_CP ='"+model.CPClien+"', @CP_Nombre_contacto ='"+model.ContaClnt+"',@CP_Correo ='"+model.CorreoC+"', @CP_IdRegistro = 1, @CP_TelContacto ='"+model.TelConClient+"'";
           var mov = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(mov);
        }
        public int Set_EliminaCliente(int IdClnt) 
        {
            string consulta = "EXEC CP_Clientes_EliminaClientes @CP_IdCliente ="+IdClnt;
            var mov = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(mov);
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
            string consulta = "EXEC CP_Puesto_Sel";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public DataTable Get_Nivel()
        {
            string consulta = "EXEC CP_Nivel_Sel";
            return MBD.ConsultarTablaBD(consulta).Tables[0];
        }
        public int Set_InsertaTrabajador(TrabajadoresViewModel model)
        {
            string consulta = "EXEC CP_Usuarios_UsuariosInserta @CP_Nombre = '" + model.nombreT+"', @CP_Ap_Paterno ='"+model.aPaternoT+"', @CP_Ap_Materno ='"+model.aMaternoT+"', @CP_Puesto ="+model.puestoT+", @CP_Nivel ="+model.nivelT+", @CP_Usuario ='"+model.usuarioT+"', @CP_Password   ='"+model.pswT+"', @CP_Telefono   ="+model.telT+",@CP_Direccion  ='"+model.direcT+"', @CP_Correo = '"+model.emailT+"', @CP_Sueldo ="+model.sueldoT+",@CP_IdUsuariO  = "+model.IdT;
             
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
        }
        public int Set_EliminaUsuario(int IdUsr)
        {
            string consulta = "EXEC CP_Usuarios_EliminaUsuarios @CP_IdUsuario = " + IdUsr;
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
        }
        public int Set_ActivaRegistro(int idReg, string tipoReg)
        {
            string consulta = "EXEC CP_ActivaRegistros @CP_IdRegistro="+idReg+ ", @CP_TipoRegistro='"+tipoReg+"'";
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
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
        public int Set_InsertaMaterial(ProductosViewModel model) 
        {
            string consulta = "EXEC CP_Producto_ProductoInserta @CP_IdArticulo ="+model.Id+" ,@CP_Articulo ='" + model.Descripcion+"', @CP_Espesor = '"+model.Espesor+"', @CP_Color ='"+model.Color+"', @CP_Clasificacion ='"+model.Clasificacion+"', @CP_UM = '"+model.Unidad+"',@CP_Costo ="+model.Costo+", @CP_IdProveedor = "+model.IdProveedor+", @CP_Codigo = '"+model.Codigo+"'";
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
        }
        public int Set_EliminaMaterial(int idMaterial)
        {
            string consulta = "EXEC CP_Producto_ProductoElimina @CP_IdProducto ="+idMaterial;
            var res = MBD.ConsultaEscalarBD(consulta);
            return Convert.ToInt32(res);
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
