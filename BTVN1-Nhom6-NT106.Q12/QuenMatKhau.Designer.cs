namespace BTVN1_Nhom6_NT106.Q12
{
    partial class QuenMatKhau
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
            label2 = new Label();
            label3 = new Label();
            TXT_1 = new TextBox();
            TXT_2 = new TextBox();
            TXT_3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(56, 133);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 0;
            label1.Text = "Đặt lại mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(56, 178);
            label2.Name = "label2";
            label2.Size = new Size(259, 35);
            label2.TabIndex = 1;
            label2.Text = "Xác nhận lại mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(56, 87);
            label3.Name = "label3";
            label3.Size = new Size(127, 35);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // TXT_1
            // 
            TXT_1.Location = new Point(370, 87);
            TXT_1.Name = "TXT_1";
            TXT_1.Size = new Size(235, 27);
            TXT_1.TabIndex = 3;
            TXT_1.TextChanged += TXT_1_TextChanged;
            // 
            // TXT_2
            // 
            TXT_2.Location = new Point(370, 141);
            TXT_2.Name = "TXT_2";
            TXT_2.Size = new Size(235, 27);
            TXT_2.TabIndex = 4;
            TXT_2.TextChanged += TXT_2_TextChanged;
            // 
            // TXT_3
            // 
            TXT_3.Location = new Point(370, 187);
            TXT_3.Name = "TXT_3";
            TXT_3.Size = new Size(235, 27);
            TXT_3.TabIndex = 5;
            TXT_3.TextChanged += TXT_3_TextChanged;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TXT_3);
            Controls.Add(TXT_2);
            Controls.Add(TXT_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TXT_1;
        private TextBox TXT_2;
        private TextBox TXT_3;
    }
}