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
    public partial class _02_AggregateFunctions : Form
    {
        List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public _02_AggregateFunctions()
        {
            InitializeComponent();
        }

        private void _02_AggregateFunctions_Load(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lblMin.Text = "Min is: ";
            lblMin.Text = lblMin.Text + " " + Numbers.Min().ToString();
            lblMin.Visible = true;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lblMax.Text = "Max is: ";
            lblMax.Text = lblMax.Text + " " + Numbers.Max().ToString();
            lblMax.Visible = true;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Count is: ";
            lblCount.Text = lblCount.Text + " " + Numbers.Count().ToString();
            lblCount.Visible = true;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblSum.Text = "Sum is: ";
            lblSum.Text = lblSum.Text + " " + Numbers.Sum().ToString();
            lblSum.Visible = true;
        }

        private void btnEvensSum_Click(object sender, EventArgs e)
        {
            lblEvenSum.Text = "Sum of Evens is: ";
            lblEvenSum.Text = lblEvenSum.Text + " " + Numbers.Where(n => n % 2 == 0).Sum().ToString();
            lblEvenSum.Visible = true;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblAverage.Text = "Average is: ";
            lblAverage.Text = lblAverage.Text + " " + Numbers.Average().ToString();
            lblAverage.Visible = true;
        }

        private void btnStringMin_Click(object sender, EventArgs e)
        {
            string[] countries = { "Pakistan", "UK", "USA" };
            lblStringMin.Text = "String Min is: ";
            lblStringMin.Text = lblStringMin.Text + " " + countries.Min(s => s.Length).ToString();
            lblStringMin.Visible = true;
        }

        private void btnStringMax_Click(object sender, EventArgs e)
        {
            string[] countries = { "Pakistan", "UK", "USA" };
            lblStringMax.Text = "String Min is: ";
            lblStringMax.Text = lblStringMax.Text + " " + countries.Max(s => s.Length).ToString();
            lblStringMax.Visible = true;
        }

        private void btnAggregate_Click(object sender, EventArgs e)
        {
            string[] countries = { "Pakistan", "UK", "USA" };
            lblAggregate.Text = "Aggregate is: ";
            lblAggregate.Text = lblAggregate.Text + " " + countries.Aggregate((a, b) => a + ", " + b).ToString();
            lblAggregate.Visible = true;
        }
    }
}
