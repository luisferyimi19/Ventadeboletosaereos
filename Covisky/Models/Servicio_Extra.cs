//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Covisky.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicio_Extra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio_Extra()
        {
            this.Boleto = new HashSet<Boleto>();
        }
    
        public decimal ser_ID { get; set; }
        public string ser_Nombre { get; set; }
        public string ser_Descripcion { get; set; }
        public Nullable<decimal> ser_Costo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boleto { get; set; }
    }
}
