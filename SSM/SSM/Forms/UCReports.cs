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
            SqlCommand cmd = new SqlCommand(" SELECT s.Id AS StudentId, s.FirstName, s.LastName, c.Id AS CloId, c.Name AS CloName, SUM(rc.TotalMarks) AS TotalMarks, SUM(rc.TotalWeightage) AS TotalWeightage FROM Student s LEFT JOIN StudentResult sr ON s.Id = sr.StudentId LEFT JOIN AssessmentComponent ac ON sr.AssessmentComponentId = ac.Id LEFT JOIN Rubric r ON ac.RubricId = r.Id LEFT JOIN Clo c ON r.CloId = c.Id LEFT JOIN RubricLevel rl ON r.Id = rl.RubricId AND sr.RubricMeasurementId = rl.Id GROUP BY s.Id, c.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;


           
        }
    }
}
