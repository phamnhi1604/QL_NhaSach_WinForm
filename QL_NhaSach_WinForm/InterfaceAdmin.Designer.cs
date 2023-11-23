
namespace QL_NhaSach_WinForm
{
    partial class InterfaceAdmin
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
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnNhapS = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDX = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnQLNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQLNV.Location = new System.Drawing.Point(-2, 347);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(296, 117);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(135)))), ((int)(((byte)(55)))));
            this.btnTT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTT.Location = new System.Drawing.Point(-2, 232);
            this.btnTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(296, 117);
            this.btnTT.TabIndex = 2;
            this.btnTT.Text = "Tra cứu";
            this.btnTT.UseVisualStyleBackColor = false;
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(177)))), ((int)(((byte)(109)))));
            this.btnHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHD.Location = new System.Drawing.Point(-2, 114);
            this.btnHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(296, 117);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "Hóa đơn";
            this.btnHD.UseVisualStyleBackColor = false;
            // 
            // btnNhapS
            // 
            this.btnNhapS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.btnNhapS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapS.Location = new System.Drawing.Point(-2, -1);
            this.btnNhapS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapS.Name = "btnNhapS";
            this.btnNhapS.Size = new System.Drawing.Size(296, 117);
            this.btnNhapS.TabIndex = 4;
            this.btnNhapS.Text = "Sách";
            this.btnNhapS.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(-2, 462);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(296, 117);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnDX);
            this.panel2.Location = new System.Drawing.Point(689, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 82);
            this.panel2.TabIndex = 6;
            // 
            // btnDX
            // 
            this.btnDX.Location = new System.Drawing.Point(271, 22);
            this.btnDX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(107, 38);
            this.btnDX.TabIndex = 2;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = true;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(296, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 82);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_NhaSach_WinForm.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(70, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin";
            // 
            // InterfaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnNhapS);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfaceAdmin";
            this.Text = "InterfaceAdmin";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnNhapS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQLNV;
    }
}