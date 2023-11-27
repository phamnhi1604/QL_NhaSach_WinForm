using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VBSQLHelper;
using System.Reflection;

namespace QL_NhaSach_WinForm
{

    public partial class Cashier : Form
    {
        public string TenNhanVien { get; set; }
        DataTable dtable;
        SqlConnection connsql = new SqlConnection(@"Data Source=LAPTOP-E3VIO9U0;Initial Catalog=QL_NhaSach_DA_DotNet;Integrated Security=True");


        public Cashier(string tenNhanVien)
        {
            InitializeComponent();
            TenNhanVien = tenNhanVien;
        }

        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void load_hd()
        {
            string select_string = "select * from HoaDon";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            cboMaHD.DataSource = dtable;
            cboMaHD.DisplayMember = "mahd";
            cboMaHD.ValueMember = "mahd";
            dgvHD.DataSource = dtable;
        }

        public void load_cbo_hd()
        {
            string select_string = "select * from HOADON";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            cboMaHD.DataSource = dtable;
            cboMaHD.DisplayMember = "mahd";
            cboMaHD.ValueMember = "mahd";

            DataRow new_row = dtable.NewRow();
            new_row["mahd"] = "Chon tat ca.";
            dtable.Rows.Add(new_row);

            cboMaHD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaHD.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboMaHD.SelectedIndex = cboMaHD.Items.Count - 1;

            //if (cboMaHD.Items.Count > 0)
            //{
            //    // Chọn giá trị đầu tiên
            //    cboMaHD.SelectedIndex = 0;

            //    string maHoaDon = dtable.Rows[0]["mahd"].ToString();

            //    // Gán giá trị cho ComboBox
            //    cboMaHD.SelectedValue = maHoaDon;
            //}

        }

        //public void load_cboTenSach()
        //{
        //    string select_string = "select * from Sach";
        //    SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
        //    DataTable dtable = new DataTable();
        //    sda.Fill(dtable);
        //    cboTenSach.DataSource = dtable;
        //    cboTenSach.DisplayMember = "tensach";
        //    cboTenSach.ValueMember = "tensach";
        //    dgvHD.DataSource = dtable;
        //}
        public void load_cbo_maSach()
        {
            string select_string = "select * from Sach";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable_1 = new DataTable();
            sda.Fill(dtable_1);
            cboMaSach.DataSource = dtable_1;
            cboMaSach.DisplayMember = "TenSach";
            cboMaSach.ValueMember = "MaSach";


            cboMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaSach.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void load_cbo_KhachHang()
        {
            string select_cboKH = "select * from Khachhang";
            SqlDataAdapter sda_cboKH = new SqlDataAdapter(select_cboKH, connsql);
            DataTable dtable_cboKH = new DataTable();
            sda_cboKH.Fill(dtable_cboKH);

            cboTenKH.DataSource = dtable_cboKH;
            cboTenKH.DisplayMember = "tenkh";
            cboTenKH.ValueMember = "makh";

            //DataRow new_row = dtable_cboKH.NewRow();
            //dtable_cboKH.Rows.Add(new_row);

            //cboTenKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cboTenKH.AutoCompleteSource = AutoCompleteSource.ListItems;

            //cboTenKH.SelectedIndex = cboTenKH.Items.Count - 1;

        }
        public void load_solg_donGia()
        {
            string select_string = "select SoLuong, DonGia from Sach where MaSach = '" + cboMaSach.SelectedValue.ToString() + "'";

            connsql.Open();
            SqlCommand cmd = new SqlCommand(select_string, connsql);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtDonGia.Text = sdr["DonGia"].ToString();
            }
            connsql.Close();


        }
        public string CreateAutoID_HD()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('MAHD', RIGHT(CONCAT('0000',ISNULL(right(max(mahd),10),0) + 1),10))
                                            FROM dbo.HOADON where mahd like 'HD%'").ToString();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from HoaDon";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);


                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;


                DataRow find_row = dtable.Rows.Find(txtMaHD.Text);
                if (find_row != null)
                {
                    MessageBox.Show("Mã hóa đơn bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["MaHD"] = txtMaHD.Text;
                    new_row["NgayMua"] = dtpNgayTao.Value.Date.ToString();
                    new_row["MaNV"] = txt_Nv.Text;
                    new_row["makh"] = cboTenKH.SelectedValue.ToString();

                    dtable.Rows.Add(new_row);
                    MessageBox.Show("Thêm hóa đơn thành công.");

                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                load_hd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hóa đơn thất bại.");
            }

        }
        //where mahd = '" + cboMaHD.SelectedValue.ToString() + "'
        public void load_ct_hoaDon()
        {
            string select_string = "select * from CT_HoaDon";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgvHD.DataSource = dtable;
        }

        //public string CreateAutoID_KH()
        //{

        //}
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Khachhang";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);


                DataRow new_row = dtable.NewRow();
                new_row["makh"] = txtMaKH.Text;
                new_row["tenkh"] = txtTenKh.Text;
                new_row["diachi"] = txtDiaChi.Text;
                new_row["gioitinh"] = cboPhai.SelectedItem.ToString();
                new_row["sdt"] = txtSDT.Text;


                dtable.Rows.Add(new_row);

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);



                MessageBox.Show("Thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại.");
            }
            load_KH();
            load_cbo_KhachHang();
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKH.CurrentRow != null)
            {
                txtMaKH.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
                txtDiaChi.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();
                txtTenKh.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
                cboPhai.Text = dgvKH.CurrentRow.Cells[3].Value.ToString();
                txtSDT.Text = dgvKH.CurrentRow.Cells[4].Value.ToString();

            }
        }
        private void btnDelKH_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from khachhang";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txtMaKH.Text);

                if (kt_trung != null)
                {
                    kt_trung.Delete();
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã Xóa thành công.");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xóa thất bại.");
            }
            load_KH();
            load_cbo_KhachHang();
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Khachhang";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txtMaKH.Text);

                if (d_row != null)
                {
                    d_row["tenkh"] = txtTenKh.Text;
                    d_row["diachi"] = txtDiaChi.Text;
                    d_row["gioitinh"] = cboPhai.SelectedItem.ToString();
                    d_row["sdt"] = txtSDT.Text;
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã sửa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã sửa thất bại.");
            }

            load_KH();
            load_cbo_KhachHang();

        }
        public void load_KH()
        {

            string select_string = "select * from khachhang";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            dgvKH.DataSource = dtable;


        }
        private void btnR_Click(object sender, EventArgs e)
        {
            //txtMaKH.Text = CreateAutoID_KH();
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            txt_Nv.Text = TenNhanVien;
            load_cbo_maSach();
            load_ct_hoaDon();
            load_KH();
            load_cbo_hd();
            //load_cboTenSach();
            load_cbo_KhachHang();

        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();

            this.Hide();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvHD.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng header và có giá trị
                if (!row.IsNewRow && row.Cells["Tongtien"].Value != null)
                {
                    // Lấy giá trị từ cột số tiền (thay "ColumnName" bằng tên cột thực tế)
                    decimal amount = Convert.ToDecimal(row.Cells["Tongtien"].Value);

                    // Cộng vào tổng số tiền
                    totalAmount += amount;
                }
            }

            return totalAmount;
        }






        private void btnTong_Click(object sender, EventArgs e)
        {
            double totalAmount = 0;




            //foreach (DataGridViewRow row in dgvHD.Rows)
            //{
            //    // Kiểm tra xem ô trong cột "Tongtien" có giá trị không
            //    if (row.Cells["Tongtien"].Value != null && row.Cells["Tongtien"].Value != DBNull.Value)
            //    {
            //        // Lấy giá trị từ ô trong cột "Tongtien" và chuyển đổi thành kiểu double
            //        double amount;
            //        if (double.TryParse(row.Cells["Tongtien"].Value.ToString(), out amount))
            //        {
            //            // Thêm vào tổng
            //            totalAmount += amount;
            //        }

            //    }
            //}


            txtTong.Text = totalAmount.ToString();
        }




        private void xemChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from CT_HOADON";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);


                DataRow new_row = dtable.NewRow();
                new_row["Ma_CT_HOADON"] = txtCT_HOADON.Text;
                new_row["MaHD"] = cboMaHD.SelectedValue.ToString();
                new_row["MaSach"] = cboMaSach.SelectedValue.ToString();
                new_row["SoLuong"] = txtSL.Text;
                new_row["Thanhtien"] = decimal.TryParse(txtTong.Text, out decimal Thanhtien);
                //new_row["makh"] = cboTenKH.SelectedValue.ToString();
                dtable.Rows.Add(new_row);

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);



                MessageBox.Show("Thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại.");
            }
            load_ct_hoaDon();

        }

        private decimal GetGiaTien(string maSach)
        {
            // Thực hiện truy vấn để lấy giá tiền từ CSDL hoặc nguồn dữ liệu khác
            // Đây chỉ là một ví dụ đơn giản, bạn cần thay thế nó với mã logic lấy giá tiền thực tế của bạn
            string selectGiaTienString = "SELECT GiaBia FROM Sach WHERE MaSach = '" + cboMaSach.SelectedValue.ToString() + "'";

            using (SqlCommand cmd = new SqlCommand(selectGiaTienString, connsql))
            {
                connsql.Open();
                object result = cmd.ExecuteScalar();
                connsql.Close();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
            }

            return 0; // Giả định giá tiền là 0 nếu không tìm thấy
        }
        private void txtSL_TextChanged(object sender, EventArgs e)
        {

            //decimal tinhtoan = decimal.Parse(txtSL.Text)*;
            string selectedMaSach = cboMaSach.SelectedValue?.ToString();

            // Lấy giá tiền tương ứng từ CSDL hoặc từ nguồn dữ liệu khác
            decimal giaTien = GetGiaTien(selectedMaSach);


            txtDonGia.Text = giaTien.ToString();


            if (txtSL.Text!="")
            { 
                decimal tongtien = GetGiaTien(selectedMaSach) * Int32.Parse(txtSL.Text);
                txtTong.Text = tongtien.ToString();
            }    
            
            // Hiển thị giá tiền vào TextBox
            txtDonGia.Text = giaTien.ToString(); // Định dạng giá tiền

            // tính tổng
        
            

        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
