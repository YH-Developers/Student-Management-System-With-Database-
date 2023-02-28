using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSM.Forms
{
    public partial class SplashScrren : Form
    {
        int i = 0;
        public SplashScrren()
        {
            InitializeComponent();
            //timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value = i;
            i++;
            if(i==100)
            {
                timer1.Stop();
                this.Hide();
                Dashboard f1 = new Dashboard();
                f1.Show();
            }
        }
    }
}
