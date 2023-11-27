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

namespace QL_NhaSach_WinForm
{
    public partial class interface_Admin : Form
    {
        DataTable dtable;
        SqlConnection connsql = new SqlConnection(@"Data Source=LAPTOP-E3VIO9U0;Initial Catalog=QL_NhaSach_DA_DotNet;Integrated Security=True");


        public interface_Admin()
        {
            InitializeComponent();
        }
        private void interface_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnEditS_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from sach";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txtMaS.Text);

                if (d_row != null)
                {
                    //d_row["tenkh"] = txtTenS.Text;
                    //d_row["diachi"] = txtDiaChi.Text;
                    //d_row["gioitinh"] = cboPhai.SelectedItem.ToString();
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

            //load_KH();
            //load_cbo_KhachHang();

        }



        //##############################################
        //===================SÁCH=======================
        //##############################################

        private void interface_Admin_Load(object sender, EventArgs e)
        {
            load_nv();
            load_tg();
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {

        }

        //##############################################
        //=================TÁC GIẢ======================
        //##############################################
        public void load_tg()
        {


            string select_string = "select * from TacGia";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            dgvTG.DataSource = dtable;
        }
        public void load_cbo_tacGia()
        {
            string select_cbo_tacgia = "select * from TacGia";
            SqlDataAdapter sda_cbo_tacgia = new SqlDataAdapter(select_cbo_tacgia, connsql);
            DataTable dtable_cbo_tacgia = new DataTable();
            sda_cbo_tacgia.Fill(dtable_cbo_tacgia);

            cboTG.DataSource = dtable_cbo_tacgia;
            cboTG.DisplayMember = "tentg";
            cboTG.ValueMember = "matg";

            DataRow new_row = dtable_cbo_tacgia.NewRow();
            new_row["tentg"] = "Chon tat ca";
            dtable_cbo_tacgia.Rows.Add(new_row);

            cboTG.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTG.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboTG.SelectedIndex = cboTG.Items.Count - 1;

        }
        private void dgvTG_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTG.CurrentRow != null)
            {
                txtMaTG.Text = dgvTG.CurrentRow.Cells[0].Value.ToString();
                txtTenTG.Text = dgvTG.CurrentRow.Cells[1].Value.ToString();

            }
        }
        private void btnAddTG_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Tacgia";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txtMaTG.Text);

                if (kt_trung != null)
                {
                    MessageBox.Show("Nhập tên tác giả bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["matg"] = txtMaTG.Text;
                    new_row["tentg"] = txtTenTG.Text;

                    dtable.Rows.Add(new_row);
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã thêm thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã thêm thất bại.");
            }

            load_cbo_tacGia();
            load_tg();
        }
        private void btnEditTG_Click(object sender, EventArgs e)
        {

        }
        private void btnDelTG_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from tacgia";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txtMaTG.Text);

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
            load_tg();
            load_cbo_tacGia();
        }


        //##############################################
        //=================NHÂN VIÊN====================
        //##############################################
        public void load_nv()
        {


            string select_string = "select * from nhanvien";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            dgvNV.DataSource = dtable;


        }




        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV.CurrentRow != null)
            {
                txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
                txtPW.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();

                txtSDT.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();

            }
        }
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Nhanvien";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txtMaNV.Text);

                if (kt_trung != null)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["manv"] = txtMaNV.Text;
                    new_row["tennv"] = txtTenNV.Text;
                    new_row["password"] = txtPW.Text;
                    new_row["SDT"] = txtSDT.Text;
                    new_row["gioitinh"] = cboPhai.SelectedItem.ToString();
                    new_row["DiaChi"] = txtDC.Text;
                    if (txtSDT.Text == null)
                    {
                        new_row["SDT"] = "";
                    }
                    if (txtDC.Text == null)
                    {
                        new_row["DiaChi"] = "";
                    }
                    dtable.Rows.Add(new_row);
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã thêm thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã thêm thất bại.");
            }

            //load_cbo_tacGia();
            load_nv();
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from nhanvien";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txtMaNV.Text);

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
            load_nv();

        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from nhanvien";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txtMaNV.Text);

                if (d_row != null)
                {
                    d_row["tenNV"] = txtTenNV.Text;
                    d_row["password"] = txtPW.Text;
                    d_row["sdt"] = txtSDT.Text;
                    d_row["diachi"] = txtDC.Text;
                    d_row["gioitinh"] = cboPhai.SelectedItem.ToString();
                }
                if (txtSDT.Text == null)
                {
                    d_row["SDT"] = "";
                }
                if (txtDC.Text == null)
                {
                    d_row["DiaChi"] = "";
                }
                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã sửa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã sửa thất bại.");
            }

            load_nv();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
