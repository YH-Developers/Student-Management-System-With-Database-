using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSM.Forms
{
    public partial class UC_CLO : UserControl
    {
        public UC_CLO()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(CloName.Text=="")
            {
                cloError.Text = "Enter Clo Name To save !";
            }
            else
            {
                cloError.Text = " ";
            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(RubricName.Text=="")
            {
                RubricError.Text = "Enter Rubric Name To save!";
            }
            else
            {
                RubricError.Text = " ";
            }
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(RubricLeveltxt.Text == "")
            {
                RubricLevelError.Text = "Enter Rubric Level To save!";
            }
            else
            {
                RubricLevelError.Text = " ";
            }

            if (MeasurmentLeveltxt.Text == "")
            {
                MeasurementLevelError.Text = "Enter Rubric Name To save!";
            }
            else
            {
                MeasurementLevelError.Text = " ";
            }
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            Updateclocombobox.Visible = true;
            bunifuThinButton21.Visible = false;
            if (CloName.Text == "")
            {
                cloError.Text = "Enter Clo Name To save !";
            }
            else
            {
                cloError.Text = " ";
            }
        }
    }
}
