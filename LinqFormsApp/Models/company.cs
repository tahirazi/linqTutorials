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
    
    public partial class company
    {
        public company()
        {
            this.products = new HashSet<product>();
        }
    
        public string company_name { get; set; }
    
        public virtual ICollection<product> products { get; set; }
    }
}
