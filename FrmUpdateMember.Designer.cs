namespace _07LabExercise1
{
    partial class FrmUpdateMember
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbRegistredStudentID = new System.Windows.Forms.ComboBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.TBFirstname = new System.Windows.Forms.TextBox();
            this.TBmiddleName = new System.Windows.Forms.TextBox();
            this.TBAge = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Program:";
            // 
            // CbRegistredStudentID
            // 
            this.CbRegistredStudentID.FormattingEnabled = true;
            this.CbRegistredStudentID.Location = new System.Drawing.Point(12, 67);
            this.CbRegistredStudentID.Name = "CbRegistredStudentID";
            this.CbRegistredStudentID.Size = new System.Drawing.Size(281, 34);
            this.CbRegistredStudentID.TabIndex = 7;
            this.CbRegistredStudentID.SelectedIndexChanged += new System.EventHandler(this.CbRegistredStudentID_SelectedIndexChanged);
            // 
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CBGender.Location = new System.Drawing.Point(12, 431);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(152, 34);
            this.CBGender.TabIndex = 8;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BS in Information Technology",
            "BS in Computer Science"});
            this.cbProgram.Location = new System.Drawing.Point(12, 509);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(281, 34);
            this.cbProgram.TabIndex = 9;
            // 
            // TBlastname
            // 
            this.TBlastname.Location = new System.Drawing.Point(12, 142);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(281, 33);
            this.TBlastname.TabIndex = 10;
            // 
            // TBFirstname
            // 
            this.TBFirstname.Location = new System.Drawing.Point(12, 212);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.Size = new System.Drawing.Size(281, 33);
            this.TBFirstname.TabIndex = 11;
            // 
            // TBmiddleName
            // 
            this.TBmiddleName.Location = new System.Drawing.Point(12, 294);
            this.TBmiddleName.Name = "TBmiddleName";
            this.TBmiddleName.Size = new System.Drawing.Size(281, 33);
            this.TBmiddleName.TabIndex = 12;
            // 
            // TBAge
            // 
            this.TBAge.Location = new System.Drawing.Point(12, 366);
            this.TBAge.Name = "TBAge";
            this.TBAge.Size = new System.Drawing.Size(100, 33);
            this.TBAge.TabIndex = 13;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnConfirm.ForeColor = System.Drawing.Color.Sienna;
            this.BtnConfirm.Location = new System.Drawing.Point(74, 559);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(185, 37);
            this.BtnConfirm.TabIndex = 14;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 617);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TBAge);
            this.Controls.Add(this.TBmiddleName);
            this.Controls.Add(this.TBFirstname);
            this.Controls.Add(this.TBlastname);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.CbRegistredStudentID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbRegistredStudentID;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.TextBox TBFirstname;
        private System.Windows.Forms.TextBox TBmiddleName;
        private System.Windows.Forms.TextBox TBAge;
        private System.Windows.Forms.Button BtnConfirm;
    }
}