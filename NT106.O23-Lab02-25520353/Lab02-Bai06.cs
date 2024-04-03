using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NT106.O23_Lab02_25520353
{
    public partial class Lab02_Bai06 : Form
    {
        private string connectionString = "Data Source=HUONGGIANGDAO;Initial Catalog=SQLMONAN;Integrated Security=True;TrustServerCertificate=True";
        private Random random = new Random();

        public Lab02_Bai06()
        {
            InitializeComponent();
        }

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            // Khởi tạo ListView
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Xóa các item và cột hiện có trong ListView
            listViewMonAn.Items.Clear();
            listViewMonAn.Columns.Clear();

            // Thêm các cột vào ListView
            listViewMonAn.Columns.Add("IDMA", 50);
            listViewMonAn.Columns.Add("Tên món ăn", 150);
            listViewMonAn.Columns.Add("Hình ảnh", 150);

            // Xác định cách hiển thị cột
            listViewMonAn.View = View.Details;
            listViewMonAn.GridLines = true;
            listViewMonAn.FullRowSelect = true;
        }

        private string GetRandomDish()
        {
            string tenMonAn = "";
            int selectedIDMA = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Lấy số lượng món ăn trong cơ sở dữ liệu
                string queryCount = "SELECT COUNT(*) FROM MA";
                SqlCommand commandCount = new SqlCommand(queryCount, connection);
                int totalRecords = Convert.ToInt32(commandCount.ExecuteScalar());

                // Chọn ngẫu nhiên một IDMA
                selectedIDMA = random.Next(1, totalRecords + 1);
                
                // Truy vấn để lấy thông tin món ăn
                string queryDish = "SELECT TenMonAn FROM MA WHERE IDMA = @idma";
                SqlCommand commandDish = new SqlCommand(queryDish, connection);
                commandDish.Parameters.AddWithValue("@idma", selectedIDMA);
                SqlDataReader reader = commandDish.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy tên món ăn
                    tenMonAn = reader["TenMonAn"].ToString();
                }

                reader.Close();
            }

            return tenMonAn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy ngẫu nhiên một món ăn từ cơ sở dữ liệu
            string tenMonAn = GetRandomDish();

            // Hiển thị món ăn được chọn
            lblTenMonAn.Text = tenMonAn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trong ListView
            listViewMonAn.Items.Clear();

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn để lấy dữ liệu từ bảng MA
                string query = "SELECT * FROM MA";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Duyệt qua từng hàng dữ liệu và thêm vào ListView
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                    item.SubItems.Add(reader["TenMonAn"].ToString());
                    item.SubItems.Add(reader["HinhAnh"].ToString());
                    item.SubItems.Add(reader["iPNCC"].ToString());

                    listViewMonAn.Items.Add(item);
                }

                reader.Close();
            }

        }
    }
}
