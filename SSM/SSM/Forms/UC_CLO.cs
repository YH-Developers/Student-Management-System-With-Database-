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
    public partial class UC_CLO : UserControl
    {
        public UC_CLO()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(CloName.Text=="")
            {
                cloError.Text = "Enter Clo Name To save !";
            }
            else
            {
                cloError.Text = " ";
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES(@Name, GETDATE(), GETDATE()); ", con);
                cmd.Parameters.AddWithValue("@Name", CloName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(RubricName.Text=="")
            {
                RubricError.Text = "Enter Rubric Name To save!";
            }
            else
            {
                RubricError.Text = " ";
            }
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(RubricLeveltxt.Text == "")
            {
                RubricLevelError.Text = "Enter Rubric Level To save!";
            }
            else
            {
                RubricLevelError.Text = " ";
            }

            if (MeasurmentLeveltxt.Text == "")
            {
                MeasurementLevelError.Text = "Enter Rubric Name To save!";
            }
            else
            {
                MeasurementLevelError.Text = " ";
            }
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            Updateclocombobox.Visible = true;
            linkLabel1.Visible = true;
            bunifuThinButton21.Visible = false;
            if (CloName.Text == "")
            {
                cloError.Text = "Enter Clo Name To save !";
            }
            else
            {
                cloError.Text = " ";

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name=@NewName WHERE Name=@OldName", con);
                cmd.Parameters.AddWithValue("@NewName", CloName.Text);
                cmd.Parameters.AddWithValue("@OldName", Updateclocombobox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated...");
            }
        }

        private void UC_CLO_Load(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("select Name from Clo", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Load(reader);
                Updateclocombobox.ValueMember = "Name";
                Updateclocombobox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CloName_Click(object sender, EventArgs e)
        {

        }

        private void Updateclocombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("select Name from Clo", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Load(reader);
                Updateclocombobox.ValueMember = "Name";
                Updateclocombobox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
