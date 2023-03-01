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
    public partial class UCReports : UserControl
    {
        public UCReports()
        {
            InitializeComponent();
        }

        private void UCReports_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.Id AS StudentId, s.FirstName, s.LastName, assessment.Title AS AssessmentTitle, SUM(CASE WHEN rubric.CloId = 1 THEN rubricLevel.MeasurementLevel * assessmentComponent.TotalMarks / assessment.TotalWeightage ELSE NULL END) AS Clo1_Obtained,SUM(CASE WHEN rubric.CloId = 1 THEN assessmentComponent.TotalMarks ELSE NULL END) AS Clo1_Total,SUM(CASE WHEN rubric.CloId = 2 THEN rubricLevel.MeasurementLevel * assessmentComponent.TotalMarks / assessment.TotalWeightage ELSE NULL END) AS Clo2_Obtained,SUM(CASE WHEN rubric.CloId = 2 THEN assessmentComponent.TotalMarks ELSE NULL END) AS Clo2_Total,SUM(CASE WHEN rubric.CloId = 3 THEN rubricLevel.MeasurementLevel * assessmentComponent.TotalMarks / assessment.TotalWeightage ELSE NULL END) AS Clo3_Obtained,SUM(CASE WHEN rubric.CloId = 3 THEN assessmentComponent.TotalMarks ELSE NULL END) AS Clo3_Total,SUM(rubricLevel.MeasurementLevel * assessmentComponent.TotalMarks / assessment.TotalWeightage) AS ObtainedMarks,SUM(assessmentComponent.TotalMarks) AS TotalMarks,assessment.DateCreated FROM Student s INNER JOIN StudentResult studentResult ON s.Id = studentResult.StudentId INNER JOIN AssessmentComponent assessmentComponent ON studentResult.AssessmentComponentId = assessmentComponent.Id INNER JOIN Assessment assessment ON assessmentComponent.AssessmentId = assessment.Id INNER JOIN Rubric rubric ON assessmentComponent.RubricId = rubric.Id INNER JOIN RubricLevel rubricLevel ON rubric.Id = rubricLevel.RubricId AND studentResult.RubricMeasurementId = rubricLevel.Id GROUP BY s.Id, s.FirstName, s.LastName, assessment.Title, assessment.DateCreated ORDER BY s.LastName, s.FirstName, assessment.DateCreated", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }
    }
}
