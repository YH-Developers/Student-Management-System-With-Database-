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

namespace SSM.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashBoard_User_Control1.Show();
            student_User_Control1.Hide();
            dashBoard_User_Control1.BringToFront();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            student_User_Control1.Show();
            dashBoard_User_Control1.Hide();
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

        private void Student_User_Control1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalander_Click(object sender, EventArgs e)
        {
            add_Student1.Show();
            student_User_Control1.Hide();
            dashBoard_User_Control1.Hide();
            add_Student1.BringToFront();
        }
    }
}
