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
    
    public partial class Parametro_transaccion
    {
        public int id { get; set; }
        public long id_transaccion { get; set; }
        public int id_parametro { get; set; }
        public Nullable<int> id_valor_parametro { get; set; }
        public string valor { get; set; }
    
        public virtual Detalle_maestro Detalle_maestro { get; set; }
        public virtual Transaccion Transaccion { get; set; }
    }
}