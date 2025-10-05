using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BTVN1_Nhom6_NT106.Q12
{
    public partial class Dangnhap : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        public Dangnhap(string username)
        {
            InitializeComponent();
        }
        private void BT_Dangnhap_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text.Trim();
            string password = TB_MK.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @u AND Password = @p";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            Dangnhap main = new Dangnhap(username);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var dangkyForm = new Dangky();
            dangkyForm.ShowDialog();
        }

        private void LinkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dangkyForm = new Dangky();
            dangkyForm.ShowDialog();
        }

        private void LB_QUENMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form quên mật khẩu (giả sử bạn có form QuenMatKhau)
            using var quenMatKhauForm = new QuenMatKhau();
            quenMatKhauForm.ShowDialog();
        }
    }
}
