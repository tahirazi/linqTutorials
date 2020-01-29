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
    public partial class _07__ConversionOperators : Form
    {
        List<customer> customers = customer.GetCustomersData().ToList();
        public _07__ConversionOperators()
        {
            InitializeComponent();
        }

        private void _07__ConversionOperators_Load(object sender, EventArgs e)
        {
            var data = customers.Select(cust =>
                                 new { Id = cust.id, Name = cust.customer_name, Rating = cust.Rating })
                                 .ToList();
            dataGridView1.DataSource = data;
        }

        private void btnToDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> customersDictionary = customers.ToDictionary(cust => cust.id, cust => cust.customer_name);
            dataGridView1.DataSource = customersDictionary.ToList();
        }

        private void btnValueObj_Click(object sender, EventArgs e)
        {
            Dictionary<int, customer> customersDictionary = customers.ToDictionary(cust => cust.id);
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            foreach(KeyValuePair<int,customer> pair in customersDictionary)
            {
                table.Rows.Add(pair.Key,pair.Value.customer_name);
            }
            dataGridView1.DataSource = table;
        }
    }
}
