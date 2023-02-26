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
    public partial class DashBoard_User_Control : UserControl
    {
        public DashBoard_User_Control()
        {
            InitializeComponent();
        }

        private void DashBoard_User_Control_Load(object sender, EventArgs e)
        {
            string stm = "SELECT COUNT(*) FROM Student";
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(stm, con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label5.Text = count.ToString();
                circularProgressBar1.Value = count;
                circularProgressBar1.Text = (count.ToString() + "%");
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            string stm = "SELECT COUNT(*) FROM Student";
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(stm, con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label5.Text = count.ToString();
                circularProgressBar1.Value = count;
                circularProgressBar1.Text = (count.ToString() + "%");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
