
namespace QL_NhaSach_WinForm
{
    partial class IAdmin_QLNV
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(13, 275);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 62;
            this.dgvNV.RowTemplate.Height = 25;
            this.dgvNV.Size = new System.Drawing.Size(1110, 445);
            this.dgvNV.TabIndex = 9;
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboPhai);
            this.groupBox3.Controls.Add(this.txtMaNV);
            this.groupBox3.Controls.Add(this.txtDC);
            this.groupBox3.Controls.Add(this.txtTenNV);
            this.groupBox3.Controls.Add(this.txtPW);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnAddNV);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnDelNV);
            this.groupBox3.Controls.Add(this.btnEditNV);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(13, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1110, 187);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhân viên";
            // 
            // cboPhai
            // 
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboPhai.Location = new System.Drawing.Point(588, 138);
            this.cboPhai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(215, 33);
            this.cboPhai.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(151, 45);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(215, 31);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(151, 142);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(215, 31);
            this.txtDC.TabIndex = 5;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(151, 93);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(215, 31);
            this.txtTenNV.TabIndex = 5;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(588, 41);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(215, 31);
            this.txtPW.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(588, 89);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(215, 31);
            this.txtSDT.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(492, 145);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Giới  tính";
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(939, 31);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(126, 38);
            this.btnAddNV.TabIndex = 4;
            this.btnAddNV.Text = "Nhập";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Địa chỉ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(492, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "SDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên nhân viên";
            // 
            // btnDelNV
            // 
            this.btnDelNV.Location = new System.Drawing.Point(939, 82);
            this.btnDelNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(126, 38);
            this.btnDelNV.TabIndex = 4;
            this.btnDelNV.Text = "Xóa";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Location = new System.Drawing.Point(939, 134);
            this.btnEditNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(126, 38);
            this.btnEditNV.TabIndex = 4;
            this.btnEditNV.Text = "Chỉnh sửa";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 60);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_NhaSach_WinForm.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
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
            this.label4.Location = new System.Drawing.Point(70, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnDX);
            this.panel2.Location = new System.Drawing.Point(510, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 60);
            this.panel2.TabIndex = 11;
            // 
            // btnDX
            // 
            this.btnDX.Location = new System.Drawing.Point(506, 12);
            this.btnDX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(107, 38);
            this.btnDX.TabIndex = 2;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = true;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // IAdmin_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.groupBox3);
            this.Name = "IAdmin_QLNV";
            this.Text = "IAdmin_QLNV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IAdmin_QLNV_FormClosing);
            this.Load += new System.EventHandler(this.IAdmin_QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDX;
    }
}