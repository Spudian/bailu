using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Quan_Ly_San_Pham : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Quan_Ly_San_Pham()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            QuanLySanPham();
            RandomMaSP();
            RandomMaNCC();
            RandomMaNXS();

        }
        private void QuanLySanPham()
        {
            try
            {
                var sanpham = dangNhapBUS.GetQuanLySanPhams();
                dgv_San_Pham.DataSource = sanpham;
                dgv_San_Pham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
                dgv_San_Pham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dgv_San_Pham.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
                dgv_San_Pham.Columns["TenNhaCUngCap"].HeaderText = "Tên Nhà Cung Cấp";
                dgv_San_Pham.Columns["MaNhaSanXuat"].HeaderText = "Mã Nhà Sản Xuất";
                dgv_San_Pham.Columns["TenNhaSanXuat"].HeaderText = "Tên Nhà Sản Xuất";
                dgv_San_Pham.Columns["ThuongHieu"].HeaderText = "Thương Hiệu";
                dgv_San_Pham.Columns["HuongVi"].HeaderText = "Hương Vị";
                dgv_San_Pham.Columns["Gia"].HeaderText = "Giá";
                dgv_San_Pham.Columns["TrongLuong"].HeaderText = "Trọng Lượng";
                dgv_San_Pham.Columns["DongGoi"].HeaderText = "Đóng Gói";
                dgv_San_Pham.Columns["LoaiMi"].HeaderText = "Loại Mì";
                dgv_San_Pham.Columns["NSX"].HeaderText = "Ngày Sản Xuất";
                dgv_San_Pham.Columns["NHH"].HeaderText = "Ngày Hết Hạn";
                dgv_San_Pham.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgv_San_Pham.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_San_Pham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_San_Pham.Rows[e.RowIndex];

                lbl_Ma_San_Pham.Text = row.Cells["MaSanPham"].Value.ToString();
                txt_Ten_San_Pham.Text = row.Cells["TenSanPham"].Value.ToString();
                lbl_Ma_Nha_Cung_Cap.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                txt_Ten_Nha_CC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                lbl_Ma_Nha_San_Xuat.Text = row.Cells["MaNhaSanXuat"].Value.ToString();
                txt_Ten_Nha_SX.Text = row.Cells["TenNhaSanXuat"].Value.ToString();
                txt_Thuong_Hieu.Text = row.Cells["ThuongHieu"].Value.ToString();
                txt_Huong_Vi.Text = row.Cells["HuongVi"].Value.ToString();
                txt_Gia.Text = row.Cells["Gia"].Value.ToString();
                txt_Trong_Luong.Text = row.Cells["TrongLuong"].Value.ToString();
                txt_Dong_Goi.Text = row.Cells["DongGoi"].Value.ToString();
                txt_Loai_Mi.Text = row.Cells["LoaiMi"].Value.ToString();

                if (DateTime.TryParse(row.Cells["NSX"].Value.ToString(), out DateTime nsxDate))
                {
                    dtp_Ngay_San_Xuat.Value = nsxDate;
                }
                else
                {
                    dtp_Ngay_San_Xuat.Value = DateTime.Now;
                }

                if (DateTime.TryParse(row.Cells["NHH"].Value.ToString(), out DateTime nhhDate))
                {
                    dtp_Ngay_Het_Han.Value = nhhDate;
                }
                else
                {
                    dtp_Ngay_Het_Han.Value = DateTime.Now;
                }

                txt_Trang_Thai.Text = row.Cells["TrangThai"].Value.ToString();
                txt_Tinh_Trang.Text = row.Cells["TinhTrang"].Value.ToString();


            }
        }

        public void lamMoi()
        {
            lbl_Ma_San_Pham.Text = "";
            txt_Ten_San_Pham.Text = "";
            lbl_Ma_Nha_San_Xuat.Text = "";
            txt_Ten_Nha_SX.Text = "";
            txt_Ten_Nha_CC.Text = "";
            lbl_Ma_Nha_Cung_Cap.Text = "";
            txt_Huong_Vi.Text = "";
            txt_Thuong_Hieu.Text = "";
            txt_Gia.Text = "";
            txt_Trong_Luong.Text = "";
            txt_Dong_Goi.Text = "";
            txt_Loai_Mi.Text = "";
            dtp_Ngay_San_Xuat.Value = DateTime.Now;
            dtp_Ngay_Het_Han.Value= DateTime.Now;
            txt_Trang_Thai.Text = "";
            txt_Tinh_Trang.Text = "";
            var quanlysanpham = dangNhapBUS.GetQuanLySanPhams();
            dgv_San_Pham.DataSource = quanlysanpham;
            txt_Tong_San_Pham.Text = quanlysanpham.Count.ToString();
        }
        // Phương thức tạo mã ngẫu nhiên cho sản phẩm mới trong phần THÊM
        public string RandomMaSP()
        {
            Random random = new Random();
            return "SP" + random.Next(001, 999).ToString();
        }
        public string RandomMaNXS()
        {
            Random random = new Random();
            return random.Next(001, 999).ToString();
        }
        public string RandomMaNCC()
        {
            Random random = new Random();
            return random.Next(001, 999).ToString();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten_San_Pham.Text) ||
                string.IsNullOrEmpty(lbl_Ma_Nha_San_Xuat.Text) ||
                string.IsNullOrEmpty(txt_Ten_Nha_SX.Text) ||
                string.IsNullOrEmpty(lbl_Ma_Nha_Cung_Cap.Text) ||
                string.IsNullOrEmpty(txt_Ten_Nha_CC.Text) ||
                string.IsNullOrEmpty(txt_Thuong_Hieu.Text) ||
                string.IsNullOrEmpty(txt_Gia.Text) ||
                string.IsNullOrEmpty(txt_Trong_Luong.Text) ||
                string.IsNullOrEmpty(txt_Dong_Goi.Text) ||
                string.IsNullOrEmpty(txt_Loai_Mi.Text) ||
                string.IsNullOrEmpty(txt_Trang_Thai.Text) ||
                string.IsNullOrEmpty(txt_Tinh_Trang.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Quan_Ly_San_Pham san_Pham = new Quan_Ly_San_Pham
            {
                MaSanPham = RandomMaSP(), // Assuming you have a unique way to generate MaSanPham
                TenSanPham = txt_Ten_San_Pham.Text,
                ThuongHieu = txt_Thuong_Hieu.Text,
                HuongVi = txt_Huong_Vi.Text,
                Gia = float.Parse(txt_Gia.Text),
                TrongLuong = float.Parse(txt_Trong_Luong.Text),
                DongGoi = txt_Dong_Goi.Text,
                LoaiMi = txt_Loai_Mi.Text,
                NSX = dtp_Ngay_San_Xuat.Value,
                NHH = dtp_Ngay_Het_Han.Value,
                TrangThai = txt_Trang_Thai.Text,
                TinhTrang = txt_Tinh_Trang.Text,
                MaNhaSanXuat = RandomMaNXS(),
                TenNhaSanXuat = txt_Ten_Nha_SX.Text,
                MaNhaCungCap = RandomMaNXS(),
                TenNhaCungCap = txt_Ten_Nha_CC.Text
            };

            try
            {
                dangNhapBUS.ThemSanPham(san_Pham); // Make sure to implement this method in your BUS layer
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
                QuanLySanPham(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Lam_Moi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
    }
}
