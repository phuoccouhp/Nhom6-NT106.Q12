namespace BTVN1_Nhom6_NT106.Q12
{
    partial class ThongTinNguoiDung
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblWelcome;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtGender;
        private TextBox txtBirthday;
        private TextBox txtAddress;
        private Button btnShowPass;
        private Button btnLogout;
        private Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblWelcome = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtGender = new TextBox();
            txtBirthday = new TextBox();
            txtAddress = new TextBox();
            btnShowPass = new Button();
            btnLogout = new Button();
            panelMain = new Panel();

            panelMain.SuspendLayout();
            SuspendLayout();

            // ======= TITLE =======

            lblTitle.Text = "ỨNG DỤNG QUẢN LÝ NGƯỜI DÙNG";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Height = 60;

            // ======= MAIN =======

            panelMain.Dock = DockStyle.Fill;
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Padding = new Padding(30);

            int leftLabel = 40;
            int leftBox = 180;
            int top = 40;
            int spacing = 40;
            Size boxSize = new Size(250, 27);

            // ======= WELCOME =======

            lblWelcome.Text = "Xin chào, ...";
            lblWelcome.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblWelcome.Location = new Point(leftLabel, top);
            lblWelcome.AutoSize = true;
            top += spacing + 10;

            // ======= USERNAME =======

            Label lblU = new Label();
            lblU.Text = "Tên đăng nhập:";
            lblU.Location = new Point(leftLabel, top);
            txtUsername.Location = new Point(leftBox, top - 3);
            txtUsername.Size = boxSize;
            txtUsername.ReadOnly = true;
            top += spacing;

            // ======= EMAIL =======

            Label lblE = new Label();
            lblE.Text = "Email:";
            lblE.Location = new Point(leftLabel, top);
            txtEmail.Location = new Point(leftBox, top - 3);
            txtEmail.Size = boxSize;
            txtEmail.ReadOnly = true;
            top += spacing;

            // ======= PASSWORD =======

            Label lblP = new Label();
            lblP.Text = "Mật khẩu:";
            lblP.Location = new Point(leftLabel, top);
            txtPassword.Location = new Point(leftBox, top - 3);
            txtPassword.Size = boxSize;
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;

            btnShowPass.Text = "👁";
            btnShowPass.Size = new Size(40, 27);
            btnShowPass.Location = new Point(leftBox + 260, top - 3);
            btnShowPass.BackColor = Color.LightGray;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.Click += BtnShowPass_Click;

            top += spacing;

            // ======= PHONE =======

            Label lblPhone = new Label();
            lblPhone.Text = "Số điện thoại:";
            lblPhone.Location = new Point(leftLabel, top);
            txtPhone.Location = new Point(leftBox, top - 3);
            txtPhone.Size = boxSize;
            txtPhone.ReadOnly = true;
            top += spacing;

            // ======= GENDER =======

            Label lblG = new Label();
            lblG.Text = "Giới tính:";
            lblG.Location = new Point(leftLabel, top);
            txtGender.Location = new Point(leftBox, top - 3);
            txtGender.Size = boxSize;
            txtGender.ReadOnly = true;
            top += spacing;

            // ======= BIRTHDAY =======

            Label lblB = new Label();
            lblB.Text = "Ngày sinh:";
            lblB.Location = new Point(leftLabel, top);
            txtBirthday.Location = new Point(leftBox, top - 3);
            txtBirthday.Size = boxSize;
            txtBirthday.ReadOnly = true;
            top += spacing;

            // ======= ADDRESS =======

            Label lblA = new Label();
            lblA.Text = "Địa chỉ:";
            lblA.Location = new Point(leftLabel, top);
            txtAddress.Location = new Point(leftBox, top - 3);
            txtAddress.Size = boxSize;
            txtAddress.ReadOnly = true;
            top += spacing + 10;

            // ======= LOGOUT =======

            btnLogout.Text = "🔁 Đăng xuất";
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.BackColor = Color.LightCoral;
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(leftBox, top);
            btnLogout.Size = new Size(140, 40);
            btnLogout.Click += btnLogout_Click;

            // ======= ADD CONTROL =======

            panelMain.Controls.AddRange(new Control[]
            {
                lblWelcome, lblU, txtUsername, lblE, txtEmail, lblP, txtPassword, btnShowPass,
                lblPhone, txtPhone, lblG, txtGender, lblB, txtBirthday, lblA, txtAddress, btnLogout
            });

            // ======= THONGTINNGUOIDUNG =======

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 500);
            Controls.Add(panelMain);
            Controls.Add(lblTitle);
            Name = "ThongTinNguoiDung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin người dùng";
            Load += ThongTinNguoiDung_Load;

            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }
    }
}
