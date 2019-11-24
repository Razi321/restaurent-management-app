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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 100);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 wt = new Form1();
            this.Hide();
            wt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            this.Hide();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 t = new Form5();
            this.Hide();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 t = new Form6();
            this.Hide();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 t = new Form8();
            this.Hide();
            t.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 t = new Form10();
            this.Hide();
            t.Show();
        }
    }
}
