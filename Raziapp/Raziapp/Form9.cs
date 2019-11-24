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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 100);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            this.Hide();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 lm = new Form8();
            this.Hide();
            lm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 lm = new Form4();
            this.Hide();
            lm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 lm = new Form5();
            this.Hide();
            lm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 lm = new Form6();
            this.Hide();
            lm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 lm = new Form7();
            this.Hide();
            lm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form10 t = new Form10();
            this.Hide();
            t.Show();
        }
    }
}
