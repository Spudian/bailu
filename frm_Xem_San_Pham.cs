using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using ZXing;
using ZXing.QrCode;

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Xem_San_Pham : Form
    {
        private DangNhapBUS dangNhapBUS;

        private DangNhapBUS tk = new DangNhapBUS();

        public frm_Xem_San_Pham()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            SanPham();
            this.Opacity = 0;
            tmr_Hien_Dan_Xem_San_Pham.Start();

            // tạo timer hiệu ứng ẩn
            tmr_An_Dan_Xem_San_Pham = new Timer();
            tmr_An_Dan_Xem_San_Pham.Interval = 50; // Đặt khoảng tg  50 mili giây
            tmr_An_Dan_Xem_San_Pham.Tick += new EventHandler(tmr_An_Dan_Xem_San_Pham_Tick);
        }

        private int tongSoSanPham;
        private void SanPham()
        {
            try
            {
                var sanpham = dangNhapBUS.GetSanPhams();
                dgv_Xem_San_Pham.DataSource = sanpham;
                dgv_Xem_San_Pham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
                dgv_Xem_San_Pham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dgv_Xem_San_Pham.Columns["ThuongHieu"].HeaderText = "Thương Hiệu";
                dgv_Xem_San_Pham.Columns["HuongVi"].HeaderText = "Hương Vị";
                dgv_Xem_San_Pham.Columns["Gia"].HeaderText = "Gía";
                dgv_Xem_San_Pham.Columns["TrongLuong"].HeaderText = "Trọng Lượng";
                dgv_Xem_San_Pham.Columns["DongGoi"].HeaderText = "Đóng Gói";
                dgv_Xem_San_Pham.Columns["LoaiMi"].HeaderText = "Loại Mì";
                dgv_Xem_San_Pham.Columns["NSX"].HeaderText = "Ngày Sản Xuất";
                dgv_Xem_San_Pham.Columns["NHH"].HeaderText = "Ngày Hết Hạn";
                dgv_Xem_San_Pham.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgv_Xem_San_Pham.Columns["TinhTrang"].HeaderText = "Tình Trạng";
                dgv_Xem_San_Pham.Columns["TenNSX"].HeaderText = "Tên Nhà Sản Xuất";
                dgv_Xem_San_Pham.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_Xem_San_Pham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Xem_San_Pham.Rows[e.RowIndex];
                lbl_Ma.Text = row.Cells["MaSanPham"].Value.ToString();
                txt_Ten_San_Pham.Text = row.Cells["TenSanPham"].Value.ToString();
                txt_Thuong_Hieu.Text = row.Cells["ThuongHieu"].Value.ToString();
                txt_Huong_Vi.Text = row.Cells["HuongVi"].Value.ToString();
                txt_Gia.Text = row.Cells["Gia"].Value.ToString();
                txt_Trong_Luong.Text = row.Cells["TrongLuong"].Value.ToString();
                txt_Dong_Goi.Text = row.Cells["DongGoi"].Value.ToString();
                txt_Loai_Mi.Text = row.Cells["LoaiMi"].Value.ToString();
                cbb_Trang_Thai.Text = row.Cells["TrangThai"].Value.ToString();
                cbb_Tinh_Trang.Text = row.Cells["TinhTrang"].Value.ToString();
                lbl_ten_Nha_San_Xuat2.Text = row.Cells["TenNSX"].Value.ToString();
                lbl_Ten_Nha_Cung_Cap2.Text = row.Cells["TenNCC"].Value.ToString();
                DateTime nsxDate;
                if (DateTime.TryParse(row.Cells["NSX"].Value.ToString(), out nsxDate))
                {
                    dtp_Ngay_San_Xuat.Value = nsxDate;
                }
                else
                {
                    dtp_Ngay_San_Xuat.Value = DateTime.Now;
                }
                DateTime nhhDate;
                if (DateTime.TryParse(row.Cells["NHH"].Value.ToString(), out nhhDate))
                {
                    dtp_Ngay_Het_Han.Value = nhhDate;
                }
                else
                {
                    dtp_Ngay_Het_Han.Value = DateTime.Now;
                }
            }

        }
        private void btn_Tim_Kiem_San_Pham_Click(object sender, EventArgs e)
        {
            var searchCriteria = cbb_Tim_Kiem_Cac_Loai.Text;
            var searchText = txt_Tim_Kiem.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(searchCriteria) || string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm và chọn tiêu chí tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<San_Pham> filteredList = null;
            var allSanPhams = dangNhapBUS.GetSanPhams();
            switch (searchCriteria)
            {
                case "Tìm Kiếm Theo Mã Sản Phẩm":
                    filteredList = allSanPhams.Where(sp => sp.MaSanPham.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Tên Sản Phẩm":
                    filteredList = allSanPhams.Where(sp => sp.TenSanPham.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Hương Vị":
                    filteredList = allSanPhams.Where(sp => sp.HuongVi.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Giá":
                    if (float.TryParse(searchText, out float gia))
                    {
                        filteredList = allSanPhams.Where(sp => sp.Gia == gia).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Giá không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Tìm Kiếm Theo Trọng Lượng":
                    if (float.TryParse(searchText, out float trongLuong))
                    {
                        filteredList = allSanPhams.Where(sp => sp.TrongLuong == trongLuong).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Trọng lượng không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Tìm Kiếm Theo Loại Mì":
                    filteredList = allSanPhams.Where(sp => sp.LoaiMi.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Ngày Sản Xuất":
                    if (DateTime.TryParse(searchText, out DateTime nsx))
                    {
                        filteredList = allSanPhams.Where(sp => sp.NSX.Date == nsx.Date).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Ngày sản xuất không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Tìm Kiếm Theo Ngày Hết Hạn":
                    if (DateTime.TryParse(searchText, out DateTime nhh))
                    {
                        filteredList = allSanPhams.Where(sp => sp.NHH.Date == nhh.Date).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Ngày hết hạn không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Tìm Kiếm Theo Trạng Thái":
                    filteredList = allSanPhams.Where(sp => sp.TrangThai.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Nhà Sản Xuất":
                    filteredList = allSanPhams.Where(sp => sp.TenNSX.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Nhà Cung Cấp":
                    filteredList = allSanPhams.Where(sp => sp.TenNCC.ToUpper().Contains(searchText)).ToList();
                    break;
                default:
                    MessageBox.Show("Không Tìm Thấy Thông Tin Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            if (filteredList != null)
            {
                dgv_Xem_San_Pham.DataSource = filteredList;
                txt_Tong_San_Pham.Text = filteredList.Count.ToString();
                txt_Tim_Kiem.Clear();
                cbb_Tim_Kiem_Cac_Loai.SelectedIndex = -1;
            }
        }
        private void LamMoi()
        {
            lbl_Ma_San_Pham.Text = string.Empty;
            txt_Tim_Kiem.Clear();
            txt_Ten_San_Pham.Clear();
            txt_Thuong_Hieu.Clear();
            txt_Huong_Vi.Clear();
            txt_Gia.Clear();
            txt_Trong_Luong.Clear();
            txt_Dong_Goi.Clear();
            txt_Loai_Mi.Clear();
            cbb_Trang_Thai.SelectedIndex = -1;
            cbb_Tinh_Trang.SelectedIndex = -1;
            dtp_Ngay_San_Xuat.Value = DateTime.Now;
            dtp_Ngay_Het_Han.Value = DateTime.Now;
            var sanpham = dangNhapBUS.GetSanPhams();
            dgv_Xem_San_Pham.DataSource = sanpham;
            txt_Tong_San_Pham.Text = sanpham.Count.ToString();
        }
        private void btn_Lam_Moi_San_Pham_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        private void btn_Xuat_Ra_Execl_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo hỏi người dùng có muốn xuất ra Excel không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xuất Ra Excel không???", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hiển thị hộp thoại để chọn đường dẫn và đặt tên cho file Excel
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                    saveFileDialog.Title = "Chọn nơi lưu file Excel";

                    // Hiển thị hộp thoại và kiểm tra kết quả
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn và tên file Excel được chọn
                        string filePath = saveFileDialog.FileName;

                        // Kiểm tra xem có dữ liệu trong DataGridView không
                        if (dgv_Xem_San_Pham.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Xem_San_Pham.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Xem_San_Pham.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Xem_San_Pham.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Xem_San_Pham.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Xem_San_Pham.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            // Tự động điều chỉnh kích thước cột trong Excel
                            excelApp.Columns.AutoFit();
                            excelApp.Visible = true;

                            // Lưu file Excel vào đường dẫn và tên file đã chọn
                            excelApp.ActiveWorkbook.SaveAs(filePath);

                            // Hiển thị thông báo thành công
                            MessageBox.Show("Xuất dữ liệu thành công và lưu tại: " + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Hiển thị thông báo nếu không có dữ liệu để xuất ra Excel
                            MessageBox.Show("Không có bản ghi nào để xuất ra file Excel!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btn_Dang_Xuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Xác nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Cảm Ơn bạn đã sử dụng ứng dụng!!!  Chúc Bạn 1 Ngày Tốt Lành !!!", "Xin Cảm Ơn!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                tmr_An_Dan_Xem_San_Pham.Start();
            }
        }
        private void tmr_Hien_Dan_Xem_San_Pham_Tick(object sender, EventArgs e)
        {

            if (Opacity < 1)
            {
                Opacity += 0.11;
            }
            else
            {
                tmr_Hien_Dan_Xem_San_Pham.Stop();
            }
        }

        private void tmr_An_Dan_Xem_San_Pham_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.11;
            }
            else
            {
                tmr_An_Dan_Xem_San_Pham.Stop();
                Close();
            }
        }
        private void CreateQRCODE(string text)
        {
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = ptb_Game.Height,
                    Width = ptb_Game.Width
                }
            };
            Bitmap qrCodeBitmap = writer.Write(text);
            ptb_Game.Image = qrCodeBitmap;
            ScanQRCODE();
        }

        private void ScanQRCODE()
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)ptb_Game.Image);
        }

        private void btn_Quet_Ma_De_Choi_Game_Click(object sender, EventArgs e)
        {
            if (txt_Quet_Ma_De_Choi_Game.Text.Trim() == "thaythachdeptraivodoi")
            {
                frm_Chon_Game chongame = new frm_Chon_Game();
                this.Hide();
                chongame.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn Đăng Nhập Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void frm_Xem_San_Pham_Load(object sender, EventArgs e)
        {
            string qrCodeText = "https://docs.google.com/document/d/1tbevWJ1zUnT22p6ezOxQjPh3dAM5wIFToqHEF1TkE-g/edit?usp=sharing";
            CreateQRCODE(qrCodeText);
            ScanQRCODE();
        }
    }
}