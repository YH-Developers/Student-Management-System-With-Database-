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
using iTextSharp.text.pdf.draw;
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
            SqlCommand cmd = new SqlCommand(@"SELECT S.RegistrationNumber, CASE WHEN A.Id IS NULL THEN '-' ELSE A.Title END AS Assessment, CASE WHEN AC.Name IS NULL THEN '-' ELSE AC.Name END AS AssesmentComponent , CASE WHEN AC.Id IS NULL THEN '-' ELSE C.Name END AS CLO, CASE WHEN A.Id IS NULL THEN '-' ELSE AC.TotalMarks END AS TotalMarks, CASE WHEN AC.Name IS NULL THEN '0' ELSE CAST( (SUM(((RL.MeasurementLevel/(RL.Maximum*1.0)) * AC.TotalMarks))) AS decimal(9,2)) END  AS Obtained_Marks
FROM Student S
LEFT JOIN StudentResult SR
ON S.Id = SR.StudentId
LEFT JOIN AssessmentComponent AC
ON AC.Id = SR.AssessmentComponentId
LEFT JOIN Assessment A
ON A.Id = AC.AssessmentId
LEFT JOIN Rubric R
ON R.Id = AC.RubricId
LEFT JOIN Clo C
ON C.Id = R.CloId
LEFT JOIN (SELECT Id,RubricId ,MeasurementLevel , R.Maximum FROM RubricLevel, (SELECT 
		RubricId AS RID, Max(RubricLevel.MeasurementLevel) AS Maximum 
		FROM RubricLevel 
		GROUP BY RubricId) AS R 
		WHERE RubricLevel.RubricId = R.RID ) AS RL
ON SR.RubricMeasurementId = RL.ID
GROUP BY S.Id, S.RegistrationNumber, A.Id,A.Title, AC.Id, AC.Name, AC.TotalMarks, C.Id, C.Name
HAVING S.RegistrationNumber LIKE '%'
", con);
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
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(@"Report_Pdf.png");
                image.ScaleAbsolute(50f, 50f);
                document.Add(image);


                // Create a new font for the heading
                iTextSharp.text.Font headingFont = FontFactory.GetFont("Times New Roman", 18, iTextSharp.text.Font.BOLD);

                // Create a new paragraph for the heading
                Paragraph heading = new Paragraph("Final Report", headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                heading.SpacingAfter = 10f;

                // Add the heading to the document
                document.Add(heading);
                // Create a new LineSeparator object
                LineSeparator line = new LineSeparator();

                // Add the line separator to the paragraph
                document.Add(line);

                // Create a new paragraph for the course name
                iTextSharp.text.Font courseFont = FontFactory.GetFont("Times New Roman", 12);
                Paragraph course = new Paragraph("Course: Database", courseFont);
                course.Alignment = Element.ALIGN_LEFT;
                course.IndentationLeft = 55f; // Add a little space from the left side
                course.SpacingAfter = 20f;

                // Add the course name to the document
                document.Add(course);

                // Create a new PdfPTable object with the same number of columns as the DataGridView control
                PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);

                // Set the font size of the table
                iTextSharp.text.Font tableFont = FontFactory.GetFont("Times New Roman", 10);

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
                if (File.Exists("report.pdf"))
                {
                    System.Diagnostics.Process.Start("report.pdf");
                }
            }
        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
