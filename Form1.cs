using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linux
{
    public partial class Startup : Form
    {
        bool prg1 = false;
        public Startup()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label3.Text = $"Loading up Operating System ({progressBar1.Value}%)";

            }
            else if (progressBar1.Value > 99)
            {

                
                timer1.Stop();
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 0;
                timer2.Start();
                progressBar1.Style = ProgressBarStyle.Marquee;

            }

        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label3.Text = $"Exctracting Linux-Cosmic.tar.gz [dir_: \\LinuxCosmic\\System\\] ({progressBar1.Value}%)";
            }

            if (progressBar1.Value > 99)
            {
                timer2.Stop();
                Thread.Sleep(4000);

                Desktop test = new Desktop();
                test.Show();
                this.Hide();
                Console.WriteLine("Done!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}