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
    
    public partial class stock
    {
        public int stock_id { get; set; }
        public int config_id { get; set; }
        public decimal quantity { get; set; }
        public decimal total_price { get; set; }
        public string stock_date { get; set; }
    
        public virtual config config { get; set; }
    }
}