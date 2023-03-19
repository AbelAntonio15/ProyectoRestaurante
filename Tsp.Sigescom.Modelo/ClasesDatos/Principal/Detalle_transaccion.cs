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
    
    public partial class Detalle_transaccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detalle_transaccion()
        {
            this.Referencia_detalle_transaccion = new HashSet<Referencia_detalle_transaccion>();
            this.Valor_detalle_maestro_detalle_transaccion = new HashSet<Valor_detalle_maestro_detalle_transaccion>();
        }
    
        public long id { get; set; }
        public long id_transaccion { get; set; }
        public decimal cantidad { get; set; }
        public int id_concepto_negocio { get; set; }
        public string detalle { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal total { get; set; }
        public Nullable<int> id_precio { get; set; }
        public decimal cantidad_secundaria { get; set; }
        public Nullable<int> indicadorMultiproposito { get; set; }
        public Nullable<int> id_cuenta_contable { get; set; }
        public decimal isc { get; set; }
        public decimal igv { get; set; }
        public decimal descuento { get; set; }
        public string lote { get; set; }
        public Nullable<System.DateTime> vencimiento { get; set; }
        public string registro { get; set; }
        public byte[] version_fila { get; set; }
        public decimal cantidad_1 { get; set; }
    
        public virtual Concepto_negocio Concepto_negocio { get; set; }
        public virtual Cuenta_contable Cuenta_contable { get; set; }
        public virtual Transaccion Transaccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referencia_detalle_transaccion> Referencia_detalle_transaccion { get; set; }
        public virtual Precio Precio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Valor_detalle_maestro_detalle_transaccion> Valor_detalle_maestro_detalle_transaccion { get; set; }
    }
}
