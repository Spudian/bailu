namespace MI_AN_LIEN_LIN_Q
{
    partial class frm_Quen_Mat_Khau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quen_Mat_Khau));
            this.txt_Gmail = new System.Windows.Forms.TextBox();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_Gmail = new System.Windows.Forms.Button();
            this.lbl_Nhap_Lai_Mat_Khau = new System.Windows.Forms.Label();
            this.lbl_Nhap_Mat_Khau = new System.Windows.Forms.Label();
            this.lbl_OTP = new System.Windows.Forms.Label();
            this.lbl_Gmail = new System.Windows.Forms.Label();
            this.lbl_Tieu_De = new System.Windows.Forms.Label();
            this.pic_Icon1 = new System.Windows.Forms.PictureBox();
            this.txt_Nhap_Lai_Mat_Khau = new System.Windows.Forms.TextBox();
            this.txt_Mat_Khau_Moi = new System.Windows.Forms.TextBox();
            this.txt_OTP = new System.Windows.Forms.TextBox();
            this.timevcode = new System.Windows.Forms.Timer(this.components);
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.Location = new System.Drawing.Point(22, 195);
            this.txt_Gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Gmail.Multiline = true;
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.Size = new System.Drawing.Size(285, 35);
            this.txt_Gmail.TabIndex = 2;
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Brown;
            this.pnl_1.Controls.Add(this.btn_Nhap);
            this.pnl_1.Controls.Add(this.btn_Gmail);
            this.pnl_1.Controls.Add(this.lbl_Nhap_Lai_Mat_Khau);
            this.pnl_1.Controls.Add(this.lbl_Nhap_Mat_Khau);
            this.pnl_1.Controls.Add(this.lbl_OTP);
            this.pnl_1.Controls.Add(this.lbl_Gmail);
            this.pnl_1.Controls.Add(this.lbl_Tieu_De);
            this.pnl_1.Controls.Add(this.pic_Icon1);
            this.pnl_1.Controls.Add(this.txt_Nhap_Lai_Mat_Khau);
            this.pnl_1.Controls.Add(this.txt_Mat_Khau_Moi);
            this.pnl_1.Controls.Add(this.txt_OTP);
            this.pnl_1.Controls.Add(this.txt_Gmail);
            this.pnl_1.Location = new System.Drawing.Point(176, 86);
            this.pnl_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(425, 574);
            this.pnl_1.TabIndex = 6;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(162, 525);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(109, 35);
            this.btn_Nhap.TabIndex = 8;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_Gmail
            // 
            this.btn_Gmail.Location = new System.Drawing.Point(326, 195);
            this.btn_Gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Gmail.Name = "btn_Gmail";
            this.btn_Gmail.Size = new System.Drawing.Size(75, 35);
            this.btn_Gmail.TabIndex = 7;
            this.btn_Gmail.Text = "Gửi";
            this.btn_Gmail.UseVisualStyleBackColor = true;
            this.btn_Gmail.Click += new System.EventHandler(this.btn_Gmail_Click_1);
            // 
            // lbl_Nhap_Lai_Mat_Khau
            // 
            this.lbl_Nhap_Lai_Mat_Khau.AutoSize = true;
            this.lbl_Nhap_Lai_Mat_Khau.Location = new System.Drawing.Point(19, 442);
            this.lbl_Nhap_Lai_Mat_Khau.Name = "lbl_Nhap_Lai_Mat_Khau";
            this.lbl_Nhap_Lai_Mat_Khau.Size = new System.Drawing.Size(140, 20);
            this.lbl_Nhap_Lai_Mat_Khau.TabIndex = 6;
            this.lbl_Nhap_Lai_Mat_Khau.Text = "Nhập lại mật khẩu:";
            // 
            // lbl_Nhap_Mat_Khau
            // 
            this.lbl_Nhap_Mat_Khau.AutoSize = true;
            this.lbl_Nhap_Mat_Khau.Location = new System.Drawing.Point(19, 354);
            this.lbl_Nhap_Mat_Khau.Name = "lbl_Nhap_Mat_Khau";
            this.lbl_Nhap_Mat_Khau.Size = new System.Drawing.Size(150, 20);
            this.lbl_Nhap_Mat_Khau.TabIndex = 6;
            this.lbl_Nhap_Mat_Khau.Text = "Nhập mật khẩu mới:";
            // 
            // lbl_OTP
            // 
            this.lbl_OTP.AutoSize = true;
            this.lbl_OTP.Location = new System.Drawing.Point(19, 264);
            this.lbl_OTP.Name = "lbl_OTP";
            this.lbl_OTP.Size = new System.Drawing.Size(179, 20);
            this.lbl_OTP.TabIndex = 6;
            this.lbl_OTP.Text = "Nhập mã OTP đã gửi về:";
            // 
            // lbl_Gmail
            // 
            this.lbl_Gmail.AutoSize = true;
            this.lbl_Gmail.Location = new System.Drawing.Point(19, 160);
            this.lbl_Gmail.Name = "lbl_Gmail";
            this.lbl_Gmail.Size = new System.Drawing.Size(92, 20);
            this.lbl_Gmail.TabIndex = 5;
            this.lbl_Gmail.Text = "Nhập gmail:";
            // 
            // lbl_Tieu_De
            // 
            this.lbl_Tieu_De.AutoSize = true;
            this.lbl_Tieu_De.BackColor = System.Drawing.Color.Brown;
            this.lbl_Tieu_De.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tieu_De.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Tieu_De.Location = new System.Drawing.Point(158, 54);
            this.lbl_Tieu_De.Name = "lbl_Tieu_De";
            this.lbl_Tieu_De.Size = new System.Drawing.Size(206, 29);
            this.lbl_Tieu_De.TabIndex = 4;
            this.lbl_Tieu_De.Text = " Lấy lại mật khẩu";
            // 
            // pic_Icon1
            // 
            this.pic_Icon1.Image = ((System.Drawing.Image)(resources.GetObject("pic_Icon1.Image")));
            this.pic_Icon1.Location = new System.Drawing.Point(52, 31);
            this.pic_Icon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Icon1.Name = "pic_Icon1";
            this.pic_Icon1.Size = new System.Drawing.Size(108, 65);
            this.pic_Icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Icon1.TabIndex = 3;
            this.pic_Icon1.TabStop = false;
            // 
            // txt_Nhap_Lai_Mat_Khau
            // 
            this.txt_Nhap_Lai_Mat_Khau.Location = new System.Drawing.Point(22, 475);
            this.txt_Nhap_Lai_Mat_Khau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nhap_Lai_Mat_Khau.Multiline = true;
            this.txt_Nhap_Lai_Mat_Khau.Name = "txt_Nhap_Lai_Mat_Khau";
            this.txt_Nhap_Lai_Mat_Khau.PasswordChar = '♔';
            this.txt_Nhap_Lai_Mat_Khau.Size = new System.Drawing.Size(285, 32);
            this.txt_Nhap_Lai_Mat_Khau.TabIndex = 2;
            // 
            // txt_Mat_Khau_Moi
            // 
            this.txt_Mat_Khau_Moi.Location = new System.Drawing.Point(22, 386);
            this.txt_Mat_Khau_Moi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Mat_Khau_Moi.Multiline = true;
            this.txt_Mat_Khau_Moi.Name = "txt_Mat_Khau_Moi";
            this.txt_Mat_Khau_Moi.PasswordChar = '♔';
            this.txt_Mat_Khau_Moi.Size = new System.Drawing.Size(285, 32);
            this.txt_Mat_Khau_Moi.TabIndex = 2;
            // 
            // txt_OTP
            // 
            this.txt_OTP.Location = new System.Drawing.Point(22, 296);
            this.txt_OTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OTP.Multiline = true;
            this.txt_OTP.Name = "txt_OTP";
            this.txt_OTP.Size = new System.Drawing.Size(285, 32);
            this.txt_OTP.TabIndex = 2;
            // 
            // timevcode
            // 
            this.timevcode.Enabled = true;
            this.timevcode.Interval = 1000;
            // 
            // frm_Quen_Mat_Khau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.pnl_1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Quen_Mat_Khau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Gmail;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_Gmail;
        private System.Windows.Forms.Label lbl_Nhap_Lai_Mat_Khau;
        private System.Windows.Forms.Label lbl_Nhap_Mat_Khau;
        private System.Windows.Forms.Label lbl_OTP;
        private System.Windows.Forms.Label lbl_Gmail;
        private System.Windows.Forms.Label lbl_Tieu_De;
        private System.Windows.Forms.PictureBox pic_Icon1;
        private System.Windows.Forms.TextBox txt_Nhap_Lai_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Mat_Khau_Moi;
        private System.Windows.Forms.TextBox txt_OTP;
        private System.Windows.Forms.Timer timevcode;
    }
}