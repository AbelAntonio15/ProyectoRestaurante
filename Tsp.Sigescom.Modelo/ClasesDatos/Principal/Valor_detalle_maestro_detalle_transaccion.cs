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
    
    public partial class Valor_detalle_maestro_detalle_transaccion
    {
        public int id { get; set; }
        public long id_detalle_transaccion { get; set; }
        public int numero { get; set; }
        public int id_detalle_maestro { get; set; }
        public Nullable<int> id_valor_detalle_maestro { get; set; }
        public string valor { get; set; }
    
        public virtual Detalle_maestro Detalle_maestro { get; set; }
        public virtual Detalle_transaccion Detalle_transaccion { get; set; }
    }
}