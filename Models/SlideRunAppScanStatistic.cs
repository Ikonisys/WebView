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
    
    public partial class SlideRunAppScanStatistic
    {
        public int ID { get; set; }
        public int SlideRunAppScanID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    
        public virtual SlideRunAppScan SlideRunAppScan { get; set; }
    }
}
