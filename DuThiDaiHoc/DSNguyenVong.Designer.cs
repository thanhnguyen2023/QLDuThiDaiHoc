namespace DuThiDaiHoc
{
    partial class DSNguyenVong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSNguyenVong));
            dataGridView1 = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaNganh = new DataGridViewTextBoxColumn();
            TenNganh = new DataGridViewTextBoxColumn();
            TenTruong = new DataGridViewTextBoxColumn();
            DiemChuan = new DataGridViewTextBoxColumn();
            TongDiem = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            customerButton1 = new CustomerButton();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT, MaNganh, TenNganh, TenTruong, DiemChuan, TongDiem, Edit, Delete });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(992, 441);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STT.FillWeight = 1F;
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // MaNganh
            // 
            MaNganh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNganh.FillWeight = 2F;
            MaNganh.HeaderText = "Mã Ngành";
            MaNganh.Name = "MaNganh";
            MaNganh.ReadOnly = true;
            // 
            // TenNganh
            // 
            TenNganh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNganh.FillWeight = 4F;
            TenNganh.HeaderText = "Tên Ngành";
            TenNganh.Name = "TenNganh";
            TenNganh.ReadOnly = true;
            // 
            // TenTruong
            // 
            TenTruong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenTruong.FillWeight = 4F;
            TenTruong.HeaderText = "Tên Trường";
            TenTruong.Name = "TenTruong";
            TenTruong.ReadOnly = true;
            // 
            // DiemChuan
            // 
            DiemChuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiemChuan.FillWeight = 3F;
            DiemChuan.HeaderText = "Điểm Chuẩn";
            DiemChuan.Name = "DiemChuan";
            DiemChuan.ReadOnly = true;
            // 
            // TongDiem
            // 
            TongDiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongDiem.FillWeight = 3F;
            TongDiem.HeaderText = "Tổng Điểm";
            TongDiem.Name = "TongDiem";
            TongDiem.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edit.FillWeight = 1F;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.FillWeight = 1F;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(customerButton1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 65);
            panel1.TabIndex = 2;
            // 
            // customerButton1
            // 
            customerButton1.Image = (Image)resources.GetObject("customerButton1.Image");
            customerButton1.ImageHover = (Image)resources.GetObject("customerButton1.ImageHover");
            customerButton1.ImageNormal = (Image)resources.GetObject("customerButton1.ImageNormal");
            customerButton1.Location = new Point(918, 22);
            customerButton1.Name = "customerButton1";
            customerButton1.Size = new Size(30, 31);
            customerButton1.TabIndex = 2;
            customerButton1.TabStop = false;
            customerButton1.Click += customerButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(276, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "Search Box";
            // 
            // DSNguyenVong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 506);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DSNguyenVong";
            Text = "DSNguyenVong";
            Load += DSNguyenVong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private CustomerButton customerButton1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaNganh;
        private DataGridViewTextBoxColumn TenNganh;
        private DataGridViewTextBoxColumn TenTruong;
        private DataGridViewTextBoxColumn DiemChuan;
        private DataGridViewTextBoxColumn TongDiem;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}