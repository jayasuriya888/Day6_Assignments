using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Day5Assignment
{
    public partial class Form1 : Form
    {
        string constr = "Data Source=(local);Initial Catalog=AssignmentDB;Integrated Security=True;Pooling=False";
        SqlConnection con = null;
        SqlCommand cmd = null;
        string query = null;
        SqlDataReader read = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dtpdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
          
            string name = txtname.Text;
            DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
            string gender=null;
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            //string dept = cbdept.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            string address = txtaddress.Text;
            string phonenumber = txtphonenumber.Text;

            MessageBox.Show(name+"\n"+dob + "\n" +gender + "\n" +course + "\n" +address + "\n" +phonenumber);
            try
            {
                lblist.Items.Clear();
                con = new SqlConnection(constr);
                con.Open();
                query = "INSERT INTO [Student_Info](Name,Dob,Gender,Course,Semester,Address,PhoneNumber) VALUES (@name,@dob,@gen,@course,@sem,@add,@phno)";
                cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@dob",dtpdob.Value);
                cmd.Parameters.AddWithValue("@gen",gender);
                cmd.Parameters.AddWithValue("@course",course);
                cmd.Parameters.AddWithValue("@sem",semester);
                cmd.Parameters.AddWithValue("@add",address);
                cmd.Parameters.AddWithValue("@phno",phonenumber);
                int res = cmd.ExecuteNonQuery();
              
                if (res > 0)
                    MessageBox.Show("Inserted Successfully..." + res);
            }
            catch (SqlException sql)
            {
                MessageBox.Show("SQL ERROR MSG: "+sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION ERROR MSG: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btselect_Click(object sender, EventArgs e)
        {
            try
            {
                lblist.Items.Clear();
                con = new SqlConnection(constr);
                con.Open();
                query = "SELECT * FROM [Student_Info]";
                cmd = new SqlCommand(query,con);
                read = cmd.ExecuteReader();
                while(read.Read())
                {
                    for(int i=0;i<read.FieldCount;i++)
                    {
                        lblist.Items.Add(read[i]);
                    }
                    lblist.Items.Add("********************************");


                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btfind_Click(object sender, EventArgs e)
        {

            try
            {
                lblist.Items.Clear();
                con = new SqlConnection(constr);
                con.Open();
                query = "SELECT * FROM [Student_Info] WHERE [Roll_No]='" + txtrollno.Text + "'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        lblist.Items.Add(read[i]);
                    }
                    lblist.Items.Add("********************************");

                    txtname.Text = read["Name"].ToString();
                    dtpdob.Value = DateTime.Parse(read["Dob"].ToString());
                    if (read["Gender"].ToString() == "Male")
                        rbmale.Checked = true;
                    if (read["Gender"].ToString() == "Female")
                        rbmale.Checked = true;

                    cbcourse.SelectedItem = read["Course"].ToString();
                    cbsemester.SelectedItem = read["Semester"].ToString();
                    txtaddress.Text = read["Address"].ToString();
                    txtphonenumber.Text = read["PhoneNumber"].ToString();
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            lblist.Items.Clear();
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
            try
            {
                
                con = new SqlConnection(constr);
                con.Open();

                query = "UPDATE [Student_Info] SET [Name]=@name,[Dob]=@dob,[Gender]=@gen,[Course]=@course,[Semester]=@sem,[Address]=@add,[PhoneNumber]=@phno WHERE [Roll_No]='"+txtrollno.Text+"'";
                cmd = new SqlCommand(query,con);

                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@dob",dob);
                cmd.Parameters.AddWithValue("@gen",gender);
                cmd.Parameters.AddWithValue("@course",course);
                cmd.Parameters.AddWithValue("@sem",semester);
                cmd.Parameters.AddWithValue("@add",address);
                cmd.Parameters.AddWithValue("@phno",phonenumber);
                
                int res =  cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Updated Successfully");
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
               
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                query = "DELETE FROM [Student_Info] WHERE [Roll_No]='" + txtrollno.Text + "'";
                cmd = new SqlCommand(query, con);
                read = cmd.ExecuteReader();
               
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Deleted Succesfully...");
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

      
        }
    }

