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
using static NT106.O23_Lab02_25520353.Lab02_Bai05.Cinema;

namespace NT106.O23_Lab02_25520353
{
    public partial class Lab02_Bai05 : Form
    {
        List<Cinema.Movie> movies;

        public class Cinema
        {
            public class Movie
            {
                public string Name { get; set; }
                public float Price { get; set; } // Change int to float
                public List<string> Room1Seats { get; set; }
                public List<string> Room2Seats { get; set; }
                public List<string> Room3Seats { get; set; }
                public float TotalRevenue { get; set; }

                public void CalculateTotalRevenue() // Thêm phương thức tính tổng doanh thu
                {
                    float revenueRoom1 = CalculateRevenueForRoom(Room1Seats);
                    float revenueRoom2 = CalculateRevenueForRoom(Room2Seats);
                    float revenueRoom3 = CalculateRevenueForRoom(Room3Seats);
                    TotalRevenue = revenueRoom1 + revenueRoom2 + revenueRoom3;
                }

                private float CalculateRevenueForRoom(List<string> seats) // Phương thức tính doanh thu cho từng phòng
                {
                    float revenue = 0;
                    foreach (var seat in seats)
                    {
                        revenue += CalculateTicketPrice(seat);
                    }
                    return revenue;
                }

                private float CalculateTicketPrice(string seat) // Giữ nguyên hàm tính giá vé
                {
                    if (seat == "A1" || seat == "A5" || seat == "C1" || seat == "C5")
                        return 1 / 4; // Ghế vé vớt
                    else if (seat == "A2" || seat == "A3" || seat == "A4" || seat == "C2" || seat == "C3" || seat == "C4")
                        return 1; // Ghế vé thường
                    else if (seat == "B2" || seat == "B3" || seat == "B4")
                        return 2; // Ghế vé VIP
                    else
                        return 0; // Ghế khác
                }
                public Movie(string name, float price) // Change int to float
                {
                    Name = name;
                    Price = price;
                    Room1Seats = new List<string>();
                    Room2Seats = new List<string>();
                    Room3Seats = new List<string>();
                }
                public List<string> GetBookedSeats(string room)
                {
                    switch (room)
                    {
                        case "P1":
                            return Room1Seats;
                        case "P2":
                            return Room2Seats;
                        case "P3":
                            return Room3Seats;
                        default:
                            throw new ArgumentException("Invalid room.");
                    }
                }
                public List<string> GetAvailableSeats(List<Movie> movies, string movieName, string room)
                {
                    List<string> allSeats = new List<string> {
                        "A1", "A2", "A3", "A4", "A5",
                        "B1", "B2", "B3", "B4", "B5",
                        "C1", "C2", "C3", "C4", "C5"
                    };

                    Movie selectedMovie = movies.FirstOrDefault(movie => movie.Name == movieName);
                    if (selectedMovie == null)
                    {
                        throw new ArgumentException("Không tìm thấy thông tin về phim đã chọn.");
                    }

                    List<string> roomSeats;
                    switch (room)
                    {
                        case "P1":
                            roomSeats = selectedMovie.Room1Seats;
                            break;
                        case "P2":
                            roomSeats = selectedMovie.Room2Seats;
                            break;
                        case "P3":
                            roomSeats = selectedMovie.Room3Seats;
                            break;
                        default:
                            throw new ArgumentException("Phòng không hợp lệ.");
                    }

                    List<string> bookedSeats = new List<string>();
                    bookedSeats.AddRange(roomSeats);

                    List<string> availableSeats = allSeats.Except(bookedSeats).ToList();

                    return availableSeats;
                }
            }
        }

        public Lab02_Bai05()
        {
            InitializeComponent();
            movies = new List<Cinema.Movie>();
        }

        private void ReadDataFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    movies.Clear();

                    for (int i = 0; i < lines.Length; i += 5)
                    {
                        string name = lines[i];
                        float price = float.Parse(lines[i + 1]); // Change int to float

                        List<string> room1Seats = new List<string>();
                        if (lines[i + 2].Trim().ToLower() != "null")
                        {
                            room1Seats = lines[i + 2].Split(',').Select(s => s.Trim()).ToList();
                        }

                        List<string> room2Seats = new List<string>();
                        if (lines[i + 3].Trim().ToLower() != "null")
                        {
                            room2Seats = lines[i + 3].Split(',').Select(s => s.Trim()).ToList();
                        }

                        List<string> room3Seats = new List<string>();
                        if (lines[i + 4].Trim().ToLower() != "null")
                        {
                            room3Seats = lines[i + 4].Split(',').Select(s => s.Trim()).ToList();
                        }

                        movies.Add(new Cinema.Movie(name, price)
                        {
                            Room1Seats = room1Seats,
                            Room2Seats = room2Seats,
                            Room3Seats = room3Seats
                        });
                    }

                    MessageBox.Show("Đã đọc file thành công.");
                    if (movies.Count > 0)
                    {
                        MessageBox.Show($"Tên của bộ phim đầu tiên: {movies[0].Name}");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp văn bản.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void LoadProcessBars()
        {
            if (movies.Count >= 4)
            {
                Cinema.Movie firstMovie = movies[0];
                Cinema.Movie secondMovie = movies[1];
                Cinema.Movie thirdMovie = movies[2];
                Cinema.Movie fourthMovie = movies[3];

                Maip2.Value = firstMovie.Room2Seats.Count;
                Maip3.Value = firstMovie.Room3Seats.Count;

                DPp1.Value = secondMovie.Room1Seats.Count;
                DPp2.Value = secondMovie.Room2Seats.Count;
                DPp3.Value = secondMovie.Room3Seats.Count;

                GLp1.Value = thirdMovie.Room1Seats.Count;
                TRp3.Value = fourthMovie.Room3Seats.Count;
            }
            else
            {
                MessageBox.Show("Danh sách phim không đủ.");
            }
        }
        private int TinhTongSoVeBanRa(Cinema.Movie movie)
        {
            // Tính tổng số lượng vé bán ra cho từng phòng
            int soldTicketsRoom1 = movie.Room1Seats.Count;
            int soldTicketsRoom2 = movie.Room2Seats.Count;
            int soldTicketsRoom3 = movie.Room3Seats.Count;

            // Tính tổng số lượng vé bán ra của phim
            int totalSoldTickets = soldTicketsRoom1 + soldTicketsRoom2 + soldTicketsRoom3;

            return totalSoldTickets;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp văn bản";
            openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ReadDataFromFile(filePath);
                LoadProcessBars();
            }
        }



        private void WriteMovieDataToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var movie in movies)
                    {
                        float revenueRoom1 = CalculateRevenueForMovie(movie, "P1");
                        float revenueRoom2 = CalculateRevenueForMovie(movie, "P2");
                        float revenueRoom3 = CalculateRevenueForMovie(movie, "P3");
                        float totalRevenue = revenueRoom1 + revenueRoom2 + revenueRoom3;
                        movie.CalculateTotalRevenue();
                    }

                    movies = movies.OrderByDescending(m => m.TotalRevenue).ToList();

                    foreach (var movie in movies)
                    {
                        int tongvebanra = movie.Room1Seats.Count + movie.Room2Seats.Count + movie.Room3Seats.Count;
                        int tongveton = 15 - tongvebanra;
                        float tile = ((float)tongveton / 15) * 100; // Change int to float

                        writer.WriteLine($"Tên phim: {movie.Name}, Giá vé: {movie.Price}");
                        writer.WriteLine("Số vé bán được:" + tongvebanra);
                        writer.WriteLine("Số vé tồn:" + tongveton);
                        writer.WriteLine("Tỉ lệ bán vé:" + tile);
                        writer.WriteLine("Tổng doanh thu: " + movie.TotalRevenue);
                        writer.WriteLine(); // Add an empty line between movies
                    }
                }

                MessageBox.Show("Đã ghi dữ liệu vào tệp thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp văn bản";
            openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                WriteMovieDataToFile(filePath);

            }
        }
        private float CalculateTicketPrice(string seat)
        {
            if (seat == "A1" || seat == "A5" || seat == "C1" || seat == "C5")
                return 1.0f / 4.0f; // Ghế vé vớt
            else if (seat == "A2" || seat == "A3" || seat == "A4" || seat == "C2" || seat == "C3" || seat == "C4")
                return 1.0f; // Ghế vé thường
            else if (seat == "B2" || seat == "B3" || seat == "B4")
                return 2.0f; // Ghế vé VIP
            else
                return 0.0f; // Ghế khác
        }

        private float CalculateRevenueForMovie(Movie movie, string room)
        {
            List<string> bookedSeats = movie.GetBookedSeats(room);
            float totalRevenue = 0;
            foreach (string seat in bookedSeats)
            {
                // Nhân giá vé với số lượng vé
                totalRevenue += CalculateTicketPrice(seat) * movie.Price;
            }
            return totalRevenue;
        }


    }
}
