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
using System.Data.SqlTypes;

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Quan_Ly_Nhan_Vien : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Quan_Ly_Nhan_Vien()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            QuanLyNhanVien();
            RandomMaNV();
        }
        public void QuanLyNhanVien()
        {
            try
            {
                var nhanvien = dangNhapBUS.GetQuanLyNhanViens();
                dgv_Nhan_Vien.DataSource = nhanvien;
                dgv_Nhan_Vien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                dgv_Nhan_Vien.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
                dgv_Nhan_Vien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dgv_Nhan_Vien.Columns["CCCD"].HeaderText = "CCCD";
                dgv_Nhan_Vien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgv_Nhan_Vien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgv_Nhan_Vien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgv_Nhan_Vien.Columns["Luong"].HeaderText = "Lương";
                dgv_Nhan_Vien.Columns["ChucVu"].HeaderText = "Chức Vụ";
                dgv_Nhan_Vien.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Đây là làm mới dữ liệu
        private void LamMoi()
        {
            lbl_Ma_Nhan_Vien.Text = string.Empty;
            txt_Tim_Kiem_NV.Clear();
            txt_Ten_Nhan_Vien.Clear();
            txt_So_Dien_Thoai.Clear();
            txt_CCCD.Clear();
            txt_Dia_Chi.Clear();
            dtp_Ngay_Sinh.Value = DateTime.Now;
            txt_Luong.Clear();
            cbb_Chuc_Vu.SelectedIndex = -1;
            cbb_Tinh_Trang.SelectedIndex = -1;
            cbb_Gioi_Tinh.SelectedIndex = -1;
            var quanlynhanvien = dangNhapBUS.GetQuanLyNhanViens();
            dgv_Nhan_Vien.DataSource = quanlynhanvien;
            txt_Tong_NV.Text = quanlynhanvien.Count.ToString();
        }
        // Phương thức tạo mã ngẫu nhiên cho khách hàng mới trong phần THÊM
        public string RandomMaNV()
        {
            Random random = new Random();
            return "NV" + random.Next(001, 999).ToString();
        }
      
        // Xử lý sự kiện khi người dùng nhấn nút Thêm Nhân Viên
        private void btn_Them_Nhan_Vien_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi thêm
            if (string.IsNullOrEmpty(txt_Ten_Nhan_Vien.Text) ||
                    string.IsNullOrEmpty(txt_So_Dien_Thoai.Text) ||
                    string.IsNullOrEmpty(txt_CCCD.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    string.IsNullOrEmpty(txt_Luong.Text) ||
                    cbb_Gioi_Tinh.SelectedIndex == -1 ||
                    cbb_Chuc_Vu.SelectedIndex == -1 ||
                    cbb_Tinh_Trang.SelectedIndex == -1)

            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng khách hàng mới từ dữ liệu nhập vào
            Quan_Ly_Nhan_Vien nhan_Vien = new Quan_Ly_Nhan_Vien
            {
                MaNhanVien = RandomMaNV(),
                TenNhanVien = txt_Ten_Nhan_Vien.Text,
                SoDienThoai = txt_So_Dien_Thoai.Text,
                CCCD = txt_CCCD.Text,
                DiaChi = txt_Dia_Chi.Text,
                NgaySinh = dtp_Ngay_Sinh.Value,
                Luong = float.Parse(txt_Luong.Text),
                GioiTinh = cbb_Gioi_Tinh.SelectedItem.ToString(),
                ChucVu = cbb_Chuc_Vu.SelectedItem.ToString(),
                TinhTrang = cbb_Tinh_Trang.SelectedItem.ToString(),
            };
            try
            {

                // Thêm nhân viên vào cơ sở dữ liệu
                dangNhapBUS.ThemNhanVien(nhan_Vien);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi(); // Làm mới form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void dgv_Nhan_Vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Nhan_Vien.Rows[e.RowIndex];

                // Hiển thị thông tin của Nhân Viên được chọn
                lbl_Ma_Nhan_Vien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txt_Ten_Nhan_Vien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txt_So_Dien_Thoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                txt_Dia_Chi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_Luong.Text = row.Cells["Luong"].Value.ToString();
                cbb_Gioi_Tinh.Text = row.Cells["GioiTinh"].Value.ToString();
                cbb_Chuc_Vu.Text = row.Cells["ChucVu"].Value.ToString();
                cbb_Tinh_Trang.Text = row.Cells["TinhTrang"].Value.ToString();
                DateTime nsDate;

                // Hiển thị ngày sinh nếu có
                if (DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out nsDate))
                {
                    dtp_Ngay_Sinh.Value = nsDate;
                }
                else
                {
                    dtp_Ngay_Sinh.Value = DateTime.Now;
                }
            }
        }

        private void btn_Lam_Moi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // Xử lý sự kiện khi người dùng nhấn nút Cập Nhật Nhân Viên
        private void btn_Cap_Nhat_Nhan_Vien_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi cập nhật
            if (string.IsNullOrEmpty(txt_Ten_Nhan_Vien.Text) ||
                    string.IsNullOrEmpty(txt_So_Dien_Thoai.Text) ||
                    string.IsNullOrEmpty(txt_CCCD.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    string.IsNullOrEmpty(txt_Luong.Text) ||
                    cbb_Gioi_Tinh.SelectedIndex == -1 ||
                    cbb_Chuc_Vu.SelectedIndex == -1 ||
                    cbb_Tinh_Trang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng khách hàng từ dữ liệu nhập vào
            Quan_Ly_Nhan_Vien nhan_Vien = new Quan_Ly_Nhan_Vien
            {
                MaNhanVien = lbl_Ma_Nhan_Vien.Text,
                TenNhanVien = txt_Ten_Nhan_Vien.Text,
                SoDienThoai = txt_So_Dien_Thoai.Text,
                CCCD = txt_CCCD.Text,
                DiaChi = txt_Dia_Chi.Text,
                NgaySinh = dtp_Ngay_Sinh.Value,
                Luong = float.Parse(txt_Luong.Text),
                GioiTinh = cbb_Gioi_Tinh.SelectedItem.ToString(),
                ChucVu = cbb_Chuc_Vu.SelectedItem.ToString(),
                TinhTrang = cbb_Tinh_Trang.SelectedItem.ToString(),
            };
            try
            {

                // Cập nhật thông tin khách hàng vào cơ sở dữ liệu
                dangNhapBUS.CapNhatNhanVien(nhan_Vien);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();           // Làm mới form sau khi cập nhật thành công
                QuanLyNhanVien();  // Hiển thị lại danh sách khách hàng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút Xóa Nhân Viên
        private void btn_Xoa_Nhan_Vien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_Ma_Nhan_Vien.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Xóa Nhân Viên khỏi cơ sở dữ liệu
                dangNhapBUS.XoaNhanVien(lbl_Ma_Nhan_Vien.Text);
                QuanLyNhanVien(); // Làm mới DataGridView sau khi xóa thành công
                MessageBox.Show("Xóa khách hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        if (dgv_Nhan_Vien.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Nhan_Vien.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Nhan_Vien.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Nhan_Vien.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Nhan_Vien.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Nhan_Vien.Rows[i].Cells[j].Value.ToString();
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
