//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal_RyN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int Id_Empleado { get; set; }
        public string Codigo_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> Id_Depto { get; set; }
        public Nullable<int> Id_Cargo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public bool Status { get; set; }
    }
}
