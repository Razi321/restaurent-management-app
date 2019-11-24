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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 tbb = new Form2();
            this.Hide();
            tbb.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 100);
        }
    }
}
