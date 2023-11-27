
namespace QL_NhaSach_WinForm
{
    partial class Cashier
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            txt_Nv = new System.Windows.Forms.TextBox();
            btnDX = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtCT_HOADON = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnPrint = new System.Windows.Forms.Button();
            btnTong = new System.Windows.Forms.Button();
            txtTong = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dgvHD = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            xemChiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cboMaSach = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            cboMaHD = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            txtDonGia = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            txtSL = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnTaoHD = new System.Windows.Forms.Button();
            cboTenKH = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            txtMaHD = new System.Windows.Forms.TextBox();
            dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            vScrollBar2 = new System.Windows.Forms.VScrollBar();
            dgvKH = new System.Windows.Forms.DataGridView();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnR = new System.Windows.Forms.Button();
            cboPhai = new System.Windows.Forms.ComboBox();
            txtDiaChi = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtTenKh = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtMaKH = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnEditKH = new System.Windows.Forms.Button();
            btnDelKH = new System.Windows.Forms.Button();
            btnAddKH = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(62, 204, 112);
            panel1.Controls.Add(txt_Nv);
            panel1.Controls.Add(btnDX);
            panel1.Controls.Add(label9);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // txt_Nv
            // 
            txt_Nv.Location = new System.Drawing.Point(90, 16);
            txt_Nv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Nv.Name = "txt_Nv";
            txt_Nv.Size = new System.Drawing.Size(218, 27);
            txt_Nv.TabIndex = 2;
            // 
            // btnDX
            // 
            btnDX.Location = new System.Drawing.Point(698, 20);
            btnDX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDX.Name = "btnDX";
            btnDX.Size = new System.Drawing.Size(86, 31);
            btnDX.TabIndex = 1;
            btnDX.Text = "Đăng xuất";
            btnDX.UseVisualStyleBackColor = true;
            btnDX.Click += btnDX_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(14, 20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 20);
            label9.TabIndex = 1;
            label9.Text = "Nhân viên";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(11, 71);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(773, 789);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(765, 756);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hóa đơn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCT_HOADON);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnPrint);
            groupBox2.Controls.Add(btnTong);
            groupBox2.Controls.Add(txtTong);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvHD);
            groupBox2.Controls.Add(cboMaSach);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cboMaHD);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtSL);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new System.Drawing.Point(17, 153);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(731, 593);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // txtCT_HOADON
            // 
            txtCT_HOADON.Location = new System.Drawing.Point(168, 110);
            txtCT_HOADON.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCT_HOADON.Name = "txtCT_HOADON";
            txtCT_HOADON.Size = new System.Drawing.Size(177, 27);
            txtCT_HOADON.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(29, 113);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(138, 20);
            label10.TabIndex = 5;
            label10.Text = "Mã chi tiêt hóa đơn";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(322, 149);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(123, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new System.Drawing.Point(6, 536);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(123, 31);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "In hóa đơn";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnTong
            // 
            btnTong.Location = new System.Drawing.Point(168, 149);
            btnTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTong.Name = "btnTong";
            btnTong.Size = new System.Drawing.Size(123, 31);
            btnTong.TabIndex = 4;
            btnTong.Text = "Tính tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // txtTong
            // 
            txtTong.Enabled = false;
            txtTong.Location = new System.Drawing.Point(481, 116);
            txtTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTong.Name = "txtTong";
            txtTong.Size = new System.Drawing.Size(186, 27);
            txtTong.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(11, 149);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(122, 31);
            button3.TabIndex = 4;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(383, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tổng tiền";
            // 
            // dgvHD
            // 
            dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.ContextMenuStrip = contextMenuStrip1;
            dgvHD.Location = new System.Drawing.Point(11, 197);
            dgvHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 62;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new System.Drawing.Size(709, 321);
            dgvHD.TabIndex = 3;
            dgvHD.CellContentClick += dgvHD_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { xemChiTiếtHóaĐơnToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(217, 28);
            // 
            // xemChiTiếtHóaĐơnToolStripMenuItem
            // 
            xemChiTiếtHóaĐơnToolStripMenuItem.Name = "xemChiTiếtHóaĐơnToolStripMenuItem";
            xemChiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            xemChiTiếtHóaĐơnToolStripMenuItem.Text = "Xem chi tiết hóa đơn";
            xemChiTiếtHóaĐơnToolStripMenuItem.Click += xemChiTiếtHóaĐơnToolStripMenuItem_Click;
            // 
            // cboMaSach
            // 
            cboMaSach.FormattingEnabled = true;
            cboMaSach.Location = new System.Drawing.Point(128, 68);
            cboMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboMaSach.Name = "cboMaSach";
            cboMaSach.Size = new System.Drawing.Size(218, 28);
            cboMaSach.TabIndex = 3;
            cboMaSach.SelectedIndexChanged += cboMaSach_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(30, 72);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(63, 20);
            label13.TabIndex = 1;
            label13.Text = "Mã sách";
            // 
            // cboMaHD
            // 
            cboMaHD.FormattingEnabled = true;
            cboMaHD.Location = new System.Drawing.Point(128, 29);
            cboMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboMaHD.Name = "cboMaHD";
            cboMaHD.Size = new System.Drawing.Size(218, 28);
            cboMaHD.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(30, 33);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(89, 20);
            label12.TabIndex = 1;
            label12.Text = "Mã hóa đơn";
            // 
            // txtDonGia
            // 
            txtDonGia.Enabled = false;
            txtDonGia.Location = new System.Drawing.Point(481, 79);
            txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new System.Drawing.Size(186, 27);
            txtDonGia.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Enabled = false;
            label15.Location = new System.Drawing.Point(383, 82);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(62, 20);
            label15.TabIndex = 1;
            label15.Text = "Đơn giá";
            // 
            // txtSL
            // 
            txtSL.Location = new System.Drawing.Point(481, 33);
            txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSL.Name = "txtSL";
            txtSL.Size = new System.Drawing.Size(186, 27);
            txtSL.TabIndex = 2;
            txtSL.TextChanged += txtSL_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Enabled = false;
            label14.Location = new System.Drawing.Point(383, 33);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(69, 20);
            label14.TabIndex = 1;
            label14.Text = "Số lượng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTaoHD);
            groupBox1.Controls.Add(cboTenKH);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(16, 13);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(733, 132);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập hóa đơn";
            // 
            // btnTaoHD
            // 
            btnTaoHD.Location = new System.Drawing.Point(482, 69);
            btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new System.Drawing.Size(218, 31);
            btnTaoHD.TabIndex = 0;
            btnTaoHD.Text = "Tạo hóa đơn";
            btnTaoHD.UseVisualStyleBackColor = true;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // cboTenKH
            // 
            cboTenKH.FormattingEnabled = true;
            cboTenKH.Location = new System.Drawing.Point(482, 31);
            cboTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboTenKH.Name = "cboTenKH";
            cboTenKH.Size = new System.Drawing.Size(218, 28);
            cboTenKH.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Enabled = false;
            label11.Location = new System.Drawing.Point(373, 37);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(111, 20);
            label11.TabIndex = 1;
            label11.Text = "Tên khách hàng";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new System.Drawing.Point(128, 31);
            txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new System.Drawing.Size(218, 27);
            txtMaHD.TabIndex = 2;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgayTao.Location = new System.Drawing.Point(129, 69);
            dtpNgayTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new System.Drawing.Size(218, 27);
            dtpNgayTao.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(30, 35);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(89, 20);
            label8.TabIndex = 1;
            label8.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày tạo";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(vScrollBar2);
            tabPage2.Controls.Add(dgvKH);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(765, 756);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Khách hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new System.Drawing.Point(729, 180);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new System.Drawing.Size(17, 551);
            vScrollBar2.TabIndex = 11;
            // 
            // dgvKH
            // 
            dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new System.Drawing.Point(18, 180);
            dgvKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 62;
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new System.Drawing.Size(730, 551);
            dgvKH.TabIndex = 10;
            dgvKH.SelectionChanged += dgvKH_SelectionChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnR);
            groupBox3.Controls.Add(cboPhai);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTenKh);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtMaKH);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnEditKH);
            groupBox3.Controls.Add(btnDelKH);
            groupBox3.Controls.Add(btnAddKH);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new System.Drawing.Point(18, 8);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(730, 164);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // btnR
            // 
            btnR.Location = new System.Drawing.Point(140, 125);
            btnR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnR.Name = "btnR";
            btnR.Size = new System.Drawing.Size(123, 31);
            btnR.TabIndex = 7;
            btnR.Text = "AutoID";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // cboPhai
            // 
            cboPhai.FormattingEnabled = true;
            cboPhai.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboPhai.Location = new System.Drawing.Point(425, 69);
            cboPhai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboPhai.Name = "cboPhai";
            cboPhai.Size = new System.Drawing.Size(61, 28);
            cboPhai.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(425, 32);
            txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(243, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(543, 69);
            txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(125, 27);
            txtSDT.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(361, 35);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 20);
            label6.TabIndex = 2;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(361, 75);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 20);
            label7.TabIndex = 2;
            label7.Text = "Giới tính";
            // 
            // txtTenKh
            // 
            txtTenKh.Location = new System.Drawing.Point(130, 69);
            txtTenKh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTenKh.Name = "txtTenKh";
            txtTenKh.Size = new System.Drawing.Size(173, 27);
            txtTenKh.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(510, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 20);
            label5.TabIndex = 2;
            label5.Text = "SĐT";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new System.Drawing.Point(130, 31);
            txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new System.Drawing.Size(173, 27);
            txtMaKH.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            // 
            // btnEditKH
            // 
            btnEditKH.Location = new System.Drawing.Point(510, 125);
            btnEditKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditKH.Name = "btnEditKH";
            btnEditKH.Size = new System.Drawing.Size(101, 31);
            btnEditKH.TabIndex = 4;
            btnEditKH.Text = "Chỉnh sửa";
            btnEditKH.UseVisualStyleBackColor = true;
            btnEditKH.Click += btnEditKH_Click;
            // 
            // btnDelKH
            // 
            btnDelKH.Location = new System.Drawing.Point(393, 125);
            btnDelKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelKH.Name = "btnDelKH";
            btnDelKH.Size = new System.Drawing.Size(101, 31);
            btnDelKH.TabIndex = 4;
            btnDelKH.Text = "Xóa";
            btnDelKH.UseVisualStyleBackColor = true;
            btnDelKH.Click += btnDelKH_Click;
            // 
            // btnAddKH
            // 
            btnAddKH.Location = new System.Drawing.Point(278, 125);
            btnAddKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddKH.Name = "btnAddKH";
            btnAddKH.Size = new System.Drawing.Size(101, 31);
            btnAddKH.TabIndex = 4;
            btnAddKH.Text = "Nhập";
            btnAddKH.UseVisualStyleBackColor = true;
            btnAddKH.Click += btnAddKH_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã khách hàng";
            // 
            // Cashier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 840);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Cashier";
            FormClosing += Cashier_FormClosing;
            Load += Cashier_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Nv;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditKH;
        private System.Windows.Forms.Button btnDelKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCT_HOADON;
        private System.Windows.Forms.Label label10;
    }
}