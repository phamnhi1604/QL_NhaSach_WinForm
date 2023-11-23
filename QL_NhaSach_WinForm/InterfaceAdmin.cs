using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_NhaSach_WinForm
{
    public partial class InterfaceAdmin : Form
    {
        public InterfaceAdmin()
        {
            InitializeComponent();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void btnS_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            IAdmin_QLNV dn = new IAdmin_QLNV();
            dn.Show();
        }
    }
}
    