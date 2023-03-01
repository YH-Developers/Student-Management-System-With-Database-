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
    public partial class Add_Student : UserControl
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void MaterialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void MaterialTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            bunifuButton4.Visible = true;
        }

        /// <summary>
        ///  Valid EMail Checker
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns></returns>
        bool IsValidEmail(string eMail)
        {
            bool Result = true;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }
        /// <summary>
        /// Email KeyPress Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void MaterialTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9'|| e.KeyChar >= '-' )
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        /// <summary>
        /// Add Studnet Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            // Hide Error Label
            bunifuLabel2.Text = " ";
            // Local Variables
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            string Regestration_Number = materialTextBox3.Text;
            /////////////////////////////////////////////////
            //////////////    Validation     ///////////////
            ///////////////////////////////////////////////
            if (txtName.Text.Length > 1)
            // First Name validation
            {
                if (materialTextBox1.Text.Length > 1)
                // Last Name validation
                {
                    if (PhoneNumber.Length == 11 && PhoneNumber[0] == '0' && PhoneNumber[1] == '3')
                    // Phone Number Validations
                    {
                        if (IsValidEmail(Email))
                        // Email Validation
                        {
                            if (Regestration_Number.Length > 8)
                            // Regestration Number Validation
                            {
                                if (Regestration_Number[4] == '-' && (Regestration_Number[7] == '-' || Regestration_Number[8] == '-'))
                                {
                                    AddStudent();   // Call Add Student Function
                                }

                            }
                            else { MessageBox.Show("Invalid Regestration Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        }
                        else { bunifuLabel2.Text = "Invalid Email"; }
                    }
                    else { MessageBox.Show("Invalid Phone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Last Name Can't Be Emplty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("First Name Can't Be Emplty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }



           
        }
        public void AddStudent()
        {
            int status = 0;
            if (ComboBoxSalary.Text.ToString() == "InActive")
            {
                status = 6;
            }
            else
            {
                status = 5;
            }
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("insert into Student values (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", con);
            con.Close();
            con.Open();
            cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
            cmd.Parameters.AddWithValue("@LastName", materialTextBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@RegistrationNumber", materialTextBox3.Text);
            cmd.Parameters.AddWithValue("@Status", status);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void TxtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Update Student Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            // Hide Error Label
            bunifuLabel2.Text = " ";
            // Local Variables
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            string Regestration_Number = materialTextBox3.Text;
            /////////////////////////////////////////////////
            //////////////    Validation     ///////////////
            ///////////////////////////////////////////////
            if (txtName.Text.Length > 1)
            // First Name validation
            {
                if(materialTextBox1.Text.Length > 1)
                // Last Name validation
                {
                    if(PhoneNumber.Length == 11 && PhoneNumber[0] == '0' && PhoneNumber[1] == '3')
                    // Phone Number Validations
                    {
                        if(IsValidEmail(Email))
                        // Email Validation
                        {
                            if(Regestration_Number.Length > 8)
                            // Regestration Number Validation
                            {
                                if(Regestration_Number[4] == '-' && (Regestration_Number[7] == '-' || Regestration_Number[8] == '-'))
                                {
                                    Update_Student();   // Call Update Student Function
                                }
                                
                            }
                            else { MessageBox.Show("Invalid Regestration Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        }
                        else { bunifuLabel2.Text = "Invalid Email"; }
                    }
                    else { MessageBox.Show("Invalid Phone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Last Name Can't Be Emplty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("First Name Can't Be Emplty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


           

            
        }
        /// <summary>
        /// Update Student Function
        /// </summary>
        public void Update_Student()
        {
            int status = 0;
            if (ComboBoxSalary.Text.ToString() == "Active")
            {
                status = 5;
            }
            else
            {
                status = 6;
            }
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName=@FirstName, LastName=@LastName,Contact=@Contact,Email=@Email,RegistrationNumber=@RegistrationNumber,Status=@Status WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(materialTextBox2.Text));
            cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
            cmd.Parameters.AddWithValue("@LastName", materialTextBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@RegistrationNumber", materialTextBox3.Text);
            cmd.Parameters.AddWithValue("@Status", status);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated...");
            // Function Call To Clear The Text Boxes After Update
            clear_textBoxes();
            // Make The Add Button Visible After Successfully Updating Student.
            bunifuButton4.Visible = true;
        }
        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            if(materialTextBox2.Text.Length >= 1 )
            {
                // Make The Add Button Invisible To make sure the validity to click only Update button
                bunifuButton4.Visible = false;
                Load_Student_Data();   // Call the Function to Load Data From Database
            }
            else { MessageBox.Show("ID Can't Be Emplty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
           
        }
        /// <summary>
        /// Function to Load Data For the Studnets To Update
        /// </summary>
        public void Load_Student_Data()
        {
            // Data BAse Connection To Show Data In the Text Boxes.
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student where ID=@ID", con);
            con.Close();
            con.Open();
            cmd.Parameters.AddWithValue("@ID", int.Parse(materialTextBox2.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txtName.Text = da.GetValue(1).ToString();
                materialTextBox1.Text = da.GetValue(2).ToString();
                txtPhoneNumber.Text = da.GetValue(3).ToString();
                txtEmail.Text = da.GetValue(4).ToString();
                materialTextBox3.Text = da.GetValue(5).ToString();
                //ComboBoxSalary.SelectedText = da.GetValue(6).ToString();
            }
            con.Close();
        }

        public void clear_textBoxes()
        {
            txtName.Clear();
            materialTextBox1.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            materialTextBox3.Clear();
        }
    }
}
