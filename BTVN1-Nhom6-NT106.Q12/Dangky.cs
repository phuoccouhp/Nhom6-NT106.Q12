namespace BTVN1_Nhom6_NT106.Q12
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
            txtSDT.Visible = false;
            txtNgaySinh.Visible = false;
            txtGioiTinh.Visible = false;
            txtDiaChi.Visible = false;
            lblSDT.Visible = false;
            lblNgaySinh.Visible = false;
            lblGioiTinh.Visible = false;
            lblDiaChi.Visible = false;

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
                MessageBox.Show("Mật khẩu nhập lại không khớp!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            string sdt = txtSDT.Visible ? txtSDT.Text : "";
            string ngaysinh = txtNgaySinh.Visible ? txtNgaySinh.Text : "";
            string gioitinh = txtGioiTinh.Visible ? txtGioiTinh.Text : "";
            string diachi = txtDiaChi.Visible ? txtDiaChi.Text : "";

            MessageBox.Show($"Đăng ký thành công!\nUsername: {username}\nEmail: {email}\nHọ tên: {hoten}\n" +
                            $"SĐT: {sdt}\nNgày sinh: {ngaysinh}\nGiới tính: {gioitinh}\nĐịa chỉ: {diachi}");
        }

    }
}
