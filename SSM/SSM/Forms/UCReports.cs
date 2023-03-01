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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SSM.Forms
{
    public partial class UCReports : UserControl
    {
        // Declare a global variable to store the path to the PDF file
        string pdfFilePath = @"report.pdf";
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

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            GeneratePdfReport(bunifuDataGridView1);
        }


        // Create a method to generate the PDF report
        public void GeneratePdfReport(DataGridView dataGridView)
        {
            // Create a new Document object with page size and margins
            Document document = new Document(PageSize.LETTER, 36, 36, 54, 36);

            try
            {
                // Create a new PdfWriter object to write the PDF file
                PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));

                // Open the document
                document.Open();

                // Create a new PdfPTable object with the same number of columns as the DataGridView control
                PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);

                // Loop through each column in the DataGridView control and add a new PdfPCell object to the PdfPTable object
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText));
                    pdfTable.AddCell(cell);
                }

                // Loop through each row in the DataGridView control and add a new PdfPCell object to the PdfPTable object
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView[j, i].Value != null)
                        {
                            pdfTable.AddCell(new Phrase(dataGridView[j, i].Value.ToString()));
                        }
                    }
                }

                // Add the PdfPTable object to the document
                document.Add(pdfTable);
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the document
                document.Close();

                // Display a message box with the path to the PDF file
                MessageBox.Show("PDF report generated successfully. File saved at: " + pdfFilePath);
            }
        }
    }
}
