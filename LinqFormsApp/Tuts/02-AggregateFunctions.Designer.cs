namespace LinqFormsApp.Tuts
{
    partial class _02_AggregateFunctions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblNums = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEvensSum = new System.Windows.Forms.Button();
            this.lblEvenSum = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnStringMin = new System.Windows.Forms.Button();
            this.lblStringMin = new System.Windows.Forms.Label();
            this.btnStringMax = new System.Windows.Forms.Button();
            this.lblStringMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAggregate = new System.Windows.Forms.Label();
            this.btnAggregate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnStringMax);
            this.tabPage1.Controls.Add(this.btnStringMin);
            this.tabPage1.Controls.Add(this.btnAverage);
            this.tabPage1.Controls.Add(this.btnEvensSum);
            this.tabPage1.Controls.Add(this.lblStringMax);
            this.tabPage1.Controls.Add(this.lblStringMin);
            this.tabPage1.Controls.Add(this.lblAverage);
            this.tabPage1.Controls.Add(this.lblEvenSum);
            this.tabPage1.Controls.Add(this.lblSum);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.lblMax);
            this.tabPage1.Controls.Add(this.lblMin);
            this.tabPage1.Controls.Add(this.btnSum);
            this.tabPage1.Controls.Add(this.btnCount);
            this.tabPage1.Controls.Add(this.btnMax);
            this.tabPage1.Controls.Add(this.btnMin);
            this.tabPage1.Controls.Add(this.lblNums);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.ForeColor = System.Drawing.Color.Green;
            this.lblSum.Location = new System.Drawing.Point(109, 150);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(44, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum is: ";
            this.lblSum.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Green;
            this.lblCount.Location = new System.Drawing.Point(109, 121);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(51, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count is: ";
            this.lblCount.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.Green;
            this.lblMax.Location = new System.Drawing.Point(109, 92);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(43, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Max is: ";
            this.lblMax.Visible = false;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.Green;
            this.lblMin.Location = new System.Drawing.Point(109, 63);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(40, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min is: ";
            this.lblMin.Visible = false;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(9, 145);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sum ()";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(9, 116);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count ()";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(9, 87);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Max ()";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(9, 58);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Min ()";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(6, 13);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(241, 13);
            this.lblNums.TabIndex = 2;
            this.lblNums.Text = "The Numbers are  { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAggregate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblAggregate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aggregate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEvensSum
            // 
            this.btnEvensSum.Location = new System.Drawing.Point(9, 174);
            this.btnEvensSum.Name = "btnEvensSum";
            this.btnEvensSum.Size = new System.Drawing.Size(75, 23);
            this.btnEvensSum.TabIndex = 5;
            this.btnEvensSum.Text = "Sum Even ()";
            this.btnEvensSum.UseVisualStyleBackColor = true;
            this.btnEvensSum.Click += new System.EventHandler(this.btnEvensSum_Click);
            // 
            // lblEvenSum
            // 
            this.lblEvenSum.AutoSize = true;
            this.lblEvenSum.ForeColor = System.Drawing.Color.Green;
            this.lblEvenSum.Location = new System.Drawing.Point(105, 179);
            this.lblEvenSum.Name = "lblEvenSum";
            this.lblEvenSum.Size = new System.Drawing.Size(89, 13);
            this.lblEvenSum.TabIndex = 4;
            this.lblEvenSum.Text = "Sum of Evens is: ";
            this.lblEvenSum.Visible = false;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(9, 203);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 6;
            this.btnAverage.Text = "Average ()";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.ForeColor = System.Drawing.Color.Green;
            this.lblAverage.Location = new System.Drawing.Point(105, 208);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(63, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average is: ";
            this.lblAverage.Visible = false;
            // 
            // btnStringMin
            // 
            this.btnStringMin.Location = new System.Drawing.Point(9, 232);
            this.btnStringMin.Name = "btnStringMin";
            this.btnStringMin.Size = new System.Drawing.Size(75, 23);
            this.btnStringMin.TabIndex = 7;
            this.btnStringMin.Text = "String Min ()";
            this.btnStringMin.UseVisualStyleBackColor = true;
            this.btnStringMin.Click += new System.EventHandler(this.btnStringMin_Click);
            // 
            // lblStringMin
            // 
            this.lblStringMin.AutoSize = true;
            this.lblStringMin.ForeColor = System.Drawing.Color.Green;
            this.lblStringMin.Location = new System.Drawing.Point(105, 237);
            this.lblStringMin.Name = "lblStringMin";
            this.lblStringMin.Size = new System.Drawing.Size(70, 13);
            this.lblStringMin.TabIndex = 4;
            this.lblStringMin.Text = "Min String is: ";
            this.lblStringMin.Visible = false;
            // 
            // btnStringMax
            // 
            this.btnStringMax.Location = new System.Drawing.Point(9, 261);
            this.btnStringMax.Name = "btnStringMax";
            this.btnStringMax.Size = new System.Drawing.Size(75, 23);
            this.btnStringMax.TabIndex = 8;
            this.btnStringMax.Text = "String Max ()";
            this.btnStringMax.UseVisualStyleBackColor = true;
            this.btnStringMax.Click += new System.EventHandler(this.btnStringMax_Click);
            // 
            // lblStringMax
            // 
            this.lblStringMax.AutoSize = true;
            this.lblStringMax.ForeColor = System.Drawing.Color.Green;
            this.lblStringMax.Location = new System.Drawing.Point(105, 266);
            this.lblStringMax.Name = "lblStringMax";
            this.lblStringMax.Size = new System.Drawing.Size(73, 13);
            this.lblStringMax.TabIndex = 4;
            this.lblStringMax.Text = "Max String is: ";
            this.lblStringMax.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Countries are: { \"Pakistan\", \"UK\", \"USA\" }";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Countries are: { \"Pakistan\", \"UK\", \"USA\" }";
            // 
            // lblAggregate
            // 
            this.lblAggregate.AutoSize = true;
            this.lblAggregate.ForeColor = System.Drawing.Color.Green;
            this.lblAggregate.Location = new System.Drawing.Point(101, 67);
            this.lblAggregate.Name = "lblAggregate";
            this.lblAggregate.Size = new System.Drawing.Size(72, 13);
            this.lblAggregate.TabIndex = 10;
            this.lblAggregate.Text = "Aggregate is: ";
            this.lblAggregate.Visible = false;
            // 
            // btnAggregate
            // 
            this.btnAggregate.Location = new System.Drawing.Point(9, 60);
            this.btnAggregate.Name = "btnAggregate";
            this.btnAggregate.Size = new System.Drawing.Size(75, 23);
            this.btnAggregate.TabIndex = 12;
            this.btnAggregate.Text = "Aggregate ()";
            this.btnAggregate.UseVisualStyleBackColor = true;
            this.btnAggregate.Click += new System.EventHandler(this.btnAggregate_Click);
            // 
            // _02_AggregateFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "_02_AggregateFunctions";
            this.Text = "_02_AggregateFunctions";
            this.Load += new System.EventHandler(this._02_AggregateFunctions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Button btnEvensSum;
        private System.Windows.Forms.Label lblEvenSum;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnStringMin;
        private System.Windows.Forms.Label lblStringMin;
        private System.Windows.Forms.Button btnStringMax;
        private System.Windows.Forms.Label lblStringMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAggregate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAggregate;
    }
}