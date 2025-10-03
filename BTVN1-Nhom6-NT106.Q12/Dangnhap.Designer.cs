namespace BTVN1_Nhom6_NT106.Q12
{
    partial class Dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            TB_Username = new TextBox();
            LB_Username = new Label();
            LB_Link = new LinkLabel();
            LB_Quen = new Label();
            BT_Dangnhap = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(108, 124);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 10;
            label1.Text = "Mật khẩu";
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(261, 80);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(267, 27);
            TB_Username.TabIndex = 9;
            // 
            // LB_Username
            // 
            LB_Username.AutoSize = true;
            LB_Username.Font = new Font("Segoe UI", 11F);
            LB_Username.Location = new Point(79, 82);
            LB_Username.Name = "LB_Username";
            LB_Username.Size = new Size(150, 25);
            LB_Username.TabIndex = 8;
            LB_Username.Text = "Username/Email";
            // 
            // LB_Link
            // 
            LB_Link.AutoSize = true;
            LB_Link.Location = new Point(412, 155);
            LB_Link.Name = "LB_Link";
            LB_Link.Size = new Size(116, 20);
            LB_Link.TabIndex = 24;
            LB_Link.TabStop = true;
            LB_Link.Text = "Quên mật khẩu?";
            // 
            // LB_Quen
            // 
            LB_Quen.AutoSize = true;
            LB_Quen.Font = new Font("Segoe UI", 9F);
            LB_Quen.Location = new Point(278, 230);
            LB_Quen.Name = "LB_Quen";
            LB_Quen.Size = new Size(154, 20);
            LB_Quen.TabIndex = 23;
            LB_Quen.Text = "nếu chưa có tài khoản";
            // 
            // BT_Dangnhap
            // 
            BT_Dangnhap.Location = new Point(261, 179);
            BT_Dangnhap.Name = "BT_Dangnhap";
            BT_Dangnhap.Size = new Size(121, 39);
            BT_Dangnhap.TabIndex = 22;
            BT_Dangnhap.Text = "Đăng nhập";
            BT_Dangnhap.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(218, 230);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng ký";
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 277);
            Controls.Add(linkLabel1);
            Controls.Add(LB_Link);
            Controls.Add(LB_Quen);
            Controls.Add(BT_Dangnhap);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(TB_Username);
            Controls.Add(LB_Username);
            Name = "Dangnhap";
            Text = "Dangnhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox TB_Username;
        private Label LB_Username;
        private LinkLabel LB_Link;
        private Label LB_Quen;
        private Button BT_Dangnhap;
        private LinkLabel linkLabel1;
    }
}