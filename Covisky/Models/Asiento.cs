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
    
    public partial class Asiento
    {
        public decimal asi_No_Asiento { get; set; }
        public string asi_Nombre { get; set; }
        public string asi_Ubicacion { get; set; }
        public Nullable<decimal> asi_cla_ID { get; set; }
    
        public virtual Clase Clase { get; set; }
    }
}
