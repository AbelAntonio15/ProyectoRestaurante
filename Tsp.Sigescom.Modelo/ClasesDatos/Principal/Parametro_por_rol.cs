//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tsp.Sigescom.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parametro_por_rol
    {
        public int id { get; set; }
        public int id_rol { get; set; }
        public int id_parametro { get; set; }
        public int numero_orden { get; set; }
        public int tipo { get; set; }
    
        public virtual Detalle_maestro Detalle_maestro { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
