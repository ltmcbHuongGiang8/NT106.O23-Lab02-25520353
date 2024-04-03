using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_Lab02_25520353
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 form = new Lab02_Bai03();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 form = new Lab02_Bai01();
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 form = new Lab02_Bai02();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 form = new Lab02_Bai04();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 form = new Lab02_Bai05();
            form.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab2_Bai07 form = new Lab2_Bai07();
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 form = new Lab02_Bai06();
            form.Show();

        }
    }
}
