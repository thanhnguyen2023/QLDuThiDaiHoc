using BLL;
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
    public partial class LoginForm : Form
    {
        public DSNV dsnv;
        public MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
            dsnv = new DSNV();
            mainForm = new MainForm();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsnv.checkLogin(int.Parse(txtName.Text), txtPass.Text))
                {
                    mainForm = new MainForm(int.Parse(txtName.Text)); // Truyền SoBD đúng vào constructor
                    mainForm.Show();
                    this.Hide(); // Ẩn LoginForm
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AdminLoginForm().Show();
        }
    }
}
