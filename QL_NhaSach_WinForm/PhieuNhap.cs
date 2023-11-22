using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VBSQLHelper;
using System.Data.SqlClient;

namespace QL_NhaSach_WinForm
{
    public partial class PhieuNhap : Form
    {
        DataTable dtable;
        SqlConnection connsql = new SqlConnection(@"Data Source=DESKTOP-U2QN3CF\SQLEXPRESS;Initial Catalog=QL_NhaSach_DA_DotNet;Integrated Security=True");

        public PhieuNhap()
        {
            InitializeComponent();
        }


        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();

            this.Hide();
        }
        public void load_solg_donGia()
        {
            string select_string = "select SoLuong, DonGia from ct_phieunhap where mapn = '" + cbMaPN.SelectedValue.ToString() + "'";

            connsql.Open();
            SqlCommand cmd = new SqlCommand(select_string, connsql);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtDonGia.Text = sdr["DonGia"].ToString();
            }
            connsql.Close();


        }
        private void cbo_phieunhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_solg_donGia();

        }
        public void load_ct_phieunhap()
        {
            string select_string = "select * from CT_HoaDon where SoHD = '" + cbMaPN.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            gdvPN.DataSource = dtable;
        }
        private void cbo_maPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_ct_phieunhap();
        }
        public string CreateAutoID_PN()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('MAPN', RIGHT(CONCAT('000000',ISNULL(right(max(mapn),10),0) + 1),10))
                                            FROM dbo.Phieunhap where mapn like 'PN%'").ToString();
        }
        public void load_pn()
        {
            string select_string = "select * from phieunhap";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            cbMaPN.DataSource = dtable;
            cbMaPN.DisplayMember = "maPN";
            cbMaPN.ValueMember = "maPN";
        }
        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from phieunhap";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow find_row = dtable.Rows.Find(txtMaPN.Text);
                if (find_row != null)
                {
                    MessageBox.Show("Mã hóa đơn bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["maPN"] = txtMaPN.Text;
                    new_row["NgayNhap"] = dtpNgayNhap.Value.Date.ToString();
                    //new_row["MaNV"] = txtNV.Text;

                    dtable.Rows.Add(new_row);
                    MessageBox.Show("Thêm phiếu nhập thành công.");

                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                load_pn();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hóa đơn thất bại.");
            }
        }


    }
}
