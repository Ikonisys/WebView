//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebView.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GenericAppMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GenericAppMethod()
        {
            this.GenericApps = new HashSet<GenericApp>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string DisplayedName { get; set; }
        public string Description { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> TimeCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GenericApp> GenericApps { get; set; }
        public virtual IkoUser IkoUser { get; set; }
    }
}