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
    
    public partial class Yanitlar
    {
        public int Yanit_ID { get; set; }
        public Nullable<int> Anket_ID { get; set; }
        public Nullable<int> Soru_ID { get; set; }
        public Nullable<int> Secenek_ID { get; set; }
    
        public virtual Anketler Anketler { get; set; }
        public virtual Secenekler Secenekler { get; set; }
        public virtual Sorular Sorular { get; set; }
    }
}
