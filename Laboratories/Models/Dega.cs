//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratories.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dega()
        {
            this.Grupis = new HashSet<Grupi>();
            this.GrupiLabs = new HashSet<GrupiLab>();
        }
    
        public int Id { get; set; }
        public string Emri { get; set; }
        public int FakultetiId { get; set; }
    
        public virtual Fakulteti Fakulteti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupi> Grupis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrupiLab> GrupiLabs { get; set; }
    }
}
