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
    
    public partial class sale
    {
        public sale()
        {
            this.solds = new HashSet<sold>();
        }
    
        public string invoice_no { get; set; }
        public Nullable<System.DateTime> invoice_date { get; set; }
        public string customer_name { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> received { get; set; }
        public string remarks { get; set; }
        public string soleby { get; set; }
    
        public virtual ICollection<sold> solds { get; set; }
    }
}
