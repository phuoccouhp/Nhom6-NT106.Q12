namespace BTVN1_Nhom6_NT106.Q12
{
    partial class MatKhauMoi
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
            label1 = new Label();
            BT_Xacthuc = new Button();
            TB_Username = new TextBox();
            LB_Username = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(107, 206);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 28;
            label1.Text = "Nhập lại mật khẩu mới:";
            // 
            // BT_Xacthuc
            // 
            BT_Xacthuc.Location = new Point(326, 259);
            BT_Xacthuc.Name = "BT_Xacthuc";
            BT_Xacthuc.Size = new Size(121, 39);
            BT_Xacthuc.TabIndex = 27;
            BT_Xacthuc.Text = "Đổi mật khẩu";
            BT_Xacthuc.UseVisualStyleBackColor = true;
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(347, 152);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(257, 27);
            TB_Username.TabIndex = 26;
            // 
            // LB_Username
            // 
            LB_Username.AutoSize = true;
            LB_Username.Font = new Font("Segoe UI", 11F);
            LB_Username.Location = new Point(132, 152);
            LB_Username.Name = "LB_Username";
            LB_Username.Size = new Size(182, 25);
            LB_Username.TabIndex = 25;
            LB_Username.Text = "Nhập mật khẩu mới:";
            LB_Username.Click += LB_Username_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 29;
            // 
            // MatKhauMoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BT_Xacthuc);
            Controls.Add(TB_Username);
            Controls.Add(LB_Username);
            Name = "MatKhauMoi";
            Text = "MatKhauMoi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BT_Xacthuc;
        private TextBox TB_Username;
        private Label LB_Username;
        private TextBox textBox1;
    }
}