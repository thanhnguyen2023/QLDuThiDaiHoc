
using DuThiDaiHoc;

namespace DuThiDaiHoc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            lbName = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lbDangXuat = new Label();
            customerButton1 = new CustomerButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnDiem = new CustomerButton();
            btnHoSo = new CustomerButton();
            btnNV = new CustomerButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHoSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNV).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbDangXuat);
            panel1.Controls.Add(customerButton1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnDiem);
            panel1.Controls.Add(btnHoSo);
            panel1.Controls.Add(btnNV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 94);
            panel1.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(110, 42);
            lbName.Name = "lbName";
            lbName.Size = new Size(270, 28);
            lbName.TabIndex = 18;
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(110, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 16;
            label1.Text = "Xin Chào !";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDangXuat
            // 
            lbDangXuat.AutoSize = true;
            lbDangXuat.ForeColor = Color.FromArgb(244, 0, 0);
            lbDangXuat.Location = new Point(671, 62);
            lbDangXuat.Name = "lbDangXuat";
            lbDangXuat.Size = new Size(165, 32);
            lbDangXuat.TabIndex = 15;
            lbDangXuat.Text = "ĐĂNG XUẤT";
            lbDangXuat.Click += lbDangXuat_Click;
            // 
            // customerButton1
            // 
            customerButton1.Image = (Image)resources.GetObject("customerButton1.Image");
            customerButton1.ImageHover = (Image)resources.GetObject("customerButton1.ImageHover");
            customerButton1.ImageNormal = (Image)resources.GetObject("customerButton1.ImageNormal");
            customerButton1.Location = new Point(693, 12);
            customerButton1.Name = "customerButton1";
            customerButton1.Size = new Size(33, 32);
            customerButton1.SizeMode = PictureBoxSizeMode.Zoom;
            customerButton1.TabIndex = 14;
            customerButton1.TabStop = false;
            customerButton1.Click += customerButton1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(244, 0, 0);
            label6.Location = new Point(597, 62);
            label6.Name = "label6";
            label6.Size = new Size(84, 32);
            label6.TabIndex = 13;
            label6.Text = "ĐIỂM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(244, 0, 0);
            label5.Location = new Point(512, 62);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 13;
            label5.Text = "HỒ SƠ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(244, 0, 0);
            label4.Location = new Point(386, 62);
            label4.Name = "label4";
            label4.Size = new Size(215, 32);
            label4.TabIndex = 13;
            label4.Text = "NGUYỆN VỌNG";
            // 
            // btnDiem
            // 
            btnDiem.Image = (Image)resources.GetObject("btnDiem.Image");
            btnDiem.ImageHover = (Image)resources.GetObject("btnDiem.ImageHover");
            btnDiem.ImageNormal = (Image)resources.GetObject("btnDiem.ImageNormal");
            btnDiem.Location = new Point(601, 12);
            btnDiem.Name = "btnDiem";
            btnDiem.Size = new Size(33, 32);
            btnDiem.SizeMode = PictureBoxSizeMode.Zoom;
            btnDiem.TabIndex = 12;
            btnDiem.TabStop = false;
            btnDiem.Click += btnDiem_Click;
            // 
            // btnHoSo
            // 
            btnHoSo.Image = (Image)resources.GetObject("btnHoSo.Image");
            btnHoSo.ImageHover = (Image)resources.GetObject("btnHoSo.ImageHover");
            btnHoSo.ImageNormal = (Image)resources.GetObject("btnHoSo.ImageNormal");
            btnHoSo.Location = new Point(520, 12);
            btnHoSo.Name = "btnHoSo";
            btnHoSo.Size = new Size(33, 32);
            btnHoSo.SizeMode = PictureBoxSizeMode.Zoom;
            btnHoSo.TabIndex = 12;
            btnHoSo.TabStop = false;
            btnHoSo.Click += btnHoSo_Click;
            // 
            // btnNV
            // 
            btnNV.Image = (Image)resources.GetObject("btnNV.Image");
            btnNV.ImageHover = (Image)resources.GetObject("btnNV.ImageHover");
            btnNV.ImageNormal = (Image)resources.GetObject("btnNV.ImageNormal");
            btnNV.Location = new Point(420, 12);
            btnNV.Name = "btnNV";
            btnNV.Size = new Size(33, 32);
            btnNV.SizeMode = PictureBoxSizeMode.Zoom;
            btnNV.TabIndex = 12;
            btnNV.TabStop = false;
            btnNV.Click += btnNguyenVong_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(244, 0, 0);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 600);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(992, 17);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(pictureBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 94);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(992, 506);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(883, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 617);
            Controls.Add(panelMain);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHoSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNV).EndInit();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMain;
        private CustomerButton btnNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
      
        private CustomerButton btnDiem;
        private CustomerButton btnHoSo;
        private PictureBox pictureBox1;
        private Label lbDangXuat;
        private CustomerButton customerButton1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label lbName;
    }
}