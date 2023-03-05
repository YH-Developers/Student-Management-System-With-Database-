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

namespace SSM.Forms
{
    public partial class UC_Assesment : UserControl
    {
        public UC_Assesment()
        {
            InitializeComponent();
        }

        private void UC_Assesment_Load(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Assessment", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectAssesmentIDComboBox.ValueMember = "Id";
                SelectAssesmentIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Rubric", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectRubricIDComboBox.ValueMember = "Id";
                SelectRubricIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Title FROM Assessment", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Title", typeof(string));
                dt.Load(reader);
                UpdateAssesmentcombobox.ValueMember = "Title";
                UpdateAssesmentcombobox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Titletxt.Text == "") { TitleError.Text = "Enter Title !"; }
            else
            {
                TitleError.Text = " ";
                if (markstxt.Text == "") { marksError.Text = "Enter Marks ! "; }
                else
                {
                    marksError.Text = " ";
                    if (weightagetxt.Text == "") { weightageError.Text = "Enter Weightage ! "; }
                    else
                    {
                        try
                        {
                            weightageError.Text = " ";
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES(@Title,  GETDATE(), @TotalMarks,@TotalWeightage); ", con);
                            cmd.Parameters.AddWithValue("@Title", Titletxt.Text);
                            //cmd.Parameters.AddWithValue("@DateCreated", int.Parse(SelectRubricIDComboBox.Text));
                            cmd.Parameters.AddWithValue("@TotalMarks", markstxt.Text);
                            cmd.Parameters.AddWithValue("@TotalWeightage", weightagetxt.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Connecting To Server");
                        }
                    }
                }
            }
        }

        private void AddAssesment_Click(object sender, EventArgs e)
        {
            Titletxt.Visible = true;
            markstxt.Visible = true;
            weightagetxt.Visible = true;
            SaveButton.Visible = true;

            UpdateAssesmentcombobox.Visible = false;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            Refresh.Visible = false;
        }

        private void UpdateAssesment_Click(object sender, EventArgs e)
        {
            Titletxt.Visible = true;
            markstxt.Visible = true;
            weightagetxt.Visible = true;
            UpdateBtn.Visible = true;
            Refresh.Visible = true;
            UpdateAssesmentcombobox.Visible = true;

            SaveButton.Visible = false;
            DeleteBtn.Visible = false;
        }

        private void DeleteAssesment_Click(object sender, EventArgs e)
        {
            Refresh.Visible = true;
            UpdateAssesmentcombobox.Visible = true;
            DeleteBtn.Visible = true;

            Titletxt.Visible = false;
            markstxt.Visible = false;
            weightagetxt.Visible = false;
            UpdateBtn.Visible = false;


            SaveButton.Visible = false;
            UpdateBtn.Visible = false;
        }

        private void Refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Title FROM Assessment", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Title", typeof(string));
                dt.Load(reader);
                UpdateAssesmentcombobox.ValueMember = "Title";
                UpdateAssesmentcombobox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Titletxt.Text == "") { TitleError.Text = "Enter Title !"; }
            else
            {
                TitleError.Text = " ";
                if (markstxt.Text == "") { marksError.Text = "Enter Marks ! "; }
                else
                {
                    marksError.Text = " ";
                    if (weightagetxt.Text == "") { weightageError.Text = "Enter Weightage ! "; }
                    else
                    {
                        try
                        {
                            weightageError.Text = " ";
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("UPDATE Assessment SET Title = @NewTitle, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Title = @PreviousTitle;", con);
                            cmd.Parameters.AddWithValue("@NewTitle", Titletxt.Text);
                            cmd.Parameters.AddWithValue("@PreviousTitle", UpdateAssesmentcombobox.Text);
                            cmd.Parameters.AddWithValue("@TotalMarks", markstxt.Text);
                            cmd.Parameters.AddWithValue("@TotalWeightage", weightagetxt.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Updated");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Connecting To Server");
                        }
                    }
                }
            }






        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Assessment WHERE Title = @Title; DELETE FROM AssessmentComponent WHERE AssessmentId IN (SELECT Id FROM Assessment WHERE Title = @Title);", con);
                cmd.Parameters.AddWithValue("@Title", UpdateAssesmentcombobox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting To Server");
            }

        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Rubric", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectRubricIDComboBox.ValueMember = "Id";
                SelectRubricIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Assessment", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectAssesmentIDComboBox.ValueMember = "Id";
                SelectAssesmentIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Titletxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar <= ' ' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void Markstxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Weightagetxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar <= ' ' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TotalMarkstxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text == "") { NameError.Text = "Enter Name !"; }
            else
            {
                NameError.Text = " ";
                if (TotalMarkstxt.Text == "") { TotalMarkslError.Text = "Enter Marks ! "; }
                else
                {
                    TotalMarkslError.Text = " ";
                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSERT INTO AssessmentComponent (Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES(@Name,@RubricId, @TotalMarks, GETDATE(), GETDATE(), @AssessmentId);", con);
                        cmd.Parameters.AddWithValue("@Name", Nametxt.Text);
                        cmd.Parameters.AddWithValue("@RubricId", int.Parse(SelectRubricIDComboBox.Text));
                        cmd.Parameters.AddWithValue("@TotalMarks", TotalMarkstxt.Text);
                        cmd.Parameters.AddWithValue("@AssessmentId", int.Parse(SelectAssesmentIDComboBox.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Connecting To Server");
                    }

                }
            }
        }

    }
}
