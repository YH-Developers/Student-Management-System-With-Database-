using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace SSM.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashBoard_User_Control1.Show();
            student_User_Control1.Hide();
            attendence1.Hide();
            ucReports1.Hide();
            dashBoard_User_Control1.BringToFront();
        }



        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            student_User_Control1.Show();
            dashBoard_User_Control1.Hide();
            attendence1.Hide();
            ucReports1.Hide();
            uC_CLO1.Hide();
            student_User_Control1.BringToFront();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            dashBoard_User_Control1.Show();
            student_User_Control1.Hide();
            dashBoard_User_Control1.BringToFront();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnCalander_Click(object sender, EventArgs e)
        {
            attendence1.Show();
            student_User_Control1.Hide();
            dashBoard_User_Control1.Hide();
            attendence1.BringToFront();
        }

        private void Student_User_Control1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            uC_CLO1.Show();
            student_User_Control1.Hide();
            attendence1.Hide();
            dashBoard_User_Control1.Hide();
            uC_CLO1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ucReports1.Show();
            student_User_Control1.Hide();
            attendence1.Hide();
            dashBoard_User_Control1.Hide();
            ucReports1.BringToFront();
        }
    }
}
