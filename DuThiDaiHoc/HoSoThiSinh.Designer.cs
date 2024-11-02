namespace DuThiDaiHoc
{
    partial class HoSoThiSinh
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
            btnSaveData = new Button();
            cboGioiTinh = new ComboBox();
            lbGioiTinh = new Label();
            cboDoiTuong = new ComboBox();
            cboUuTien = new ComboBox();
            cboKhuVuc = new ComboBox();
            cboQueQuan = new ComboBox();
            lbDoiTuong = new Label();
            lbUuTien = new Label();
            lbKhuVuc = new Label();
            lbQueQuan = new Label();
            btnChonAnh = new Button();
            picAnhSinhVien = new PictureBox();
            txtHoTen = new TextBox();
            lbHoTen = new Label();
            lbNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picAnhSinhVien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveData
            // 
            btnSaveData.BackColor = Color.FromArgb(33, 8, 97);
            btnSaveData.FlatStyle = FlatStyle.Flat;
            btnSaveData.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveData.ForeColor = Color.White;
            btnSaveData.Location = new Point(247, 343);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(153, 39);
            btnSaveData.TabIndex = 58;
            btnSaveData.Text = "Lưu Thông Tin";
            btnSaveData.UseVisualStyleBackColor = false;
            btnSaveData.Click += btnSaveData_Click;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(107, 248);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(293, 23);
            cboGioiTinh.TabIndex = 57;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGioiTinh.Location = new Point(22, 250);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(60, 16);
            lbGioiTinh.TabIndex = 56;
            lbGioiTinh.Text = "Giới Tính";
            // 
            // cboDoiTuong
            // 
            cboDoiTuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDoiTuong.FormattingEnabled = true;
            cboDoiTuong.Location = new Point(106, 191);
            cboDoiTuong.Name = "cboDoiTuong";
            cboDoiTuong.Size = new Size(294, 23);
            cboDoiTuong.TabIndex = 53;
            // 
            // cboUuTien
            // 
            cboUuTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUuTien.FormattingEnabled = true;
            cboUuTien.Location = new Point(106, 137);
            cboUuTien.Name = "cboUuTien";
            cboUuTien.Size = new Size(294, 23);
            cboUuTien.TabIndex = 52;
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(107, 85);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(293, 23);
            cboKhuVuc.TabIndex = 51;
            // 
            // cboQueQuan
            // 
            cboQueQuan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboQueQuan.FormattingEnabled = true;
            cboQueQuan.Location = new Point(107, 39);
            cboQueQuan.Name = "cboQueQuan";
            cboQueQuan.Size = new Size(293, 23);
            cboQueQuan.TabIndex = 49;
            // 
            // lbDoiTuong
            // 
            lbDoiTuong.AutoSize = true;
            lbDoiTuong.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDoiTuong.Location = new Point(22, 191);
            lbDoiTuong.Name = "lbDoiTuong";
            lbDoiTuong.Size = new Size(69, 16);
            lbDoiTuong.TabIndex = 47;
            lbDoiTuong.Text = "Đối Tượng";
            // 
            // lbUuTien
            // 
            lbUuTien.AutoSize = true;
            lbUuTien.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUuTien.Location = new Point(22, 139);
            lbUuTien.Name = "lbUuTien";
            lbUuTien.Size = new Size(54, 16);
            lbUuTien.TabIndex = 46;
            lbUuTien.Text = "Ưu Tiên";
            // 
            // lbKhuVuc
            // 
            lbKhuVuc.AutoSize = true;
            lbKhuVuc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbKhuVuc.Location = new Point(22, 87);
            lbKhuVuc.Name = "lbKhuVuc";
            lbKhuVuc.Size = new Size(55, 16);
            lbKhuVuc.TabIndex = 45;
            lbKhuVuc.Text = "Khu Vực";
            // 
            // lbQueQuan
            // 
            lbQueQuan.AutoSize = true;
            lbQueQuan.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQueQuan.Location = new Point(22, 39);
            lbQueQuan.Name = "lbQueQuan";
            lbQueQuan.Size = new Size(67, 16);
            lbQueQuan.TabIndex = 44;
            lbQueQuan.Text = "Quê Quán";
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.FromArgb(33, 8, 97);
            btnChonAnh.FlatStyle = FlatStyle.Flat;
            btnChonAnh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChonAnh.ForeColor = Color.White;
            btnChonAnh.Location = new Point(340, 345);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(137, 39);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // picAnhSinhVien
            // 
            picAnhSinhVien.BorderStyle = BorderStyle.FixedSingle;
            picAnhSinhVien.Location = new Point(15, 22);
            picAnhSinhVien.Name = "picAnhSinhVien";
            picAnhSinhVien.Size = new Size(290, 273);
            picAnhSinhVien.SizeMode = PictureBoxSizeMode.Zoom;
            picAnhSinhVien.TabIndex = 0;
            picAnhSinhVien.TabStop = false;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(90, 322);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(215, 23);
            txtHoTen.TabIndex = 55;
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHoTen.Location = new Point(15, 324);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(52, 16);
            lbHoTen.TabIndex = 54;
            lbHoTen.Text = "Họ Tên";
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNgaySinh.Location = new Point(15, 366);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(69, 16);
            lbNgaySinh.TabIndex = 48;
            lbNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Location = new Point(90, 361);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(215, 23);
            dtpNgaySinh.TabIndex = 50;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnSaveData);
            groupBox2.Controls.Add(cboGioiTinh);
            groupBox2.Controls.Add(lbGioiTinh);
            groupBox2.Controls.Add(cboDoiTuong);
            groupBox2.Controls.Add(cboUuTien);
            groupBox2.Controls.Add(cboKhuVuc);
            groupBox2.Controls.Add(cboQueQuan);
            groupBox2.Controls.Add(lbDoiTuong);
            groupBox2.Controls.Add(lbUuTien);
            groupBox2.Controls.Add(lbKhuVuc);
            groupBox2.Controls.Add(lbQueQuan);
            groupBox2.Location = new Point(512, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 451);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(picAnhSinhVien);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(lbHoTen);
            groupBox1.Controls.Add(lbNgaySinh);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 451);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // HoSoThiSinh
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 450);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "HoSoThiSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký";
            FormClosed += DangKy_FormClosed;
            Load += DangKy_Load;
            SizeChanged += DangKy_SizeChanged;
            Leave += label4_Click;
            ((System.ComponentModel.ISupportInitialize)picAnhSinhVien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaveData;
        private ComboBox cboGioiTinh;
        private Label lbGioiTinh;
        private ComboBox cboDoiTuong;
        private ComboBox cboUuTien;
        private ComboBox cboKhuVuc;
        private ComboBox cboQueQuan;
        private Label lbDoiTuong;
        private Label lbUuTien;
        private Label lbKhuVuc;
        private Label lbQueQuan;
        private Button btnChonAnh;
        private PictureBox picAnhSinhVien;
        private TextBox txtHoTen;
        private Label lbHoTen;
        private Label lbNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}