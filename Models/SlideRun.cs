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
    
    public partial class SlideRun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SlideRun()
        {
            this.ArchivedSlideRuns = new HashSet<ArchivedSlideRun>();
            this.PurgedSlideRuns = new HashSet<PurgedSlideRun>();
            this.SlideRunAppScans = new HashSet<SlideRunAppScan>();
            this.SlideRunBrightFieldAssociations = new HashSet<SlideRunBrightFieldAssociation>();
            this.SlideRunLocks = new HashSet<SlideRunLock>();
            this.StudySlideRuns = new HashSet<StudySlideRun>();
        }
    
        public int ID { get; set; }
        public int SlideID { get; set; }
        public int SlideAreaID { get; set; }
        public int ImageLocationID { get; set; }
        public int ScannerID { get; set; }
        public int UserID { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<int> DurationInSeconds { get; set; }
        public string TestOutcome { get; set; }
        public Nullable<int> LampHoursStart { get; set; }
        public Nullable<int> LampHoursEnd { get; set; }
        public Nullable<bool> Archived { get; set; }
        public Nullable<bool> Purged { get; set; }
        public int SlideTypeAssociationID { get; set; }
        public bool IsManual { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> TransferStartTime { get; set; }
        public Nullable<System.DateTime> TransferEndTime { get; set; }
        public int FormatVersion { get; set; }
        public string NuclearSize { get; set; }
        public string StructureScore { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivedSlideRun> ArchivedSlideRuns { get; set; }
        public virtual IkoUser IkoUser { get; set; }
        public virtual ImageLocation ImageLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurgedSlideRun> PurgedSlideRuns { get; set; }
        public virtual Scanner Scanner { get; set; }
        public virtual Slide Slide { get; set; }
        public virtual SlideArea SlideArea { get; set; }
        public virtual SlideTypeAssociation SlideTypeAssociation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SlideRunAppScan> SlideRunAppScans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SlideRunBrightFieldAssociation> SlideRunBrightFieldAssociations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SlideRunLock> SlideRunLocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudySlideRun> StudySlideRuns { get; set; }
    }
}
