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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 100);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form10 t = new Form10();
            this.Hide();
            t.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 t = new Form7();
            this.Hide();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 t = new Form9();
            this.Hide();
            t.Show();
        }
    }
}
