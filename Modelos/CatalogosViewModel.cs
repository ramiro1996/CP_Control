﻿using System;

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
        public int status { get; set; }
        public bool estadoCreado { get; set; }
    }
    public class ClienteViewModel
    {
        public int IdCiente { get; set; }
        public string Cliente { get; set; }
        public string RFCCli {  get; set; }
        public string DirClien { get; set; }
        public string CiudClien { get; set; }
        public string CPClien { get; set; }
        public string CorreoC { get; set; }
        public string ContaClnt { get; set; }
        public string TelConClient {  get; set; }
    }
    public class TrabajadoresViewModel
    {
        public int IdT { get; set; }
        public string nombreT { get; set; }
        public string aPaternoT { get; set; }
        public string aMaternoT { get; set; }
        public int puestoT { get; set; }
        public int nivelT { get; set; }
        public decimal sueldoT { get; set; }
        public string usuarioT { get; set; }
        public string pswT { get; set; }
        public string telT { get; set; }
        public string direcT { get; set; }
        public string emailT { get; set; }
        public bool estadoActivo { get; set; }
    }

}
