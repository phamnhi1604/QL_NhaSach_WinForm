using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_NhaSach_WinForm
{
    public partial class interfaceNV : Form
    {
        public interfaceNV()
        {
            InitializeComponent();
        }

        private void btnNhapS_Click(object sender, EventArgs e)
        {
            PhieuNhap form_pn = new PhieuNhap();
            form_pn.Show();
            this.Hide();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            Form_Info form_tt = new Form_Info();
            form_tt.Show();
            this.Hide();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {

        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            Cashier form_nvthungan = new Cashier();
            form_nvthungan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
