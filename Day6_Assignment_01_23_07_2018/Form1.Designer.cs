namespace Day6_Assignment_01_23_07_2018
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
            this.components = new System.ComponentModel.Container();
            this.lblist = new System.Windows.Forms.ListBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btselect = new System.Windows.Forms.Button();
            this.btfind = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblrollno = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentDBDataSet = new Day6_Assignment_01_23_07_2018.AssignmentDBDataSet();
            this.student_InfoTableAdapter = new Day6_Assignment_01_23_07_2018.AssignmentDBDataSetTableAdapters.Student_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.Location = new System.Drawing.Point(754, 107);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(432, 433);
            this.lblist.TabIndex = 30;
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
            this.cbsemester.Location = new System.Drawing.Point(384, 319);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(340, 21);
            this.cbsemester.TabIndex = 29;
            // 
            // cbcourse
            // 
            this.cbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "B.Tech",
            "M.Tech"});
            this.cbcourse.Location = new System.Drawing.Point(384, 271);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(340, 21);
            this.cbcourse.TabIndex = 28;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(451, 215);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(48, 17);
            this.rbmale.TabIndex = 27;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(574, 215);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 26;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(384, 165);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(340, 20);
            this.dtpdob.TabIndex = 25;
            this.dtpdob.Value = new System.DateTime(2018, 7, 20, 0, 0, 0, 0);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(384, 116);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(340, 20);
            this.txtname.TabIndex = 24;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(384, 422);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(340, 20);
            this.txtphonenumber.TabIndex = 23;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(384, 371);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(340, 20);
            this.txtaddress.TabIndex = 22;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(533, 491);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(100, 36);
            this.btdelete.TabIndex = 20;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(381, 491);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(100, 36);
            this.btupdate.TabIndex = 19;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btselect
            // 
            this.btselect.Location = new System.Drawing.Point(247, 491);
            this.btselect.Name = "btselect";
            this.btselect.Size = new System.Drawing.Size(100, 36);
            this.btselect.TabIndex = 18;
            this.btselect.Text = "Select";
            this.btselect.UseVisualStyleBackColor = true;
            this.btselect.Click += new System.EventHandler(this.btselect_Click);
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(754, 62);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(100, 36);
            this.btfind.TabIndex = 17;
            this.btfind.Text = "Find";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(100, 491);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(100, 36);
            this.btadd.TabIndex = 16;
            this.btadd.Text = "Add New";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(61, 425);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(78, 13);
            this.lblphonenumber.TabIndex = 14;
            this.lblphonenumber.Text = "Phone Number";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(61, 374);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 13;
            this.lbladdress.Text = "Address";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(61, 217);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 12;
            this.lblgender.Text = "Gender";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(61, 322);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(51, 13);
            this.lblsemester.TabIndex = 11;
            this.lblsemester.Text = "Semester";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(61, 170);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(36, 13);
            this.lbldob.TabIndex = 10;
            this.lbldob.Text = "D.O.B";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(61, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name";
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(61, 70);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(42, 13);
            this.lblrollno.TabIndex = 8;
            this.lblrollno.Text = "Roll No";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(61, 274);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(40, 13);
            this.lblcourse.TabIndex = 15;
            this.lblcourse.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Profile";
            // 
            // cbid
            // 
            this.cbid.DataSource = this.studentInfoBindingSource;
            this.cbid.DisplayMember = "Name";
            this.cbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(381, 70);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(343, 21);
            this.cbid.TabIndex = 31;
            this.cbid.ValueMember = "Roll_No";
            this.cbid.SelectedIndexChanged += new System.EventHandler(this.cbid_SelectedIndexChanged);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "Student_Info";
            this.studentInfoBindingSource.DataSource = this.assignmentDBDataSet;
            // 
            // assignmentDBDataSet
            // 
            this.assignmentDBDataSet.DataSetName = "AssignmentDBDataSet";
            this.assignmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_InfoTableAdapter
            // 
            this.student_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 582);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtaddress);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblist;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btselect;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbid;
        private AssignmentDBDataSet assignmentDBDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private AssignmentDBDataSetTableAdapters.Student_InfoTableAdapter student_InfoTableAdapter;
    }
}

