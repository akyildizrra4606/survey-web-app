//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Secenekler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Secenekler()
        {
            this.Yanitlar = new HashSet<Yanitlar>();
        }
    
        public int Secenek_ID { get; set; }
        public string Secenek_Adi { get; set; }
        public Nullable<int> Soru_ID { get; set; }
    
        public virtual Sorular Sorular { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yanitlar> Yanitlar { get; set; }
    }
}
