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
    
    public partial class @return
    {
        public int returnid { get; set; }
        public int config_id { get; set; }
        public int quantity { get; set; }
        public decimal amount { get; set; }
    
        public virtual @return returns1 { get; set; }
        public virtual @return return1 { get; set; }
    }
}
