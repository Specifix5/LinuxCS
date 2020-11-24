using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Drawing;

namespace Linux
{
    public partial class Desktop : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        public Desktop()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TestApp testapp = new TestApp();

            testapp.Show();
            SetParent(testapp.Handle, this.Handle);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Startup test = new Startup();
            TestApp t2 = new TestApp();
            t2.Close();
            test.Close();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pika pikac = new pika();
            pikac.Show();
            SetParent(pikac.Handle, this.Handle);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Internet ie = new Internet();
            ie.Show();
            SetParent(ie.Handle, this.Handle);
        }
    }
}
