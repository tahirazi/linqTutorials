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

namespace LinqFormsApp.Admin
{
    public partial class CompanyForm : Form
    {
        shopEntities db = new shopEntities();
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            var data = from CompanyData in db.companies
                       select new {Name = CompanyData.company_name };
            dataGridView1.DataSource = data.ToList();
        }
    }
}
