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
    public partial class IAdmin_QLNV : Form
    {
        DataTable dtable;
        SqlConnection connsql = new SqlConnection(@"Data Source=DESKTOP-U2QN3CF\SQLEXPRESS;Initial Catalog=QL_NhaSach_DA_DotNet;Integrated Security=True");

        public IAdmin_QLNV()
        {
            InitializeComponent();
        }

        private void IAdmin_QLNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

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
                cboPhai.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();

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
                    if (cboPhai.SelectedItem == null)
                    {
                        new_row["gioitinh"] = "";
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
                    if (txtMaNV.Text != "admin")
                    {
                        d_row["tennv"] = txtTenNV.Text;
                        d_row["password"] = txtPW.Text;
                        d_row["SDT"] = txtSDT.Text;
                        d_row["DiaChi"] = txtDC.Text;
                        d_row["gioitinh"] = cboPhai.SelectedItem.ToString();
                        if (txtSDT.Text == null)
                        {
                            d_row["SDT"] = "";
                        }
                        if (txtDC.Text == null)
                        {
                            d_row["DiaChi"] = "";
                        }
                        if (txtDC.Text == null)
                        {
                            d_row["gioitinh"] = "";
                        }
                    } 

                }
                
                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã sửa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa thất bại.");
            }

            load_nv();

        }
        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void IAdmin_QLNV_Load(object sender, EventArgs e)
        {
            load_nv();
        }
    }



}
