namespace LinqFormsApp.Tuts
{
    partial class _07__ConversionOperators
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToDictionary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValueObj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToList, ToArray, ToDictionary, ToLookup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValueObj);
            this.groupBox1.Controls.Add(this.btnToDictionary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToDictionary Operator";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnToDictionary
            // 
            this.btnToDictionary.Location = new System.Drawing.Point(233, 19);
            this.btnToDictionary.Name = "btnToDictionary";
            this.btnToDictionary.Size = new System.Drawing.Size(118, 23);
            this.btnToDictionary.TabIndex = 1;
            this.btnToDictionary.Text = "Apply ToDictionary";
            this.btnToDictionary.UseVisualStyleBackColor = true;
            this.btnToDictionary.Click += new System.EventHandler(this.btnToDictionary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ToDictionary is used to make key value pairs";
            // 
            // btnValueObj
            // 
            this.btnValueObj.Location = new System.Drawing.Point(357, 19);
            this.btnValueObj.Name = "btnValueObj";
            this.btnValueObj.Size = new System.Drawing.Size(67, 23);
            this.btnValueObj.TabIndex = 2;
            this.btnValueObj.Text = "Value Obj";
            this.btnValueObj.UseVisualStyleBackColor = true;
            this.btnValueObj.Click += new System.EventHandler(this.btnValueObj_Click);
            // 
            // _07__ConversionOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_07__ConversionOperators";
            this.Text = "_07__ConversionOperators";
            this.Load += new System.EventHandler(this._07__ConversionOperators_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToDictionary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValueObj;
    }
}