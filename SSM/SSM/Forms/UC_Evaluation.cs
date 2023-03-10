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
    public partial class UC_Evaluation : UserControl
    {
        public UC_Evaluation()
        {
            InitializeComponent();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM AssessmentComponent", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectAssesmentComponenetIDComboBox.ValueMember = "Id";
                SelectAssesmentComponenetIDComboBox.DataSource = dt;
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
                SqlCommand sc = new SqlCommand("SELECT Id FROM RubricLevel", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectMeasurementID.ValueMember = "Id";
                SelectMeasurementID.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {


            // ... code to set up your SqlConnection ...
            var con = Configuration.getInstance().getConnection();
            // Replace these values with the actual IDs and measurement level you want to use
            int studentId = int.Parse(SelectStudentId.Text);
            int assessmentComponentId = int.Parse(SelectAssesmentComponenetIDComboBox.Text);
            int measurementLevel = int.Parse(SelectMeasurementID.Text);
            DateTime date = DatePicker.Value;

            // Define the SQL query as a string
            string sql = @"
                        INSERT INTO StudentResult (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate)
                        VALUES (
                        @StudentId,
                        @AssessmentComponentId,
                        (SELECT RubricLevel.Id FROM RubricLevel 
                        INNER JOIN Rubric ON RubricLevel.RubricId = Rubric.Id 
                        INNER JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId 
                        WHERE RubricLevel.MeasurementLevel = @MeasurementLevel AND AssessmentComponent.Id = @AssessmentComponentId),
                        @date )";

            // Create a new SqlCommand object with the SQL query and SqlConnection object
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                // Set the parameter values using SqlParameter objects
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@AssessmentComponentId", assessmentComponentId);
                command.Parameters.AddWithValue("@MeasurementLevel", measurementLevel);
                command.Parameters.AddWithValue("@date", date);

                // Execute the SQL query
                int rowsAffected = command.ExecuteNonQuery();

                // Check if any rows were affected (should be 1 if the insert was successful)
                if (rowsAffected == 1)
                {
                    Console.WriteLine("Student evaluation saved successfully.");
                }
                else
                {
                    Console.WriteLine("Error saving student evaluation.");
                }
            }

        }

        private void UC_Evaluation_Load(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Student", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectStudentId.ValueMember = "Id";
                SelectStudentId.DataSource = dt;                
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM AssessmentComponent", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectAssesmentComponenetIDComboBox.ValueMember = "Id";
                SelectAssesmentComponenetIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM RubricLevel", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectMeasurementID.ValueMember = "Id";
                SelectMeasurementID.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void StudentIDRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM Student", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectStudentId.ValueMember = "Id";
                SelectStudentId.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SelectStudentId_Enter(object sender, EventArgs e)
        {
           
        }

        private void SelectStudentId_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void SelectStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.Id,s.FirstName,s.LastName,s.Contact,s.Email,s.RegistrationNumber, l.Name as Status FROM Student s JOIN lookup l ON s.Status = l.LookupId where Id=@StudentId", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(SelectStudentId.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void StartEvaluation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
