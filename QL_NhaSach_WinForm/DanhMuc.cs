using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QL_NhaSach_WinForm
{
    public partial class DanhMuc : Form
    {
        SqlConnection connsql = new SqlConnection(Ketnoi.stringConnect);
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataTable tb;

        public DanhMuc()
        {
            InitializeComponent();

        }
        public DataTable XemDL(string sql)
        {
            if (connsql.State == ConnectionState.Closed)
            {
                // Kết nối đang mở
                Console.WriteLine("Kết nối đang mở.");
                connsql.Open();
            }


            SqlDataAdapter adap = new SqlDataAdapter(sql, connsql);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            connsql.Close();
        }
        void load_dgvDanhMuc_Sach()
        {
            string truyvan = "select * from Sach";
            da = new SqlDataAdapter(truyvan, connsql);
            tb = new DataTable();
            da.Fill(tb);
            dgv_Sach.DataSource = tb;
            dgv_TraCuu.DataSource = tb;
        }

        void load_cboTG_Sach()
        {
            string truyvan = "select * from TACGIA  ";
            da = new SqlDataAdapter(truyvan, connsql);
            tb = new DataTable();
            da.Fill(tb);
            cboTG.DataSource = tb;
            cboTG.DisplayMember = "tentg";
            cboTG.ValueMember = "matg";
     
        }

       
        void load_cboTL_Sach()
        {
            string truyvan = "select * from theloai";
            da = new SqlDataAdapter(truyvan, connsql);
            tb = new DataTable();
            da.Fill(tb);
            cboTL.DataSource = tb;
            cboTL.DisplayMember = "tentl";
            cboTL.ValueMember = "matl";
        }
        void load_cboNXB_Sach()
        {
            string truyvan = "select * from NXB";
            da = new SqlDataAdapter(truyvan, connsql);
            tb = new DataTable();
            da.Fill(tb);
            cboNXB.DataSource = tb;
            cboNXB.DisplayMember = "tenNXB";
            cboNXB.ValueMember = "maNXB";
        }


        private void DanhMuc_Load(object sender, EventArgs e)
        {
            load_dgvDanhMuc_Sach();
            load_cboTG_Sach();
            load_cboTL_Sach();
            load_cboNXB_Sach();
        }

        private void dgv_Sach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Sach.CurrentRow != null)
            {
                txtTenSach.Text = dgv_Sach.CurrentRow.Cells[1].Value.ToString();
                cboTG.SelectedValue = dgv_Sach.CurrentRow.Cells[5].Value.ToString();
                cboNXB.SelectedValue = dgv_Sach.CurrentRow.Cells[6].Value.ToString();
                cboTL.SelectedValue = dgv_Sach.CurrentRow.Cells[4].Value.ToString();
            }
        }
       

    //hàm để tìm kiếm 
    public void loadTimKiem()
        {

            string truyvan = "select * from Sach where tensach like N'%" + txtSearch.Text + "%'";
            da = new SqlDataAdapter(truyvan, connsql);
            tb = new DataTable();
            da.Fill(tb);
            dgv_TraCuu.DataSource = tb;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTraCuu_Click(object sender, EventArgs e)
        {


            if (rbTG.Checked == true)
            {
                dgv_TraCuu.DataSource = XemDL("select * from sach where matg like N'%" + txtSearch.Text.Trim() + "%' ");
            }

            else if (rbTenSach.Checked == true)
            {
                dgv_TraCuu.DataSource = XemDL("select * from sach where tensach like N'%" + txtSearch.Text.Trim() + "%' ");
            }
            else if (rbTL.Checked == true)
            {
                dgv_TraCuu.DataSource = XemDL("select * from sach where matl like N'%" + txtSearch.Text.Trim() + "%' ");
            }



        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            load_dgvDanhMuc_Sach();
        }


        //tìm kiếm bằng nút
        public void loadTimKiemBangnut()
        {

            string truyvan = "select * from Sach where tensach like '%" + txtSearch.Text + "%'";
            da = new SqlDataAdapter(truyvan, connsql);
            tb = new DataTable();
            da.Fill(tb);
            dgv_TraCuu.DataSource = tb;
        }
        private void rbTG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTG.Checked == true)
            {
                dgv_TraCuu.DataSource = XemDL("select * from sach where matg like N'%" + txtSearch.Text.Trim() + "%' ");
            }


        }

        private void rbTenSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTenSach.Checked == true)
            {
                dgv_TraCuu.DataSource = XemDL("select * from sach where tensach like N'%" + txtSearch.Text.Trim() + "%' ");
            }


        }

        private void rbTL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTenSach.Checked == true)
            {
                dgv_TraCuu.DataSource = XemDL("select * from sach where matl like N'%" + txtSearch.Text.Trim() + "%' ");
            }

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            load_dgvDanhMuc_Sach();
        }
    }
}
