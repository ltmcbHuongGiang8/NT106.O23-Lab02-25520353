using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106.O23_Lab02_25520353
{

    public partial class Lab02_Bai04 : Form
    {
        int currentPage = 0;
        private string ip = @"D:\ki 2 nam 2\ltmcb\luutxt\input4.txt";
        private string op = @"D:\ki 2 nam 2\ltmcb\\luutxt\output4.txt";
        private List<SinhVien> sinhViens;

        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        

        private void ReadDataFromFile()
        {
            if (File.Exists(ip))
            {
                string[] lines = File.ReadAllLines(ip);

                sinhViens = new List<SinhVien>();
                int count = 0;

                for (int i = 0; i < lines.Length; i += 7) 
                {
                    SinhVien sinhVien = new SinhVien();

                    sinhVien.HoTen = lines[i];
                    sinhVien.MSSV = int.Parse(lines[i + 1]);
                    sinhVien.DienThoai = lines[i + 2];
                    sinhVien.DiemMon1 = float.Parse(lines[i + 3]);
                    sinhVien.DiemMon2 = float.Parse(lines[i + 4]);
                    sinhVien.DiemMon3 = float.Parse(lines[i + 5]);

                    if (sinhVien.DienThoai.Length != 10 || sinhVien.DienThoai[0] != '0' || !sinhVien.DienThoai.All(char.IsDigit) ||
                sinhVien.MSSV.ToString().Length != 8 ||
                sinhVien.DiemMon1 < 0 || sinhVien.DiemMon1 > 10 ||
                sinhVien.DiemMon2 < 0 || sinhVien.DiemMon2 > 10 ||
                sinhVien.DiemMon3 < 0 || sinhVien.DiemMon3 > 10)
                    {
                        MessageBox.Show($"Sinh viên {sinhVien.HoTen} bị bỏ qua vì dữ liệu không hợp lệ.");
                        continue;
                    }

                    sinhViens.Add(sinhVien);
                    count++;

                }

                DisplayDataInTextBox();
            }
            else
            {
                MessageBox.Show("File input4.txt không tồn tại.");
            }
        }

        private void DisplayDataInTextBox()
        {
            textBox1.Clear();

            foreach (SinhVien sv in sinhViens)
            {
                textBox1.AppendText(sv.HoTen + Environment.NewLine);
                textBox1.AppendText(sv.MSSV + Environment.NewLine);
                textBox1.AppendText(sv.DienThoai + Environment.NewLine);
                textBox1.AppendText(sv.DiemMon1 + Environment.NewLine);
                textBox1.AppendText(sv.DiemMon2 + Environment.NewLine);
                textBox1.AppendText(sv.DiemMon3 + Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        public class SinhVien
        {
            public string HoTen;
            public int MSSV;
            public string DienThoai;
            public float DiemMon1;
            public float DiemMon2;
            public float DiemMon3;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (sinhViens == null || sinhViens.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống hoặc chưa được tải.");
                return;
            }
            currentPage++;

            if (currentPage > sinhViens.Count)
            {
                MessageBox.Show("Hết sinh viên.");
                currentPage = sinhViens.Count;
                return;
            }

            DisplayStudent(currentPage - 1);
            ShowCurrentPage();

        }
        private void ShowCurrentPage()
        {
            labelPage.Text = $"Page: {currentPage}";
        }

        private void DisplayStudent(int index)
        {
            ITen.Text = sinhViens[index].HoTen;
            IID.Text = sinhViens[index].MSSV.ToString();
            Iphone.Text = sinhViens[index].DienThoai;
            Id1.Text = sinhViens[index].DiemMon1.ToString();
            Id2.Text = sinhViens[index].DiemMon2.ToString();
            Id3.Text = sinhViens[index].DiemMon3.ToString();

        }
        private void IDocFIle_Click_1(object sender, EventArgs e)
        {
            ReadDataFromFile();
        }

        private void Back_Click(object sender, EventArgs e)
        {
          
            if (sinhViens == null || sinhViens.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống hoặc chưa được tải.");
                return;
            }

            if (currentPage <= 1)
            {
                MessageBox.Show("Không thể quay lại.");
                return;
            }

            currentPage--;
            DisplayStudent(currentPage - 1);
            ShowCurrentPage();

        }
        private float TinhDiemTrungBinhTheoPage(int currentPage)
        {
            if (currentPage < 1 || currentPage > sinhViens.Count)
            {
                return 0;
            }

            int index = currentPage - 1; 
            SinhVien sinhVien = sinhViens[index];

            float diemTrungBinh = (sinhVien.DiemMon1 + sinhVien.DiemMon2 + sinhVien.DiemMon3) / 3.0f;

            return diemTrungBinh;
        }

        private void Add_Click(object sender, EventArgs e)
        {

            int index = currentPage - 1;
            if (index >= 0 && index < sinhViens.Count)
            {
                SinhVien sinhVien = sinhViens[index];
                OTen.Text = sinhVien.HoTen;
                OIP.Text = sinhVien.MSSV.ToString();
                Ophone.Text = sinhVien.DienThoai;
                Od1.Text = sinhVien.DiemMon1.ToString();
                Od2.Text = sinhVien.DiemMon2.ToString();
                Od3.Text = sinhVien.DiemMon3.ToString();

                
                float diemTrungBinh = (sinhVien.DiemMon1 + sinhVien.DiemMon2 + sinhVien.DiemMon3) / 3;
                Odtb.Text = diemTrungBinh.ToString();
            }
        }
        private void SaveTextBoxesToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(OTen.Text);
                    writer.WriteLine(OIP.Text);
                    writer.WriteLine(Ophone.Text);
                    writer.WriteLine(Od1.Text);
                    writer.WriteLine(Od2.Text);
                    writer.WriteLine(Od3.Text);
                    writer.WriteLine(Odtb.Text);
                    writer.WriteLine();
                }

                MessageBox.Show("Lưu thành công vào tệp: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void OWrite_Click(object sender, EventArgs e)
        {
            SaveTextBoxesToFile(op);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
