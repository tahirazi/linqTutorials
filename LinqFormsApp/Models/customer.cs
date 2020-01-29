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

    public partial class customer
    {
        public customer()
        {
            this.balances = new HashSet<balance>();
            this.cashbooks = new HashSet<cashbook>();
            this.salescs = new HashSet<salesc>();
        }

        public int id { get; set; }
        public string customer_name { get; set; }
        public string phone { get; set; }
        public string customer_address { get; set; }
        public List<string> Type { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<balance> balances { get; set; }
        public virtual ICollection<cashbook> cashbooks { get; set; }
        public virtual ICollection<salesc> salescs { get; set; }

        public static List<customer> GetCustomersData()
        {
            List<customer> customers = new List<customer>
            {
                new customer
                {
                    id = 101,
                    customer_name = "Ali Abid",
                    phone = "0300-3568921",
                    customer_address = "Lahore, Pakistan",
                    Type = new List<string>
                    {
                        "Non-Regular",
                        "Running"
                    },
                    Rating = 5
                },
                new customer
                {
                    id = 102,
                    customer_name = "Muhammad Aleem",
                    phone = "0301-3568933",
                    customer_address = "Islamabad, Pakistan",
                    Type = new List<string>
                    {
                        "Normal",
                        "Loan Taker"
                    },
                    Rating = 4
                },
                new customer
                {
                    id = 103,
                    customer_name = "Tahir Bashir",
                    phone = "0345-3568022",
                    customer_address = "Karachi, Pakistan",
                    Type = new List<string>
                    {
                        "Regular",
                        "Agent",
                        "Reseller"
                    },
                    Rating = 3
                },
                new customer
                {
                    id = 104,
                    customer_name = "Ali Abid",
                    phone = "0333-3568566",
                    customer_address = "Lahore, Pakistan",
                    Type = new List<string>
                    {
                        "Regular",
                        "Running"
                    },
                    Rating = 4
                },
                new customer
                {
                    id = 105,
                    customer_name = "Bashir Ahmed",
                    phone = "0332-3568663",
                    customer_address = "Islamabad, Pakistan",
                    Type = new List<string>
                    {
                        "Normal"
                    },
                    Rating = 5
                },
                new customer
                {
                    id = 106,
                    customer_name = "Camran Bhatti",
                    phone = "0345-3563433",
                    customer_address = "Lahore, Pakistan",
                    Type = new List<string>
                    {
                        "Reseller",
                        "Agent"
                    },
                    Rating = 4
                },
                new customer
                {
                    id = 107,
                    customer_name = "Kamran Idrees",
                    phone = "0345-3563433",
                    customer_address = "Bhimber, AJK",
                    Type = new List<string>
                    {
                        "Fascal"
                    },
                    Rating = 1
                },
                new customer
                {
                    id = 108,
                    customer_name = "Kamran Ghaffar",
                    phone = "0340-3560033",
                    customer_address = "Bhimber, AJK",
                    Type = new List<string>
                    {
                        "Reseller",
                        "Agent",
                        "Partner"
                    },
                    Rating = 5
                },
                new customer
                {
                    id = 109,
                    customer_name = "Usman Akram",
                    phone = "0345-3563433",
                    customer_address = "Mirpur, Pakistan",
                    Type = new List<string>
                    {
                        "New Customer"
                    },
                    Rating = 3
                },
                new customer
                {
                    id = 110,
                    customer_name = "Nauman Sadiq",
                    phone = "0333-5832602",
                    customer_address = "Mirpur, Pakistan",
                    Type = new List<string>
                    {
                        "Whole-Seller",
                        "Agent"
                    },
                    Rating = 5
                },
                new customer
                {
                    id = 111,
                    customer_name = "Mehmood Ahmed",
                    phone = "0345-3563433",
                    customer_address = "Peshawar, Pakistan",
                    Type = new List<string>
                    {
                        "Permanent",
                        "Agent"
                    },
                    Rating = 4
                }
            };
            return customers;
        }
    }
}
