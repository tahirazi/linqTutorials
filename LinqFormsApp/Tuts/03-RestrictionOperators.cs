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
    public partial class _03_RestrictionOperators : Form
    {
        List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public _03_RestrictionOperators()
        {
            InitializeComponent();
        }

        private void _03_RestrictionOperators_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyRestriction_Click(object sender, EventArgs e)
        {
            Func<int, bool> predicate = x => x % 2 == 0;
            IEnumerable<int> EvenNumbers = Numbers.Where(predicate);
            lblRestictionApplied.Text = "After restriction the evens: ";
            foreach(int even in EvenNumbers)
            {
                lblRestictionApplied.Text = lblRestictionApplied.Text + even.ToString() + " ";
            }
            lblRestictionApplied.Visible = true;
            lblNote.Visible = true;
        }

        private void btnRestrictionWithIndex_Click(object sender, EventArgs e)
        {
            var result = Numbers.Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0);
            lblRestrictedWithIndex.Text = "Evens with Index: ";
            foreach(var item in result)
            {
                lblRestrictedWithIndex.Text = lblRestrictedWithIndex.Text + " " + item.Number.ToString() +
                    " Index: " + item.Index.ToString();
            }
            lblRestrictedWithIndex.Visible = true;
            lblNoteWithIndex.Visible = true;
        }

        private void btnIndexOnly_Click(object sender, EventArgs e)
        {
            IEnumerable<int> result = Numbers.Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0)
                .Select(n => n.Index);
            lblRestrictIndexOnly.Text = "Even indexes: ";
            foreach(int number in result)
            {
                lblRestrictIndexOnly.Text = lblRestrictIndexOnly.Text + " " + number.ToString();
            }
            lblRestrictIndexOnly.Visible = true;
            lblNoteIndexOnly.Visible = true;
        }
    }
}
