
namespace QL_NhaSach_WinForm
{
    partial class interfaceNV
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
            cashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            nhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnNhapS = new System.Windows.Forms.Button();
            btnHD = new System.Windows.Forms.Button();
            btnTT = new System.Windows.Forms.Button();
            btnThongKe = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            txtUser = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cashierToolStripMenuItem
            // 
            cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            cashierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            cashierToolStripMenuItem.Text = "Cashier";
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            khoToolStripMenuItem.Text = "Kho";
            // 
            // sáchToolStripMenuItem1
            // 
            sáchToolStripMenuItem1.Name = "sáchToolStripMenuItem1";
            sáchToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            sáchToolStripMenuItem1.Text = "&Sách";
            // 
            // nhậpSáchToolStripMenuItem
            // 
            nhậpSáchToolStripMenuItem.Name = "nhậpSáchToolStripMenuItem";
            nhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            nhậpSáchToolStripMenuItem.Text = "Nhập sách";
            // 
            // btnNhapS
            // 
            btnNhapS.BackColor = System.Drawing.Color.FromArgb(40, 108, 176);
            btnNhapS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnNhapS.Location = new System.Drawing.Point(1, 1);
            btnNhapS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNhapS.Name = "btnNhapS";
            btnNhapS.Size = new System.Drawing.Size(130, 128);
            btnNhapS.TabIndex = 0;
            btnNhapS.Text = "Sách";
            btnNhapS.UseVisualStyleBackColor = false;
            btnNhapS.Click += btnNhapS_Click;
            // 
            // btnHD
            // 
            btnHD.BackColor = System.Drawing.Color.FromArgb(94, 177, 109);
            btnHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnHD.Location = new System.Drawing.Point(1, 125);
            btnHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnHD.Name = "btnHD";
            btnHD.Size = new System.Drawing.Size(130, 128);
            btnHD.TabIndex = 0;
            btnHD.Text = "Hóa đơn";
            btnHD.UseVisualStyleBackColor = false;
            btnHD.Click += btnHD_Click;
            // 
            // btnTT
            // 
            btnTT.BackColor = System.Drawing.Color.FromArgb(223, 135, 55);
            btnTT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnTT.Location = new System.Drawing.Point(1, 248);
            btnTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTT.Name = "btnTT";
            btnTT.Size = new System.Drawing.Size(130, 128);
            btnTT.TabIndex = 0;
            btnTT.Text = "Tra cứu";
            btnTT.UseVisualStyleBackColor = false;
            btnTT.Click += btnTT_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = System.Drawing.Color.FromArgb(216, 31, 48);
            btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnThongKe.Location = new System.Drawing.Point(1, 372);
            btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new System.Drawing.Size(130, 128);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnKH_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgDN;
            pictureBox1.Location = new System.Drawing.Point(135, 59);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(635, 441);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(240, 17);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gray;
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(135, 1);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(290, 65);
            panel1.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new System.Drawing.Point(79, 19);
            txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(171, 27);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(8, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Xin chào";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(button1);
            panel2.Location = new System.Drawing.Point(424, 1);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(346, 65);
            panel2.TabIndex = 3;
            // 
            // interfaceNV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(783, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnThongKe);
            Controls.Add(btnTT);
            Controls.Add(btnHD);
            Controls.Add(btnNhapS);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "interfaceNV";
            Text = "interfaceNV";
            Load += interfaceNV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhậpSáchToolStripMenuItem;
        private System.Windows.Forms.Button btnNhapS;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}