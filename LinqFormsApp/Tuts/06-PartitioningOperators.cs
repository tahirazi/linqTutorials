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
    public partial class _06_PartitioningOperators : Form
    {
        string[] countries = { "Australia", "Bangladesh", "Canada", "Pakistan", "UK", "US", "West Indies", "Zimbabwe" };
        public _06_PartitioningOperators()
        {
            InitializeComponent();
        }

        private void _06_PartitioningOperators_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Countries");
            IEnumerable<string> data = countries;
            foreach (string item in data)
            {
                dataTable.Rows.Add(item);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<string> data = countries.Take(3).ToList();
            dt.Columns.Add("Countries");
            foreach(string item in data)
            {
                dt.Rows.Add(item);
            }
            dataGridView1.DataSource = dt;
            //SQL Like syntax
            var result = (from country in countries
                          select country).Take(3);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            IEnumerable<string> data = countries.Skip(3);
            dt.Columns.Add("Countries");
            foreach (string item in data)
            {
                dt.Rows.Add(item);
            }
            dataGridView1.DataSource = dt;
            //SQL Like syntax
            var result = (from country in countries
                          select country).Skip(3);
        }

        private void btnTakeWhile_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Countries");
            IEnumerable<string> data = countries.TakeWhile(c => c.Length > 2);
            foreach(string item in data)
            {
                dataTable.Rows.Add(item);
            }
            dataGridView1.DataSource = dataTable;
            //SQL like syntax
            IEnumerable<string> result = (from country in countries
                                          select country)
                                          .TakeWhile(c => c.Length > 2);
        }

        private void btnSkipWhile_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Countries");
            IEnumerable<string> data = countries.SkipWhile(c => c.Length > 2);
            foreach (string item in data)
            {
                dataTable.Rows.Add(item);
            }
            dataGridView1.DataSource = dataTable;
            //SQL like syntax
            IEnumerable<string> result = (from country in countries
                                          select country)
                                          .SkipWhile(c => c.Length > 2);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Countries");
            IEnumerable<string> data = countries;
            foreach (string item in data)
            {
                dataTable.Rows.Add(item);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void btnShowPagingRecord_Click(object sender, EventArgs e)
        {
            IEnumerable<customer> customers = customer.GetCustomersData();
            int pageNumber = 0;
            if(int.TryParse(txtPageNo.Text, out pageNumber))
            {
                if(pageNumber >= 1 && pageNumber <= 4)
                {
                    int pageSize = 3;
                    IEnumerable<customer> data = customers.Skip((pageNumber - 1) * pageSize)
                                                            .Take(pageSize);
                    var gridData = data.Select(d => new { Id = d.id, Name = d.customer_name, Rating = d.Rating }).ToList();
                    dataGridView2.DataSource = gridData;
                    lblDisplayRecord.Text = "Displaying Record of page: " + pageNumber;
                }
                else
                {
                    MessageBox.Show("Please enter a valid page number like 1,2,3,4", "Error: Invalid page number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid page number like 1,2,3,4", "Error: Invalid page number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
