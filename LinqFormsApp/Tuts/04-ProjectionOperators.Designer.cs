namespace LinqFormsApp.Tuts
{
    partial class _04_ProjectionOperators
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
            this.btnSingleSelect = new System.Windows.Forms.Button();
            this.lblSingleResults = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMultipleSelect = new System.Windows.Forms.Button();
            this.lblMultiSelectName = new System.Windows.Forms.Label();
            this.lblMultiSelectId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.btnSelectMany = new System.Windows.Forms.Button();
            this.btnSelectManyMultiple = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectTypes = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers Data with diffrent projection operators";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select () and SelectMany ()";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSingleSelect);
            this.groupBox1.Controls.Add(this.lblSingleResults);
            this.groupBox1.Location = new System.Drawing.Point(15, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single Select operator";
            // 
            // btnSingleSelect
            // 
            this.btnSingleSelect.Location = new System.Drawing.Point(25, 27);
            this.btnSingleSelect.Name = "btnSingleSelect";
            this.btnSingleSelect.Size = new System.Drawing.Size(88, 23);
            this.btnSingleSelect.TabIndex = 3;
            this.btnSingleSelect.Text = "Single Select";
            this.btnSingleSelect.UseVisualStyleBackColor = true;
            this.btnSingleSelect.Click += new System.EventHandler(this.btnSingleSelect_Click);
            // 
            // lblSingleResults
            // 
            this.lblSingleResults.AutoSize = true;
            this.lblSingleResults.ForeColor = System.Drawing.Color.Green;
            this.lblSingleResults.Location = new System.Drawing.Point(45, 67);
            this.lblSingleResults.Name = "lblSingleResults";
            this.lblSingleResults.Size = new System.Drawing.Size(42, 13);
            this.lblSingleResults.TabIndex = 1;
            this.lblSingleResults.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMultipleSelect);
            this.groupBox2.Controls.Add(this.lblMultiSelectName);
            this.groupBox2.Controls.Add(this.lblMultiSelectId);
            this.groupBox2.Location = new System.Drawing.Point(191, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Multiple";
            // 
            // btnMultipleSelect
            // 
            this.btnMultipleSelect.Location = new System.Drawing.Point(30, 27);
            this.btnMultipleSelect.Name = "btnMultipleSelect";
            this.btnMultipleSelect.Size = new System.Drawing.Size(88, 23);
            this.btnMultipleSelect.TabIndex = 3;
            this.btnMultipleSelect.Text = "Multiple Select";
            this.btnMultipleSelect.UseVisualStyleBackColor = true;
            this.btnMultipleSelect.Click += new System.EventHandler(this.btnMultipleSelect_Click);
            // 
            // lblMultiSelectName
            // 
            this.lblMultiSelectName.AutoSize = true;
            this.lblMultiSelectName.ForeColor = System.Drawing.Color.Green;
            this.lblMultiSelectName.Location = new System.Drawing.Point(44, 67);
            this.lblMultiSelectName.Name = "lblMultiSelectName";
            this.lblMultiSelectName.Size = new System.Drawing.Size(40, 13);
            this.lblMultiSelectName.TabIndex = 1;
            this.lblMultiSelectName.Text = "Names";
            // 
            // lblMultiSelectId
            // 
            this.lblMultiSelectId.AutoSize = true;
            this.lblMultiSelectId.ForeColor = System.Drawing.Color.Green;
            this.lblMultiSelectId.Location = new System.Drawing.Point(6, 67);
            this.lblMultiSelectId.Name = "lblMultiSelectId";
            this.lblMultiSelectId.Size = new System.Drawing.Size(21, 13);
            this.lblMultiSelectId.TabIndex = 1;
            this.lblMultiSelectId.Text = "Ids";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Controls.Add(this.btnSelectManyMultiple);
            this.groupBox3.Controls.Add(this.btnSelectMany);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.lblType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblSelectTypes);
            this.groupBox3.Controls.Add(this.lblProperties);
            this.groupBox3.Location = new System.Drawing.Point(364, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 380);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Many";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.Green;
            this.lblType.Location = new System.Drawing.Point(136, 80);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.ForeColor = System.Drawing.Color.Green;
            this.lblProperties.Location = new System.Drawing.Point(6, 80);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(54, 13);
            this.lblProperties.TabIndex = 1;
            this.lblProperties.Text = "Properties";
            // 
            // btnSelectMany
            // 
            this.btnSelectMany.Location = new System.Drawing.Point(9, 40);
            this.btnSelectMany.Name = "btnSelectMany";
            this.btnSelectMany.Size = new System.Drawing.Size(88, 23);
            this.btnSelectMany.TabIndex = 2;
            this.btnSelectMany.Text = "Select Many";
            this.btnSelectMany.UseVisualStyleBackColor = true;
            this.btnSelectMany.Click += new System.EventHandler(this.btnSelectMany_Click);
            // 
            // btnSelectManyMultiple
            // 
            this.btnSelectManyMultiple.Location = new System.Drawing.Point(139, 40);
            this.btnSelectManyMultiple.Name = "btnSelectManyMultiple";
            this.btnSelectManyMultiple.Size = new System.Drawing.Size(88, 23);
            this.btnSelectManyMultiple.TabIndex = 3;
            this.btnSelectManyMultiple.Text = "Select Many";
            this.btnSelectManyMultiple.UseVisualStyleBackColor = true;
            this.btnSelectManyMultiple.Click += new System.EventHandler(this.btnSelectManyMultiple_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Single";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Multiple";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Green;
            this.lblName.Location = new System.Drawing.Point(239, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Single";
            // 
            // lblSelectTypes
            // 
            this.lblSelectTypes.AutoSize = true;
            this.lblSelectTypes.ForeColor = System.Drawing.Color.Green;
            this.lblSelectTypes.Location = new System.Drawing.Point(361, 80);
            this.lblSelectTypes.Name = "lblSelectTypes";
            this.lblSelectTypes.Size = new System.Drawing.Size(31, 13);
            this.lblSelectTypes.TabIndex = 1;
            this.lblSelectTypes.Text = "Type";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(345, 42);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select ()";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // _04_ProjectionOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_04_ProjectionOperators";
            this.Text = "_04_ProjectionOperators";
            this.Load += new System.EventHandler(this._04_ProjectionOperators_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSingleSelect;
        private System.Windows.Forms.Label lblSingleResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMultipleSelect;
        private System.Windows.Forms.Label lblMultiSelectName;
        private System.Windows.Forms.Label lblMultiSelectId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelectMany;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Button btnSelectManyMultiple;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectTypes;
        private System.Windows.Forms.Button btnSelect;
    }
}