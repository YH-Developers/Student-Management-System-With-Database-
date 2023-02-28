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
using SSM.Forms;

namespace SSM.Forms
{
    public partial class Student_User_Control : UserControl
    {
        public Student_User_Control()
        {
            InitializeComponent();
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void Student_User_Control_Load(object sender, EventArgs e)
        {

        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            if(materialTextBox1.Text.Length<1)
            {
                ErrorLabel.Text= "ID can't be Emplty";
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(materialTextBox1.Text));
                cmd.ExecuteNonQuery();
                ErrorLabel.Text = " ";
                MessageBox.Show("Successfully saved");
                materialTextBox1.Clear();
            }
           
        }

        private void MaterialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void BunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
