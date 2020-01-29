namespace LinqFormsApp.Tuts
{
    partial class _06_PartitioningOperators
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSkipWhile = new System.Windows.Forms.Button();
            this.btnTakeWhile = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowPagingRecord = new System.Windows.Forms.Button();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblDisplayRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnSkipWhile);
            this.groupBox1.Controls.Add(this.btnTakeWhile);
            this.groupBox1.Controls.Add(this.btnSkip);
            this.groupBox1.Controls.Add(this.btnTake);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Operators";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(195, 31);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSkipWhile
            // 
            this.btnSkipWhile.Location = new System.Drawing.Point(195, 147);
            this.btnSkipWhile.Name = "btnSkipWhile";
            this.btnSkipWhile.Size = new System.Drawing.Size(75, 23);
            this.btnSkipWhile.TabIndex = 2;
            this.btnSkipWhile.Text = "SkipWhile";
            this.btnSkipWhile.UseVisualStyleBackColor = true;
            this.btnSkipWhile.Click += new System.EventHandler(this.btnSkipWhile_Click);
            // 
            // btnTakeWhile
            // 
            this.btnTakeWhile.Location = new System.Drawing.Point(195, 89);
            this.btnTakeWhile.Name = "btnTakeWhile";
            this.btnTakeWhile.Size = new System.Drawing.Size(75, 23);
            this.btnTakeWhile.TabIndex = 2;
            this.btnTakeWhile.Text = "TakeWhile";
            this.btnTakeWhile.UseVisualStyleBackColor = true;
            this.btnTakeWhile.Click += new System.EventHandler(this.btnTakeWhile_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(195, 118);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip ()";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(195, 60);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Take ()";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(178, 328);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The countries = { \"Australia\", \"Bangladesh\", \"Canada\", \"Pakistan\", \"UK\", \"USA\" }";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowPagingRecord);
            this.groupBox2.Controls.Add(this.txtPageNo);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.lblDisplayRecord);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(319, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paging with Take and Skip";
            // 
            // btnShowPagingRecord
            // 
            this.btnShowPagingRecord.Location = new System.Drawing.Point(282, 27);
            this.btnShowPagingRecord.Name = "btnShowPagingRecord";
            this.btnShowPagingRecord.Size = new System.Drawing.Size(87, 23);
            this.btnShowPagingRecord.TabIndex = 3;
            this.btnShowPagingRecord.Text = "Show Record";
            this.btnShowPagingRecord.UseVisualStyleBackColor = true;
            this.btnShowPagingRecord.Click += new System.EventHandler(this.btnShowPagingRecord_Click);
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(174, 28);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(100, 20);
            this.txtPageNo.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(363, 230);
            this.dataGridView2.TabIndex = 0;
            // 
            // lblDisplayRecord
            // 
            this.lblDisplayRecord.AutoSize = true;
            this.lblDisplayRecord.ForeColor = System.Drawing.Color.Green;
            this.lblDisplayRecord.Location = new System.Drawing.Point(6, 298);
            this.lblDisplayRecord.Name = "lblDisplayRecord";
            this.lblDisplayRecord.Size = new System.Drawing.Size(138, 13);
            this.lblDisplayRecord.TabIndex = 1;
            this.lblDisplayRecord.Text = "Displaying Record of page: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Page Number between 1-4";
            // 
            // _06_PartitioningOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "_06_PartitioningOperators";
            this.Text = "_06_PartitioningOperators";
            this.Load += new System.EventHandler(this._06_PartitioningOperators_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSkipWhile;
        private System.Windows.Forms.Button btnTakeWhile;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowPagingRecord;
        private System.Windows.Forms.TextBox txtPageNo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayRecord;
    }
}