using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnect;
namespace DuThiDaiHoc
{
    public partial class Diem : Form
    {
        public int SoBd;
        public Connection connection;
        public Diem()
        {
            InitializeComponent();
            LoadDiem();
        }
        public Diem(int SoBD)
        {
            this.SoBd = SoBD;
            InitializeComponent();
            connection = new Connection();
            LoadDiem();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void LoadDiem()
        {
            string query = "SELECT DiemToan, DiemLy, DiemHoa FROM DiemThi WHERE SoBD = @SoBD";
            connection.OpenConnection();

            SqlParameter[] parameters =
            {
                 new SqlParameter("@SoBD", this.SoBd)
            };
                {
                    
                    using (SqlDataReader reader = connection.ExecuteReader(query,parameters))
                    {
                        if (reader.Read())
                        {
                            txtDiemToan.Text = reader["DiemToan"].ToString();
                            txtDiemLy.Text = reader["DiemLy"].ToString();
                            txtDiemHoa.Text = reader["DiemHoa"].ToString();
                            TinhTongDiem();  // Tính và hiển thị tổng điểm
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo");
                        }
                    }
                    
                }
            
            
        }
        private void TinhTongDiem()
        {
            float toan = float.TryParse(txtDiemToan.Text, out float diemToan) ? diemToan : 0;
            float ly = float.TryParse(txtDiemLy.Text, out float diemLy) ? diemLy : 0;
            float hoa = float.TryParse(txtDiemHoa.Text, out float diemHoa) ? diemHoa : 0;

            float tongDiem = toan + ly + hoa;
            txtTongDiem.Text = tongDiem.ToString();
        }
        private void btnCapNhatMK_Click(object sender, EventArgs e)
        {
            // Lấy mật khẩu từ các TextBox
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhau = txtNhapLai.Text;

            if (matKhauCu == "" || matKhauMoi == "" || nhapLaiMatKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mật khẩu mới và nhập lại mật khẩu có khớp không
            if (matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.OpenConnection();

                // Kiểm tra mật khẩu cũ
                string queryCheck = "SELECT COUNT(*) FROM HoSoThiSinh WHERE SoBD = @SoBD AND MatKhau = @MatKhauCu";
                SqlParameter[] parametersCheck =
                {
            new SqlParameter("@SoBD", this.SoBd),
            new SqlParameter("@MatKhauCu", matKhauCu)
        };

                int count = (int)connection.ExecuteScalar(queryCheck, parametersCheck);
                if (count == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật mật khẩu mới
                string queryUpdate = "UPDATE HoSoThiSinh SET MatKhau = @MatKhauMoi WHERE SoBD = @SoBD";
                SqlParameter[] parametersUpdate =
                {
            new SqlParameter("@SoBD", this.SoBd),
            new SqlParameter("@MatKhauMoi", matKhauMoi)
        };

                int rowsAffected = connection.ExecuteNonQuery(queryUpdate, parametersUpdate);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.CloseConnection();
        }

        private void txtDiemToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDiemLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDiemHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {

            if (txtDiemToan.Text == "" || txtDiemLy.Text == "" || txtDiemHoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(float.Parse(txtDiemHoa.Text) > 10 || float.Parse(txtDiemLy.Text) > 10 || float.Parse(txtDiemToan.Text) > 10)
            {
                MessageBox.Show("Điểm nhập phải nhỏ hơn hoặc bằng 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Lấy giá trị từ các TextBox

                float diemToan = float.Parse(txtDiemToan.Text);
                float diemLy = float.Parse(txtDiemLy.Text);
                float diemHoa = float.Parse(txtDiemHoa.Text);
                float tongDiem = diemToan + diemLy + diemHoa;

                // Cập nhật vào cơ sở dữ liệu


                connection.OpenConnection();
                if (connection == null)
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE DiemThi SET DiemToan = @DiemToan, DiemLy = @DiemLy, DiemHoa = @DiemHoa WHERE SoBD = @SoBD";

                SqlParameter[] parameters =
                {
                        new SqlParameter("@DiemToan", diemToan),
                     new SqlParameter("@DiemLy", diemLy),
                    new SqlParameter("@DiemHoa", diemHoa),
                    new SqlParameter("@SoBD", this.SoBd)
                };



                int rowsAffected = (int)connection.ExecuteNonQuery(query, parameters);
                

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTongDiem.Text = tongDiem.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Số BD.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTongDiem_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    float diemToan = string.IsNullOrEmpty(txtDiemToan.Text) ? 0 : float.Parse(txtDiemToan.Text);
                    float diemLy = string.IsNullOrEmpty(txtDiemLy.Text) ? 0 : float.Parse(txtDiemLy.Text);
                    float diemHoa = string.IsNullOrEmpty(txtDiemHoa.Text) ? 0 : float.Parse(txtDiemHoa.Text);

                    txtTongDiem.Text = (diemToan + diemLy + diemHoa).ToString();
                }
                catch
                {
                    txtTongDiem.Text = "0";
                }
            }
        }
    }
}
