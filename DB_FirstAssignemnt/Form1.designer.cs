namespace Day5Assignment
{
    partial class Form1
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
            this.lblrollno = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.btselect = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.btfind = new System.Windows.Forms.Button();
            this.lblist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Profile";
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(80, 89);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(60, 20);
            this.lblrollno.TabIndex = 0;
            this.lblrollno.Text = "Roll No";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(80, 138);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(80, 189);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(52, 20);
            this.lbldob.TabIndex = 0;
            this.lbldob.Text = "D.O.B";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(80, 236);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(63, 20);
            this.lblgender.TabIndex = 0;
            this.lblgender.Text = "Gender";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(80, 336);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(60, 20);
            this.lblcourse.TabIndex = 0;
            this.lblcourse.Text = "Course";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(80, 384);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(78, 20);
            this.lblsemester.TabIndex = 0;
            this.lblsemester.Text = "Semester";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(80, 436);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(68, 20);
            this.lbladdress.TabIndex = 0;
            this.lbladdress.Text = "Address";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(80, 487);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(115, 20);
            this.lblphonenumber.TabIndex = 0;
            this.lblphonenumber.Text = "Phone Number";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(225, 540);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(100, 36);
            this.btadd.TabIndex = 1;
            this.btadd.Text = "Add New";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btselect
            // 
            this.btselect.Location = new System.Drawing.Point(372, 540);
            this.btselect.Name = "btselect";
            this.btselect.Size = new System.Drawing.Size(100, 36);
            this.btselect.TabIndex = 1;
            this.btselect.Text = "Select";
            this.btselect.UseVisualStyleBackColor = true;
            this.btselect.Click += new System.EventHandler(this.btselect_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(506, 540);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(100, 36);
            this.btupdate.TabIndex = 1;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(658, 540);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(100, 36);
            this.btdelete.TabIndex = 1;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(403, 86);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(340, 26);
            this.txtrollno.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(403, 135);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(340, 26);
            this.txtname.TabIndex = 2;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(403, 184);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(340, 26);
            this.dtpdob.TabIndex = 3;
            this.dtpdob.Value = new System.DateTime(2018, 7, 20, 0, 0, 0, 0);
            this.dtpdob.ValueChanged += new System.EventHandler(this.dtpdob_ValueChanged);
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(593, 234);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(80, 24);
            this.rbfemale.TabIndex = 4;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(470, 234);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(61, 24);
            this.rbmale.TabIndex = 4;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // cbcourse
            // 
            this.cbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "B.Tech",
            "M.Tech"});
            this.cbcourse.Location = new System.Drawing.Point(403, 333);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(340, 28);
            this.cbcourse.TabIndex = 5;
            // 
            // cbsemester
            // 
            this.cbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eight"});
            this.cbsemester.Location = new System.Drawing.Point(403, 381);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(340, 28);
            this.cbsemester.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(403, 433);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(340, 26);
            this.txtaddress.TabIndex = 2;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(403, 484);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(340, 26);
            this.txtphonenumber.TabIndex = 2;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(773, 81);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(100, 36);
            this.btfind.TabIndex = 1;
            this.btfind.Text = "Find";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.ItemHeight = 20;
            this.lblist.Location = new System.Drawing.Point(773, 126);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(432, 444);
            this.lblist.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1240, 604);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btselect);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblrollno);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btselect;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.ListBox lblist;
    }
}

