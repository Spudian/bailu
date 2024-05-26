namespace MI_AN_LIEN_LIN_Q
{
    partial class frm_Tao_Tai_Khoan_Khach_Hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tao_Tai_Khoan_Khach_Hang));
            this.cbb_Gioi_Tinh = new System.Windows.Forms.ComboBox();
            this.btn_OTP = new System.Windows.Forms.Button();
            this.dtp_Ngay_Sinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_Ten_KH = new System.Windows.Forms.Label();
            this.lbl_OTP = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Gioi_Tinh = new System.Windows.Forms.Label();
            this.lbl_Ngay_Sinh = new System.Windows.Forms.Label();
            this.lbl_Dia_Chi = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_Ten_KH = new System.Windows.Forms.TextBox();
            this.txt_OTP = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Dia_Chi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_Dang_Ky = new System.Windows.Forms.Button();
            this.lbl_Mat_Khau = new System.Windows.Forms.Label();
            this.lbl_Tai_Khoan = new System.Windows.Forms.Label();
            this.txt_Mat_Khau = new System.Windows.Forms.TextBox();
            this.txt_Tai_Khoan = new System.Windows.Forms.TextBox();
            this.lbl_Dang_Ky = new System.Windows.Forms.Label();
            this.pic_Icon5 = new System.Windows.Forms.PictureBox();
            this.timevcode = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon5)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_Gioi_Tinh
            // 
            this.cbb_Gioi_Tinh.FormattingEnabled = true;
            this.cbb_Gioi_Tinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_Gioi_Tinh.Location = new System.Drawing.Point(176, 667);
            this.cbb_Gioi_Tinh.Name = "cbb_Gioi_Tinh";
            this.cbb_Gioi_Tinh.Size = new System.Drawing.Size(114, 28);
            this.cbb_Gioi_Tinh.TabIndex = 16;
            // 
            // btn_OTP
            // 
            this.btn_OTP.Location = new System.Drawing.Point(422, 738);
            this.btn_OTP.Name = "btn_OTP";
            this.btn_OTP.Size = new System.Drawing.Size(104, 37);
            this.btn_OTP.TabIndex = 15;
            this.btn_OTP.Text = "Gửi mã OTP";
            this.btn_OTP.UseVisualStyleBackColor = true;
            this.btn_OTP.Click += new System.EventHandler(this.btn_OTP_Click);
            // 
            // dtp_Ngay_Sinh
            // 
            this.dtp_Ngay_Sinh.Location = new System.Drawing.Point(176, 595);
            this.dtp_Ngay_Sinh.Name = "dtp_Ngay_Sinh";
            this.dtp_Ngay_Sinh.Size = new System.Drawing.Size(240, 26);
            this.dtp_Ngay_Sinh.TabIndex = 14;
            // 
            // lbl_Ten_KH
            // 
            this.lbl_Ten_KH.AutoSize = true;
            this.lbl_Ten_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_KH.Location = new System.Drawing.Point(-4, 319);
            this.lbl_Ten_KH.Name = "lbl_Ten_KH";
            this.lbl_Ten_KH.Size = new System.Drawing.Size(160, 22);
            this.lbl_Ten_KH.TabIndex = 11;
            this.lbl_Ten_KH.Text = "Tên khách hàng:";
            // 
            // lbl_OTP
            // 
            this.lbl_OTP.AutoSize = true;
            this.lbl_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OTP.Location = new System.Drawing.Point(66, 830);
            this.lbl_OTP.Name = "lbl_OTP";
            this.lbl_OTP.Size = new System.Drawing.Size(89, 22);
            this.lbl_OTP.TabIndex = 12;
            this.lbl_OTP.Text = "Mã OTP:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(90, 753);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(65, 22);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Gioi_Tinh
            // 
            this.lbl_Gioi_Tinh.AutoSize = true;
            this.lbl_Gioi_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gioi_Tinh.Location = new System.Drawing.Point(64, 674);
            this.lbl_Gioi_Tinh.Name = "lbl_Gioi_Tinh";
            this.lbl_Gioi_Tinh.Size = new System.Drawing.Size(91, 22);
            this.lbl_Gioi_Tinh.TabIndex = 12;
            this.lbl_Gioi_Tinh.Text = "Giới tính:";
            // 
            // lbl_Ngay_Sinh
            // 
            this.lbl_Ngay_Sinh.AutoSize = true;
            this.lbl_Ngay_Sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay_Sinh.Location = new System.Drawing.Point(52, 598);
            this.lbl_Ngay_Sinh.Name = "lbl_Ngay_Sinh";
            this.lbl_Ngay_Sinh.Size = new System.Drawing.Size(105, 22);
            this.lbl_Ngay_Sinh.TabIndex = 12;
            this.lbl_Ngay_Sinh.Text = "Ngày sinh:";
            // 
            // lbl_Dia_Chi
            // 
            this.lbl_Dia_Chi.AutoSize = true;
            this.lbl_Dia_Chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dia_Chi.Location = new System.Drawing.Point(77, 526);
            this.lbl_Dia_Chi.Name = "lbl_Dia_Chi";
            this.lbl_Dia_Chi.Size = new System.Drawing.Size(78, 22);
            this.lbl_Dia_Chi.TabIndex = 12;
            this.lbl_Dia_Chi.Text = "Địa chỉ:";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CCCD.Location = new System.Drawing.Point(83, 454);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(72, 22);
            this.lbl_CCCD.TabIndex = 12;
            this.lbl_CCCD.Text = "CCCD:";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(22, 382);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(134, 22);
            this.lbl_SDT.TabIndex = 13;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // txt_Ten_KH
            // 
            this.txt_Ten_KH.Location = new System.Drawing.Point(176, 304);
            this.txt_Ten_KH.Multiline = true;
            this.txt_Ten_KH.Name = "txt_Ten_KH";
            this.txt_Ten_KH.Size = new System.Drawing.Size(240, 37);
            this.txt_Ten_KH.TabIndex = 8;
            // 
            // txt_OTP
            // 
            this.txt_OTP.Location = new System.Drawing.Point(176, 815);
            this.txt_OTP.Multiline = true;
            this.txt_OTP.Name = "txt_OTP";
            this.txt_OTP.Size = new System.Drawing.Size(240, 37);
            this.txt_OTP.TabIndex = 9;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(176, 738);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(240, 37);
            this.txt_Email.TabIndex = 9;
            // 
            // txt_Dia_Chi
            // 
            this.txt_Dia_Chi.Location = new System.Drawing.Point(176, 511);
            this.txt_Dia_Chi.Multiline = true;
            this.txt_Dia_Chi.Name = "txt_Dia_Chi";
            this.txt_Dia_Chi.Size = new System.Drawing.Size(240, 37);
            this.txt_Dia_Chi.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.cbb_Gioi_Tinh);
            this.panel1.Controls.Add(this.btn_OTP);
            this.panel1.Controls.Add(this.dtp_Ngay_Sinh);
            this.panel1.Controls.Add(this.lbl_Ten_KH);
            this.panel1.Controls.Add(this.lbl_OTP);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.lbl_Gioi_Tinh);
            this.panel1.Controls.Add(this.lbl_Ngay_Sinh);
            this.panel1.Controls.Add(this.lbl_Dia_Chi);
            this.panel1.Controls.Add(this.lbl_CCCD);
            this.panel1.Controls.Add(this.lbl_SDT);
            this.panel1.Controls.Add(this.txt_Ten_KH);
            this.panel1.Controls.Add(this.txt_OTP);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_Dia_Chi);
            this.panel1.Controls.Add(this.txt_CCCD);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.btn_Dang_Ky);
            this.panel1.Controls.Add(this.lbl_Mat_Khau);
            this.panel1.Controls.Add(this.lbl_Tai_Khoan);
            this.panel1.Controls.Add(this.txt_Mat_Khau);
            this.panel1.Controls.Add(this.txt_Tai_Khoan);
            this.panel1.Controls.Add(this.lbl_Dang_Ky);
            this.panel1.Controls.Add(this.pic_Icon5);
            this.panel1.Location = new System.Drawing.Point(253, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 951);
            this.panel1.TabIndex = 7;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(176, 439);
            this.txt_CCCD.Multiline = true;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(240, 37);
            this.txt_CCCD.TabIndex = 9;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(176, 367);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(240, 37);
            this.txt_SDT.TabIndex = 10;
            // 
            // btn_Dang_Ky
            // 
            this.btn_Dang_Ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dang_Ky.Location = new System.Drawing.Point(210, 888);
            this.btn_Dang_Ky.Name = "btn_Dang_Ky";
            this.btn_Dang_Ky.Size = new System.Drawing.Size(132, 40);
            this.btn_Dang_Ky.TabIndex = 7;
            this.btn_Dang_Ky.Text = "Đăng ký";
            this.btn_Dang_Ky.UseVisualStyleBackColor = true;
            this.btn_Dang_Ky.Click += new System.EventHandler(this.btn_Dang_Ky_Click);
            // 
            // lbl_Mat_Khau
            // 
            this.lbl_Mat_Khau.AutoSize = true;
            this.lbl_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Khau.Location = new System.Drawing.Point(58, 248);
            this.lbl_Mat_Khau.Name = "lbl_Mat_Khau";
            this.lbl_Mat_Khau.Size = new System.Drawing.Size(97, 22);
            this.lbl_Mat_Khau.TabIndex = 6;
            this.lbl_Mat_Khau.Text = "Mật khẩu:";
            // 
            // lbl_Tai_Khoan
            // 
            this.lbl_Tai_Khoan.AutoSize = true;
            this.lbl_Tai_Khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tai_Khoan.Location = new System.Drawing.Point(50, 176);
            this.lbl_Tai_Khoan.Name = "lbl_Tai_Khoan";
            this.lbl_Tai_Khoan.Size = new System.Drawing.Size(105, 22);
            this.lbl_Tai_Khoan.TabIndex = 6;
            this.lbl_Tai_Khoan.Text = "Tài khoản:";
            // 
            // txt_Mat_Khau
            // 
            this.txt_Mat_Khau.Location = new System.Drawing.Point(176, 233);
            this.txt_Mat_Khau.Multiline = true;
            this.txt_Mat_Khau.Name = "txt_Mat_Khau";
            this.txt_Mat_Khau.PasswordChar = '♔';
            this.txt_Mat_Khau.Size = new System.Drawing.Size(240, 37);
            this.txt_Mat_Khau.TabIndex = 5;
            // 
            // txt_Tai_Khoan
            // 
            this.txt_Tai_Khoan.Location = new System.Drawing.Point(176, 161);
            this.txt_Tai_Khoan.Multiline = true;
            this.txt_Tai_Khoan.Name = "txt_Tai_Khoan";
            this.txt_Tai_Khoan.Size = new System.Drawing.Size(240, 37);
            this.txt_Tai_Khoan.TabIndex = 5;
            // 
            // lbl_Dang_Ky
            // 
            this.lbl_Dang_Ky.AutoSize = true;
            this.lbl_Dang_Ky.BackColor = System.Drawing.Color.Brown;
            this.lbl_Dang_Ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dang_Ky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Dang_Ky.Location = new System.Drawing.Point(150, 50);
            this.lbl_Dang_Ky.Name = "lbl_Dang_Ky";
            this.lbl_Dang_Ky.Size = new System.Drawing.Size(218, 29);
            this.lbl_Dang_Ky.TabIndex = 4;
            this.lbl_Dang_Ky.Text = "Đăng ký tài khoản";
            // 
            // pic_Icon5
            // 
            this.pic_Icon5.Image = ((System.Drawing.Image)(resources.GetObject("pic_Icon5.Image")));
            this.pic_Icon5.Location = new System.Drawing.Point(49, 30);
            this.pic_Icon5.Name = "pic_Icon5";
            this.pic_Icon5.Size = new System.Drawing.Size(108, 65);
            this.pic_Icon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Icon5.TabIndex = 3;
            this.pic_Icon5.TabStop = false;
            // 
            // timevcode
            // 
            this.timevcode.Enabled = true;
            this.timevcode.Interval = 1000;
            // 
            // frm_Tao_Tai_Khoan_Khach_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 1050);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Tao_Tai_Khoan_Khach_Hang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản Khách Hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Gioi_Tinh;
        private System.Windows.Forms.Button btn_OTP;
        private System.Windows.Forms.DateTimePicker dtp_Ngay_Sinh;
        private System.Windows.Forms.Label lbl_Ten_KH;
        private System.Windows.Forms.Label lbl_OTP;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Gioi_Tinh;
        private System.Windows.Forms.Label lbl_Ngay_Sinh;
        private System.Windows.Forms.Label lbl_Dia_Chi;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_Ten_KH;
        private System.Windows.Forms.TextBox txt_OTP;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Dia_Chi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Button btn_Dang_Ky;
        private System.Windows.Forms.Label lbl_Mat_Khau;
        private System.Windows.Forms.Label lbl_Tai_Khoan;
        private System.Windows.Forms.TextBox txt_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Tai_Khoan;
        private System.Windows.Forms.Label lbl_Dang_Ky;
        private System.Windows.Forms.PictureBox pic_Icon5;
        private System.Windows.Forms.Timer timevcode;
    }
}