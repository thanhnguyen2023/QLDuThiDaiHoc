
namespace DuThiDaiHoc
{
    partial class AddNguyenVong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNguyenVong));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label5 = new Label();
            label4 = new Label();
            txtMaNganh = new TextBox();
            label3 = new Label();
            txtSTT = new TextBox();
            label2 = new Label();
            txtDiemChuan = new TextBox();
            label7 = new Label();
            cboTenNganh = new ComboBox();
            cboTenTruong = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 0, 0);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 49);
            panel1.TabIndex = 14;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(575, -1);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 27);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 11;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 1;
            label1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 259);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 26;
            label6.Text = "Tên Trường";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(442, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 37);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(342, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 64, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(242, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 305);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 21;
            label5.Text = "Điểm Chuẩn";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 216);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 19;
            label4.Text = "Tên Ngành : ";
            // 
            // txtMaNganh
            // 
            txtMaNganh.Location = new Point(144, 170);
            txtMaNganh.Name = "txtMaNganh";
            txtMaNganh.ReadOnly = true;
            txtMaNganh.Size = new Size(396, 22);
            txtMaNganh.TabIndex = 18;
            txtMaNganh.TextChanged += txtMaNganh_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 173);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 17;
            label3.Text = "Mã Ngành : ";
            // 
            // txtSTT
            // 
            txtSTT.Location = new Point(144, 127);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(396, 22);
            txtSTT.TabIndex = 16;
            txtSTT.TextChanged += txtSTT_TextChanged;
            txtSTT.KeyPress += txtSTT_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 130);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 15;
            label2.Text = "STT : ";
            // 
            // txtDiemChuan
            // 
            txtDiemChuan.Location = new Point(144, 302);
            txtDiemChuan.Name = "txtDiemChuan";
            txtDiemChuan.ReadOnly = true;
            txtDiemChuan.Size = new Size(396, 22);
            txtDiemChuan.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(144, 73);
            label7.Name = "label7";
            label7.Size = new Size(377, 16);
            label7.TabIndex = 29;
            label7.Text = "VUI LÒNG NHẬP THEO THỨ TỰ : STT->TÊN NGÀNH-> TÊN TRƯỜNG";
            // 
            // cboTenNganh
            // 
            cboTenNganh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTenNganh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTenNganh.FormattingEnabled = true;
            cboTenNganh.Location = new Point(144, 213);
            cboTenNganh.Name = "cboTenNganh";
            cboTenNganh.Size = new Size(396, 23);
            cboTenNganh.TabIndex = 30;
            cboTenNganh.SelectedIndexChanged += cboTenNganh_SelectedIndexChanged;
            // 
            // cboTenTruong
            // 
            cboTenTruong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTenTruong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTenTruong.FormattingEnabled = true;
            cboTenTruong.Location = new Point(144, 256);
            cboTenTruong.Name = "cboTenTruong";
            cboTenTruong.Size = new Size(396, 23);
            cboTenTruong.TabIndex = 31;
            cboTenTruong.SelectedIndexChanged += cboTenTruong_SelectedIndexChanged;
            // 
            // AddNguyenVong
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 417);
            Controls.Add(cboTenTruong);
            Controls.Add(cboTenNganh);
            Controls.Add(label7);
            Controls.Add(txtDiemChuan);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMaNganh);
            Controls.Add(label3);
            Controls.Add(txtSTT);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddNguyenVong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModuleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label2;
        public TextBox txtDiemChuan;
        private Label label7;
        public  ComboBox cboTenNganh;
        public ComboBox cboTenTruong;
    }
}