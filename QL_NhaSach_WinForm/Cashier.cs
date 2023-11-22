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

namespace QL_NhaSach_WinForm
{
    public partial class Cashier : Form
    {
        DataTable dtable;
        SqlConnection connsql = new SqlConnection(@"Data Source=DESKTOP-U2QN3CF\SQLEXPRESS;Initial Catalog=QL_NhaSach_DA_DotNet;Integrated Security=True");


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
        }
        public void load_cbo_maSach()
        {
            string select_string = "select * from Sach";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable_1 = new DataTable();
            sda.Fill(dtable_1);
            cboMaSach.DataSource = dtable_1;
            cboMaSach.DisplayMember = "MaSach";
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

            cboTenKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenKH.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboTenKH.SelectedIndex = cboTenKH.Items.Count - 1;

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

        public void load_ct_hoaDon()
        {
            string select_string = "select * from CT_HoaDon where mahd = '" + cboMaHD.SelectedValue.ToString() + "'";
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
                new_row["makh"] =txtMaKH.Text;
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
            load_hd();
            load_cbo_maSach();
            load_KH();

            load_cbo_KhachHang();

        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();

            this.Hide();
        }
    }
}
