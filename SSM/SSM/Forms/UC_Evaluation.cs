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
    public partial class UC_Evaluation : UserControl
    {
        public UC_Evaluation()
        {
            InitializeComponent();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM AssessmentComponent", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectAssesmentComponenetIDComboBox.ValueMember = "Id";
                SelectAssesmentComponenetIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sc = new SqlCommand("SELECT Id FROM AssessmentComponent", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Load(reader);
                SelectAssesmentComponenetIDComboBox.ValueMember = "Id";
                SelectAssesmentComponenetIDComboBox.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
