
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
    
public partial class Anketler
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Anketler()
    {

        this.Sorular = new HashSet<Sorular>();

        this.Yanitlar = new HashSet<Yanitlar>();

    }


    public int Anket_ID { get; set; }

    public string Anket_Adi { get; set; }

    public Nullable<System.DateTime> Anket_Baslangic_Tarih { get; set; }

    public Nullable<System.DateTime> Anket_Bitis_Tarih { get; set; }

    public Nullable<int> Anket_Katilim { get; set; }

    public Nullable<bool> Anket_Durum { get; set; }

    public Nullable<System.DateTime> Anket_Olusturulma_Tarih { get; set; }

    public string Anket_Basligi { get; set; }

    public string Anket_Aciklamasi { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sorular> Sorular { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Yanitlar> Yanitlar { get; set; }

}

}
