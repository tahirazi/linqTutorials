namespace LinqFormsApp.Tuts
{
    partial class _01_ExtensionMethods
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
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.btnChangeCase = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEvens = new System.Windows.Forms.Label();
            this.lblNums = new System.Windows.Forms.Label();
            this.btnFindEvens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeCase);
            this.groupBox1.Controls.Add(this.lblAfter);
            this.groupBox1.Controls.Add(this.lblBefore);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.lblLabel);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Extension Method";
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(12, 57);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(83, 13);
            this.lblBefore.TabIndex = 1;
            this.lblBefore.Text = "TextCaseBefore";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(12, 22);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(252, 13);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "It simply extends the string class with a new method.";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.ForeColor = System.Drawing.Color.Red;
            this.lblAfter.Location = new System.Drawing.Point(206, 57);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(74, 13);
            this.lblAfter.TabIndex = 1;
            this.lblAfter.Text = "TextCaseAfter";
            this.lblAfter.Visible = false;
            // 
            // btnChangeCase
            // 
            this.btnChangeCase.Location = new System.Drawing.Point(101, 52);
            this.btnChangeCase.Name = "btnChangeCase";
            this.btnChangeCase.Size = new System.Drawing.Size(91, 23);
            this.btnChangeCase.TabIndex = 1;
            this.btnChangeCase.Text = "Change Case";
            this.btnChangeCase.UseVisualStyleBackColor = true;
            this.btnChangeCase.Click += new System.EventHandler(this.btnChangeCase_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Green;
            this.lblNote.Location = new System.Drawing.Point(81, 84);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(130, 13);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "First Letter case changed.";
            this.lblNote.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFindEvens);
            this.groupBox2.Controls.Add(this.lblEvens);
            this.groupBox2.Controls.Add(this.lblNums);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "The Extension Method";
            // 
            // lblEvens
            // 
            this.lblEvens.AutoSize = true;
            this.lblEvens.ForeColor = System.Drawing.Color.Red;
            this.lblEvens.Location = new System.Drawing.Point(12, 85);
            this.lblEvens.Name = "lblEvens";
            this.lblEvens.Size = new System.Drawing.Size(65, 13);
            this.lblEvens.TabIndex = 1;
            this.lblEvens.Text = "The Evens: ";
            this.lblEvens.Visible = false;
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(12, 22);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(241, 13);
            this.lblNums.TabIndex = 1;
            this.lblNums.Text = "The Numbers are  { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }";
            // 
            // btnFindEvens
            // 
            this.btnFindEvens.Location = new System.Drawing.Point(15, 49);
            this.btnFindEvens.Name = "btnFindEvens";
            this.btnFindEvens.Size = new System.Drawing.Size(75, 23);
            this.btnFindEvens.TabIndex = 1;
            this.btnFindEvens.Text = "Find Even";
            this.btnFindEvens.UseVisualStyleBackColor = true;
            this.btnFindEvens.Click += new System.EventHandler(this.btnFindEvens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "It uses extension method wrapper class style syntax.";
            this.label1.Visible = false;
            // 
            // _01_ExtensionMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "_01_ExtensionMethods";
            this.Text = "_01_ExtensionMethods";
            this.Load += new System.EventHandler(this._01_ExtensionMethods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeCase;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFindEvens;
        private System.Windows.Forms.Label lblEvens;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Label label1;
    }
}