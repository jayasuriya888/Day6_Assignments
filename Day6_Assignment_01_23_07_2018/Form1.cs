using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_Assignment_01_23_07_2018
{
    public partial class Form1 : Form
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
            string gender = null;
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            //string dept = cbdept.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            string address = txtaddress.Text;
            string phonenumber = txtphonenumber.Text;

            Student_Info si = new Student_Info();
            si.Name = name;
            si.Dob = dob;
            si.Gender = gender;
            si.Course = course;
            si.Semester = semester;
            si.Address = address;
            si.PhoneNumber = phonenumber;

            db.Student_Info.Add(si);
            var data = db.SaveChanges();
            if (data >0)
            MessageBox.Show("Data inserted...");
            else
                MessageBox.Show("Data Not Inserted...");
        }

        private void btselect_Click(object sender, EventArgs e)
        {
            lblist.Items.Clear();
            foreach(var v in db.Student_Info)
            {
                lblist.Items.Add(v.Roll_No);
                lblist.Items.Add(v.Name);
                lblist.Items.Add(v.Gender);
                lblist.Items.Add(v.Dob);
                lblist.Items.Add(v.Course);
                lblist.Items.Add(v.Semester);
                lblist.Items.Add(v.Address);
                lblist.Items.Add(v.PhoneNumber);
                lblist.Items.Add("++++++++++++++++++++++++++++++++++++++");
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
            string gender = null;
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            string address = txtaddress.Text;
            string phonenumber = txtphonenumber.Text;

            int id = (int)cbid.SelectedValue;

            var si = db.Student_Info.Where(x => id == x.Roll_No).SingleOrDefault();
            si.Name =name;
            si.Dob = dob;
            si.Gender = gender;
            si.Course = course;
            si.Semester = semester;
            si.Address = address;
            si.PhoneNumber = phonenumber;

            db.Student_Info.Add(si);
            var result = db.SaveChanges();
            if (result > 0)
                MessageBox.Show("Data Updated...");

            this.student_InfoTableAdapter.Fill(this.assignmentDBDataSet.Student_Info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentDBDataSet.Student_Info' table. You can move, or remove it, as needed.
            this.student_InfoTableAdapter.Fill(this.assignmentDBDataSet.Student_Info);

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            
            Student_Info si = new Student_Info();
            int id = (int)cbid.SelectedValue;
            var del = (from t in db.Student_Info where t.Roll_No == id select t).SingleOrDefault();
            db.Student_Info.Remove(del);
            var result = db.SaveChanges();
            if (result > 0)
                MessageBox.Show("Data Deleted..");
            this.student_InfoTableAdapter.Fill(this.assignmentDBDataSet.Student_Info);
        }

        private void cbid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btfind_Click(object sender, EventArgs e)
        {
            lblist.Items.Clear();
            int id = (int)cbid.SelectedValue;
            var sel = (from t in db.Student_Info where t.Roll_No == id select t).SingleOrDefault();
            lblist.Items.Add(sel.Roll_No);
            lblist.Items.Add(sel.Name);
            lblist.Items.Add(sel.Gender);
            lblist.Items.Add(sel.Dob);
            lblist.Items.Add(sel.Course);
            lblist.Items.Add(sel.Semester);
            lblist.Items.Add(sel.Address);
            lblist.Items.Add(sel.PhoneNumber);
            lblist.Items.Add("+++++++++++++++++++++++++++++++");

        }
    }
}
