namespace LinqFormsApp.Tuts
{
    partial class _03_RestrictionOperators
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
            this.lblRestictionApplied = new System.Windows.Forms.Label();
            this.btnApplyRestriction = new System.Windows.Forms.Button();
            this.lblNums = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRestrictedWithIndex = new System.Windows.Forms.Label();
            this.lblNoteWithIndex = new System.Windows.Forms.Label();
            this.lblTheNums = new System.Windows.Forms.Label();
            this.btnRestrictionWithIndex = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRestrictIndexOnly = new System.Windows.Forms.Label();
            this.lblNoteIndexOnly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIndexOnly = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRestictionApplied);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.lblNums);
            this.groupBox1.Controls.Add(this.btnApplyRestriction);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restriction Operator (WHERE)";
            // 
            // lblRestictionApplied
            // 
            this.lblRestictionApplied.AutoSize = true;
            this.lblRestictionApplied.ForeColor = System.Drawing.Color.Green;
            this.lblRestictionApplied.Location = new System.Drawing.Point(111, 58);
            this.lblRestictionApplied.Name = "lblRestictionApplied";
            this.lblRestictionApplied.Size = new System.Drawing.Size(55, 13);
            this.lblRestictionApplied.TabIndex = 7;
            this.lblRestictionApplied.Text = "Restricted";
            this.lblRestictionApplied.Visible = false;
            // 
            // btnApplyRestriction
            // 
            this.btnApplyRestriction.Location = new System.Drawing.Point(9, 51);
            this.btnApplyRestriction.Name = "btnApplyRestriction";
            this.btnApplyRestriction.Size = new System.Drawing.Size(94, 23);
            this.btnApplyRestriction.TabIndex = 6;
            this.btnApplyRestriction.Text = "Apply Restriction";
            this.btnApplyRestriction.UseVisualStyleBackColor = true;
            this.btnApplyRestriction.Click += new System.EventHandler(this.btnApplyRestriction_Click);
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(6, 23);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(229, 13);
            this.lblNums.TabIndex = 5;
            this.lblNums.Text = "The Numbers are  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNote.Location = new System.Drawing.Point(6, 82);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(173, 13);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Operator applied as Func delegate.";
            this.lblNote.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestrictionWithIndex);
            this.groupBox2.Controls.Add(this.lblRestrictedWithIndex);
            this.groupBox2.Controls.Add(this.lblNoteWithIndex);
            this.groupBox2.Controls.Add(this.lblTheNums);
            this.groupBox2.Location = new System.Drawing.Point(10, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 104);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restriction Operator With index (WHERE, SELECT)";
            // 
            // lblRestrictedWithIndex
            // 
            this.lblRestrictedWithIndex.AutoSize = true;
            this.lblRestrictedWithIndex.ForeColor = System.Drawing.Color.Green;
            this.lblRestrictedWithIndex.Location = new System.Drawing.Point(111, 58);
            this.lblRestrictedWithIndex.Name = "lblRestrictedWithIndex";
            this.lblRestrictedWithIndex.Size = new System.Drawing.Size(55, 13);
            this.lblRestrictedWithIndex.TabIndex = 7;
            this.lblRestrictedWithIndex.Text = "Restricted";
            this.lblRestrictedWithIndex.Visible = false;
            // 
            // lblNoteWithIndex
            // 
            this.lblNoteWithIndex.AutoSize = true;
            this.lblNoteWithIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoteWithIndex.Location = new System.Drawing.Point(6, 82);
            this.lblNoteWithIndex.Name = "lblNoteWithIndex";
            this.lblNoteWithIndex.Size = new System.Drawing.Size(188, 13);
            this.lblNoteWithIndex.TabIndex = 5;
            this.lblNoteWithIndex.Text = "Operator applied with value and index.";
            this.lblNoteWithIndex.Visible = false;
            // 
            // lblTheNums
            // 
            this.lblTheNums.AutoSize = true;
            this.lblTheNums.Location = new System.Drawing.Point(6, 23);
            this.lblTheNums.Name = "lblTheNums";
            this.lblTheNums.Size = new System.Drawing.Size(229, 13);
            this.lblTheNums.TabIndex = 5;
            this.lblTheNums.Text = "The Numbers are  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }";
            // 
            // btnRestrictionWithIndex
            // 
            this.btnRestrictionWithIndex.Location = new System.Drawing.Point(9, 51);
            this.btnRestrictionWithIndex.Name = "btnRestrictionWithIndex";
            this.btnRestrictionWithIndex.Size = new System.Drawing.Size(94, 23);
            this.btnRestrictionWithIndex.TabIndex = 1;
            this.btnRestrictionWithIndex.Text = "Apply Restriction";
            this.btnRestrictionWithIndex.UseVisualStyleBackColor = true;
            this.btnRestrictionWithIndex.Click += new System.EventHandler(this.btnRestrictionWithIndex_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIndexOnly);
            this.groupBox3.Controls.Add(this.lblRestrictIndexOnly);
            this.groupBox3.Controls.Add(this.lblNoteIndexOnly);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(10, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 104);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "With index Only (WHERE, SELECT)";
            // 
            // lblRestrictIndexOnly
            // 
            this.lblRestrictIndexOnly.AutoSize = true;
            this.lblRestrictIndexOnly.ForeColor = System.Drawing.Color.Green;
            this.lblRestrictIndexOnly.Location = new System.Drawing.Point(111, 58);
            this.lblRestrictIndexOnly.Name = "lblRestrictIndexOnly";
            this.lblRestrictIndexOnly.Size = new System.Drawing.Size(55, 13);
            this.lblRestrictIndexOnly.TabIndex = 7;
            this.lblRestrictIndexOnly.Text = "Restricted";
            this.lblRestrictIndexOnly.Visible = false;
            // 
            // lblNoteIndexOnly
            // 
            this.lblNoteIndexOnly.AutoSize = true;
            this.lblNoteIndexOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoteIndexOnly.Location = new System.Drawing.Point(6, 82);
            this.lblNoteIndexOnly.Name = "lblNoteIndexOnly";
            this.lblNoteIndexOnly.Size = new System.Drawing.Size(160, 13);
            this.lblNoteIndexOnly.TabIndex = 5;
            this.lblNoteIndexOnly.Text = "Operator applied with index only.";
            this.lblNoteIndexOnly.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "The Numbers are  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }";
            // 
            // btnIndexOnly
            // 
            this.btnIndexOnly.Location = new System.Drawing.Point(9, 51);
            this.btnIndexOnly.Name = "btnIndexOnly";
            this.btnIndexOnly.Size = new System.Drawing.Size(94, 23);
            this.btnIndexOnly.TabIndex = 8;
            this.btnIndexOnly.Text = "Apply Restriction";
            this.btnIndexOnly.UseVisualStyleBackColor = true;
            this.btnIndexOnly.Click += new System.EventHandler(this.btnIndexOnly_Click);
            // 
            // _03_RestrictionOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "_03_RestrictionOperators";
            this.Text = "_03_RestrictionOperators";
            this.Load += new System.EventHandler(this._03_RestrictionOperators_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRestictionApplied;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Button btnApplyRestriction;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestrictionWithIndex;
        private System.Windows.Forms.Label lblRestrictedWithIndex;
        private System.Windows.Forms.Label lblNoteWithIndex;
        private System.Windows.Forms.Label lblTheNums;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIndexOnly;
        private System.Windows.Forms.Label lblRestrictIndexOnly;
        private System.Windows.Forms.Label lblNoteIndexOnly;
        private System.Windows.Forms.Label label3;
    }
}