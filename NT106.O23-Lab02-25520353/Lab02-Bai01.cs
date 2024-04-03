using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O23_Lab02_25520353
{
    public partial class Lab02_Bai01 : Form
    {
        string ip = @"D:\ki 2 nam 2\ltmcb\luutxt\input1.txt";
        string op = @"D:\ki 2 nam 2\ltmcb\luutxt\output1.txt";
        public Lab02_Bai01()
        {
            InitializeComponent();
        }
        private string ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp: " + ex.Message);
                return string.Empty;
            }
        }

        private void WriteToFile(string filePath, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi ghi vào tệp: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inf = ReadFromFile(ip);
            textBox1.Text = inf;    


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string content = textBox1.Text.ToUpper();
            WriteToFile(op, content);

        }
    }
}
