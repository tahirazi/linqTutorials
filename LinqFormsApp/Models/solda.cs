//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class solda
    {
        public int sold_id { get; set; }
        public string invoice_no { get; set; }
        public int config_id { get; set; }
        public decimal quantity { get; set; }
        public decimal price { get; set; }
        public decimal total { get; set; }
        public string soldby { get; set; }
    
        public virtual config config { get; set; }
        public virtual salesa salesa { get; set; }
    }
}
