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
    
    public partial class ProbeQcSignal
    {
        public int ID { get; set; }
        public int TargetChannelID { get; set; }
        public bool UserDefinedSignal { get; set; }
        public int SystemDefinedSignalIndex { get; set; }
        public bool UsedInCalculation { get; set; }
        public int BrightestPoint_X { get; set; }
        public int BrightestPoint_Y { get; set; }
        public int BestFocusedPlane { get; set; }
        public int GrayScaleLevelThreshold { get; set; }
    
        public virtual TargetChannel TargetChannel { get; set; }
    }
}
