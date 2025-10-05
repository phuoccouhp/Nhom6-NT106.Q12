using System.Runtime.InteropServices;

namespace BTVN1_Nhom6_NT106.Q12
{

    public partial class Dangky : Form
    {
        string connectionString = "Server=localhost;Database=UserDB;Trusted_Connection=True;";

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        public Dangky()
        {

            InitializeComponent();
            SetCueBanner(textBox1, "abc@gmail.com");
            txtSDT.Visible = false;
            txtNgaySinh.Visible = false;
            txtGioiTinh.Visible = false;
            txtDiaChi.Visible = false;
            lblSDT.Visible = false;
            lblNgaySinh.Visible = false;
            lblGioiTinh.Visible = false;
            lblDiaChi.Visible = false;
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isVisible = txtSDT.Visible;

            txtSDT.Visible = !isVisible;
            txtNgaySinh.Visible = !isVisible;
            txtGioiTinh.Visible = !isVisible;
            txtDiaChi.Visible = !isVisible;

            lblSDT.Visible = !isVisible;
            lblNgaySinh.Visible = !isVisible;
            lblGioiTinh.Visible = !isVisible;
            lblDiaChi.Visible = !isVisible;
        }
        private void BT_Dangky_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text;
            string email = textBox1.Text;
            string hoten = textBox2.Text;
            string password = textBox3.Text;
            string repassword = textBox4.Text;


            if (password != repassword)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string sdt = txtSDT.Visible ? txtSDT.Text : "";
            string ngaysinh = txtNgaySinh.Visible ? txtNgaySinh.Text : "";
            string gioitinh = txtGioiTinh.Visible ? txtGioiTinh.Text : "";
            string diachi = txtDiaChi.Visible ? txtDiaChi.Text : "";

            MessageBox.Show($"Đăng ký thành công!\nUsername: {username}\nEmail: {email}\nHọ tên: {hoten}\n" +
                            $"SĐT: {sdt}\nNgày sinh: {ngaysinh}\nGiới tính: {gioitinh}\nĐịa chỉ: {diachi}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void SetCueBanner(TextBox box, string cue)
        {
            SendMessage(box.Handle, EM_SETCUEBANNER, (IntPtr)0, cue);
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = textBox1.Text.Trim();

            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                e.Cancel = true;
                MessageBox.Show("Email phải kết thúc bằng @gmail.com",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool checkmk(string mk)
        {
            if (mk == null) return false;


            return true;
        }
        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string password = textBox3.Text;
            if (password.Length < 8)
            {
                e.Cancel = true;
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password.Any(char.IsUpper))
            {
                e.Cancel = true;
                MessageBox.Show("Mật khẩu phải chứa ít nhất 1 chữ hoa!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password.Any(char.IsDigit))
            {
                e.Cancel = true;
                MessageBox.Show("Mật khẩu phải chứa ít nhất 1 chữ số!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                e.Cancel = true;
                MessageBox.Show("Mật khẩu phải chứa ít nhất 1 ký tự đặc biệt!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TB_Username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = TB_Username.Text;
            if (text == "")
            {
                MessageBox.Show("Không được để username trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = textBox2.Text;
            if (text == "")
            {
                MessageBox.Show("Không được để họ tên trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LB_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TB_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
