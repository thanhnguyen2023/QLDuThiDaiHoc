using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DBConnect;
namespace DuThiDaiHoc
{
    public partial class AddNguyenVong : Form
    {
        public Connection connect;
        public String tennganh;
        public String tentruong;
        public String manganh;
        public DSNV dsnv;
        public int SoBD;
        public bool checkInsert = false;
        public DSNguyenVong dSNguyenVong;
        public string OldMaNganh;
        public AddNguyenVong()
        {
            InitializeComponent();
            connect = new Connection();
            LoadCategory();
            dsnv = new DSNV();
        }
        public AddNguyenVong(int SoBD)
        {
            InitializeComponent();
            connect = new Connection();
            LoadCategory();
            dsnv = new DSNV();
            this.SoBD = SoBD;
        }
        public AddNguyenVong(DSNguyenVong dSNguyenVong)
        {
            InitializeComponent();
            connect = new Connection();
            LoadCategory();
            dsnv = new DSNV();

            this.dSNguyenVong = dSNguyenVong;
        }

        public void LoadCategory()
        {
            loadCboTenNganh();
            loadCboTenTruong();
            loadTxtMaNganh();
            loadTxtDiemChuan();
        }
        public void loadCboTenNganh()
        {
            connect.OpenConnection();
            string query = "select distinct(TenNganh) from DiemChuan";
            SqlDataReader reader = connect.ExecuteReader(query);
            while (reader.Read())
            {
                cboTenNganh.Items.Add(reader["TenNganh"].ToString());

            }
            reader.Close();
            connect.CloseConnection();
        }

        public void loadCboTenTruong(string TenNganh = "")
        {
            connect.OpenConnection();
            try
            {
                string query = "SELECT TenTruong FROM DiemChuan WHERE TenNganh like @TenNganh";

                SqlParameter[] parameters =
                {
                new SqlParameter("@TenNganh", TenNganh)
                };

                SqlDataReader reader = connect.ExecuteReader(query, parameters);



                while (reader.Read())
                {
                    cboTenTruong.Items.Add(reader["TenTruong"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }

        public void loadTxtMaNganh(string TenNganh = "", String TenTruong = "")
        {
            connect.OpenConnection();
            try
            {
                string query = "SELECT MaNganh FROM DiemChuan WHERE TenNganh like @TenNganh and TenTruong like @TenTruong";

                SqlParameter[] parameters =
                {
                new SqlParameter("@TenNganh", TenNganh),
                new SqlParameter("@TenTruong", TenTruong),

                };

                SqlDataReader reader = connect.ExecuteReader(query, parameters);



                while (reader.Read())
                {
                    txtMaNganh.Text = reader["MaNganh"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }
        public void loadTxtDiemChuan(string MaNganh = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open(); // Mở kết nối riêng cho mỗi truy vấn
                    string query = "SELECT TongDiem FROM DiemChuan WHERE MaNganh = @MaNganh";
                    SqlParameter[] parameters = { new SqlParameter("@MaNganh", MaNganh) };

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddRange(parameters);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    txtDiemChuan.Text = reader["TongDiem"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text) ||
    string.IsNullOrWhiteSpace(cboTenNganh.Text) ||
    string.IsNullOrWhiteSpace(txtSTT.Text) ||
    string.IsNullOrWhiteSpace(cboTenTruong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                    {
                        conn.Open(); // Mở kết nối riêng cho mỗi truy vấn
                        string query = "insert into NguyenVong(MaNganh,TenNguyenVong,ThuTuNV,SoBD)\r\nvalues (@MaNganh, @TenNguyenVong,@ThuTuNV,@SoBD)";
                        SqlParameter[] parameters =
                        {
                        new SqlParameter("@MaNganh",txtMaNganh.Text),
                        new SqlParameter("@TenNguyenVong",cboTenNganh.Text),
                        new SqlParameter("@ThuTuNV",int.Parse(txtSTT.Text)),
                        new SqlParameter("@SoBD",this.SoBD)

                    };
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddRange(parameters);

                            int check = command.ExecuteNonQuery();
                            if (check > 0)
                            {

                                MessageBox.Show("Thêm Thành Công");
                                checkInsert = true;
                                if (dSNguyenVong != null)
                                    dSNguyenVong.ReloadData();

                            }
                            else MessageBox.Show("Thêm Thất Bại");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
            //MessageBox.Show(txtMaNganh.Text);
            //MessageBox.Show(cboTenNganh.Text);
            //MessageBox.Show(txtSTT.Text.ToString());
            //MessageBox.Show(this.SoBD.ToString());
        }

        public void Clear()
        {
            txtSTT.Clear();
            txtMaNganh.Clear();
            cboTenNganh.Text = "";
            cboTenTruong.Text = "";
            txtDiemChuan.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Hỏi xác nhận trước khi sửa
                if (MessageBox.Show("Bạn có chắc chắn không?", "Sửa thông tin",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Kiểm tra các trường cần thiết
                    if (string.IsNullOrWhiteSpace(txtMaNganh.Text) || string.IsNullOrWhiteSpace(this.SoBD.ToString()))
                    {
                        MessageBox.Show("Mã ngành hoặc Số báo danh không được để trống.");
                        return;
                    }

                    // Chuỗi kết nối với SQL Server (cần điều chỉnh theo hệ thống của bạn)


                    // Truy vấn cập nhật dữ liệu
                    string query = @"
                UPDATE NguyenVong 
                SET ThuTuNV = @ThuTuNV, TenNguyenVong = @TenNguyenVong,MaNganh = @MaNganh1 
                WHERE SoBD = @SoBD AND MaNganh = @MaNganh2;";

                    using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                    {
                        conn.Open();  // Mở kết nối

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Thêm tham số cho truy vấn
                            cmd.Parameters.AddWithValue("@ThuTuNV", int.Parse(txtSTT.Text));
                            cmd.Parameters.AddWithValue("@TenNguyenVong", cboTenNganh.Text);

                            cmd.Parameters.AddWithValue("@SoBD", this.SoBD);
                            cmd.Parameters.AddWithValue("@MaNganh1", txtMaNganh.Text);
                            cmd.Parameters.AddWithValue("@MaNganh2", OldMaNganh);

                            // Thực thi truy vấn
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                                MessageBox.Show("Sửa dữ liệu thành công.");
                            else
                                MessageBox.Show("Không tìm thấy bản ghi phù hợp để cập nhật.");

                            //string fullQuery = $"UPDATE NguyenVong " +
                            //$"SET ThuTuNV = '{txtSTT.Text}', TenNguyenVong = '{cboTenNganh.Text}' " +
                            //$"WHERE SoBD = '{this.SoBD}' AND MaNganh = '{this.OldMaNganh}';";
                            //MessageBox.Show(fullQuery);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show($"Lỗi: {ex.Message}\n{ex.StackTrace}");
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboTenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cboTenNganh.Text))
            {
                cboTenTruong.Items.Clear();
                tennganh = cboTenNganh.Text;
                txtMaNganh.Text = "";
                cboTenTruong.Text = "";
                txtDiemChuan.Text = "";
                loadCboTenTruong(tennganh);
            }

        }

        private void cboTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboTenTruong.Text))
            {

                tentruong = cboTenTruong.Text;
                loadTxtMaNganh(tennganh, tentruong);
            }

        }

        private void txtMaNganh_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNganh.Text))
            {
                manganh = txtMaNganh.Text;
                loadTxtDiemChuan(manganh);
            }
        }

        private void txtSTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy sự kiện nếu không phải số
            }
        }
    }
}
