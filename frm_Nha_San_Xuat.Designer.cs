namespace MI_AN_LIEN_LIN_Q
{
    partial class frm_Nha_San_Xuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nha_San_Xuat));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Lam_Moi_Nha_SX = new System.Windows.Forms.Button();
            this.btn_Xoa_Nha_SX = new System.Windows.Forms.Button();
            this.btn_Cap_Nhat_Nha_SX = new System.Windows.Forms.Button();
            this.btn_Them_Nha_SX = new System.Windows.Forms.Button();
            this.dgv_Nha_San_Xuat = new System.Windows.Forms.DataGridView();
            this.btn_Xuat_Ra_Execl = new System.Windows.Forms.Button();
            this.lbl_Tim_Kiem_Theo = new System.Windows.Forms.Label();
            this.cbb_Tim_Kiem_Cac_Loai = new System.Windows.Forms.ComboBox();
            this.lbl_Tong_KH = new System.Windows.Forms.Label();
            this.txt_Tong_NSX = new System.Windows.Forms.TextBox();
            this.txt_Tim_Kiem_NSX = new System.Windows.Forms.TextBox();
            this.btn_Tim_Kiem = new System.Windows.Forms.Button();
            this.tmr_Hien_Dan_Xem_San_Pham = new System.Windows.Forms.Timer(this.components);
            this.tmr_An_Dan_Xem_San_Pham = new System.Windows.Forms.Timer(this.components);
            this.txt_So_Dien_Thoai = new System.Windows.Forms.TextBox();
            this.lbl_Ma_Nha_San_Xuat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Ma_NSX = new System.Windows.Forms.Label();
            this.lbl_Ten_San_Pham = new System.Windows.Forms.Label();
            this.cbb_Tinh_Trang = new System.Windows.Forms.ComboBox();
            this.txt_Dia_Chi = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Ten_Nha_San_Xuat = new System.Windows.Forms.TextBox();
            this.lbl_Trong_Luong = new System.Windows.Forms.Label();
            this.lbl_Huong_Vi = new System.Windows.Forms.Label();
            this.lbl_Thuong_Hieu = new System.Windows.Forms.Label();
            this.lbl_Tinh_Trang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nha_San_Xuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(374, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 163;
            this.label1.Text = "Chức Năng";
            // 
            // btn_Lam_Moi_Nha_SX
            // 
            this.btn_Lam_Moi_Nha_SX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Lam_Moi_Nha_SX.Location = new System.Drawing.Point(690, 601);
            this.btn_Lam_Moi_Nha_SX.Name = "btn_Lam_Moi_Nha_SX";
            this.btn_Lam_Moi_Nha_SX.Size = new System.Drawing.Size(225, 47);
            this.btn_Lam_Moi_Nha_SX.TabIndex = 162;
            this.btn_Lam_Moi_Nha_SX.Text = "Làm Mới";
            this.btn_Lam_Moi_Nha_SX.UseVisualStyleBackColor = true;
            this.btn_Lam_Moi_Nha_SX.Click += new System.EventHandler(this.btn_Lam_Moi_Nha_SX_Click);
            // 
            // btn_Xoa_Nha_SX
            // 
            this.btn_Xoa_Nha_SX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa_Nha_SX.Location = new System.Drawing.Point(690, 538);
            this.btn_Xoa_Nha_SX.Name = "btn_Xoa_Nha_SX";
            this.btn_Xoa_Nha_SX.Size = new System.Drawing.Size(225, 47);
            this.btn_Xoa_Nha_SX.TabIndex = 161;
            this.btn_Xoa_Nha_SX.Text = "Xóa";
            this.btn_Xoa_Nha_SX.UseVisualStyleBackColor = true;
            this.btn_Xoa_Nha_SX.Click += new System.EventHandler(this.btn_Xoa_Nha_SX_Click);
            // 
            // btn_Cap_Nhat_Nha_SX
            // 
            this.btn_Cap_Nhat_Nha_SX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Cap_Nhat_Nha_SX.Location = new System.Drawing.Point(377, 601);
            this.btn_Cap_Nhat_Nha_SX.Name = "btn_Cap_Nhat_Nha_SX";
            this.btn_Cap_Nhat_Nha_SX.Size = new System.Drawing.Size(225, 47);
            this.btn_Cap_Nhat_Nha_SX.TabIndex = 160;
            this.btn_Cap_Nhat_Nha_SX.Text = "Cập Nhật";
            this.btn_Cap_Nhat_Nha_SX.UseVisualStyleBackColor = true;
            this.btn_Cap_Nhat_Nha_SX.Click += new System.EventHandler(this.btn_Cap_Nhat_Nha_SX_Click);
            // 
            // btn_Them_Nha_SX
            // 
            this.btn_Them_Nha_SX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them_Nha_SX.Location = new System.Drawing.Point(377, 538);
            this.btn_Them_Nha_SX.Name = "btn_Them_Nha_SX";
            this.btn_Them_Nha_SX.Size = new System.Drawing.Size(225, 47);
            this.btn_Them_Nha_SX.TabIndex = 159;
            this.btn_Them_Nha_SX.Text = "Thêm";
            this.btn_Them_Nha_SX.UseVisualStyleBackColor = true;
            this.btn_Them_Nha_SX.Click += new System.EventHandler(this.btn_Them_Nha_SX_Click);
            // 
            // dgv_Nha_San_Xuat
            // 
            this.dgv_Nha_San_Xuat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Nha_San_Xuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Nha_San_Xuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nha_San_Xuat.GridColor = System.Drawing.Color.Black;
            this.dgv_Nha_San_Xuat.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgv_Nha_San_Xuat.Location = new System.Drawing.Point(27, 163);
            this.dgv_Nha_San_Xuat.Name = "dgv_Nha_San_Xuat";
            this.dgv_Nha_San_Xuat.ReadOnly = true;
            this.dgv_Nha_San_Xuat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Nha_San_Xuat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Nha_San_Xuat.RowHeadersWidth = 51;
            this.dgv_Nha_San_Xuat.RowTemplate.Height = 24;
            this.dgv_Nha_San_Xuat.Size = new System.Drawing.Size(1039, 229);
            this.dgv_Nha_San_Xuat.TabIndex = 153;
            this.dgv_Nha_San_Xuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Nha_San_Xuat_CellClick);
            // 
            // btn_Xuat_Ra_Execl
            // 
            this.btn_Xuat_Ra_Execl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xuat_Ra_Execl.Location = new System.Drawing.Point(24, 601);
            this.btn_Xuat_Ra_Execl.Name = "btn_Xuat_Ra_Execl";
            this.btn_Xuat_Ra_Execl.Size = new System.Drawing.Size(225, 47);
            this.btn_Xuat_Ra_Execl.TabIndex = 151;
            this.btn_Xuat_Ra_Execl.Text = "Xuất Ra Excel";
            this.btn_Xuat_Ra_Execl.UseVisualStyleBackColor = true;
            this.btn_Xuat_Ra_Execl.Click += new System.EventHandler(this.btn_Xuat_Ra_Execl_Click);
            // 
            // lbl_Tim_Kiem_Theo
            // 
            this.lbl_Tim_Kiem_Theo.AutoSize = true;
            this.lbl_Tim_Kiem_Theo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Tim_Kiem_Theo.Location = new System.Drawing.Point(24, 409);
            this.lbl_Tim_Kiem_Theo.Name = "lbl_Tim_Kiem_Theo";
            this.lbl_Tim_Kiem_Theo.Size = new System.Drawing.Size(104, 16);
            this.lbl_Tim_Kiem_Theo.TabIndex = 150;
            this.lbl_Tim_Kiem_Theo.Text = "Tìm Kiếm Theo";
            // 
            // cbb_Tim_Kiem_Cac_Loai
            // 
            this.cbb_Tim_Kiem_Cac_Loai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_Tim_Kiem_Cac_Loai.FormattingEnabled = true;
            this.cbb_Tim_Kiem_Cac_Loai.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã Khách Hàng",
            "Tìm Kiếm Theo Tên Khách Hàng",
            "Tìm Kiếm Theo Số Điện Thoại",
            "Tìm Kiếm Theo Căn Cước Công Dân",
            "Tìm Kiếm Theo Địa Chỉ",
            "Tìm Kiếm Theo Ngày Sinh",
            "Tìm Kiếm Theo Giới Tính"});
            this.cbb_Tim_Kiem_Cac_Loai.Location = new System.Drawing.Point(24, 438);
            this.cbb_Tim_Kiem_Cac_Loai.Name = "cbb_Tim_Kiem_Cac_Loai";
            this.cbb_Tim_Kiem_Cac_Loai.Size = new System.Drawing.Size(227, 26);
            this.cbb_Tim_Kiem_Cac_Loai.TabIndex = 149;
            // 
            // lbl_Tong_KH
            // 
            this.lbl_Tong_KH.AutoSize = true;
            this.lbl_Tong_KH.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Tong_KH.Location = new System.Drawing.Point(781, 420);
            this.lbl_Tong_KH.Name = "lbl_Tong_KH";
            this.lbl_Tong_KH.Size = new System.Drawing.Size(134, 16);
            this.lbl_Tong_KH.TabIndex = 148;
            this.lbl_Tong_KH.Text = "Tổng Nhà Cung Cấp";
            // 
            // txt_Tong_NSX
            // 
            this.txt_Tong_NSX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Tong_NSX.Location = new System.Drawing.Point(944, 417);
            this.txt_Tong_NSX.Name = "txt_Tong_NSX";
            this.txt_Tong_NSX.Size = new System.Drawing.Size(122, 22);
            this.txt_Tong_NSX.TabIndex = 147;
            // 
            // txt_Tim_Kiem_NSX
            // 
            this.txt_Tim_Kiem_NSX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Tim_Kiem_NSX.Location = new System.Drawing.Point(24, 486);
            this.txt_Tim_Kiem_NSX.Multiline = true;
            this.txt_Tim_Kiem_NSX.Name = "txt_Tim_Kiem_NSX";
            this.txt_Tim_Kiem_NSX.Size = new System.Drawing.Size(227, 30);
            this.txt_Tim_Kiem_NSX.TabIndex = 146;
            // 
            // btn_Tim_Kiem
            // 
            this.btn_Tim_Kiem.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Tim_Kiem.Location = new System.Drawing.Point(24, 538);
            this.btn_Tim_Kiem.Name = "btn_Tim_Kiem";
            this.btn_Tim_Kiem.Size = new System.Drawing.Size(225, 47);
            this.btn_Tim_Kiem.TabIndex = 138;
            this.btn_Tim_Kiem.Text = "Tìm Kiếm Nhà Cung Cấp";
            this.btn_Tim_Kiem.UseVisualStyleBackColor = true;
            // 
            // txt_So_Dien_Thoai
            // 
            this.txt_So_Dien_Thoai.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_So_Dien_Thoai.Location = new System.Drawing.Point(477, 37);
            this.txt_So_Dien_Thoai.Name = "txt_So_Dien_Thoai";
            this.txt_So_Dien_Thoai.Size = new System.Drawing.Size(171, 22);
            this.txt_So_Dien_Thoai.TabIndex = 176;
            // 
            // lbl_Ma_Nha_San_Xuat
            // 
            this.lbl_Ma_Nha_San_Xuat.AutoSize = true;
            this.lbl_Ma_Nha_San_Xuat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ma_Nha_San_Xuat.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Ma_Nha_San_Xuat.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ma_Nha_San_Xuat.Location = new System.Drawing.Point(214, 42);
            this.lbl_Ma_Nha_San_Xuat.Name = "lbl_Ma_Nha_San_Xuat";
            this.lbl_Ma_Nha_San_Xuat.Size = new System.Drawing.Size(19, 16);
            this.lbl_Ma_Nha_San_Xuat.TabIndex = 175;
            this.lbl_Ma_Nha_San_Xuat.Text = "   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(208, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 28);
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Ma_NSX
            // 
            this.lbl_Ma_NSX.AutoSize = true;
            this.lbl_Ma_NSX.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Ma_NSX.Location = new System.Drawing.Point(47, 37);
            this.lbl_Ma_NSX.Name = "lbl_Ma_NSX";
            this.lbl_Ma_NSX.Size = new System.Drawing.Size(117, 16);
            this.lbl_Ma_NSX.TabIndex = 173;
            this.lbl_Ma_NSX.Text = "Mã Nhà Sản Xuất";
            // 
            // lbl_Ten_San_Pham
            // 
            this.lbl_Ten_San_Pham.AutoSize = true;
            this.lbl_Ten_San_Pham.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Ten_San_Pham.Location = new System.Drawing.Point(47, 95);
            this.lbl_Ten_San_Pham.Name = "lbl_Ten_San_Pham";
            this.lbl_Ten_San_Pham.Size = new System.Drawing.Size(122, 16);
            this.lbl_Ten_San_Pham.TabIndex = 172;
            this.lbl_Ten_San_Pham.Text = "Tên Nhà Sản Xuất";
            // 
            // cbb_Tinh_Trang
            // 
            this.cbb_Tinh_Trang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_Tinh_Trang.FormattingEnabled = true;
            this.cbb_Tinh_Trang.Items.AddRange(new object[] {
            "Ngừng hoạt động",
            "Đang hoạt động"});
            this.cbb_Tinh_Trang.Location = new System.Drawing.Point(877, 95);
            this.cbb_Tinh_Trang.Name = "cbb_Tinh_Trang";
            this.cbb_Tinh_Trang.Size = new System.Drawing.Size(137, 24);
            this.cbb_Tinh_Trang.TabIndex = 171;
            // 
            // txt_Dia_Chi
            // 
            this.txt_Dia_Chi.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Dia_Chi.Location = new System.Drawing.Point(477, 97);
            this.txt_Dia_Chi.Name = "txt_Dia_Chi";
            this.txt_Dia_Chi.Size = new System.Drawing.Size(231, 22);
            this.txt_Dia_Chi.TabIndex = 170;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(877, 37);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(118, 22);
            this.txt_Email.TabIndex = 169;
            // 
            // txt_Ten_Nha_San_Xuat
            // 
            this.txt_Ten_Nha_San_Xuat.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Ten_Nha_San_Xuat.Location = new System.Drawing.Point(208, 95);
            this.txt_Ten_Nha_San_Xuat.Name = "txt_Ten_Nha_San_Xuat";
            this.txt_Ten_Nha_San_Xuat.Size = new System.Drawing.Size(118, 22);
            this.txt_Ten_Nha_San_Xuat.TabIndex = 168;
            // 
            // lbl_Trong_Luong
            // 
            this.lbl_Trong_Luong.AutoSize = true;
            this.lbl_Trong_Luong.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Trong_Luong.Location = new System.Drawing.Point(364, 95);
            this.lbl_Trong_Luong.Name = "lbl_Trong_Luong";
            this.lbl_Trong_Luong.Size = new System.Drawing.Size(53, 16);
            this.lbl_Trong_Luong.TabIndex = 166;
            this.lbl_Trong_Luong.Text = "Địa Chỉ";
            // 
            // lbl_Huong_Vi
            // 
            this.lbl_Huong_Vi.AutoSize = true;
            this.lbl_Huong_Vi.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Huong_Vi.Location = new System.Drawing.Point(770, 37);
            this.lbl_Huong_Vi.Name = "lbl_Huong_Vi";
            this.lbl_Huong_Vi.Size = new System.Drawing.Size(43, 16);
            this.lbl_Huong_Vi.TabIndex = 165;
            this.lbl_Huong_Vi.Text = "Email";
            // 
            // lbl_Thuong_Hieu
            // 
            this.lbl_Thuong_Hieu.AutoSize = true;
            this.lbl_Thuong_Hieu.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Thuong_Hieu.Location = new System.Drawing.Point(363, 37);
            this.lbl_Thuong_Hieu.Name = "lbl_Thuong_Hieu";
            this.lbl_Thuong_Hieu.Size = new System.Drawing.Size(97, 16);
            this.lbl_Thuong_Hieu.TabIndex = 164;
            this.lbl_Thuong_Hieu.Text = "Số Điện Thoại";
            // 
            // lbl_Tinh_Trang
            // 
            this.lbl_Tinh_Trang.AutoSize = true;
            this.lbl_Tinh_Trang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Tinh_Trang.Location = new System.Drawing.Point(770, 95);
            this.lbl_Tinh_Trang.Name = "lbl_Tinh_Trang";
            this.lbl_Tinh_Trang.Size = new System.Drawing.Size(75, 16);
            this.lbl_Tinh_Trang.TabIndex = 167;
            this.lbl_Tinh_Trang.Text = "Tình Trạng";
            // 
            // frm_Nha_San_Xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 670);
            this.Controls.Add(this.txt_So_Dien_Thoai);
            this.Controls.Add(this.lbl_Ma_Nha_San_Xuat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Ma_NSX);
            this.Controls.Add(this.lbl_Ten_San_Pham);
            this.Controls.Add(this.cbb_Tinh_Trang);
            this.Controls.Add(this.txt_Dia_Chi);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Ten_Nha_San_Xuat);
            this.Controls.Add(this.lbl_Trong_Luong);
            this.Controls.Add(this.lbl_Huong_Vi);
            this.Controls.Add(this.lbl_Thuong_Hieu);
            this.Controls.Add(this.lbl_Tinh_Trang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Lam_Moi_Nha_SX);
            this.Controls.Add(this.btn_Xoa_Nha_SX);
            this.Controls.Add(this.btn_Cap_Nhat_Nha_SX);
            this.Controls.Add(this.btn_Them_Nha_SX);
            this.Controls.Add(this.dgv_Nha_San_Xuat);
            this.Controls.Add(this.btn_Xuat_Ra_Execl);
            this.Controls.Add(this.lbl_Tim_Kiem_Theo);
            this.Controls.Add(this.cbb_Tim_Kiem_Cac_Loai);
            this.Controls.Add(this.lbl_Tong_KH);
            this.Controls.Add(this.txt_Tong_NSX);
            this.Controls.Add(this.txt_Tim_Kiem_NSX);
            this.Controls.Add(this.btn_Tim_Kiem);
            this.Name = "frm_Nha_San_Xuat";
            this.Text = "Quản Lý Nhà Sản Xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nha_San_Xuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lam_Moi_Nha_SX;
        private System.Windows.Forms.Button btn_Xoa_Nha_SX;
        private System.Windows.Forms.Button btn_Cap_Nhat_Nha_SX;
        private System.Windows.Forms.Button btn_Them_Nha_SX;
        private System.Windows.Forms.DataGridView dgv_Nha_San_Xuat;
        private System.Windows.Forms.Button btn_Xuat_Ra_Execl;
        private System.Windows.Forms.Label lbl_Tim_Kiem_Theo;
        private System.Windows.Forms.ComboBox cbb_Tim_Kiem_Cac_Loai;
        private System.Windows.Forms.Label lbl_Tong_KH;
        private System.Windows.Forms.TextBox txt_Tong_NSX;
        private System.Windows.Forms.TextBox txt_Tim_Kiem_NSX;
        private System.Windows.Forms.Button btn_Tim_Kiem;
        private System.Windows.Forms.Timer tmr_Hien_Dan_Xem_San_Pham;
        private System.Windows.Forms.Timer tmr_An_Dan_Xem_San_Pham;
        private System.Windows.Forms.TextBox txt_So_Dien_Thoai;
        private System.Windows.Forms.Label lbl_Ma_Nha_San_Xuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Ma_NSX;
        private System.Windows.Forms.Label lbl_Ten_San_Pham;
        private System.Windows.Forms.ComboBox cbb_Tinh_Trang;
        private System.Windows.Forms.TextBox txt_Dia_Chi;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Ten_Nha_San_Xuat;
        private System.Windows.Forms.Label lbl_Trong_Luong;
        private System.Windows.Forms.Label lbl_Huong_Vi;
        private System.Windows.Forms.Label lbl_Thuong_Hieu;
        private System.Windows.Forms.Label lbl_Tinh_Trang;
    }
}