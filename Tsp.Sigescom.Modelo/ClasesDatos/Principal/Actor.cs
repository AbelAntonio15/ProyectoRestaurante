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
    
    public partial class Actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actor()
        {
            this.Direccion = new HashSet<Direccion>();
            this.Atributo_actor = new HashSet<Atributo_actor>();
            this.Actor_negocio = new HashSet<Actor_negocio>();
            this.Parentesco = new HashSet<Parentesco>();
            this.Parentesco1 = new HashSet<Parentesco>();
        }
    
        public int id { get; set; }
        public int id_documento_identidad { get; set; }
        public string numero_documento_identidad { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public string telefono { get; set; }
        public int id_tipo_actor { get; set; }
        public long id_foto { get; set; }
        public int id_clase_actor { get; set; }
        public int id_estado_legal { get; set; }
        public string correo { get; set; }
        public string tercer_nombre { get; set; }
        public string pagina_web { get; set; }
        public string informacion_multiproposito { get; set; }
        public Nullable<int> id_detalle_multiproposito { get; set; }
        public Nullable<int> id_detalle_multiproposito1 { get; set; }
    
        public virtual Detalle_maestro Detalle_maestro { get; set; }
        public virtual Detalle_maestro Detalle_maestro1 { get; set; }
        public virtual Detalle_maestro Detalle_maestro2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Direccion> Direccion { get; set; }
        public virtual Clase_actor Clase_actor { get; set; }
        public virtual Tipo_actor Tipo_actor { get; set; }
        public virtual Estado_legal Estado_legal { get; set; }
        public virtual Foto Foto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atributo_actor> Atributo_actor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor_negocio> Actor_negocio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parentesco> Parentesco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parentesco> Parentesco1 { get; set; }
    }
}