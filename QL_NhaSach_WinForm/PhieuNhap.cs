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

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();

            this.Hide();
        }
        public void LoadData()
        {
            string select_string = "select * from CT_phieunhap where mapn = '" + cbMaPN.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            gdvPN.DataSource = dtable;
        }
        public string CreateAutoID_PN()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('MAPN', RIGHT(CONCAT('000000',ISNULL(right(max(mapn),10),0) + 1),10))
                                            FROM dbo.Phieunhap where mapn like 'PN%'").ToString();
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = CreateAutoID_PN();

            var mapn = txtMaPN.Text.Trim();
            var ngaytao = dtpNgayNhap.Value.ToString("dd/MM/yyyy HH:mm:ss");
            //var tensinhvien = txt_tensv.Text.Trim();
            var sql_insert = $@"INSERT INTO dbo.phieunhap
                                (
                                    mapn,
                                    ngaytao
                                )
                                VALUES
                                (   @mapn,
                                   @ngaytao
                                 )";

            var affectRow = SQLHelper.ExecQueryNonData(sql_insert, new { mapn = mapn, ngaytao = ngaytao });
            // fix insert sql injection
            if (affectRow > 0)
            {
                // Insert success
                
                LoadData();
                txtMaPN.Text = CreateAutoID_PN();
                //dtpNgayNhap.Value.ToString() = "";
                cbMaPN.Focus();
            }
            else
            {
                MessageBox.Show("Insert fails");
            }
        }
    }
}
