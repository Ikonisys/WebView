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
    
    public partial class SlideRunAppScan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SlideRunAppScan()
        {
            this.Fields = new HashSet<Field>();
            this.SlideRunAppScanStatistics = new HashSet<SlideRunAppScanStatistic>();
        }
    
        public int ID { get; set; }
        public int SlideRunID { get; set; }
        public int GenericAppScanID { get; set; }
        public Nullable<int> DurationInSeconds { get; set; }
        public float PixelSizeInMicronX { get; set; }
        public float PixelSizeInMicronY { get; set; }
        public float FieldSizeInMicronX { get; set; }
        public float FieldSizeInMicronY { get; set; }
        public int NumberOfNuclei { get; set; }
        public int NumberOfTargets { get; set; }
        public Nullable<float> TargetDensityPerSquareMillimeter { get; set; }
        public bool GenerateTargetImages { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Field> Fields { get; set; }
        public virtual GenericAppScan GenericAppScan { get; set; }
        public virtual SlideRun SlideRun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SlideRunAppScanStatistic> SlideRunAppScanStatistics { get; set; }
    }
}
