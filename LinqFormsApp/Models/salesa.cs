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
    
    public partial class salesa
    {
        public salesa()
        {
            this.agentbalances = new HashSet<agentbalance>();
            this.soldas = new HashSet<solda>();
        }
    
        public string invoice_no { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> agent_id { get; set; }
        public string agent_name { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> netamount { get; set; }
        public Nullable<decimal> received { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<decimal> debitcredit { get; set; }
        public string remarks { get; set; }
        public string saleby { get; set; }
    
        public virtual ICollection<agentbalance> agentbalances { get; set; }
        public virtual agent agent { get; set; }
        public virtual ICollection<solda> soldas { get; set; }
    }
}
