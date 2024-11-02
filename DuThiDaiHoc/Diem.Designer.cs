namespace DuThiDaiHoc
{
    partial class Diem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCapNhatMK = new Button();
            txtNhapLai = new TextBox();
            label2 = new Label();
            txtMatKhauMoi = new TextBox();
            label1 = new Label();
            txtMatKhauCu = new TextBox();
            lbMatKhauCu = new Label();
            groupBox2 = new GroupBox();
            txtTongDiem = new TextBox();
            label6 = new Label();
            btnCapNhatDiem = new Button();
            txtDiemHoa = new TextBox();
            label5 = new Label();
            txtDiemLy = new TextBox();
            label4 = new Label();
            txtDiemToan = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCapNhatMK);
            groupBox1.Controls.Add(txtNhapLai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatKhauMoi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMatKhauCu);
            groupBox1.Controls.Add(lbMatKhauCu);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi Mật Khẩu";
            // 
            // btnCapNhatMK
            // 
            btnCapNhatMK.BackColor = Color.FromArgb(33, 8, 97);
            btnCapNhatMK.FlatStyle = FlatStyle.Flat;
            btnCapNhatMK.ForeColor = Color.White;
            btnCapNhatMK.Location = new Point(263, 241);
            btnCapNhatMK.Name = "btnCapNhatMK";
            btnCapNhatMK.Size = new Size(167, 37);
            btnCapNhatMK.TabIndex = 62;
            btnCapNhatMK.Text = "Cập Nhật";
            btnCapNhatMK.UseVisualStyleBackColor = false;
            btnCapNhatMK.Click += btnCapNhatMK_Click;
            // 
            // txtNhapLai
            // 
            txtNhapLai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNhapLai.Location = new Point(168, 178);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(262, 23);
            txtNhapLai.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 180);
            label2.Name = "label2";
            label2.Size = new Size(119, 16);
            label2.TabIndex = 60;
            label2.Text = "Nhập Lại Mật Khẩu";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauMoi.Location = new Point(168, 118);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(262, 23);
            txtMatKhauMoi.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 122);
            label1.Name = "label1";
            label1.Size = new Size(87, 16);
            label1.TabIndex = 58;
            label1.Text = "Mật Khẩu Mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauCu.Location = new Point(168, 60);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(262, 23);
            txtMatKhauCu.TabIndex = 57;
            // 
            // lbMatKhauCu
            // 
            lbMatKhauCu.AllowDrop = true;
            lbMatKhauCu.AutoSize = true;
            lbMatKhauCu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMatKhauCu.Location = new Point(31, 62);
            lbMatKhauCu.Name = "lbMatKhauCu";
            lbMatKhauCu.Size = new Size(81, 16);
            lbMatKhauCu.TabIndex = 56;
            lbMatKhauCu.Text = "Mật Khẩu Cũ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongDiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnCapNhatDiem);
            groupBox2.Controls.Add(txtDiemHoa);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDiemLy);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDiemToan);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(502, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điểm";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtTongDiem
            // 
            txtTongDiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongDiem.Location = new Point(143, 239);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.Size = new Size(247, 23);
            txtTongDiem.TabIndex = 66;
            txtTongDiem.TextChanged += txtTongDiem_TextChanged;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 241);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 65;
            label6.Text = "Tổng Điểm";
            // 
            // btnCapNhatDiem
            // 
            btnCapNhatDiem.BackColor = Color.FromArgb(33, 8, 97);
            btnCapNhatDiem.FlatStyle = FlatStyle.Flat;
            btnCapNhatDiem.ForeColor = Color.White;
            btnCapNhatDiem.Location = new Point(223, 295);
            btnCapNhatDiem.Name = "btnCapNhatDiem";
            btnCapNhatDiem.Size = new Size(167, 37);
            btnCapNhatDiem.TabIndex = 64;
            btnCapNhatDiem.Text = "Cập Nhật";
            btnCapNhatDiem.UseVisualStyleBackColor = false;
            btnCapNhatDiem.Click += btnCapNhatDiem_Click;
            // 
            // txtDiemHoa
            // 
            txtDiemHoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemHoa.Location = new Point(143, 183);
            txtDiemHoa.Name = "txtDiemHoa";
            txtDiemHoa.Size = new Size(247, 23);
            txtDiemHoa.TabIndex = 63;
            txtDiemHoa.KeyPress += txtDiemHoa_KeyPress;
            // 
            // label5
            // 
            label5.AllowDrop = true;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 185);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 62;
            label5.Text = "Điểm Hóa";
            // 
            // txtDiemLy
            // 
            txtDiemLy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemLy.Location = new Point(143, 123);
            txtDiemLy.Name = "txtDiemLy";
            txtDiemLy.Size = new Size(247, 23);
            txtDiemLy.TabIndex = 61;
            txtDiemLy.KeyPress += txtDiemLy_KeyPress;
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 125);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 60;
            label4.Text = "Điểm Lý";
            // 
            // txtDiemToan
            // 
            txtDiemToan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemToan.Location = new Point(143, 65);
            txtDiemToan.Name = "txtDiemToan";
            txtDiemToan.Size = new Size(247, 23);
            txtDiemToan.TabIndex = 59;
            txtDiemToan.TextChanged += txtDiemToan_TextChanged;
            txtDiemToan.KeyPress += txtDiemToan_KeyPress;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 67);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 58;
            label3.Text = "Điểm Toán";
            // 
            // Diem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(976, 450);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Diem";
            Text = "Diem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtMatKhauCu;
        private Label lbMatKhauCu;
        private TextBox txtNhapLai;
        private Label label2;
        private TextBox txtMatKhauMoi;
        private Label label1;
        private Button btnCapNhatMK;
        private TextBox txtDiemToan;
        private Label label3;
        private TextBox txtDiemHoa;
        private Label label5;
        private TextBox txtDiemLy;
        private Label label4;
        private Button btnCapNhatDiem;
        private TextBox txtTongDiem;
        private Label label6;
    }
}