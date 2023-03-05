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
            if(Titletxt.Text==""){ TitleError.Text = "Enter Title !"; }
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
                }
            }




            

        }
    }
    
}
