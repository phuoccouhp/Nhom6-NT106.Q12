using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN1_Nhom6_NT106.Q12
{
    public partial class QuenMatKhau : Form
    {
        private System.Windows.Forms.Timer passwordTimer = new System.Windows.Forms.Timer();

        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void TXT_1_TextChanged(object sender, EventArgs e)
        {
            string username = TXT_1.Text.Trim();

            // Kiểm tra nếu username rỗng thì thông báo
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra username hợp lệ (ví dụ: không chứa ký tự đặc biệt)
            if (!username.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa chữ và số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu hợp lệ, không hiển thị thông báo
        }

        private void TXT_2_TextChanged(object sender, EventArgs e)
        {
            // Đặt lại timer mỗi khi user nhập
            passwordTimer.Stop();
            passwordTimer.Interval = 1500;
            passwordTimer.Tick -= PasswordTimer_Tick;
            passwordTimer.Tick += PasswordTimer_Tick;
            passwordTimer.Start();
        }

        private void PasswordTimer_Tick(object? sender, EventArgs e)
        {
            passwordTimer.Stop();
            string password = TXT_2.Text;

            if (password.Length <= 8)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn 8 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Nếu hợp lệ, không hiển thị thông báo
        }

        private System.Windows.Forms.Timer confirmTimer = new System.Windows.Forms.Timer();

        private void TXT_3_TextChanged(object sender, EventArgs e)
        {
            // Mỗi lần user gõ lại reset timer
            confirmTimer.Stop();
            confirmTimer.Interval = 1500; // 1.5 giây (tùy chỉnh)
            confirmTimer.Tick -= ConfirmTimer_Tick;
            confirmTimer.Tick += ConfirmTimer_Tick;
            confirmTimer.Start();
        }

        private void ConfirmTimer_Tick(object? sender, EventArgs e)
        {
            confirmTimer.Stop();

            string password = TXT_2.Text.Trim();
            string confirmPassword = TXT_3.Text.Trim();

            // Nếu 1 trong 2 ô chưa nhập xong thì không kiểm tra
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                return;

            if (confirmPassword != password)
            {
                MessageBox.Show("⚠️ Mật khẩu xác nhận không khớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Nếu khớp thì không làm gì
        }

    }
}
