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
    public partial class UC_ViewAttendence : UserControl
    {
        public UC_ViewAttendence()
        {
            InitializeComponent();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT A.AttendanceDate,  COUNT(CASE WHEN SA.AttendanceStatus = 1 THEN S.Id END) AS TotalPresent,   COUNT(CASE WHEN SA.AttendanceStatus = 2 THEN S.Id END) AS TotalAbsent ,  COUNT(CASE WHEN SA.AttendanceStatus = 3 THEN S.Id END) AS LeaveStudent ,  COUNT(CASE WHEN SA.AttendanceStatus = 4 THEN S.Id END) AS LateStudent FROM ClassAttendance A LEFT JOIN StudentAttendance SA ON A.Id = SA.AttendanceId \r\nLEFT JOIN Student S ON SA.StudentId = S.Id  GROUP BY A.AttendanceDate", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, new FileStream("Attendance.pdf", FileMode.Create));
            pdfDoc.Open();
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(@"Report_Pdf.png");
            image.ScaleAbsolute(50f, 50f);
            pdfDoc.Add(image);
            iTextSharp.text.Font headingFont = FontFactory.GetFont("Times New Roman", 18, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font headingFont1 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
            // Create a new paragraph for the heading
            Paragraph heading1 = new Paragraph("Student Management System", headingFont);
            heading1.Alignment = Element.ALIGN_LEFT;
            heading1.SpacingBefore = 10f;
            heading1.SpacingAfter = 10f;
            pdfDoc.Add(heading1);
            LineSeparator line = new LineSeparator();
            pdfDoc.Add(line);
            Paragraph heading = new Paragraph("Attendance Overview Report", headingFont1);
            heading.Alignment = Element.ALIGN_CENTER;
            heading.SpacingBefore = 10f;
            heading.SpacingAfter = 10f;
            pdfDoc.Add(heading);
            LineSeparator line1 = new LineSeparator();
            pdfDoc.Add(line1);
            PdfPTable pdfTable = new PdfPTable(bunifuDataGridView1.Columns.Count);

            // Add the heading to the document


            foreach (DataGridViewColumn column in bunifuDataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                    else
                    {
                        pdfTable.AddCell("");
                    }
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
            if (File.Exists("Attendance.pdf"))
            {
                System.Diagnostics.Process.Start("Attendance.pdf");
            }
        }
    }
}
