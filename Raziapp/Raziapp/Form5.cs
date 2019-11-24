using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raziapp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            this.Hide();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            this.Hide();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 t = new Form6();
            this.Hide();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 t = new Form7();
            this.Hide();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 t = new Form8();
            this.Hide();
            t.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 100);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 t = new Form10();
            this.Hide();
            t.Show();
        }
    }
}
