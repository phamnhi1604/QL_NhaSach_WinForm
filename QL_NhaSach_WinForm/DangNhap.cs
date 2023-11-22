using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QL_NhaSach_WinForm
{
    public partial class DangNhap : Form
    {
        SqlConnection connsql;
        public static string nameVar;


        public DangNhap()
        {
            InitializeComponent();
            connsql = new SqlConnection(@"Data Source=DESKTOP-U2QN3CF\SQLEXPRESS;Initial Catalog=QL_NhaSach_DA_DotNet;Integrated Security=True");
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string username, password;
            
            username = txtUserName.Text;
            password = txtPassword.Text;

            connsql.Open();

            try
            {
                string select_string = "select * from nhanvien where manv = '" + txtUserName.Text + "' AND password = '" + txtPassword.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    password = txtPassword.Text;

                    // Đưa cái bảng tiếp theo vào.

                    if (txtUserName.Text == "admin")
                    {
                        //MessageBox.Show("Bang cho admin.");
                        interface_Admin form_admin = new interface_Admin();
                        form_admin.Show();
                        this.Hide();

                    }

                    else
                    {
                        //MessageBox.Show("Bang cho nhan vien.");
                        nameVar = txtUserName.Text;
                        interfaceNV form_nv = new interfaceNV();
                        form_nv.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Ten Dang Nhap hay Mat Khau sai.");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
            finally
            {
                connsql.Close();
            }
        }


    }
}
