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
    
    public partial class Laboratory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public Nullable<int> Accession { get; set; }
        public Nullable<int> AccessionLength { get; set; }
        public bool UseBase36 { get; set; }
        public bool GenerateAccession { get; set; }
        public bool PrintLabel { get; set; }
        public bool PrintPatientOnLabel { get; set; }
        public string Symbology { get; set; }
        public string LogoFile { get; set; }
        public bool IsDefault { get; set; }
        public Nullable<int> AllowPurgingAfterDay { get; set; }
    }
}