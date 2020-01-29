using LinqFormsApp.Models;
using System;
using System.Collections;
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
    public partial class _08_CastAndTypeOfOperators : Form
    {
        ArrayList list = new ArrayList();
        shopEntities db = new shopEntities();
        public _08_CastAndTypeOfOperators()
        {
            InitializeComponent();
        }

        private void _08_CastAndTypeOfOperators_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            list.Clear();
            //We're adding integer values in array list
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //If we try to add other data type in array list then it'll gives us an exception
            //Un-comment below line of code to see exception
            //list.Add("Some String..");

            IEnumerable<int> result = list.Cast<int>();

            DataTable table = new DataTable();
            table.Columns.Add("Integers");

            foreach (int item in result)
            {
                table.Rows.Add(item);
            }
            dataGridView1.DataSource = table;
        }

        private void btnOfType_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(101);
            list.Add(102);
            list.Add(103);
            //This string type will no more throw exception because of "OfType" operator
            list.Add("104");
            list.Add("Some String");

            //This will return only type integer in array list
            IEnumerable<int> result = list.OfType<int>();
            DataTable table = new DataTable();
            table.Columns.Add("OfTypeInteger");

            foreach (int item in result)
            {
                table.Rows.Add(item);
            }
            dataGridView1.DataSource = table;


        }

        private void btnAsEnumerable_Click(object sender, EventArgs e)
        {
            var data = db.Custs
                .Where(c => c.Type == "Non-Regular")
                .AsEnumerable()
                .OrderBy(c => c.FirstName)
                .Take(10);
            dataGridView2.DataSource = data.ToList();
        }

        private void btnAsQueryable_Click(object sender, EventArgs e)
        {
            var data = db.Custs
                .Where(c => c.Type == "Non-Regular")
                .OrderBy(c => c.FirstName)
                .AsQueryable()
                .Take(10);
            var abc = "None";
            dataGridView2.DataSource = data.ToList();
        }
    }
}
