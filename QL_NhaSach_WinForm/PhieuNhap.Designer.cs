
namespace QL_NhaSach_WinForm
{
    partial class PhieuNhap
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageManage_book = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaPN = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRetype = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEditTT_PN = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdvPN = new System.Windows.Forms.DataGridView();
            this.pageManage_author = new System.Windows.Forms.TabPage();
            this.dgvTG = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditTG = new System.Windows.Forms.Button();
            this.btnDelTG = new System.Windows.Forms.Button();
            this.btnAddTG = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pageManage_NXB = new System.Windows.Forms.TabPage();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.btnDX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pageManage_book.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPN)).BeginInit();
            this.pageManage_author.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pageManage_NXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageManage_book);
            this.tabControl1.Controls.Add(this.pageManage_author);
            this.tabControl1.Controls.Add(this.pageManage_NXB);
            this.tabControl1.Location = new System.Drawing.Point(9, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 699);
            this.tabControl1.TabIndex = 5;
            // 
            // pageManage_book
            // 
            this.pageManage_book.Controls.Add(this.btnPrint);
            this.pageManage_book.Controls.Add(this.textBox12);
            this.pageManage_book.Controls.Add(this.label14);
            this.pageManage_book.Controls.Add(this.groupBox5);
            this.pageManage_book.Controls.Add(this.hScrollBar1);
            this.pageManage_book.Controls.Add(this.groupBox1);
            this.pageManage_book.Controls.Add(this.gdvPN);
            this.pageManage_book.Location = new System.Drawing.Point(4, 24);
            this.pageManage_book.Name = "pageManage_book";
            this.pageManage_book.Padding = new System.Windows.Forms.Padding(3);
            this.pageManage_book.Size = new System.Drawing.Size(726, 671);
            this.pageManage_book.TabIndex = 1;
            this.pageManage_book.Text = "Quản lý phiếu nhập";
            this.pageManage_book.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 625);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Xuất phiếu nhập";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(502, 626);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(209, 23);
            this.textBox12.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 630);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Tổng tiền";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTaoPN);
            this.groupBox5.Controls.Add(this.txtMaPN);
            this.groupBox5.Controls.Add(this.dtpNgayNhap);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(699, 68);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhập phiếu nhập";
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Location = new System.Drawing.Point(543, 24);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(121, 23);
            this.btnTaoPN.TabIndex = 0;
            this.btnTaoPN.Text = "Tạo phiếu nhập";
            this.btnTaoPN.UseVisualStyleBackColor = true;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(105, 24);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(123, 23);
            this.txtMaPN.TabIndex = 2;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(323, 24);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(139, 23);
            this.dtpNgayNhap.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Mã phiếu nhập";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ngày tạo";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 603);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(699, 17);
            this.hScrollBar1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbMaPN);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnRetype);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnEditTT_PN);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.txtTenS);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtTL);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(543, 121);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(121, 23);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(543, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(543, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "NXB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên tác giả";
            // 
            // cbMaPN
            // 
            this.cbMaPN.FormattingEnabled = true;
            this.cbMaPN.Location = new System.Drawing.Point(110, 22);
            this.cbMaPN.Name = "cbMaPN";
            this.cbMaPN.Size = new System.Drawing.Size(123, 23);
            this.cbMaPN.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mã phiếu nhập";
            // 
            // btnRetype
            // 
            this.btnRetype.Location = new System.Drawing.Point(418, 121);
            this.btnRetype.Name = "btnRetype";
            this.btnRetype.Size = new System.Drawing.Size(96, 23);
            this.btnRetype.TabIndex = 4;
            this.btnRetype.Text = "Nhập lại";
            this.btnRetype.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(292, 121);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEditTT_PN
            // 
            this.btnEditTT_PN.Location = new System.Drawing.Point(167, 121);
            this.btnEditTT_PN.Name = "btnEditTT_PN";
            this.btnEditTT_PN.Size = new System.Drawing.Size(96, 23);
            this.btnEditTT_PN.TabIndex = 4;
            this.btnEditTT_PN.Text = "Chỉnh sửa";
            this.btnEditTT_PN.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(543, 82);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(121, 23);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập sách";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(110, 82);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(123, 23);
            this.txtTenS.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(323, 82);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(96, 23);
            this.txtDonGia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thể loại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(323, 53);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(96, 23);
            this.txtSL.TabIndex = 3;
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(323, 24);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(96, 23);
            this.txtTL.TabIndex = 3;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(110, 53);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(123, 23);
            this.txtMaSach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // gdvPN
            // 
            this.gdvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvPN.Location = new System.Drawing.Point(12, 255);
            this.gdvPN.Name = "gdvPN";
            this.gdvPN.Size = new System.Drawing.Size(699, 365);
            this.gdvPN.TabIndex = 1;
            // 
            // pageManage_author
            // 
            this.pageManage_author.Controls.Add(this.dgvTG);
            this.pageManage_author.Controls.Add(this.groupBox2);
            this.pageManage_author.Location = new System.Drawing.Point(4, 24);
            this.pageManage_author.Name = "pageManage_author";
            this.pageManage_author.Padding = new System.Windows.Forms.Padding(3);
            this.pageManage_author.Size = new System.Drawing.Size(726, 671);
            this.pageManage_author.TabIndex = 0;
            this.pageManage_author.Text = "Tác giả";
            this.pageManage_author.UseVisualStyleBackColor = true;
            // 
            // dgvTG
            // 
            this.dgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTG.Location = new System.Drawing.Point(13, 136);
            this.dgvTG.Name = "dgvTG";
            this.dgvTG.RowHeadersWidth = 62;
            this.dgvTG.RowTemplate.Height = 25;
            this.dgvTG.Size = new System.Drawing.Size(698, 521);
            this.dgvTG.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenTG);
            this.groupBox2.Controls.Add(this.txtMaTG);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnEditTG);
            this.groupBox2.Controls.Add(this.btnDelTG);
            this.groupBox2.Controls.Add(this.btnAddTG);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 111);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tác giả";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(106, 52);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(152, 23);
            this.txtTenTG.TabIndex = 5;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(106, 27);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(152, 23);
            this.txtMaTG.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên tác giả";
            // 
            // btnEditTG
            // 
            this.btnEditTG.Location = new System.Drawing.Point(584, 23);
            this.btnEditTG.Name = "btnEditTG";
            this.btnEditTG.Size = new System.Drawing.Size(88, 23);
            this.btnEditTG.TabIndex = 4;
            this.btnEditTG.Text = "Chỉnh sửa";
            this.btnEditTG.UseVisualStyleBackColor = true;
            // 
            // btnDelTG
            // 
            this.btnDelTG.Location = new System.Drawing.Point(482, 23);
            this.btnDelTG.Name = "btnDelTG";
            this.btnDelTG.Size = new System.Drawing.Size(88, 23);
            this.btnDelTG.TabIndex = 4;
            this.btnDelTG.Text = "Xóa";
            this.btnDelTG.UseVisualStyleBackColor = true;
            // 
            // btnAddTG
            // 
            this.btnAddTG.Location = new System.Drawing.Point(381, 23);
            this.btnAddTG.Name = "btnAddTG";
            this.btnAddTG.Size = new System.Drawing.Size(88, 23);
            this.btnAddTG.TabIndex = 4;
            this.btnAddTG.Text = "Nhập";
            this.btnAddTG.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã tác giả";
            // 
            // pageManage_NXB
            // 
            this.pageManage_NXB.Controls.Add(this.vScrollBar3);
            this.pageManage_NXB.Controls.Add(this.dataGridView3);
            this.pageManage_NXB.Controls.Add(this.groupBox4);
            this.pageManage_NXB.Location = new System.Drawing.Point(4, 24);
            this.pageManage_NXB.Name = "pageManage_NXB";
            this.pageManage_NXB.Padding = new System.Windows.Forms.Padding(3);
            this.pageManage_NXB.Size = new System.Drawing.Size(726, 671);
            this.pageManage_NXB.TabIndex = 2;
            this.pageManage_NXB.Text = "Nhà xuất bản";
            this.pageManage_NXB.UseVisualStyleBackColor = true;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(691, 126);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(17, 425);
            this.vScrollBar3.TabIndex = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(11, 126);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(698, 425);
            this.dataGridView3.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(11, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(698, 111);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin nhà xuất bản";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(88, 61);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(152, 23);
            this.textBox8.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(88, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(152, 23);
            this.textBox9.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên NXB";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(584, 23);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Chỉnh sửa";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(482, 23);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 23);
            this.button12.TabIndex = 4;
            this.button12.Text = "Xóa";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(381, 23);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "Nhập";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mã NXB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.txtNV);
            this.panel1.Controls.Add(this.btnDX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 46);
            this.panel1.TabIndex = 6;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(79, 12);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(191, 23);
            this.txtNV.TabIndex = 2;
            // 
            // btnDX
            // 
            this.btnDX.Location = new System.Drawing.Point(664, 11);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(75, 23);
            this.btnDX.TabIndex = 1;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = true;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên";
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 777);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.tabControl1.ResumeLayout(false);
            this.pageManage_book.ResumeLayout(false);
            this.pageManage_book.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPN)).EndInit();
            this.pageManage_author.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pageManage_NXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageManage_book;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetype;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEditTT_PN;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdvPN;
        private System.Windows.Forms.TabPage pageManage_author;
        private System.Windows.Forms.TabPage pageManage_NXB;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaPN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvTG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditTG;
        private System.Windows.Forms.Button btnDelTG;
        private System.Windows.Forms.Button btnAddTG;
        private System.Windows.Forms.Label label9;
    }
}