using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;




namespace NT106.O23_Lab02_25520353
{
    public partial class Lab02_Bai03 : Form
    {
        string ip = @"D:\ki 2 nam 2\ltmcb\luutxt\input3.txt";
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void ReadFromFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    textBox1.AppendText(line + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Đọc File " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            ReadFromFile(ip);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(ip);
            List<string> results = new List<string>();
            foreach (string line in lines)
            {
                try
                {
                    string cleanLine = line.Replace(" ", "");
                    int result = 0;

                    string[] operands = Regex.Split(cleanLine, @"(?<=[+\-*/])|(?=[+\-*/])");
                    if (operands.Length < 3)
                    {
                        MessageBox.Show("Lỗi: Biểu thức không hợp lệ.");
                        return;
                    }

                    if (!int.TryParse(operands[0], out int num1))
                    {
                        MessageBox.Show("Lỗi: Biểu thức không hợp lệ.");
                        return;
                    }

                    for (int i = 1; i < operands.Length; i += 2)
                    {
                        string op = operands[i];
                        if (!int.TryParse(operands[i + 1], out int num2))
                        {
                            MessageBox.Show("Lỗi: Biểu thức không hợp lệ.");
                            return;
                        }

                        switch (op)
                        {
                            case "+":
                                result = num1 + num2;
                                break;
                            case "-":
                                result = num1 - num2;
                                break;
                            case "*":
                                result = num1 * num2;
                                break;
                            case "/":
                        
                                if (num2 == 0)
                                {
                                    MessageBox.Show("Lỗi: Số bị chia không được là 0.");
                                    return;
                                }
                                result = num1 / num2;
                                break;
                            default:
                                MessageBox.Show("Lỗi: Biểu thức không hợp lệ.");
                                return;
                        }

                        num1 = result;
                    }

                    results.Add(line + " = " + result.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                    return;
                }
            }

            try
            {
                string op = @"D:\ki 2 nam 2\ltmcb\luutxt\output3.txt";
                File.WriteAllLines(op, results);
                textBox2.Text = string.Join("\r\n", results);
                MessageBox.Show("Các phép tính đã được lưu vào file output3.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}");
            }
        }




    }
}
