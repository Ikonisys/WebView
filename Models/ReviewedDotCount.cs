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
    
    public partial class ReviewedDotCount
    {
        public int ID { get; set; }
        public int ReviewedTargetID { get; set; }
        public int TargetChannelID { get; set; }
        public int DotCount { get; set; }
    
        public virtual ReviewedTarget ReviewedTarget { get; set; }
        public virtual TargetChannel TargetChannel { get; set; }
    }
}