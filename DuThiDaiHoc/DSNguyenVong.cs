using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DBConnect;
using Microsoft.VisualBasic.Devices;
namespace DuThiDaiHoc
{

    public partial class DSNguyenVong : Form
    {

        public Connection connection;
        public DSNV dsnv; // Khai báo đối tượng DSNV
        public int SoBD;
        public AddNguyenVong addNguyenVong ;
        public DSNguyenVong()
        {
            InitializeComponent();
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addNguyenVong = new AddNguyenVong();
            connection = new Connection();
            dsnv = new DSNV(); // Khởi tạo đối tượng DSNV
            addNguyenVong = new AddNguyenVong(this);
            LoadData(); // Gọi hàm load dữ liệu

        }
        public DSNguyenVong(int SoBD)
        {
            this.SoBD = SoBD;
            InitializeComponent();
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            connection = new Connection();
            dsnv = new DSNV(); // Khởi tạo đối tượng DSNV
            dsnv.sv.soBD = SoBD;

            addNguyenVong = new AddNguyenVong(this);

            addNguyenVong = new AddNguyenVong(SoBD);
            LoadData(); // Gọi hàm load dữ liệu

        }

        public DSNguyenVong(DSNV dsnv)
        {
            this.SoBD = SoBD;
            InitializeComponent();
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            addNguyenVong = new AddNguyenVong(this);
            this.dsnv = dsnv; // Khởi tạo đối tượng DSNV
            this.dsnv.sv.soBD = SoBD;

            addNguyenVong = new AddNguyenVong(SoBD);
            LoadData(); // Gọi hàm load dữ liệu

        }
        public void LoadData(string keyword = "")
        {
            dataGridView1.Rows.Clear();
            dsnv.getNguyenVong(SoBD, keyword);  // Gọi hàm tìm kiếm với từ khóa

            for (int i = 0; i < dsnv.listNguyenVong.Count; i++)
            {
                dataGridView1.Rows.Add(
                    dsnv.listNguyenVong[i].ThuTu,
                    dsnv.listNguyenVong[i].MaNganh,
                    dsnv.listDiemChuan[i].TenNganh,
                    dsnv.listDiemChuan[i].TenTruong,
                    dsnv.listDiemChuan[i].TongDiem,
                    dsnv.diemThi.TongDiem
                );
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra hàng và cột hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            AddNguyenVong addNguyenVong1 = new AddNguyenVong(SoBD); // Khởi tạo form AddNguyenVong

            // Lưu mã ngành cũ từ cột thứ 2
            addNguyenVong1.OldMaNganh = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (colName == "Edit")
            {
                // Truyền dữ liệu từ DataGridView sang các TextBox và ComboBox trong form AddNguyenVong
                addNguyenVong1.txtSTT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                addNguyenVong1.txtMaNganh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                addNguyenVong1.cboTenNganh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                addNguyenVong1.cboTenTruong.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                addNguyenVong1.txtDiemChuan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Tắt các nút không cần thiết
                addNguyenVong1.btnSave.Enabled = false;
                addNguyenVong1.btnClear.Enabled = false;

                // Hiển thị form dưới dạng hộp thoại để người dùng cập nhật thông tin
                addNguyenVong1.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắn chắn xóa không ?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.OpenConnection();
                    string query = "delete from NguyenVong where MaNganh = @MaNganh";
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@MaNganh",dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString())
                    };
                    int a = connection.ExecuteNonQuery(query, parameters);
                    if (a > 0) MessageBox.Show("Xóa Thành Công");
                    else MessageBox.Show("Xóa Thất Bại");
                    connection.CloseConnection();
                }
            }
        }


        private void DSNguyenVong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show("click");
        //}


        private void customerButton1_Click(object sender, EventArgs e) // Nút thêm nguyện vọng
        {
            addNguyenVong.Show();

            addNguyenVong.SoBD = this.SoBD;

           
            addNguyenVong.btnSave.Enabled = true;
            addNguyenVong.btnUpdate.Enabled = false;
           
        }

        public void ReloadData()
        {
            dataGridView1.Rows.Clear(); // Xóa dữ liệu cũ
            LoadData(); // Tải lại dữ liệu mới
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            LoadData(keyword);  // Gọi tìm kiếm với từ khóa mới nhất
        }
    }
}
