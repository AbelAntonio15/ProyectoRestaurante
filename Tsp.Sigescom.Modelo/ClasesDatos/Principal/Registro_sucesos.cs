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
    
    public partial class Registro_sucesos
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string ubicacion { get; set; }
        public string suceso { get; set; }
        public Nullable<int> nivel { get; set; }
        public Nullable<int> id_destinatario { get; set; }
    
        public virtual Rol Rol { get; set; }
    }
}
