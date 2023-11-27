
namespace QL_NhaSach_WinForm
{
    partial class DanhMuc
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
            rbTenSach = new System.Windows.Forms.RadioButton();
            rbTL = new System.Windows.Forms.RadioButton();
            btnNhapLai = new System.Windows.Forms.Button();
            cboNXB = new System.Windows.Forms.ComboBox();
            cboTG = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cboTL = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnClr = new System.Windows.Forms.Button();
            txtTenSach = new System.Windows.Forms.TextBox();
            btnLoc = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            rbTG = new System.Windows.Forms.RadioButton();
            txtSearch = new System.Windows.Forms.TextBox();
            btnTimKiemTraCuu = new System.Windows.Forms.Button();
            vScrollBar3 = new System.Windows.Forms.VScrollBar();
            dgv_TraCuu = new System.Windows.Forms.DataGridView();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            pageSearch = new System.Windows.Forms.TabPage();
            dgv_Sach = new System.Windows.Forms.DataGridView();
            vScrollBar1 = new System.Windows.Forms.VScrollBar();
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            pageBook = new System.Windows.Forms.TabPage();
            tabControl1 = new System.Windows.Forms.TabControl();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnDangXuat = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TraCuu).BeginInit();
            groupBox4.SuspendLayout();
            pageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sach).BeginInit();
            pageBook.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rbTenSach
            // 
            rbTenSach.AutoSize = true;
            rbTenSach.Location = new System.Drawing.Point(282, 92);
            rbTenSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            rbTenSach.Name = "rbTenSach";
            rbTenSach.Size = new System.Drawing.Size(147, 24);
            rbTenSach.TabIndex = 6;
            rbTenSach.TabStop = true;
            rbTenSach.Text = "Tìm theo tên sách";
            rbTenSach.UseVisualStyleBackColor = true;
            rbTenSach.CheckedChanged += rbTenSach_CheckedChanged;
            // 
            // rbTL
            // 
            rbTL.AutoSize = true;
            rbTL.Location = new System.Drawing.Point(441, 92);
            rbTL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            rbTL.Name = "rbTL";
            rbTL.Size = new System.Drawing.Size(143, 24);
            rbTL.TabIndex = 6;
            rbTL.TabStop = true;
            rbTL.Text = "Tìm theo thể loại";
            rbTL.UseVisualStyleBackColor = true;
            rbTL.CheckedChanged += rbTL_CheckedChanged;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new System.Drawing.Point(669, 33);
            btnNhapLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new System.Drawing.Size(101, 31);
            btnNhapLai.TabIndex = 4;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // cboNXB
            // 
            cboNXB.FormattingEnabled = true;
            cboNXB.Location = new System.Drawing.Point(415, 65);
            cboNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboNXB.Name = "cboNXB";
            cboNXB.Size = new System.Drawing.Size(148, 28);
            cboNXB.TabIndex = 8;
            // 
            // cboTG
            // 
            cboTG.FormattingEnabled = true;
            cboTG.Location = new System.Drawing.Point(104, 65);
            cboTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboTG.Name = "cboTG";
            cboTG.Size = new System.Drawing.Size(204, 28);
            cboTG.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(352, 71);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 20);
            label7.TabIndex = 6;
            label7.Text = "NXB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(27, 71);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 20);
            label6.TabIndex = 7;
            label6.Text = "Tác giả";
            // 
            // cboTL
            // 
            cboTL.FormattingEnabled = true;
            cboTL.Location = new System.Drawing.Point(415, 32);
            cboTL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboTL.Name = "cboTL";
            cboTL.Size = new System.Drawing.Size(148, 28);
            cboTL.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNXB);
            groupBox1.Controls.Add(cboTG);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboTL);
            groupBox1.Controls.Add(btnClr);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(15, 13);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(799, 120);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // btnClr
            // 
            btnClr.Location = new System.Drawing.Point(632, 31);
            btnClr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClr.Name = "btnClr";
            btnClr.Size = new System.Drawing.Size(110, 31);
            btnClr.TabIndex = 4;
            btnClr.Text = "Nhập lại";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // txtTenSach
            // 
            txtTenSach.Enabled = false;
            txtTenSach.Location = new System.Drawing.Point(104, 32);
            txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new System.Drawing.Size(204, 27);
            txtTenSach.TabIndex = 3;
            // 
            // btnLoc
            // 
            btnLoc.Location = new System.Drawing.Point(632, 65);
            btnLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new System.Drawing.Size(110, 31);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc dữ liệu";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(352, 37);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "Thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // rbTG
            // 
            rbTG.AutoSize = true;
            rbTG.Location = new System.Drawing.Point(134, 92);
            rbTG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            rbTG.Name = "rbTG";
            rbTG.Size = new System.Drawing.Size(138, 24);
            rbTG.TabIndex = 6;
            rbTG.TabStop = true;
            rbTG.Text = "Tìm theo tác giả";
            rbTG.UseVisualStyleBackColor = true;
            rbTG.CheckedChanged += rbTG_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(133, 33);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(517, 27);
            txtSearch.TabIndex = 5;
            // 
            // btnTimKiemTraCuu
            // 
            btnTimKiemTraCuu.Location = new System.Drawing.Point(669, 87);
            btnTimKiemTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTimKiemTraCuu.Name = "btnTimKiemTraCuu";
            btnTimKiemTraCuu.Size = new System.Drawing.Size(101, 31);
            btnTimKiemTraCuu.TabIndex = 4;
            btnTimKiemTraCuu.Text = "Tìm kiếm";
            btnTimKiemTraCuu.UseVisualStyleBackColor = true;
            btnTimKiemTraCuu.Click += btnTimKiemTraCuu_Click;
            // 
            // vScrollBar3
            // 
            vScrollBar3.Location = new System.Drawing.Point(789, 168);
            vScrollBar3.Name = "vScrollBar3";
            vScrollBar3.Size = new System.Drawing.Size(17, 567);
            vScrollBar3.TabIndex = 10;
            // 
            // dgv_TraCuu
            // 
            dgv_TraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TraCuu.Location = new System.Drawing.Point(11, 168);
            dgv_TraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_TraCuu.Name = "dgv_TraCuu";
            dgv_TraCuu.RowHeadersWidth = 62;
            dgv_TraCuu.RowTemplate.Height = 25;
            dgv_TraCuu.Size = new System.Drawing.Size(798, 567);
            dgv_TraCuu.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbTG);
            groupBox4.Controls.Add(rbTenSach);
            groupBox4.Controls.Add(rbTL);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(btnNhapLai);
            groupBox4.Controls.Add(btnTimKiemTraCuu);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new System.Drawing.Point(11, 12);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(798, 148);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm thông tin sách";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(22, 37);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(94, 20);
            label11.TabIndex = 2;
            label11.Text = "Tìm Tên sách";
            // 
            // pageSearch
            // 
            pageSearch.Controls.Add(vScrollBar3);
            pageSearch.Controls.Add(dgv_TraCuu);
            pageSearch.Controls.Add(groupBox4);
            pageSearch.Location = new System.Drawing.Point(4, 29);
            pageSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageSearch.Name = "pageSearch";
            pageSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageSearch.Size = new System.Drawing.Size(831, 747);
            pageSearch.TabIndex = 2;
            pageSearch.Text = "Tra cứu";
            pageSearch.UseVisualStyleBackColor = true;
            // 
            // dgv_Sach
            // 
            dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sach.Location = new System.Drawing.Point(15, 141);
            dgv_Sach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_Sach.Name = "dgv_Sach";
            dgv_Sach.RowHeadersWidth = 62;
            dgv_Sach.Size = new System.Drawing.Size(799, 593);
            dgv_Sach.TabIndex = 1;
            dgv_Sach.SelectionChanged += dgv_Sach_SelectionChanged;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new System.Drawing.Point(801, 137);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new System.Drawing.Size(17, 584);
            vScrollBar1.TabIndex = 7;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new System.Drawing.Point(15, 721);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(799, 17);
            hScrollBar1.TabIndex = 6;
            // 
            // pageBook
            // 
            pageBook.Controls.Add(vScrollBar1);
            pageBook.Controls.Add(hScrollBar1);
            pageBook.Controls.Add(groupBox1);
            pageBook.Controls.Add(dgv_Sach);
            pageBook.Location = new System.Drawing.Point(4, 29);
            pageBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageBook.Name = "pageBook";
            pageBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageBook.Size = new System.Drawing.Size(831, 747);
            pageBook.TabIndex = 1;
            pageBook.Text = "Sách";
            pageBook.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageBook);
            tabControl1.Controls.Add(pageSearch);
            tabControl1.Location = new System.Drawing.Point(11, 59);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(839, 780);
            tabControl1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Xin chào: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDangXuat);
            panel1.Location = new System.Drawing.Point(-5, 1);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(867, 52);
            panel1.TabIndex = 3;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new System.Drawing.Point(763, 9);
            btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(86, 31);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // DanhMuc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(861, 840);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "DanhMuc";
            Text = "DanhMuc";
            Load += DanhMuc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TraCuu).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            pageSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Sach).EndInit();
            pageBook.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton rbTenSach;
        private System.Windows.Forms.RadioButton rbTL;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.ComboBox cboTG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTG;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTimKiemTraCuu;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.DataGridView dgv_TraCuu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage pageSearch;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TabPage pageBook;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
    }
}