using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SSM.Forms;

namespace SSM.Forms
{
    public partial class Student_User_Control : UserControl
    {
        public Student_User_Control()
        {
            InitializeComponent();
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT s.Id,s.FirstName,s.LastName,s.Contact,s.Email,s.RegistrationNumber, l.Name as Status FROM Student s JOIN lookup l ON s.Status = l.LookupId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
            }
            catch(Exception)
            {
                MessageBox.Show("Database Error");
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Student", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectId.ValueMember = "Id";
                SelectId.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error");
            }

        }

        private void Student_User_Control_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.Id,s.FirstName,s.LastName,s.Contact,s.Email,s.RegistrationNumber, l.Name as Status FROM Student s JOIN lookup l ON s.Status = l.LookupId;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(@"
                        DELETE FROM StudentAttendance WHERE StudentId = @ID;
                        DELETE FROM StudentResult WHERE StudentId = @ID;
                        DELETE FROM ClassAttendance WHERE Id IN(SELECT AttendanceId FROM StudentAttendance WHERE StudentId = @ID);
                        DELETE FROM Student WHERE Id = @ID;                        
", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(SelectId.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully deleted...");

        }

        private void MaterialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student newUserControl = new Add_Student();
            this.Parent.Controls.Add(newUserControl);
            newUserControl.BringToFront();

        }

        private void BunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
