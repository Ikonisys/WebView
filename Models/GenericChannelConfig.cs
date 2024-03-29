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
    
    public partial class GenericChannelConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GenericChannelConfig()
        {
            this.FieldChannels = new HashSet<FieldChannel>();
            this.GenericChannelConfigMethodAttributeValues = new HashSet<GenericChannelConfigMethodAttributeValue>();
            this.OrphanedTargetChannels = new HashSet<OrphanedTargetChannel>();
            this.TargetChannels = new HashSet<TargetChannel>();
        }
    
        public int ID { get; set; }
        public int GenericAppScanConfigID { get; set; }
        public int GenericAppScanStructureID { get; set; }
        public int FilterSetID { get; set; }
        public bool IsAutoExposed { get; set; }
        public Nullable<float> ManualExposureMilliseconds { get; set; }
        public int AutoFocusMethodID { get; set; }
        public int AutoExposureMethodID { get; set; }
        public bool ApplyFlatFieldCorrection { get; set; }
        public int AcquisitionCameraGain { get; set; }
        public int CompressionRatio { get; set; }
        public int DotCountingMethodID { get; set; }
        public int SkipFieldConditionMethodID { get; set; }
        public int FindBestSliceMethodID { get; set; }
        public bool AllowEdit { get; set; }
        public bool IsBrightField { get; set; }
    
        public virtual AutoExposureMethod AutoExposureMethod { get; set; }
        public virtual AutoFocusMethod AutoFocusMethod { get; set; }
        public virtual DotCountingMethod DotCountingMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldChannel> FieldChannels { get; set; }
        public virtual FilterSet FilterSet { get; set; }
        public virtual FindBestSliceMethod FindBestSliceMethod { get; set; }
        public virtual GenericAppScanConfig GenericAppScanConfig { get; set; }
        public virtual GenericAppScanStructure GenericAppScanStructure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GenericChannelConfigMethodAttributeValue> GenericChannelConfigMethodAttributeValues { get; set; }
        public virtual SkipFieldConditionMethod SkipFieldConditionMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrphanedTargetChannel> OrphanedTargetChannels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TargetChannel> TargetChannels { get; set; }
    }
}
