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
    
    public partial class agentbalance
    {
        public int transaction_no { get; set; }
        public int id { get; set; }
        public string invoice_no { get; set; }
        public System.DateTime invoice_date { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }
    
        public virtual agent agent { get; set; }
        public virtual salesa salesa { get; set; }
    }
}