using LinqFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqFormsApp.Tuts
{
    public partial class _05_OrderingOperators : Form
    {
        public _05_OrderingOperators()
        {
            InitializeComponent();
        }

        private void _05_OrderingOperators_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customer.GetCustomersData().Select(c => new { ID = c.id, Name = c.customer_name, Rating = c.Rating }).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            var data = customer.GetCustomersData()
                .Select(c => new { ID = c.id, Name = c.customer_name, Rating = c.Rating })
                .OrderBy(o => o.Name).ToList();
            dataGridView1.DataSource = data;
            //SQL like syntax
            IOrderedEnumerable<customer> customers = from cust in customer.GetCustomersData()
                                                     orderby cust.customer_name
                                                     select cust;
        }

        private void btnOrderByDesc_Click(object sender, EventArgs e)
        {
            var data = customer.GetCustomersData()
                .Select(cust => new { ID = cust.id, Name = cust.customer_name, Rating = cust.Rating })
                .OrderByDescending(cust => cust.Name)
                .ToList();
            dataGridView1.DataSource = data;
            //SQL Like syntax
            IOrderedEnumerable<customer> customers = from cust in customer.GetCustomersData()
                                                     orderby cust.customer_name descending
                                                     select cust;
        }

        private void btnThen_Click(object sender, EventArgs e)
        {
            var data = customer.GetCustomersData()
                .Select(c => new { ID = c.id, Name = c.customer_name, Rating = c.Rating })
                .OrderBy(cust => cust.Name)
                .ThenBy(cust => cust.Rating)
                .ToList();
            dataGridView1.DataSource = data;
            //SQL Like syntax
            IOrderedEnumerable<customer> customers = from cust in customer.GetCustomersData()
                                                     orderby cust.customer_name, cust.Rating
                                                     select cust;
        }

        private void btnThenByDesc_Click(object sender, EventArgs e)
        {
            var data = customer.GetCustomersData()
                .Select(c => new { ID = c.id, Name = c.customer_name, Rating = c.Rating })
                .OrderBy(cust => cust.Name)
                .ThenByDescending(cust => cust.Rating)
                .ToList();
            dataGridView1.DataSource = data;
            //SQL Like syntax
            IOrderedEnumerable<customer> customers = from cust in customer.GetCustomersData()
                                                     orderby cust.customer_name, cust.Rating descending
                                                     select cust;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            var data = customer.GetCustomersData()
                .Select(c => new { ID = c.id, Name = c.customer_name, Rating = c.Rating })
                .ToList();
            data.Reverse();
            dataGridView1.DataSource = data;
            //SQL Like syntax
            IEnumerable<customer> customers = (from cust in customer.GetCustomersData()
                                               select cust).Reverse();
        }
    }
}
