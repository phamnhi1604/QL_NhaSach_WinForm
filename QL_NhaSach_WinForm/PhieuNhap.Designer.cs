
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
            tabControl1 = new System.Windows.Forms.TabControl();
            pageManage_book = new System.Windows.Forms.TabPage();
            btnPrint = new System.Windows.Forms.Button();
            textBox12 = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            btnTaoPN = new System.Windows.Forms.Button();
            txtMaPN = new System.Windows.Forms.TextBox();
            dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnReload = new System.Windows.Forms.Button();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cbMaPN = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            btnRetype = new System.Windows.Forms.Button();
            btnDel = new System.Windows.Forms.Button();
            btnEditTT_PN = new System.Windows.Forms.Button();
            btnNhap = new System.Windows.Forms.Button();
            txtTenS = new System.Windows.Forms.TextBox();
            txtDonGia = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtSL = new System.Windows.Forms.TextBox();
            txtTL = new System.Windows.Forms.TextBox();
            txtMaSach = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            gdvPN = new System.Windows.Forms.DataGridView();
            pageManage_author = new System.Windows.Forms.TabPage();
            dgvTG = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtTenTG = new System.Windows.Forms.TextBox();
            txtMaTG = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            btnEditTG = new System.Windows.Forms.Button();
            btnDelTG = new System.Windows.Forms.Button();
            btnAddTG = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            pageManage_NXB = new System.Windows.Forms.TabPage();
            vScrollBar3 = new System.Windows.Forms.VScrollBar();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox9 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            txtNV = new System.Windows.Forms.TextBox();
            btnDX = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            pageManage_book.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gdvPN).BeginInit();
            pageManage_author.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTG).BeginInit();
            groupBox2.SuspendLayout();
            pageManage_NXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageManage_book);
            tabControl1.Controls.Add(pageManage_author);
            tabControl1.Controls.Add(pageManage_NXB);
            tabControl1.Location = new System.Drawing.Point(10, 68);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(839, 932);
            tabControl1.TabIndex = 5;
            // 
            // pageManage_book
            // 
            pageManage_book.Controls.Add(btnPrint);
            pageManage_book.Controls.Add(textBox12);
            pageManage_book.Controls.Add(label14);
            pageManage_book.Controls.Add(groupBox5);
            pageManage_book.Controls.Add(hScrollBar1);
            pageManage_book.Controls.Add(groupBox1);
            pageManage_book.Controls.Add(gdvPN);
            pageManage_book.Location = new System.Drawing.Point(4, 29);
            pageManage_book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageManage_book.Name = "pageManage_book";
            pageManage_book.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageManage_book.Size = new System.Drawing.Size(831, 899);
            pageManage_book.TabIndex = 1;
            pageManage_book.Text = "Quản lý phiếu nhập";
            pageManage_book.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new System.Drawing.Point(14, 833);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(138, 31);
            btnPrint.TabIndex = 11;
            btnPrint.Text = "Xuất phiếu nhập";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.Location = new System.Drawing.Point(574, 835);
            textBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox12.Name = "textBox12";
            textBox12.Size = new System.Drawing.Size(238, 27);
            textBox12.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(505, 840);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(72, 20);
            label14.TabIndex = 9;
            label14.Text = "Tổng tiền";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnTaoPN);
            groupBox5.Controls.Add(txtMaPN);
            groupBox5.Controls.Add(dtpNgayNhap);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label16);
            groupBox5.Location = new System.Drawing.Point(14, 16);
            groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox5.Size = new System.Drawing.Size(799, 91);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Nhập phiếu nhập";
            // 
            // btnTaoPN
            // 
            btnTaoPN.Location = new System.Drawing.Point(621, 32);
            btnTaoPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTaoPN.Name = "btnTaoPN";
            btnTaoPN.Size = new System.Drawing.Size(138, 31);
            btnTaoPN.TabIndex = 0;
            btnTaoPN.Text = "Tạo phiếu nhập";
            btnTaoPN.UseVisualStyleBackColor = true;
            btnTaoPN.Click += btnTaoPN_Click;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new System.Drawing.Point(120, 32);
            txtMaPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new System.Drawing.Size(140, 27);
            txtMaPN.TabIndex = 2;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new System.Drawing.Point(369, 32);
            dtpNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new System.Drawing.Size(158, 27);
            dtpNgayNhap.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(19, 37);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(108, 20);
            label15.TabIndex = 1;
            label15.Text = "Mã phiếu nhập";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(303, 37);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(70, 20);
            label16.TabIndex = 1;
            label16.Text = "Ngày tạo";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new System.Drawing.Point(14, 804);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(799, 17);
            hScrollBar1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReload);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbMaPN);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnRetype);
            groupBox1.Controls.Add(btnDel);
            groupBox1.Controls.Add(btnEditTT_PN);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtTenS);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSL);
            groupBox1.Controls.Add(txtTL);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(14, 128);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(799, 204);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnReload
            // 
            btnReload.Location = new System.Drawing.Point(621, 161);
            btnReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(138, 31);
            btnReload.TabIndex = 11;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(621, 72);
            comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(138, 28);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(621, 33);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(138, 28);
            comboBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(541, 77);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 20);
            label7.TabIndex = 7;
            label7.Text = "NXB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(541, 40);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 20);
            label6.TabIndex = 8;
            label6.Text = "Tên tác giả";
            // 
            // cbMaPN
            // 
            cbMaPN.FormattingEnabled = true;
            cbMaPN.Location = new System.Drawing.Point(126, 29);
            cbMaPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbMaPN.Name = "cbMaPN";
            cbMaPN.Size = new System.Drawing.Size(140, 28);
            cbMaPN.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(25, 37);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(108, 20);
            label12.TabIndex = 5;
            label12.Text = "Mã phiếu nhập";
            // 
            // btnRetype
            // 
            btnRetype.Location = new System.Drawing.Point(478, 161);
            btnRetype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRetype.Name = "btnRetype";
            btnRetype.Size = new System.Drawing.Size(110, 31);
            btnRetype.TabIndex = 4;
            btnRetype.Text = "Nhập lại";
            btnRetype.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new System.Drawing.Point(334, 161);
            btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new System.Drawing.Size(110, 31);
            btnDel.TabIndex = 4;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEditTT_PN
            // 
            btnEditTT_PN.Location = new System.Drawing.Point(191, 161);
            btnEditTT_PN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditTT_PN.Name = "btnEditTT_PN";
            btnEditTT_PN.Size = new System.Drawing.Size(110, 31);
            btnEditTT_PN.TabIndex = 4;
            btnEditTT_PN.Text = "Chỉnh sửa";
            btnEditTT_PN.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new System.Drawing.Point(621, 109);
            btnNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new System.Drawing.Size(138, 31);
            btnNhap.TabIndex = 4;
            btnNhap.Text = "Nhập sách";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // txtTenS
            // 
            txtTenS.Location = new System.Drawing.Point(126, 109);
            txtTenS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTenS.Name = "txtTenS";
            txtTenS.Size = new System.Drawing.Size(140, 27);
            txtTenS.TabIndex = 3;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new System.Drawing.Point(369, 109);
            txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new System.Drawing.Size(109, 27);
            txtDonGia.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(304, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 20);
            label5.TabIndex = 2;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(304, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "Thể loại";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(25, 75);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(63, 20);
            label13.TabIndex = 2;
            label13.Text = "Mã sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(304, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn Giá";
            // 
            // txtSL
            // 
            txtSL.Location = new System.Drawing.Point(369, 71);
            txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSL.Name = "txtSL";
            txtSL.Size = new System.Drawing.Size(109, 27);
            txtSL.TabIndex = 3;
            // 
            // txtTL
            // 
            txtTL.Location = new System.Drawing.Point(369, 32);
            txtTL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTL.Name = "txtTL";
            txtTL.Size = new System.Drawing.Size(109, 27);
            txtTL.TabIndex = 3;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new System.Drawing.Point(126, 71);
            txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new System.Drawing.Size(140, 27);
            txtMaSach.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // gdvPN
            // 
            gdvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvPN.Location = new System.Drawing.Point(14, 340);
            gdvPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gdvPN.Name = "gdvPN";
            gdvPN.RowHeadersWidth = 51;
            gdvPN.Size = new System.Drawing.Size(799, 487);
            gdvPN.TabIndex = 1;
            gdvPN.CellContentClick += gdvPN_CellContentClick;
            // 
            // pageManage_author
            // 
            pageManage_author.Controls.Add(dgvTG);
            pageManage_author.Controls.Add(groupBox2);
            pageManage_author.Location = new System.Drawing.Point(4, 29);
            pageManage_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageManage_author.Name = "pageManage_author";
            pageManage_author.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageManage_author.Size = new System.Drawing.Size(831, 899);
            pageManage_author.TabIndex = 0;
            pageManage_author.Text = "Tác giả";
            pageManage_author.UseVisualStyleBackColor = true;
            // 
            // dgvTG
            // 
            dgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTG.Location = new System.Drawing.Point(15, 181);
            dgvTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvTG.Name = "dgvTG";
            dgvTG.RowHeadersWidth = 62;
            dgvTG.RowTemplate.Height = 25;
            dgvTG.Size = new System.Drawing.Size(798, 695);
            dgvTG.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenTG);
            groupBox2.Controls.Add(txtMaTG);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnEditTG);
            groupBox2.Controls.Add(btnDelTG);
            groupBox2.Controls.Add(btnAddTG);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new System.Drawing.Point(15, 17);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(798, 148);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tác giả";
            // 
            // txtTenTG
            // 
            txtTenTG.Location = new System.Drawing.Point(121, 69);
            txtTenTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new System.Drawing.Size(173, 27);
            txtTenTG.TabIndex = 5;
            // 
            // txtMaTG
            // 
            txtMaTG.Location = new System.Drawing.Point(121, 36);
            txtMaTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMaTG.Name = "txtMaTG";
            txtMaTG.Size = new System.Drawing.Size(173, 27);
            txtMaTG.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(21, 69);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 20);
            label8.TabIndex = 2;
            label8.Text = "Tên tác giả";
            // 
            // btnEditTG
            // 
            btnEditTG.Location = new System.Drawing.Point(667, 31);
            btnEditTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditTG.Name = "btnEditTG";
            btnEditTG.Size = new System.Drawing.Size(101, 31);
            btnEditTG.TabIndex = 4;
            btnEditTG.Text = "Chỉnh sửa";
            btnEditTG.UseVisualStyleBackColor = true;
            // 
            // btnDelTG
            // 
            btnDelTG.Location = new System.Drawing.Point(551, 31);
            btnDelTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelTG.Name = "btnDelTG";
            btnDelTG.Size = new System.Drawing.Size(101, 31);
            btnDelTG.TabIndex = 4;
            btnDelTG.Text = "Xóa";
            btnDelTG.UseVisualStyleBackColor = true;
            // 
            // btnAddTG
            // 
            btnAddTG.Location = new System.Drawing.Point(435, 31);
            btnAddTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddTG.Name = "btnAddTG";
            btnAddTG.Size = new System.Drawing.Size(101, 31);
            btnAddTG.TabIndex = 4;
            btnAddTG.Text = "Nhập";
            btnAddTG.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(21, 36);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(79, 20);
            label9.TabIndex = 2;
            label9.Text = "Mã tác giả";
            // 
            // pageManage_NXB
            // 
            pageManage_NXB.Controls.Add(vScrollBar3);
            pageManage_NXB.Controls.Add(dataGridView3);
            pageManage_NXB.Controls.Add(groupBox4);
            pageManage_NXB.Location = new System.Drawing.Point(4, 29);
            pageManage_NXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageManage_NXB.Name = "pageManage_NXB";
            pageManage_NXB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pageManage_NXB.Size = new System.Drawing.Size(831, 899);
            pageManage_NXB.TabIndex = 2;
            pageManage_NXB.Text = "Nhà xuất bản";
            pageManage_NXB.UseVisualStyleBackColor = true;
            // 
            // vScrollBar3
            // 
            vScrollBar3.Location = new System.Drawing.Point(790, 168);
            vScrollBar3.Name = "vScrollBar3";
            vScrollBar3.Size = new System.Drawing.Size(17, 567);
            vScrollBar3.TabIndex = 10;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new System.Drawing.Point(13, 168);
            dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new System.Drawing.Size(798, 567);
            dataGridView3.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(textBox9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(button11);
            groupBox4.Controls.Add(button12);
            groupBox4.Controls.Add(button13);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new System.Drawing.Point(13, 12);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(798, 148);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhà xuất bản";
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(101, 81);
            textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(173, 27);
            textBox8.TabIndex = 5;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(101, 31);
            textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(173, 27);
            textBox9.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(21, 87);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(65, 20);
            label10.TabIndex = 2;
            label10.Text = "Tên NXB";
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(667, 31);
            button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(101, 31);
            button11.TabIndex = 4;
            button11.Text = "Chỉnh sửa";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new System.Drawing.Point(551, 31);
            button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(101, 31);
            button12.TabIndex = 4;
            button12.Text = "Xóa";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new System.Drawing.Point(435, 31);
            button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(101, 31);
            button13.TabIndex = 4;
            button13.Text = "Nhập";
            button13.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(21, 36);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(63, 20);
            label11.TabIndex = 2;
            label11.Text = "Mã NXB";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(62, 204, 112);
            panel1.Controls.Add(txtNV);
            panel1.Controls.Add(btnDX);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(861, 61);
            panel1.TabIndex = 6;
            // 
            // txtNV
            // 
            txtNV.Location = new System.Drawing.Point(90, 16);
            txtNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNV.Name = "txtNV";
            txtNV.Size = new System.Drawing.Size(218, 27);
            txtNV.TabIndex = 2;
            // 
            // btnDX
            // 
            btnDX.Location = new System.Drawing.Point(759, 15);
            btnDX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDX.Name = "btnDX";
            btnDX.Size = new System.Drawing.Size(86, 31);
            btnDX.TabIndex = 1;
            btnDX.Text = "Đăng xuất";
            btnDX.UseVisualStyleBackColor = true;
            btnDX.Click += btnDX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhân viên";
            // 
            // PhieuNhap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(858, 1036);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "PhieuNhap";
            Text = "PhieuNhap";
            Load += PhieuNhap_Load;
            tabControl1.ResumeLayout(false);
            pageManage_book.ResumeLayout(false);
            pageManage_book.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gdvPN).EndInit();
            pageManage_author.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTG).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pageManage_NXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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