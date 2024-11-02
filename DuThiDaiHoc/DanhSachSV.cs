using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBConnect; // Tham chiếu đến namespace DBConnect để sử dụng lớp Connection

namespace DuThiDaiHoc
{
    public partial class DanhSachSV : Form
    {
        // Khởi tạo đối tượng kết nối
        private Connection dbConnection = new Connection();

        public DanhSachSV()
        {
            InitializeComponent();
            LoadHoSoThiSinhData();
        }

        // Phương thức để lấy dữ liệu từ bảng HoSoThiSinh và hiển thị trong DataGridView
        private void LoadHoSoThiSinhData()
        {
            // Câu truy vấn để lấy tất cả dữ liệu từ bảng HoSoThiSinh
            string query = "SELECT * FROM HoSoThiSinh";

            try
            {
                // Sử dụng phương thức ExecuteReader của lớp Connection để lấy dữ liệu
                SqlDataReader reader = dbConnection.ExecuteReader(query);

                // Tạo DataTable để chứa dữ liệu từ SqlDataReader
                DataTable dataTable = new DataTable();
                dataTable.Load(reader); // Nạp dữ liệu từ SqlDataReader vào DataTable

                // Gán DataTable cho DataGridView
                dataGridView1.DataSource = dataTable;

                // Đảm bảo đóng SqlDataReader sau khi hoàn thành
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi");
            }
        }

        // Sự kiện khi form tải
        private void DanhSachSV_Load(object sender, EventArgs e)
        {
            LoadHoSoThiSinhData(); // Tải dữ liệu khi form mở
        }
    }
}
