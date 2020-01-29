using LinqFormsApp.Tuts.Classes;
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
    public partial class _01_ExtensionMethods : Form
    {
        public _01_ExtensionMethods()
        {
            InitializeComponent();
        }

        private void _01_ExtensionMethods_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeCase_Click(object sender, EventArgs e)
        {
            string beforeText = lblAfter.Text;
            //Extension method syntax
            string afterText = beforeText.ChangeFirstLetterCase();
            lblAfter.Text = afterText;
            lblAfter.Visible = true;
            lblNote.Visible = true;
        }

        private void btnFindEvens_Click(object sender, EventArgs e)
        {
            List<int> Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Wrapper class style syntax
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, number => number % 2 == 0);
            foreach(int EvenNumber in EvenNumbers)
            {
                lblEvens.Text = lblEvens.Text + " " + EvenNumber.ToString();
            }
            lblEvens.Visible = true;
            label1.Visible = true;
        }
    }
}
