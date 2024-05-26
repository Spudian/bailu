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
    public partial class frm_Thong_Ke_Phieu_Nhap : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Thong_Ke_Phieu_Nhap()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            PhieuNhap();
            ChiTietPhieuNhap();
        }
        public void PhieuNhap()
        {
            try
            {
                var phieunhap = dangNhapBUS.GetPhieuNhaps();
                dgv_Phieu_Nhap.DataSource = phieunhap;
                dgv_Phieu_Nhap.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
                dgv_Phieu_Nhap.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
                dgv_Phieu_Nhap.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
                dgv_Phieu_Nhap.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                dgv_Phieu_Nhap.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ChiTietPhieuNhap()
        {
            try
            {
                var chitietphieunhap = dangNhapBUS.GetChiTietPhieuNhaps();
                dgv_Chi_Tiet_Phieu_Nhap.DataSource = chitietphieunhap;
                dgv_Chi_Tiet_Phieu_Nhap.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
                dgv_Chi_Tiet_Phieu_Nhap.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
                dgv_Chi_Tiet_Phieu_Nhap.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dgv_Chi_Tiet_Phieu_Nhap.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgv_Chi_Tiet_Phieu_Nhap.Columns["GiaNhap"].HeaderText = "Giá Nhập";
                dgv_Chi_Tiet_Phieu_Nhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                dgv_Chi_Tiet_Phieu_Nhap.Columns["DiaChiNhap"].HeaderText = "Địa Chỉ Nhập";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Phieu_Nhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Phieu_Nhap.Rows[e.RowIndex];
                lbl_Ma_Phieu_Nhap.Text = row.Cells["MaPhieuNhap"].Value.ToString();
                lbl_Ma_Nha_Cung_Cap.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                lbl_Ten_Nha_Cung_Cap.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                lbl_Ma_Nhan_Vien.Text = row.Cells["MaNhanVien"].Value.ToString();
                lbl_Ten_Nhan_Vien.Text = row.Cells["TenNhanVien"].Value.ToString();
            }
        }

        private void dgv_Chi_Tiet_Phieu_Nhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Chi_Tiet_Phieu_Nhap.Rows[e.RowIndex];

                lbl_Ma_Phieu_Nhap2.Text = row.Cells["MaPhieuNhap"].Value.ToString();
                lbl_Ma_San_Pham2.Text = row.Cells["MaSanPham"].Value.ToString();
                lbl_Ten_San_Pham2.Text = row.Cells["TenSanPham"].Value.ToString();
                txt_So_Luong.Text = row.Cells["SoLuong"].Value.ToString();
                txt_Gia_Nhap.Text = row.Cells["GiaNhap"].Value.ToString();
                dtp_Ngay_Nhap.Text = row.Cells["NgayNhap"].Value.ToString();
                txt_Dia_Chi_Nhap.Text = row.Cells["DiaChiNhap"].Value.ToString();
            }
        }

        private void btn_Xuat_Ra_Execl_PN_Click(object sender, EventArgs e)
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
                        if (dgv_Phieu_Nhap.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Phieu_Nhap.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Phieu_Nhap.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Phieu_Nhap.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Phieu_Nhap.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Phieu_Nhap.Rows[i].Cells[j].Value.ToString();
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

        private void btn_Xuat_Ra_Execl_CTPN_Click(object sender, EventArgs e)
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
                        if (dgv_Chi_Tiet_Phieu_Nhap.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Chi_Tiet_Phieu_Nhap.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Chi_Tiet_Phieu_Nhap.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Chi_Tiet_Phieu_Nhap.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Chi_Tiet_Phieu_Nhap.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Chi_Tiet_Phieu_Nhap.Rows[i].Cells[j].Value.ToString();
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
    }
}
