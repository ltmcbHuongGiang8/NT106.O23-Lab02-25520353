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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBoxtenfl.Text = openFileDialog.SafeFileName;
                textBoxlinepath.Text = filePath;
                Thongtinteptin(filePath);

            }

        }
        private void Thongtinteptin(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            textBoxsize.Text = fileInfo.Length.ToString() + " bytes";
            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    wordCount += line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                }
            }

            textBoxline.Text = lineCount.ToString();
            textBoxw.Text = wordCount.ToString();
            textBoxct.Text = charCount.ToString();

            // Hiển thị nội dung của tệp tin
            try
            {
                textBoxnd.Text = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp tin: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
