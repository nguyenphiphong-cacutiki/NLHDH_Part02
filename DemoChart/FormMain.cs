using DemoChart;
using PROCESS_P2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLHDH_API
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0, 255, 255, 255);
            pictureBox2.BackColor = Color.FromArgb(0, 255, 255, 255);
            pictureBox3.BackColor = Color.FromArgb(0, 255, 255, 255);
            label1.BackColor = Color.FromArgb(0, 255, 255, 255);
            label2.BackColor = Color.FromArgb(0, 255, 255, 255);
            label3.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process_P2 fp = new Process_P2();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChatThread ft = new ChatThread();
            this.Hide();
            ft.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Algorithm fd = new Algorithm();
            this.Hide();
            fd.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
