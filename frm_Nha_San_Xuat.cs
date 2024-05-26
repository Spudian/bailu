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
    public partial class frm_Nha_San_Xuat : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Nha_San_Xuat()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            NhaSanXuat();
            RandomMaNSX();
        }
        public void NhaSanXuat()
        {
            try
            {
                var nhasanxuat = dangNhapBUS.GetNhaSanXuats();
                dgv_Nha_San_Xuat.DataSource = nhasanxuat;
                dgv_Nha_San_Xuat.Columns["MaNhaSanXuat"].HeaderText = "Mã Nhà Sản Xuất";
                dgv_Nha_San_Xuat.Columns["TenNhaSanXuat"].HeaderText = "Tên Nhà Sản Xuất";
                dgv_Nha_San_Xuat.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dgv_Nha_San_Xuat.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgv_Nha_San_Xuat.Columns["Email"].HeaderText = "Email";
                dgv_Nha_San_Xuat.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Nha_San_Xuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Nha_San_Xuat.Rows[e.RowIndex];

                lbl_Ma_Nha_San_Xuat.Text = row.Cells["MaNhaSanXuat"].Value.ToString();
                txt_Ten_Nha_San_Xuat.Text = row.Cells["TenNhaSanXuat"].Value.ToString();
                txt_So_Dien_Thoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_Dia_Chi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                cbb_Tinh_Trang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }

        //Đây là làm mới dữ liệu
        private void LamMoi()
        {
            lbl_Ma_Nha_San_Xuat.Text = string.Empty;
            txt_Tim_Kiem_NSX.Clear();
            txt_Ten_Nha_San_Xuat.Clear();
            txt_Dia_Chi.Clear();
            txt_So_Dien_Thoai.Clear();
            txt_Email.Clear();
            cbb_Tinh_Trang.Text="";
            var quanlynhasx = dangNhapBUS.GetNhaSanXuats();
            dgv_Nha_San_Xuat.DataSource = quanlynhasx;
            txt_Tong_NSX.Text = quanlynhasx.Count.ToString();
        }

        private void btn_Lam_Moi_Nha_SX_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        public string RandomMaNSX()
        {
            Random random = new Random();
            return "NS" + random.Next(01, 999).ToString();
        }

        private void btn_Them_Nha_SX_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi thêm
            if (string.IsNullOrEmpty(txt_Ten_Nha_San_Xuat.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    string.IsNullOrEmpty(txt_So_Dien_Thoai.Text) ||
                    string.IsNullOrEmpty(txt_Email.Text) ||
                    cbb_Tinh_Trang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Nhà Sản Xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo Nhà Sản Xuất mới từ dữ liệu nhập vào
            Nha_San_Xuat nhaSX = new Nha_San_Xuat
            {
                MaNhaSanXuat = RandomMaNSX(),
                TenNhaSanXuat = txt_Ten_Nha_San_Xuat.Text,
                DiaChi = txt_Dia_Chi.Text,
                SoDienThoai = txt_So_Dien_Thoai.Text,
                Email = txt_Email.Text,
                TinhTrang = cbb_Tinh_Trang.SelectedItem.ToString()
            };
            try
            {

                // Thêm Nhà Sản Xuất vào cơ sở dữ liệu
                dangNhapBUS.ThemNhaSX(nhaSX);
                MessageBox.Show("Thêm Nhà Sản Xuất thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi(); // Làm mới form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm nhà sản xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cap_Nhat_Nha_SX_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi cập nhật
            if (string.IsNullOrEmpty(txt_Ten_Nha_San_Xuat.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    string.IsNullOrEmpty(txt_So_Dien_Thoai.Text) ||
                    string.IsNullOrEmpty(txt_Email.Text) ||
                    cbb_Tinh_Trang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhà sản xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng nhà sản xuất từ dữ liệu nhập vào
            Nha_San_Xuat nhaSX = new Nha_San_Xuat
            {
                MaNhaSanXuat = lbl_Ma_Nha_San_Xuat.Text,
                TenNhaSanXuat = txt_Ten_Nha_San_Xuat.Text,
                DiaChi = txt_Dia_Chi.Text,
                SoDienThoai = txt_So_Dien_Thoai.Text,
                Email = txt_Email.Text,
                TinhTrang = cbb_Tinh_Trang.SelectedItem.ToString(),
            };
            try
            {

                // Cập nhật thông tin nhà sản xuất vào cơ sở dữ liệu
                dangNhapBUS.CapNhatNhaSX(nhaSX);
                MessageBox.Show("Cập nhật nhà sản xuất thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();           // Làm mới form sau khi cập nhật thành công
                NhaSanXuat();  // Hiển thị lại danh sách nhà sản xuất    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật nhà sản xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Nha_SX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_Ma_Nha_San_Xuat.Text))
            {
                MessageBox.Show("Vui lòng chọn một Nhà Sản Xuất để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // Xóa nhà sản xuất khỏi cơ sở dữ liệu
                dangNhapBUS.XoaNhaSX(lbl_Ma_Nha_San_Xuat.Text);
                NhaSanXuat(); // Làm mới DataGridView sau khi xóa thành công
                MessageBox.Show("Xóa nhà sản xuát thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa nhà sản xuát: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (dgv_Nha_San_Xuat.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Nha_San_Xuat.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Nha_San_Xuat.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Nha_San_Xuat.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Nha_San_Xuat.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Nha_San_Xuat.Rows[i].Cells[j].Value.ToString();
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
