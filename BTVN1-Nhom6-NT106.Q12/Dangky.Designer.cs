namespace BTVN1_Nhom6_NT106.Q12
{
    partial class Dangky
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LB_Username = new Label();
            TB_Username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblSDT = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblDiaChi = new Label();
            txtSDT = new TextBox();
            txtNgaySinh = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            BT_Dangky = new Button();
            LB_CoTK = new Label();
            LB_Link = new LinkLabel();
            SuspendLayout();
            // 
            // LB_Username
            // 
            LB_Username.AutoSize = true;
            LB_Username.Font = new Font("Segoe UI", 11F);
            LB_Username.Location = new Point(50, 38);
            LB_Username.Name = "LB_Username";
            LB_Username.Size = new Size(97, 25);
            LB_Username.TabIndex = 0;
            LB_Username.Text = "Username";
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(212, 36);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(267, 27);
            TB_Username.TabIndex = 1;
            TB_Username.Validating += TB_Username_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(65, 80);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(14, 202);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 3;
            label2.Text = "Nhập lại password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(50, 162);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(60, 120);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 5;
            label4.Text = "Họ Tên";
            // 
            // button1
            // 
            button1.Location = new Point(257, 244);
            button1.Name = "button1";
            button1.Size = new Size(121, 39);
            button1.TabIndex = 6;
            button1.Text = "Tuỳ chọn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 7;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 8;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 27);
            textBox3.TabIndex = 9;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 27);
            textBox4.TabIndex = 10;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 11F);
            lblSDT.Location = new Point(36, 297);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(123, 25);
            lblSDT.TabIndex = 11;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 11F);
            lblNgaySinh.Location = new Point(48, 339);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(96, 25);
            lblNgaySinh.TabIndex = 12;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 11F);
            lblGioiTinh.Location = new Point(53, 385);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(84, 25);
            lblGioiTinh.TabIndex = 13;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 11F);
            lblDiaChi.Location = new Point(58, 427);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(70, 25);
            lblDiaChi.TabIndex = 14;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(212, 298);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(267, 27);
            txtSDT.TabIndex = 15;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(212, 340);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(267, 27);
            txtNgaySinh.TabIndex = 16;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(212, 386);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(267, 27);
            txtGioiTinh.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(212, 428);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(267, 27);
            txtDiaChi.TabIndex = 18;
            // 
            // BT_Dangky
            // 
            BT_Dangky.Location = new Point(257, 475);
            BT_Dangky.Name = "BT_Dangky";
            BT_Dangky.Size = new Size(121, 39);
            BT_Dangky.TabIndex = 19;
            BT_Dangky.Text = "Đăng ký";
            BT_Dangky.UseVisualStyleBackColor = true;
            BT_Dangky.Click += BT_Dangky_Click;
            // 
            // LB_CoTK
            // 
            LB_CoTK.AutoSize = true;
            LB_CoTK.Font = new Font("Segoe UI", 8F);
            LB_CoTK.Location = new Point(416, 475);
            LB_CoTK.Name = "LB_CoTK";
            LB_CoTK.Size = new Size(136, 19);
            LB_CoTK.TabIndex = 20;
            LB_CoTK.Text = "Bạn đã có tài khoản?";
            // 
            // LB_Link
            // 
            LB_Link.AutoSize = true;
            LB_Link.Location = new Point(442, 494);
            LB_Link.Name = "LB_Link";
            LB_Link.Size = new Size(82, 20);
            LB_Link.TabIndex = 21;
            LB_Link.TabStop = true;
            LB_Link.Text = "Đăng nhập";
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 553);
            Controls.Add(LB_Link);
            Controls.Add(LB_CoTK);
            Controls.Add(BT_Dangky);
            Controls.Add(txtDiaChi);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtSDT);
            Controls.Add(lblDiaChi);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblSDT);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_Username);
            Controls.Add(LB_Username);
            Name = "Dangky";
            Text = "Dangky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB_Username;
        private TextBox TB_Username;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblSDT;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblDiaChi;
        private TextBox txtSDT;
        private TextBox txtNgaySinh;
        private TextBox txtGioiTinh;
        private TextBox txtDiaChi;
        private Button BT_Dangky;
        private Label LB_CoTK;
        private LinkLabel LB_Link;
    }
}
