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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            TB_MK = new TextBox();
            label1 = new Label();
            TB_Username = new TextBox();
            LB_Username = new Label();
            LB_QUENMK = new LinkLabel();
            LB_Quen = new Label();
            BT_Dangnhap = new Button();
            Link_DK = new LinkLabel();
            LinkDK = new LinkLabel();
            SuspendLayout();
            // 
            // TB_MK
            // 
            TB_MK.Location = new Point(644, 375);
            TB_MK.Name = "TB_MK";
            TB_MK.Size = new Size(267, 27);
            TB_MK.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(502, 377);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 10;
            label1.Text = "Mật khẩu";
            // 
            // TB_Username
            // 
            TB_Username.BackColor = Color.White;
            TB_Username.Location = new Point(644, 342);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(267, 27);
            TB_Username.TabIndex = 9;
            // 
            // LB_Username
            // 
            LB_Username.AutoSize = true;
            LB_Username.BackColor = Color.Transparent;
            LB_Username.Font = new Font("Segoe UI", 11F);
            LB_Username.ForeColor = SystemColors.ActiveCaptionText;
            LB_Username.Location = new Point(470, 344);
            LB_Username.Name = "LB_Username";
            LB_Username.Size = new Size(150, 25);
            LB_Username.TabIndex = 8;
            LB_Username.Text = "Username/Email";
            // 
            // LB_QUENMK
            // 
            LB_QUENMK.AutoSize = true;
            LB_QUENMK.BackColor = Color.Transparent;
            LB_QUENMK.Font = new Font("Segoe UI", 8F);
            LB_QUENMK.LinkColor = Color.Brown;
            LB_QUENMK.Location = new Point(814, 438);
            LB_QUENMK.Name = "LB_QUENMK";
            LB_QUENMK.Size = new Size(111, 19);
            LB_QUENMK.TabIndex = 24;
            LB_QUENMK.TabStop = true;
            LB_QUENMK.Text = "Quên mật khẩu?";
            LB_QUENMK.LinkClicked += LB_QUENMK_LinkClicked;
            // 
            // LB_Quen
            // 
            LB_Quen.AutoSize = true;
            LB_Quen.Font = new Font("Segoe UI", 9F);
            LB_Quen.Location = new Point(427, 316);
            LB_Quen.Name = "LB_Quen";
            LB_Quen.Size = new Size(0, 20);
            LB_Quen.TabIndex = 23;
            // 
            // BT_Dangnhap
            // 
            BT_Dangnhap.BackColor = Color.MintCream;
            BT_Dangnhap.Location = new Point(673, 418);
            BT_Dangnhap.Name = "BT_Dangnhap";
            BT_Dangnhap.Size = new Size(135, 39);
            BT_Dangnhap.TabIndex = 22;
            BT_Dangnhap.Text = "Đăng nhập";
            BT_Dangnhap.UseVisualStyleBackColor = false;
            BT_Dangnhap.Click += BT_Dangnhap_Click;
            // 
            // Link_DK
            // 
            Link_DK.ActiveLinkColor = Color.White;
            Link_DK.AutoSize = true;
            Link_DK.BackColor = Color.Transparent;
            Link_DK.Font = new Font("Segoe UI", 11F);
            Link_DK.LinkColor = Color.OrangeRed;
            Link_DK.Location = new Point(502, 476);
            Link_DK.Name = "Link_DK";
            Link_DK.Size = new Size(0, 25);
            Link_DK.TabIndex = 25;
            Link_DK.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LinkDK
            // 
            LinkDK.ActiveLinkColor = Color.White;
            LinkDK.AutoSize = true;
            LinkDK.BackColor = Color.Transparent;
            LinkDK.Font = new Font("Segoe UI", 11F);
            LinkDK.LinkColor = Color.OrangeRed;
            LinkDK.Location = new Point(544, 303);
            LinkDK.Name = "LinkDK";
            LinkDK.Size = new Size(288, 25);
            LinkDK.TabIndex = 27;
            LinkDK.TabStop = true;
            LinkDK.Text = "Đăng ký ( nếu chưa có tài khoản)";
            LinkDK.LinkClicked += LinkDK_LinkClicked;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1377, 630);
            Controls.Add(LinkDK);
            Controls.Add(Link_DK);
            Controls.Add(LB_QUENMK);
            Controls.Add(LB_Quen);
            Controls.Add(BT_Dangnhap);
            Controls.Add(TB_MK);
            Controls.Add(label1);
            Controls.Add(TB_Username);
            Controls.Add(LB_Username);
            Name = "Dangnhap";
            Text = "Dangnhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_MK;
        private Label label1;
        private TextBox TB_Username;
        private Label LB_Username;
        private LinkLabel LB_QUENMK;
        private Label LB_Quen;
        private Button BT_Dangnhap;
        private LinkLabel Link_DK;
        private LinkLabel LinkDK;
    }
}