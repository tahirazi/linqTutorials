namespace LinqFormsApp.Tuts
{
    partial class _05_OrderingOperators
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnThenByDesc = new System.Windows.Forms.Button();
            this.btnThen = new System.Windows.Forms.Button();
            this.btnOrderByDesc = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Different Ordering operators in linq";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReverse);
            this.groupBox1.Controls.Add(this.btnThenByDesc);
            this.groupBox1.Controls.Add(this.btnThen);
            this.groupBox1.Controls.Add(this.btnOrderByDesc);
            this.groupBox1.Controls.Add(this.btnOrderBy);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 403);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic operators";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(385, 135);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(107, 23);
            this.btnReverse.TabIndex = 5;
            this.btnReverse.Text = "Reverse Method";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnThenByDesc
            // 
            this.btnThenByDesc.Location = new System.Drawing.Point(385, 106);
            this.btnThenByDesc.Name = "btnThenByDesc";
            this.btnThenByDesc.Size = new System.Drawing.Size(107, 23);
            this.btnThenByDesc.TabIndex = 4;
            this.btnThenByDesc.Text = "Then By Desc";
            this.btnThenByDesc.UseVisualStyleBackColor = true;
            this.btnThenByDesc.Click += new System.EventHandler(this.btnThenByDesc_Click);
            // 
            // btnThen
            // 
            this.btnThen.Location = new System.Drawing.Point(385, 77);
            this.btnThen.Name = "btnThen";
            this.btnThen.Size = new System.Drawing.Size(107, 23);
            this.btnThen.TabIndex = 3;
            this.btnThen.Text = "Then By";
            this.btnThen.UseVisualStyleBackColor = true;
            this.btnThen.Click += new System.EventHandler(this.btnThen_Click);
            // 
            // btnOrderByDesc
            // 
            this.btnOrderByDesc.Location = new System.Drawing.Point(385, 48);
            this.btnOrderByDesc.Name = "btnOrderByDesc";
            this.btnOrderByDesc.Size = new System.Drawing.Size(107, 23);
            this.btnOrderByDesc.TabIndex = 2;
            this.btnOrderByDesc.Text = "Order By Desc";
            this.btnOrderByDesc.UseVisualStyleBackColor = true;
            this.btnOrderByDesc.Click += new System.EventHandler(this.btnOrderByDesc_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(385, 19);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(107, 23);
            this.btnOrderBy.TabIndex = 1;
            this.btnOrderBy.Text = "Order By Name";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // _05_OrderingOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "_05_OrderingOperators";
            this.Text = "_05_OrderingOperators";
            this.Load += new System.EventHandler(this._05_OrderingOperators_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnThenByDesc;
        private System.Windows.Forms.Button btnThen;
        private System.Windows.Forms.Button btnOrderByDesc;
        private System.Windows.Forms.Button btnOrderBy;
    }
}