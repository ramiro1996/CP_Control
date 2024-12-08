using System;

namespace CP_Control.CP_Control.Modelos 
{
    public class ProductosViewModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Espesor { get; set; }
        public string Color { get; set; }
        public string Clasificacion { get; set; }
        public string Unidad { get; set; }
        public decimal Costo { get; set; }
        public int IdProveedor { get; set; }
        public string Codigo { get; set; }
    }
    public class ProveedorViewModel 
    {
        public string Proveedor { get; set; }
        public string RFC { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string CP { get; set; }
        public int Telefono { get; set; }
        public string Contacto { get; set; }
        public string CargoContacto {  get; set; }
        public int TelContacto { get;set; }
        public string Correo { get; set; }
        public string TipoProveedor { get; set; }
    }
    public class ProyectosViewModel 
    {
        public int IdProyecto { get; set; }
        public string Proyecto { get;set;}
        public int Cliente { get; set; }
        public string Direccion { get; set; }
        public string Codigo { get; set; }
        public string FInicio { get; set; }
        public string FEntrega { get; set; }
    }

}
