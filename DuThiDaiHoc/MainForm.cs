using DBConnect;
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
    public partial class MainForm : Form
    {
        public int SoBD;
        Connection connection = new Connection();
        public DSNguyenVong formDSNguyenVong;
        public LoginForm loginForm;
        public HoSoThiSinh formHoSoThiSinh;
        public Diem formDiem;
        public MainForm()
        {

            InitializeComponent();
        }
        public MainForm(int SoBD)
        {
            InitializeComponent();
            this.SoBD = SoBD;
            getName();
        }

        //to show subform form in mainform
        private Form activeForm = null;
        public void getName()
        {
            connection.OpenConnection();
            string query = "select HoTen from HoSoThiSinh where SoBD = @SoBD";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoBD",this.SoBD)
            };
            SqlDataReader reader = connection.ExecuteReader(query, parameters);
            if (reader.Read())
            {
                lbName.Text = reader["HoTen"].ToString();
            }
            reader.Close();
            connection.CloseConnection();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void btnHoSo_Click(object sender, EventArgs e)
        {
            formHoSoThiSinh = new HoSoThiSinh(SoBD);
            openChildForm(formHoSoThiSinh);
            if (HoSoThiSinh.checkClick == true)
                getName();
            HoSoThiSinh.checkClick = false;
        }

        private void btnNguyenVong_Click(object sender, EventArgs e)
        {

            formDSNguyenVong = new DSNguyenVong(SoBD);
            openChildForm(formDSNguyenVong);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            formDiem = new Diem(SoBD);
            openChildForm(formDiem);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn đăng xuất ? ", "Đăng Xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbDangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
