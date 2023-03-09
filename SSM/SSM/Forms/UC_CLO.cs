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
                int id = Get_Max_ID(selectCloCombobox.Text);
                id++;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Rubric values (@id,@Details,@Cloid)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Details", RubricName.Text);
                cmd.Parameters.AddWithValue("@CloId", int.Parse(selectCloCombobox.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
            }
        }
        public int Get_Max_ID(string ID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Rubric", con);
            cmd2.Parameters.AddWithValue("@ID", ID);
            int count = Convert.ToInt32(cmd2.ExecuteScalar());
            if (count == 0)
            {
                return 0;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT Max(Id) FROM Rubric", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return (int)dt.Rows[0][0];
            }
        }


        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(RubricLeveltxt.Text == "")
            {
                RubricLevelError.Text = "Enter Rubric Level To save!";
            }
            else { RubricLevelError.Text = " ";
                    if (MeasurmentLeveltxt.Text == "")
                    {
                        MeasurementLevelError.Text = "Enter Rubric Name To save!";
                    }
                    else
                    {
                        MeasurementLevelError.Text = " ";
                        RubricError.Text = " ";
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("Insert into RubricLevel values (@RubricId,@Details,@MeasurementLevel)", con);
                        //cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@RubricId", int.Parse(SelectRubricIDComboBox.Text));
                        cmd.Parameters.AddWithValue("@Details", RubricLeveltxt.Text);
                        cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(MeasurmentLeveltxt.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved");
                    }
            }
        }

        

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (CloName.Text=="")
            {
                cloError.Text = "Enter Clo Name To Update";
            }
            else
            {
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
            Updateclocombobox.Visible = false;
            linkLabel1.Visible = false;
            CloName.Visible = false;
            bunifuThinButton21.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton25.Visible = false;
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
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("select Id from Clo", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                selectCloCombobox.ValueMember = "Id";
                selectCloCombobox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("select Id from Rubric", con);
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

        private void SelectCloCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuThinButton25_Click(object sender, EventArgs e)
        {
            Updateclocombobox.Visible = true;
            linkLabel1.Visible = true;
            bunifuThinButton21.Visible = false;
            bunifuThinButton24.Visible = false;
            CloName.Visible = false;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM RubricLevel WHERE RubricId IN (SELECT Rubric.Id FROM Rubric JOIN Clo ON Clo.Id = Rubric.CloId WHERE Clo.Name =@CloName); DELETE FROM Rubric WHERE CloId IN (SELECT Id FROM Clo WHERE Name =@CloName); DELETE FROM Clo WHERE Name =@CloName;", con);
            //cmd.Parameters.AddWithValue("@NewName", CloName.Text);
            cmd.Parameters.AddWithValue("@CloName", Updateclocombobox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted...");
        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {
            Updateclocombobox.Visible = true;
            linkLabel1.Visible = true;
            bunifuThinButton24.Visible = true;
            cloError.Visible = false;
            bunifuThinButton21.Visible = false;
            bunifuThinButton25.Visible = false;
        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {
            Updateclocombobox.Visible = true;
            CloName.Visible = false;
            bunifuThinButton25.Visible = true;
            bunifuThinButton21.Visible = false;
            bunifuThinButton24.Visible = false;
            cloError.Visible = false;
        }

        private void MaterialLabel3_Click(object sender, EventArgs e)
        {
            CloName.Visible = true;
            linkLabel1.Visible=false;
            Updateclocombobox.Visible = false;
            bunifuThinButton21.Visible = true;
            bunifuThinButton25.Visible = false;
            bunifuThinButton24.Visible = false;
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("select Id from Clo", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                selectCloCombobox.ValueMember = "Id";
                selectCloCombobox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("select Id from Rubric", con);
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
    }
}
