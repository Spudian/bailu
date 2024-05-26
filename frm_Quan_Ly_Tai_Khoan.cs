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
    public partial class frm_Quan_Ly_Tai_Khoan : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Quan_Ly_Tai_Khoan()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            TaiKhoan();
            RandomMaTK();
        }
        public void TaiKhoan()
        {
            try
            {
                var taikhoan = dangNhapBUS.GetTaiKhoans();
                dgv_Tai_Khoan.DataSource = taikhoan;
                dgv_Tai_Khoan.Columns["MaTaiKhoan"].HeaderText = "Mã Tài Khoản";
                dgv_Tai_Khoan.Columns["TaiKhoan"].HeaderText = "Tài Khoản";
                dgv_Tai_Khoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                dgv_Tai_Khoan.Columns["email"].HeaderText = "Email";
                dgv_Tai_Khoan.Columns["VaiTro"].HeaderText = "Vai Trò";
                dgv_Tai_Khoan.Columns["NgayTao"].HeaderText = "Ngày Tạo";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Tai_Khoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Tai_Khoan.Rows[e.RowIndex];

                lbl_Ma_Tai_Khoan.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                txt_Tai_Khoan.Text = row.Cells["TaiKhoan"].Value.ToString();
                txt_Mat_Khau.Text = row.Cells["MatKhau"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                cbb_Nhan_Vien.Text = row.Cells["VaiTro"].Value.ToString();

                DateTime ngayTao;
                if (DateTime.TryParse(row.Cells["NgayTao"].Value.ToString(), out ngayTao))
                {
                    dtp_Ngay_Tao.Value = ngayTao;
                }
                else
                {
                    dtp_Ngay_Tao.Value = DateTime.Now;
                }
            }
        }

        //Đây là làm mới dữ liệu
        private void LamMoi()
        {
            lbl_Ma_Tai_Khoan.Text = string.Empty;
            txt_Tim_Kiem_TK.Clear();
            txt_Tai_Khoan.Clear();
            txt_Mat_Khau.Clear();
            txt_Email.Clear();
            cbb_Nhan_Vien.Text = "";
            dtp_Ngay_Tao.Value = DateTime.Now;
            var quanlytaikhoan = dangNhapBUS.GetTaiKhoans();
            dgv_Tai_Khoan.DataSource = quanlytaikhoan;
            txt_Tong_TK.Text = quanlytaikhoan.Count.ToString();
        }

        private void btn_Lam_Moi_Tai_Khoan_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        public string RandomMaTK()
        {
            Random random = new Random();
            return "TS" + random.Next(001, 999).ToString();
        }

        private void btn_Them_Tai_Khoan_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi thêm
            if (string.IsNullOrEmpty(txt_Tai_Khoan.Text) ||
                    string.IsNullOrEmpty(txt_Mat_Khau.Text) ||
                    string.IsNullOrEmpty(txt_Email.Text) ||
                    cbb_Nhan_Vien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Tài Khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo tài khoản mới từ dữ liệu nhập vào
            Tai_Khoan tai_Khoan = new Tai_Khoan
            {
                MaTaiKhoan = RandomMaTK(),
                TaiKhoan = txt_Tai_Khoan.Text,
                MatKhau = txt_Mat_Khau.Text,
                email = txt_Email.Text,
                NgayTao = dtp_Ngay_Tao.Value,
                VaiTro = cbb_Nhan_Vien.SelectedItem.ToString(),

            };
            try
            {

                // Thêm Tài Khoản vào cơ sở dữ liệu
                dangNhapBUS.ThemTaiKhoan(tai_Khoan);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi(); // Làm mới form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cap_Nhat_Tai_Khoan_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi cập nhật
            if (string.IsNullOrEmpty(txt_Tai_Khoan.Text) ||
                    string.IsNullOrEmpty(txt_Mat_Khau.Text) ||
                    string.IsNullOrEmpty(txt_Email.Text) ||
                    cbb_Nhan_Vien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng khách hàng từ dữ liệu nhập vào
            Tai_Khoan tai_Khoan = new Tai_Khoan
            {
                MaTaiKhoan = lbl_Ma_Tai_Khoan.Text,
                TaiKhoan = txt_Tai_Khoan.Text,
                MatKhau = txt_Mat_Khau.Text,
                email = txt_Email.Text,
                NgayTao = dtp_Ngay_Tao.Value,
                VaiTro = cbb_Nhan_Vien.SelectedItem.ToString(),
            };
            try
            {

                // Cập nhật thông tin tài khoản vào cơ sở dữ liệu
                dangNhapBUS.CapNhatTaiKhoan(tai_Khoan);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();           // Làm mới form sau khi cập nhật thành công
                TaiKhoan();  // Hiển thị lại danh sách tài khoản    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (dgv_Tai_Khoan.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Tai_Khoan.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Tai_Khoan.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Tai_Khoan.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Tai_Khoan.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Tai_Khoan.Rows[i].Cells[j].Value.ToString();
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

        private void btn_Xoa_Tai_Khoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_Ma_Tai_Khoan.Text))
            {
                MessageBox.Show("Vui lòng chọn một Tài Khoản để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // Xóa tài khoản khỏi cơ sở dữ liệu
                dangNhapBUS.XoaTaiKhoan(lbl_Ma_Tai_Khoan.Text);
                TaiKhoan(); // Làm mới DataGridView sau khi xóa thành công
                MessageBox.Show("Xóa tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
