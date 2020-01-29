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
    public partial class _04_ProjectionOperators : Form
    {
        public _04_ProjectionOperators()
        {
            InitializeComponent();
        }

        private void _04_ProjectionOperators_Load(object sender, EventArgs e)
        {

        }

        private void btnSingleSelect_Click(object sender, EventArgs e)
        {
            IEnumerable<int> Ids = customer.GetCustomersData().Select(id => id.id);
            lblSingleResults.Text = "Ids:";
            foreach(int Id in Ids)
            {
                lblSingleResults.Text = lblSingleResults.Text + "\n" + Id.ToString();
            }
        }

        private void btnMultipleSelect_Click(object sender, EventArgs e)
        {
            var results = customer.GetCustomersData().Select(c => new { Id = c.id, Name = c.customer_name });
            lblMultiSelectId.Text = "Id";
            lblMultiSelectName.Text = "Name";
            foreach(var customer in results)
            {
                lblMultiSelectId.Text = lblMultiSelectId.Text + "\n" + customer.Id.ToString();
                lblMultiSelectName.Text = lblMultiSelectName.Text + "\n" + customer.Name;
            }
        }

        private void btnSelectMany_Click(object sender, EventArgs e)
        {
            IEnumerable<string> types = customer.GetCustomersData().SelectMany(c => c.Type).Distinct();
            //SQL like syntax
            IEnumerable<string> result = (from cust in customer.GetCustomersData()
                                         from type in cust.Type
                                         select type).Distinct();
            lblProperties.Text = "Type";
            foreach(string type in types)
            {
                lblProperties.Text = lblProperties.Text + "\n" + type;
            }
        }

        private void btnSelectManyMultiple_Click(object sender, EventArgs e)
        {
            var results = customer.GetCustomersData().SelectMany(c => c.Type, (cust, type) =>
                                          new { Type = type, Name = cust.customer_name });
            //SQL like syntax
            var res = from cust in customer.GetCustomersData()
                      from type in cust.Type
                      select new { Type = type, Name = cust.customer_name };
            lblType.Text = "Type";
            lblName.Text = "Name";
            foreach(var item in results)
            {
                lblName.Text = lblName.Text + "\n" + item.Name;
                lblType.Text = lblType.Text + "\n" + item.Type;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            IEnumerable<List<string>> types = customer.GetCustomersData().Select(c => c.Type);
            //With select need to iterate with inner loop
            lblSelectTypes.Text = "Type";
            foreach (List<string> item in types)
            {
                foreach(string type in item)
                {
                    lblSelectTypes.Text = lblSelectTypes.Text + "\n" + type;
                }
            }
        }
    }
}
