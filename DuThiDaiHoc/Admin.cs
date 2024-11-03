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

namespace DuThiDaiHoc
{
    public partial class Admin : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=SHIROO;Initial Catalog=DuThiDaiHoc;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableThiSinh = new DataTable();
        DataTable tableDiem = new DataTable();
        void loadDataThiSinh()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoSoThiSinh ";
            adapter.SelectCommand = command;
            tableThiSinh.Clear();
            adapter.Fill(tableThiSinh);
            dgv_thiSinh.DataSource = tableThiSinh;
        }
        void loadDataDiem()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DiemThiDaiHoc ";
            adapter.SelectCommand = command;
            tableDiem.Clear();
            adapter.Fill(tableDiem);
            dgv_diem.DataSource = tableDiem;
        }
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDataThiSinh();
            loadDataDiem();
        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dgv_thiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_thiSinh.CurrentRow.Index;
            tb_soBD.Text = dgv_thiSinh.Rows[i].Cells[0].Value.ToString();
            tb_hoTen.Text = dgv_thiSinh.Rows[i].Cells[1].Value.ToString();
            dtp_ngaySinh.Text = dgv_thiSinh.Rows[i].Cells[2].Value.ToString();
            cb_gioiTinh.Text = dgv_thiSinh.Rows[i].Cells[3].Value.ToString();
            tb_maQueQuan.Text = dgv_thiSinh.Rows[i].Cells[4].Value.ToString();
            tb_maKhuVuc.Text = dgv_thiSinh.Rows[i].Cells[5].Value.ToString();
            tb_maUuTien.Text = dgv_thiSinh.Rows[i].Cells[6].Value.ToString();
            tb_maDoiTuong.Text = dgv_thiSinh.Rows[i].Cells[7].Value.ToString();
        }

        private void dgv_diem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y;
            y = dgv_diem.CurrentRow.Index;
            tb_soBaoDanh.Text = dgv_diem.Rows[y].Cells[0].Value.ToString();
            tb_hoVaTen.Text = dgv_diem.Rows[y].Cells[1].Value.ToString();
            tb_diemToan.Text = dgv_diem.Rows[y].Cells[2].Value.ToString();
            tb_diemVan.Text = dgv_diem.Rows[y].Cells[3].Value.ToString();
            tb_diemAnh.Text = dgv_diem.Rows[y].Cells[4].Value.ToString();
            tb_diemHoa.Text = dgv_diem.Rows[y].Cells[5].Value.ToString();
            tb_diemLy.Text = dgv_diem.Rows[y].Cells[6].Value.ToString();
            tb_diemSinh.Text = dgv_diem.Rows[y].Cells[7].Value.ToString();
            tb_diemSu.Text = dgv_diem.Rows[y].Cells[8].Value.ToString();
            tb_diemDia.Text = dgv_diem.Rows[y].Cells[9].Value.ToString();
        }

        private void bt_dangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất ? ", "Đăng Xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
