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
    
    public partial class Estado_transaccion
    {
        public int id { get; set; }
        public long id_transaccion { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public int id_estado { get; set; }
        public System.DateTime fecha { get; set; }
        public string comentario { get; set; }
    
        public virtual Actor_negocio Actor_negocio { get; set; }
        public virtual Detalle_maestro Detalle_maestro { get; set; }
        public virtual Transaccion Transaccion { get; set; }
    }
}