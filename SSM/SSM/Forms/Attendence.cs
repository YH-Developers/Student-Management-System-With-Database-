﻿using System;
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
using System.Net;
using System.Net.Mail;

namespace SSM.Forms
{
    public partial class Attendence : UserControl
    {
        // Declare a global variable to store the path to the PDF file
        string pdfFilePath = @"Attendence.pdf";
        public Attendence()
        {
            InitializeComponent();
            //bunifuDataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Check if the current column is a DataGridViewComboBoxColumn
            DataGridViewComboBoxColumn comboBoxColumn = bunifuDataGridView1.Columns[bunifuDataGridView1.CurrentCell.ColumnIndex] as DataGridViewComboBoxColumn;
            if (comboBoxColumn != null)
            {
                // Retrieve the name of the ComboBox control
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    string comboBoxName = comboBox.Name;
                    MessageBox.Show("The name of the ComboBox is: " + comboBoxName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        ///   Load Data into Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attendence_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.Id, s.FirstName, s.LastName FROM Student s", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.Id, s.FirstName, s.LastName FROM Student s", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void BunifuDataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'P' || e.KeyChar == 'A' || e.KeyChar == 'L')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
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
                Paragraph heading = new Paragraph("Attendence Report", headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                heading.SpacingAfter = 10f;

                // Add the heading to the document
                document.Add(heading);
                // Create a new LineSeparator object
                LineSeparator line = new LineSeparator();

                // Add the line separator to the paragraph
                document.Add(line);
                DateTime attendanceDate = guna2DateTimePicker1.Value;
                // Create a new paragraph for the course name
                iTextSharp.text.Font courseFont = FontFactory.GetFont("Times New Roman", 12);
                Paragraph course = new Paragraph("Date : "+attendanceDate.ToString(), courseFont);
                course.Alignment = Element.ALIGN_LEFT;
                course.IndentationLeft = 55f; // Add a little space from the left side
                course.SpacingAfter = 20f;

                // Add the course name to the document
                document.Add(course);
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

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            DateTime attendanceDate = guna2DateTimePicker1.Value;

            var con = Configuration.getInstance().getConnection();

                // Insert the attendance date into the ClassAttendance table and retrieve the new AttendanceId
                string insertQuery = "INSERT INTO ClassAttendance (AttendanceDate) VALUES (@AttendanceDate); SELECT SCOPE_IDENTITY();";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                {
                    insertCommand.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                    int attendanceId = Convert.ToInt32(insertCommand.ExecuteScalar());

                    // Use a transaction to ensure atomicity of database operations
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                        {
                            string status = row.Cells["Status"].Value.ToString();
                        // Check for null values before using them
                        if (row.Cells["Status"].Value == null || row.Cells["Id"].Value == null)
                        {
                            throw new Exception("Invalid attendance data.");
                        }
                        // Perform a lookup of the string value and retrieve the corresponding integer value
                        int attendanceStatus;
                            switch (status)
                            {
                                case "Present":
                                    attendanceStatus = 1;
                                    break;
                                case "Absent":
                                    attendanceStatus = 2;
                                    break;
                                case "Leave":
                                    attendanceStatus = 3;
                                    break;
                            case "Late":
                                attendanceStatus = 4;
                                break;
                            default:
                                    throw new Exception("Invalid attendance status.");
                            }

                            int studentId = (int)row.Cells["Id"].Value;

                            // Check if the attendance record already exists
                            string checkQuery = "SELECT COUNT(*) FROM StudentAttendance WHERE AttendanceId = @AttendanceId AND StudentId = @StudentId";
                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, con, transaction))
                            {
                                checkCommand.Parameters.AddWithValue("@AttendanceId", attendanceId);
                                checkCommand.Parameters.AddWithValue("@StudentId", studentId);
                                int count = (int)checkCommand.ExecuteScalar();

                                if (count == 0)
                                {
                                    // Insert a new attendance record
                                    string insertAttendanceQuery = "INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) VALUES (@AttendanceId, @StudentId, @AttendanceStatus)";
                                    using (SqlCommand insertAttendanceCommand = new SqlCommand(insertAttendanceQuery, con, transaction))
                                    {
                                        insertAttendanceCommand.Parameters.AddWithValue("@AttendanceId", attendanceId);
                                        insertAttendanceCommand.Parameters.AddWithValue("@StudentId", studentId);
                                        insertAttendanceCommand.Parameters.AddWithValue("@AttendanceStatus", attendanceStatus);
                                        insertAttendanceCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Update an existing attendance record
                                    string updateAttendanceQuery = "UPDATE StudentAttendance SET AttendanceStatus = @AttendanceStatus WHERE AttendanceId = @AttendanceId AND StudentId = @StudentId";
                                    using (SqlCommand updateAttendanceCommand = new SqlCommand(updateAttendanceQuery, con, transaction))
                                    {
                                        updateAttendanceCommand.Parameters.AddWithValue("@AttendanceId", attendanceId);
                                        updateAttendanceCommand.Parameters.AddWithValue("@StudentId", studentId);
                                        updateAttendanceCommand.Parameters.AddWithValue("@AttendanceStatus", attendanceStatus);
                                        updateAttendanceCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Attendance saved successfully.");
                    Email_Snd();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving attendance: " + ex.Message);
                    }
                }
        }

        public void Email_Snd()
        {
            DateTime attendanceDate = guna2DateTimePicker1.Value;

            // Get all the student emails
            string query = "SELECT Email FROM Student";
            var con = Configuration.getInstance().getConnection();
            using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Store the emails in an array
                        var emails = new System.Collections.Generic.List<string>();

                        while (reader.Read())
                        {
                            string email = (string)reader["Email"];
                            emails.Add(email);
                        }

                        // Send a "hello" email to each student
                        foreach (string email in emails)
                        {
                            SendHelloEmail(email, attendanceDate);
                        }
                    }
                }

            
        }

        static void SendHelloEmail(string email, DateTime attendanceDate)
        {
            
            // Replace the SMTP server, email address, password, and message text with your own values
            string smtpServer = "smtp.gmail.com";
            string fromEmail = "hyasir368@gmail.com";
            string password = "mgdbfkdshsmllgri";
            string message = "Assalamulaikum! \n \t \n Hope You are doing well.Your Attendence have been marked for "+attendanceDate.ToString()+"\n\n Don't Reply this message as it is an AutoGenerated Mail";

            using (var client = new SmtpClient(smtpServer))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromEmail, password);
                client.EnableSsl = true;
                client.Port = 587;

                using (var msg = new MailMessage(fromEmail, email, "Database Attendence", message))
                {
                    client.Send(msg);
                }
            }

           MessageBox.Show("Sent hello email to :"+ email);
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            UC_ViewAttendence newUserControl = new UC_ViewAttendence();
            this.Parent.Controls.Add(newUserControl);
            newUserControl.BringToFront();
        }
    }
}

