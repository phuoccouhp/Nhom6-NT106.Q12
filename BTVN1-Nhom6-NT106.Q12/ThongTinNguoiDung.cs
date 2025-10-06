using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTVN1_Nhom6_NT106.Q12
{
    public partial class ThongTinNguoiDung : Form
    {
        bool isPasswordVisible = false;

        public ThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void ThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=QLNguoiDung;Integrated Security=True;";

            string username = "user1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NguoiDung WHERE TenDangNhap = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblWelcome.Text = $"Xin chào, {reader["HoTen"]}!";
                    txtUsername.Text = reader["TenDangNhap"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPassword.Text = reader["MatKhau"].ToString();
                    txtPhone.Text = reader["SoDienThoai"].ToString();
                    txtGender.Text = reader["GioiTinh"].ToString();
                    txtBirthday.Text = Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString();
                    txtAddress.Text = reader["DiaChi"].ToString();
                }
            }
        }

        private void BtnShowPass_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '*';
                btnShowPass.Text = "👁";
                isPasswordVisible = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                btnShowPass.Text = "🚫";
                isPasswordVisible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dangnhap().Show();
        }
    }
}
