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
    public partial class MDIParentTuts : Form
    {
        private int childFormNumber = 0;

        public MDIParentTuts()
        {
            InitializeComponent();
        }
       

        private void extensionMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _01_ExtensionMethods _ExtensionMethods = new _01_ExtensionMethods();
            _ExtensionMethods.Show();
            _ExtensionMethods.MdiParent = this;
        }

        private void aggregatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _02_AggregateFunctions aggregateFunctions = new _02_AggregateFunctions();
            aggregateFunctions.Show();
            aggregateFunctions.MdiParent = this;
        }

        private void restrictionOperatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _03_RestrictionOperators restrictionOperators = new _03_RestrictionOperators();
            restrictionOperators.Show();
            restrictionOperators.MdiParent = this;
        }

        private void projectionOperatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _04_ProjectionOperators projectionOperators = new _04_ProjectionOperators();
            projectionOperators.Show();
            projectionOperators.MdiParent = this;
        }

        private void orderingOperatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _05_OrderingOperators orderingOperators = new _05_OrderingOperators();
            orderingOperators.Show();
            orderingOperators.MdiParent = this;
        }

        private void partioningOperatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _06_PartitioningOperators partitioningOperators = new _06_PartitioningOperators();
            partitioningOperators.Show();
            partitioningOperators.MdiParent = this;
        }

        private void conversionOperatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _07__ConversionOperators conversionOperators = new _07__ConversionOperators();
            conversionOperators.Show();
            conversionOperators.MdiParent = this;
        }

        private void castAndTypeOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _08_CastAndTypeOfOperators castAndTypeOfOperators = new _08_CastAndTypeOfOperators();
            castAndTypeOfOperators.Show();
            castAndTypeOfOperators.MdiParent = this;
        }
    }
}
