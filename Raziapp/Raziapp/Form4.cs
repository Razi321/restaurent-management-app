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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            this.Hide();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 tf = new Form5();
            this.Hide();
            tf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 td = new Form6();
            this.Hide();
            td.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 g = new Form7();
            this.Hide();
            g.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 t = new Form8();
            this.Hide();
            t.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
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
   

