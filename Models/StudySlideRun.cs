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
    
    public partial class StudySlideRun
    {
        public int ID { get; set; }
        public int StudyID { get; set; }
        public int SlideRunID { get; set; }
    
        public virtual SlideRun SlideRun { get; set; }
        public virtual Study Study { get; set; }
    }
}
