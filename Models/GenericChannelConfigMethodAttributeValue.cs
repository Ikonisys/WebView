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
    
    public partial class GenericChannelConfigMethodAttributeValue
    {
        public int ID { get; set; }
        public int GenericChannelConfigID { get; set; }
        public int AttributeID { get; set; }
        public string Value { get; set; }
    
        public virtual GenericChannelConfig GenericChannelConfig { get; set; }
        public virtual MethodAttribute MethodAttribute { get; set; }
    }
}
