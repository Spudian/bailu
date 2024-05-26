namespace MI_AN_LIEN_LIN_Q
{
    partial class frm_Quan_Ly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quan_Ly));
            this.tmr_Hien_Dan_Quan_Ly_Cua_Hang = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tmr_An_Dan_Quan_Ly_Cua_Hang = new System.Windows.Forms.Timer(this.components);
            this.tmr_Control = new System.Windows.Forms.Timer(this.components);
            this.menu_Control = new System.Windows.Forms.PictureBox();
            this.btn_Quan_Ly_Nhan_Vien = new System.Windows.Forms.Button();
            this.btn_Dang_Xuat = new System.Windows.Forms.Button();
            this.btn_Thong_Ke_Phieu_Xuat = new System.Windows.Forms.Button();
            this.btn_Thong_Ke_Phieu_Nhap = new System.Windows.Forms.Button();
            this.btn_Thong_Ke_Hoa_Don = new System.Windows.Forms.Button();
            this.btn_Nha_San_Xuat = new System.Windows.Forms.Button();
            this.btn_Nha_Cung_Cap = new System.Windows.Forms.Button();
            this.btn_San_Pham = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btn_Quan_Ly_Tai_Khoan = new System.Windows.Forms.Button();
            this.btn_Quan_Ly_Khach_Hang = new System.Windows.Forms.Button();
            this.btn_Quay_lai = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.tmr_Close = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menu_Control)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Left.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_Hien_Dan_Quan_Ly_Cua_Hang
            // 
            this.tmr_Hien_Dan_Quan_Ly_Cua_Hang.Tick += new System.EventHandler(this.tmr_Hien_Dan_Quan_Ly_Cua_Hang_Tick_1);
            // 
            // tmr_Control
            // 
            this.tmr_Control.Interval = 5;
            this.tmr_Control.Tick += new System.EventHandler(this.tmr_Control_Tick);
            // 
            // menu_Control
            // 
            this.menu_Control.BackColor = System.Drawing.SystemColors.Control;
            this.menu_Control.Location = new System.Drawing.Point(5, 35);
            this.menu_Control.Name = "menu_Control";
            this.menu_Control.Size = new System.Drawing.Size(65, 50);
            this.menu_Control.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_Control.TabIndex = 0;
            this.menu_Control.TabStop = false;
            this.menu_Control.Click += new System.EventHandler(this.menu_Control_Click_1);
            // 
            // btn_Quan_Ly_Nhan_Vien
            // 
            this.btn_Quan_Ly_Nhan_Vien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Quan_Ly_Nhan_Vien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quan_Ly_Nhan_Vien.Location = new System.Drawing.Point(0, 427);
            this.btn_Quan_Ly_Nhan_Vien.Name = "btn_Quan_Ly_Nhan_Vien";
            this.btn_Quan_Ly_Nhan_Vien.Size = new System.Drawing.Size(80, 50);
            this.btn_Quan_Ly_Nhan_Vien.TabIndex = 9;
            this.btn_Quan_Ly_Nhan_Vien.Text = "Quản Lý Nhân Viên";
            this.btn_Quan_Ly_Nhan_Vien.UseVisualStyleBackColor = true;
            this.btn_Quan_Ly_Nhan_Vien.Click += new System.EventHandler(this.btn_Quan_Ly_Nhan_Vien_Click);
            // 
            // btn_Dang_Xuat
            // 
            this.btn_Dang_Xuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Dang_Xuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dang_Xuat.Location = new System.Drawing.Point(0, 783);
            this.btn_Dang_Xuat.Name = "btn_Dang_Xuat";
            this.btn_Dang_Xuat.Size = new System.Drawing.Size(80, 50);
            this.btn_Dang_Xuat.TabIndex = 8;
            this.btn_Dang_Xuat.Text = "Đăng Xuất";
            this.btn_Dang_Xuat.UseVisualStyleBackColor = true;
            this.btn_Dang_Xuat.Click += new System.EventHandler(this.btn_Dang_Xuat_Click);
            // 
            // btn_Thong_Ke_Phieu_Xuat
            // 
            this.btn_Thong_Ke_Phieu_Xuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thong_Ke_Phieu_Xuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thong_Ke_Phieu_Xuat.Location = new System.Drawing.Point(0, 377);
            this.btn_Thong_Ke_Phieu_Xuat.Name = "btn_Thong_Ke_Phieu_Xuat";
            this.btn_Thong_Ke_Phieu_Xuat.Size = new System.Drawing.Size(80, 50);
            this.btn_Thong_Ke_Phieu_Xuat.TabIndex = 7;
            this.btn_Thong_Ke_Phieu_Xuat.Text = "Thống Kê Phiếu Xuất";
            this.btn_Thong_Ke_Phieu_Xuat.UseVisualStyleBackColor = true;
            this.btn_Thong_Ke_Phieu_Xuat.Click += new System.EventHandler(this.btn_Thong_Ke_Phieu_Xuat_Click);
            // 
            // btn_Thong_Ke_Phieu_Nhap
            // 
            this.btn_Thong_Ke_Phieu_Nhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thong_Ke_Phieu_Nhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thong_Ke_Phieu_Nhap.Location = new System.Drawing.Point(0, 327);
            this.btn_Thong_Ke_Phieu_Nhap.Name = "btn_Thong_Ke_Phieu_Nhap";
            this.btn_Thong_Ke_Phieu_Nhap.Size = new System.Drawing.Size(80, 50);
            this.btn_Thong_Ke_Phieu_Nhap.TabIndex = 6;
            this.btn_Thong_Ke_Phieu_Nhap.Text = "Thống Kê Phiếu Nhập";
            this.btn_Thong_Ke_Phieu_Nhap.UseVisualStyleBackColor = true;
            this.btn_Thong_Ke_Phieu_Nhap.Click += new System.EventHandler(this.btn_Thong_Ke_Phieu_Nhap_Click);
            // 
            // btn_Thong_Ke_Hoa_Don
            // 
            this.btn_Thong_Ke_Hoa_Don.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thong_Ke_Hoa_Don.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thong_Ke_Hoa_Don.Location = new System.Drawing.Point(0, 277);
            this.btn_Thong_Ke_Hoa_Don.Name = "btn_Thong_Ke_Hoa_Don";
            this.btn_Thong_Ke_Hoa_Don.Size = new System.Drawing.Size(80, 50);
            this.btn_Thong_Ke_Hoa_Don.TabIndex = 5;
            this.btn_Thong_Ke_Hoa_Don.Text = "Thống Kê Hóa Đơn";
            this.btn_Thong_Ke_Hoa_Don.UseVisualStyleBackColor = true;
            this.btn_Thong_Ke_Hoa_Don.Click += new System.EventHandler(this.btn_Thong_Ke_Hoa_Don_Click);
            // 
            // btn_Nha_San_Xuat
            // 
            this.btn_Nha_San_Xuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Nha_San_Xuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nha_San_Xuat.Location = new System.Drawing.Point(0, 227);
            this.btn_Nha_San_Xuat.Name = "btn_Nha_San_Xuat";
            this.btn_Nha_San_Xuat.Size = new System.Drawing.Size(80, 50);
            this.btn_Nha_San_Xuat.TabIndex = 4;
            this.btn_Nha_San_Xuat.Text = "Quản Lý Nhà Sản Xuất";
            this.btn_Nha_San_Xuat.UseVisualStyleBackColor = true;
            this.btn_Nha_San_Xuat.Click += new System.EventHandler(this.btn_Nha_San_Xuat_Click);
            // 
            // btn_Nha_Cung_Cap
            // 
            this.btn_Nha_Cung_Cap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Nha_Cung_Cap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nha_Cung_Cap.Location = new System.Drawing.Point(0, 177);
            this.btn_Nha_Cung_Cap.Name = "btn_Nha_Cung_Cap";
            this.btn_Nha_Cung_Cap.Size = new System.Drawing.Size(80, 50);
            this.btn_Nha_Cung_Cap.TabIndex = 3;
            this.btn_Nha_Cung_Cap.Text = "Quản Lý Nhà Cung Cấp";
            this.btn_Nha_Cung_Cap.UseVisualStyleBackColor = true;
            this.btn_Nha_Cung_Cap.Click += new System.EventHandler(this.btn_Nha_Cung_Cap_Click);
            // 
            // btn_San_Pham
            // 
            this.btn_San_Pham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_San_Pham.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_San_Pham.Location = new System.Drawing.Point(0, 127);
            this.btn_San_Pham.Name = "btn_San_Pham";
            this.btn_San_Pham.Size = new System.Drawing.Size(80, 50);
            this.btn_San_Pham.TabIndex = 2;
            this.btn_San_Pham.Text = "Quản Lý Sản Phẩm";
            this.btn_San_Pham.UseVisualStyleBackColor = true;
            this.btn_San_Pham.Click += new System.EventHandler(this.btn_San_Pham_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menu_Control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 127);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Left.Controls.Add(this.btn_Quan_Ly_Tai_Khoan);
            this.panel_Left.Controls.Add(this.btn_Quan_Ly_Khach_Hang);
            this.panel_Left.Controls.Add(this.btn_Quay_lai);
            this.panel_Left.Controls.Add(this.btn_Quan_Ly_Nhan_Vien);
            this.panel_Left.Controls.Add(this.btn_Dang_Xuat);
            this.panel_Left.Controls.Add(this.btn_Thong_Ke_Phieu_Xuat);
            this.panel_Left.Controls.Add(this.btn_Thong_Ke_Phieu_Nhap);
            this.panel_Left.Controls.Add(this.btn_Thong_Ke_Hoa_Don);
            this.panel_Left.Controls.Add(this.btn_Nha_San_Xuat);
            this.panel_Left.Controls.Add(this.btn_Nha_Cung_Cap);
            this.panel_Left.Controls.Add(this.btn_San_Pham);
            this.panel_Left.Controls.Add(this.panel1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.MaximumSize = new System.Drawing.Size(220, 853);
            this.panel_Left.MinimumSize = new System.Drawing.Size(80, 653);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(80, 833);
            this.panel_Left.TabIndex = 1;
            // 
            // btn_Quan_Ly_Tai_Khoan
            // 
            this.btn_Quan_Ly_Tai_Khoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Quan_Ly_Tai_Khoan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quan_Ly_Tai_Khoan.Location = new System.Drawing.Point(0, 527);
            this.btn_Quan_Ly_Tai_Khoan.Name = "btn_Quan_Ly_Tai_Khoan";
            this.btn_Quan_Ly_Tai_Khoan.Size = new System.Drawing.Size(80, 50);
            this.btn_Quan_Ly_Tai_Khoan.TabIndex = 13;
            this.btn_Quan_Ly_Tai_Khoan.Text = "Quản Lý Tài Khoản";
            this.btn_Quan_Ly_Tai_Khoan.UseVisualStyleBackColor = true;
            this.btn_Quan_Ly_Tai_Khoan.Click += new System.EventHandler(this.btn_Quan_Ly_Tai_Khoan_Click_1);
            // 
            // btn_Quan_Ly_Khach_Hang
            // 
            this.btn_Quan_Ly_Khach_Hang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Quan_Ly_Khach_Hang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quan_Ly_Khach_Hang.Location = new System.Drawing.Point(0, 477);
            this.btn_Quan_Ly_Khach_Hang.Name = "btn_Quan_Ly_Khach_Hang";
            this.btn_Quan_Ly_Khach_Hang.Size = new System.Drawing.Size(80, 50);
            this.btn_Quan_Ly_Khach_Hang.TabIndex = 12;
            this.btn_Quan_Ly_Khach_Hang.Text = "Quản Lý Khách Hàng";
            this.btn_Quan_Ly_Khach_Hang.UseVisualStyleBackColor = true;
            this.btn_Quan_Ly_Khach_Hang.Click += new System.EventHandler(this.btn_Khach_Hang_Click_1);
            // 
            // btn_Quay_lai
            // 
            this.btn_Quay_lai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Quay_lai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quay_lai.Location = new System.Drawing.Point(0, 733);
            this.btn_Quay_lai.Name = "btn_Quay_lai";
            this.btn_Quay_lai.Size = new System.Drawing.Size(80, 50);
            this.btn_Quay_lai.TabIndex = 11;
            this.btn_Quay_lai.Text = "Quay Lại Trang Chủ";
            this.btn_Quay_lai.UseVisualStyleBackColor = true;
            this.btn_Quay_lai.Click += new System.EventHandler(this.btn_Quay_lai_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(80, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1272, 50);
            this.panel_Top.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team-Two";
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Body.BackgroundImage")));
            this.panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(80, 50);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1272, 783);
            this.panel_Body.TabIndex = 3;
            // 
            // tmr_Close
            // 
            this.tmr_Close.Interval = 5;
            this.tmr_Close.Tick += new System.EventHandler(this.tmr_Close_Tick);
            // 
            // frm_Quan_Ly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 833);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "frm_Quan_Ly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.menu_Control)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Left.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_Hien_Dan_Quan_Ly_Cua_Hang;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer tmr_An_Dan_Quan_Ly_Cua_Hang;
        private System.Windows.Forms.Timer tmr_Control;
        private System.Windows.Forms.PictureBox menu_Control;
        private System.Windows.Forms.Button btn_Quan_Ly_Nhan_Vien;
        private System.Windows.Forms.Button btn_Dang_Xuat;
        private System.Windows.Forms.Button btn_Thong_Ke_Phieu_Xuat;
        private System.Windows.Forms.Button btn_Thong_Ke_Phieu_Nhap;
        private System.Windows.Forms.Button btn_Thong_Ke_Hoa_Don;
        private System.Windows.Forms.Button btn_Nha_San_Xuat;
        private System.Windows.Forms.Button btn_Nha_Cung_Cap;
        private System.Windows.Forms.Button btn_San_Pham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Quay_lai;
        private System.Windows.Forms.Timer tmr_Close;
        private System.Windows.Forms.Button btn_Quan_Ly_Khach_Hang;
        private System.Windows.Forms.Button btn_Quan_Ly_Tai_Khoan;
    }
}