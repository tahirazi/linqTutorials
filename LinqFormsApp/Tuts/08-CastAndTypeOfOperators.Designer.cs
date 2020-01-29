namespace LinqFormsApp.Tuts
{
    partial class _08_CastAndTypeOfOperators
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCast = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOfType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAsEnumerable = new System.Windows.Forms.Button();
            this.btnAsQueryable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cast operator uses deffered execution.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOfType);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnCast);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cast and OfType operator";
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(6, 28);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(75, 23);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cast ()";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(188, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnOfType
            // 
            this.btnOfType.Location = new System.Drawing.Point(119, 28);
            this.btnOfType.Name = "btnOfType";
            this.btnOfType.Size = new System.Drawing.Size(75, 23);
            this.btnOfType.TabIndex = 2;
            this.btnOfType.Text = "OfType ()";
            this.btnOfType.UseVisualStyleBackColor = true;
            this.btnOfType.Click += new System.EventHandler(this.btnOfType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAsQueryable);
            this.groupBox2.Controls.Add(this.btnAsEnumerable);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(221, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 375);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AsEnumberable() and AsQueryable()";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(386, 312);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnAsEnumerable
            // 
            this.btnAsEnumerable.Location = new System.Drawing.Point(6, 28);
            this.btnAsEnumerable.Name = "btnAsEnumerable";
            this.btnAsEnumerable.Size = new System.Drawing.Size(100, 23);
            this.btnAsEnumerable.TabIndex = 1;
            this.btnAsEnumerable.Text = "As Enumerable";
            this.btnAsEnumerable.UseVisualStyleBackColor = true;
            this.btnAsEnumerable.Click += new System.EventHandler(this.btnAsEnumerable_Click);
            // 
            // btnAsQueryable
            // 
            this.btnAsQueryable.Location = new System.Drawing.Point(112, 28);
            this.btnAsQueryable.Name = "btnAsQueryable";
            this.btnAsQueryable.Size = new System.Drawing.Size(100, 23);
            this.btnAsQueryable.TabIndex = 3;
            this.btnAsQueryable.Text = "As Queryable";
            this.btnAsQueryable.UseVisualStyleBackColor = true;
            this.btnAsQueryable.Click += new System.EventHandler(this.btnAsQueryable_Click);
            // 
            // _08_CastAndTypeOfOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_08_CastAndTypeOfOperators";
            this.Text = "_08_CastAndOfTypeOperators";
            this.Load += new System.EventHandler(this._08_CastAndTypeOfOperators_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOfType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAsQueryable;
        private System.Windows.Forms.Button btnAsEnumerable;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}