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
    
    public partial class Grupi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupi()
        {
            this.Studentis = new HashSet<Studenti>();
        }
    
        public int Id { get; set; }
        public string Emri { get; set; }
        public int CikliStudimit { get; set; }
        public int Viti { get; set; }
        public string Perriudha { get; set; }
        public int UniversitetiId { get; set; }
        public int FakultetiId { get; set; }
        public int DegaId { get; set; }
    
        public virtual Dega Dega { get; set; }
        public virtual Fakulteti Fakulteti { get; set; }
        public virtual Universiteti Universiteti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studenti> Studentis { get; set; }
    }
}