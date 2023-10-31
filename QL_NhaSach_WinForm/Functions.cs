using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_NhaSach_WinForm
{
    class Functions
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {
             
            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = @"Data Source = DESKTOP - U2QN3CF\SQLEXPRESS;Initial Catalog = QL_NhaSach_DA_DotNet; Integrated Security = True";
            Con.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
    }
}
