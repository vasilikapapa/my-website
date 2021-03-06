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
    
    public partial class Studenti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Studenti()
        {
            this.Totalis = new HashSet<Totali>();
            this.Vleresimis = new HashSet<Vleresimi>();
        }
    
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int NrPersonal { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> GrupiId { get; set; }
        public Nullable<int> GrupiLabId { get; set; }
    
        public virtual Grupi Grupi { get; set; }
        public virtual GrupiLab GrupiLab { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Totali> Totalis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vleresimi> Vleresimis { get; set; }
    }
}
