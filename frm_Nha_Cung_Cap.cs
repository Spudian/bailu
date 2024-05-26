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
    public partial class frm_Nha_Cung_Cap : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Nha_Cung_Cap()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            NhaCungCap();
            RandomMaNCC();
        }
        public void NhaCungCap()
        {
            try
            {
                var nhacungcap = dangNhapBUS.GetNhaCungCaps();
                dgv_Nha_Cung_Cap.DataSource = nhacungcap;
                dgv_Nha_Cung_Cap.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
                dgv_Nha_Cung_Cap.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
                dgv_Nha_Cung_Cap.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dgv_Nha_Cung_Cap.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgv_Nha_Cung_Cap.Columns["Email"].HeaderText = "Email";
                dgv_Nha_Cung_Cap.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Nha_Cung_Cap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Nha_Cung_Cap.Rows[e.RowIndex];

                lbl_Ma_Nha_Cung_Cap.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                txt_Ten_Nha_Cung_Cap.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                txt_So_Dien_Thoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_Dia_Chi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                cbb_Tinh_Trang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }

        //Đây là làm mới dữ liệu
        private void LamMoi()
        {
            lbl_Ma_Nha_Cung_Cap.Text = string.Empty;
            txt_Tim_Kiem_NCC.Clear();
            txt_Ten_Nha_Cung_Cap.Clear();
            txt_Dia_Chi.Clear();
            txt_So_Dien_Thoai.Clear();
            txt_Email.Clear();
            cbb_Tinh_Trang.Text = "";
            var quanlynhacc = dangNhapBUS.GetNhaCungCaps();
            dgv_Nha_Cung_Cap.DataSource = quanlynhacc;
            txt_Tong_NCC.Text = quanlynhacc.Count.ToString();
        }

        private void btn_Lam_Moi_Nha_CC_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        public string RandomMaNCC()
        {
            Random random = new Random();
            return "NC" + random.Next(01, 999).ToString();
        }

        private void btn_Them_Nha_CC_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi thêm
            if (string.IsNullOrEmpty(txt_Ten_Nha_Cung_Cap.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    string.IsNullOrEmpty(txt_So_Dien_Thoai.Text) ||
                    string.IsNullOrEmpty(txt_Email.Text) ||
                    cbb_Tinh_Trang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Nhà Cung Cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo Nhà Cung Cấp mới từ dữ liệu nhập vào
            Nha_Cung_Cap nhaCC = new Nha_Cung_Cap
            {
                MaNhaCungCap = RandomMaNCC(),
                TenNhaCungCap = txt_Ten_Nha_Cung_Cap.Text,
                DiaChi = txt_Dia_Chi.Text,
                SoDienThoai = txt_So_Dien_Thoai.Text,
                Email = txt_Email.Text,
                TinhTrang = cbb_Tinh_Trang.SelectedItem.ToString()
            };
            try
            {

                // Thêm Nhà Cung Cấp vào cơ sở dữ liệu
                dangNhapBUS.ThemNhaCC(nhaCC);
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi(); // Làm mới form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cap_Nhat_Nha_CC_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi cập nhật
            if (string.IsNullOrEmpty(txt_Ten_Nha_Cung_Cap.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    string.IsNullOrEmpty(txt_So_Dien_Thoai.Text) ||
                    string.IsNullOrEmpty(txt_Email.Text) ||
                    cbb_Tinh_Trang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Nhà Cung Cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng nhà cung cấp từ dữ liệu nhập vào
            Nha_Cung_Cap nhaCC = new Nha_Cung_Cap
            {
                MaNhaCungCap = lbl_Ma_Nha_Cung_Cap.Text,
                TenNhaCungCap = txt_Ten_Nha_Cung_Cap.Text,
                DiaChi = txt_Dia_Chi.Text,
                SoDienThoai = txt_So_Dien_Thoai.Text,
                Email = txt_Email.Text,
                TinhTrang = cbb_Tinh_Trang.SelectedItem.ToString(),
            };
            try
            {

                // Cập nhật thông tin nhà cung cấp vào cơ sở dữ liệu
                dangNhapBUS.CapNhatNhaCC(nhaCC);
                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();           // Làm mới form sau khi cập nhật thành công
                NhaCungCap();  // Hiển thị lại danh sách nhà cung cấp   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Nha_CC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_Ma_Nha_Cung_Cap.Text))
            {
                MessageBox.Show("Vui lòng chọn một Nhà Cung Cấp để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // Xóa nhà cung cấp khỏi cơ sở dữ liệu
                dangNhapBUS.XoaNhaCC(lbl_Ma_Nha_Cung_Cap.Text);
                NhaCungCap(); // Làm mới DataGridView sau khi xóa thành công
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (dgv_Nha_Cung_Cap.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Nha_Cung_Cap.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Nha_Cung_Cap.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Nha_Cung_Cap.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Nha_Cung_Cap.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Nha_Cung_Cap.Rows[i].Cells[j].Value.ToString();
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
