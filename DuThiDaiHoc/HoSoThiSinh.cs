using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBConnect;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DuThiDaiHoc
{
    public partial class HoSoThiSinh : Form
    {
        public static bool checkClick = false;
        public int SoBD;
        private Connection dbConnection = new Connection();
        public HoSoThiSinh()
        {
            InitializeComponent();
            loadCboQueQuan();
            loadCboGioiTinh();
            loadCboKhuVuc();
            loadCboUuTien();
            loadCboDoiTuong();

           

            loadData();
        }
        public HoSoThiSinh(int SoBD)
        {
            InitializeComponent();
            loadCboQueQuan();
            loadCboGioiTinh();
            loadCboKhuVuc();
            loadCboUuTien();
            loadCboDoiTuong();

            

            this.SoBD = SoBD;
            loadData();
            
        }
        public void loadData()
        {
            try
            {
                dbConnection.OpenConnection();

                // Câu truy vấn SQL
                string query = @"SELECT HoTen, NgaySinh, GioiTinh, AnhSinhVien, 
                                TenQue, TenKhuVuc, TenUuTien, TenDoiTuong 
                         FROM HoSoThiSinh 
                         JOIN QueQuan ON QueQuan.MaQue = HoSoThiSinh.MaQueQuan
                         JOIN KhuVuc ON KhuVuc.MaKhuVuc = HoSoThiSinh.MaKhuVuc
                         JOIN UuTien ON UuTien.MaUuTien = HoSoThiSinh.MaUuTien
                         JOIN DoiTuong ON DoiTuong.MaDoiTuong = HoSoThiSinh.MaDoiTuong
                         WHERE SoBD = @SoBD";  // Sửa lại thành @SoBD

                // Truyền đúng tên biến @SoBD
                SqlParameter[] parameters =
                {
            new SqlParameter("@SoBD", this.SoBD)  // Đảm bảo biến đúng tên và kiểu dữ liệu
        };

                // Thực thi câu truy vấn
                SqlDataReader reader = dbConnection.ExecuteReader(query, parameters);

                if (reader.Read())  // Đọc kết quả
                {
                    txtHoTen.Text = reader["HoTen"].ToString();
                    dtpNgaySinh.Value = (DateTime)reader["NgaySinh"];
                    //MessageBox.Show (reader["TenQue"].ToString());
                    //MessageBox.Show(reader["TenKhuVuc"].ToString());
                    //MessageBox.Show(reader["TenUuTien"].ToString());
                    //MessageBox.Show(reader["TenDoiTuong"].ToString());
                    cboQueQuan.Text = reader["TenQue"].ToString();
                    cboKhuVuc.Text = reader["TenKhuVuc"].ToString();
                    cboUuTien.Text = reader["TenUuTien"].ToString();
                    cboDoiTuong.Text = reader["TenDoiTuong"].ToString();
                    cboGioiTinh.Text = reader["GioiTinh"].ToString();
                    string duongDanAnh;
                    // Lấy đường dẫn ảnh từ kết quả
                    if (reader["AnhSinhVien"].ToString() != null)
                        duongDanAnh = reader["AnhSinhVien"].ToString();
                    else duongDanAnh = "C:\\Users\\luu79\\source\\repos\\DuThiDaiHoc\\image\\user.png";

                    // Kiểm tra và load ảnh vào PictureBox
                    if (File.Exists(duongDanAnh))
                    {
                        if (picAnhSinhVien.Image != null)
                        {
                            picAnhSinhVien.Image.Dispose();  // Giải phóng bộ nhớ ảnh cũ
                        }

                        picAnhSinhVien.Image = Image.FromFile(duongDanAnh);  // Load ảnh mới
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy ảnh tại đường dẫn đã lưu.");
                        picAnhSinhVien.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với số báo danh này.");
                }

                reader.Close();  // Đóng SqlDataReader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);  // Xử lý lỗi nếu có
            }
            finally
            {
                dbConnection.CloseConnection();  // Đảm bảo luôn đóng kết nối
            }
        }

        private void loadCboQueQuan()
        {
            dbConnection.OpenConnection();
            cboQueQuan.DropDownHeight = 100;
            cboQueQuan.DropDownStyle = ComboBoxStyle.DropDownList;

            string query = "SELECT MaQue, TenQue FROM QueQuan";
            SqlParameter[] parameters = null;


            SqlDataReader reader = dbConnection.ExecuteReader(query, parameters);


            if (reader != null)
            {
                while (reader.Read())
                {

                    cboQueQuan.Items.Add(new { MaQue = reader["MaQue"].ToString(), TenQue = reader["TenQue"].ToString() });
                }

                reader.Close();
            }
            cboQueQuan.DisplayMember = "TenQue"; // Hiển thị TenQue
            cboQueQuan.ValueMember = "MaQue";    // Giá trị thực là MaQue
            dbConnection.CloseConnection();
        }
        private void loadCboGioiTinh()
        {

            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Khác");
        }

        public void loadCboKhuVuc()
        {
            dbConnection.OpenConnection();
            cboKhuVuc.DropDownHeight = 100;
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;

            string query = "SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc";
            SqlParameter[] parameters = null;


            SqlDataReader reader = dbConnection.ExecuteReader(query, parameters);


            if (reader != null)
            {
                while (reader.Read())
                {

                    cboKhuVuc.Items.Add(new { MaKhuVuc = reader["MaKhuVuc"].ToString(), TenKhuVuc = reader["TenKhuVuc"].ToString() });
                }

                reader.Close();
            }

            cboKhuVuc.DisplayMember = "TenKhuVuc";
            cboKhuVuc.ValueMember = "MaKhuVuc";
            dbConnection.CloseConnection();
        }
        public void loadCboUuTien()
        {
            dbConnection.OpenConnection();
            cboUuTien.DropDownHeight = 100;
            cboUuTien.DropDownStyle = ComboBoxStyle.DropDownList;

            string query = "SELECT MaUuTien, TenUuTien FROM UuTien";
            SqlParameter[] parameters = null;


            SqlDataReader reader = dbConnection.ExecuteReader(query, parameters);


            if (reader != null)
            {
                while (reader.Read())
                {

                    cboUuTien.Items.Add(new { MaUuTien = reader["MaUuTien"].ToString(), TenUuTien = reader["TenUuTien"].ToString() });
                }

                reader.Close();
            }

            cboUuTien.DisplayMember = "TenUuTien";
            cboUuTien.ValueMember = "MaUuTien";
            dbConnection.CloseConnection();
        }
        public void loadCboDoiTuong()
        {
            cboDoiTuong.DropDownHeight = 100;
            cboDoiTuong.DropDownStyle = ComboBoxStyle.DropDownList;

            string query = "SELECT MaDoiTuong, TenDoiTuong FROM DoiTuong";
            SqlParameter[] parameters = null;


            SqlDataReader reader = dbConnection.ExecuteReader(query, parameters);


            if (reader != null)
            {
                while (reader.Read())
                {

                    cboDoiTuong.Items.Add(new { MaDoiTuong = reader["MaDoiTuong"].ToString(), TenDoiTuong = reader["TenDoiTuong"].ToString() });
                }

                reader.Close();
            }

            cboDoiTuong.DisplayMember = "TenDoiTuong";
            cboDoiTuong.ValueMember = "MaDoiTuong";
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            
            //txtMatKhau.PasswordChar = '*';
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void DangKy_SizeChanged(object sender, EventArgs e)
        {

            //panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            //panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult traloi;
            //traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (traloi == DialogResult.OK)
            //{
            //    Application.ExitThread();
            //}
            //else
            //{

            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string duongDanAnh = ""; // Khai báo biến toàn cục để lưu đường dẫn ảnh

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = dialog.FileName;

                    // Giải phóng ảnh cũ nếu có
                    if (picAnhSinhVien.Image != null)
                    {
                        picAnhSinhVien.Image.Dispose();
                        picAnhSinhVien.Image = null;
                    }

                    // Load ảnh vào PictureBox từ đường dẫn gốc
                    picAnhSinhVien.Image = Image.FromFile(duongDanAnh);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSaveData_Click(object sender, EventArgs e)
        {
            checkClick = true;
            MessageBox.Show(duongDanAnh);
            try
            {
                dbConnection.OpenConnection();

                // Kiểm tra nếu người dùng đã chọn ảnh
                //if (string.IsNullOrEmpty(duongDanAnh))
                //{
                //    // Nếu chưa chọn ảnh, sử dụng ảnh mặc định
                //    duongDanAnh = "C:\\Users\\luu79\\source\\repos\\DuThiDaiHoc\\image\\user.png";
                //}

                // Câu lệnh SQL cập nhật thông tin sinh viên
                string query = @"UPDATE HoSoThiSinh 
                         SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, 
                             MaQueQuan = (SELECT MaQue FROM QueQuan WHERE TenQue = @TenQue),
                             MaKhuVuc = (SELECT MaKhuVuc FROM KhuVuc WHERE TenKhuVuc = @TenKhuVuc),
                             MaUuTien = (SELECT MaUuTien FROM UuTien WHERE TenUuTien = @TenUuTien),
                             MaDoiTuong = (SELECT MaDoiTuong FROM DoiTuong WHERE TenDoiTuong = @TenDoiTuong),
                             AnhSinhVien = @AnhSinhVien
                         WHERE SoBD = @SoBD";

                // Truyền tham số vào câu lệnh SQL
                SqlParameter[] parameters =
                {
            new SqlParameter("@SoBD", this.SoBD),
            new SqlParameter("@HoTen", txtHoTen.Text),
            new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
            new SqlParameter("@GioiTinh", cboGioiTinh.Text),
            new SqlParameter("@TenQue", cboQueQuan.Text),
            new SqlParameter("@TenKhuVuc", cboKhuVuc.Text),
            new SqlParameter("@TenUuTien", cboUuTien.Text),
            new SqlParameter("@TenDoiTuong", cboDoiTuong.Text),
            new SqlParameter("@AnhSinhVien", duongDanAnh) // Lưu đường dẫn ảnh gốc
        };

                // Thực thi câu lệnh SQL
                int rowsAffected = dbConnection.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lưu thông tin thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với số báo danh này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }


    }
}
