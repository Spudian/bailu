using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Quan_Ly_Khach_Hang : Form
    {
        private DangNhapBUS dangNhapBUS;
        public frm_Quan_Ly_Khach_Hang()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            QuanLyKhachHang();       // Hiển thị danh sách khách hàng và cập nhật tiếng việt các cột
            RandomMaTK();           // Tạo mã ngẫu nhiên cho khách hàng mới
        }

        // Hiển thị danh sách khách hàng
        public void QuanLyKhachHang()
        {
            try
            {
                var quanlykhachhang = dangNhapBUS.GetQuan_Ly_Khach_Hangs();
                dgv_Khach_Hang.DataSource = quanlykhachhang;

                // Đổi tên cột cho DataGridView
                dgv_Khach_Hang.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
                dgv_Khach_Hang.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
                dgv_Khach_Hang.Columns["SDT"].HeaderText = "SDT";
                dgv_Khach_Hang.Columns["CCCD"].HeaderText = "CCCD";
                dgv_Khach_Hang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgv_Khach_Hang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgv_Khach_Hang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xử lý sự kiện khi người dùng chọn một dòng trong DataGridView
        private void dgv_Khach_Hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Khach_Hang.Rows[e.RowIndex];

                // Hiển thị thông tin của khách hàng được chọn
                lbl_Ma_Khach_Hang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txt_Ten_Khach_Hang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                txt_Dia_Chi.Text = row.Cells["DiaChi"].Value.ToString();
                cbb_Gioi_Tinh.Text = row.Cells["GioiTinh"].Value.ToString();
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
        // Xử lý sự kiện khi người dùng nhấn nút Tìm kiếm
        private void btn_Tim_Kiem_Khach_Hang_Click(object sender, EventArgs e)
        {

            // Lấy thông tin tìm kiếm
            var searchCriteria = cbb_Tim_Kiem_Khach_Hang.Text;
            var searchText = txt_Tim_Kiem_Khach_Hang.Text.Trim().ToUpper();

            // Kiểm tra xem thông tin tìm kiếm có hợp lệ không
            if (string.IsNullOrEmpty(searchCriteria) || string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm và chọn tiêu chí tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tạo danh sách mới để lưu kết quả tìm kiếm
            List<Quan_Ly_Khach_Hang> filteredList = null;
            var allQuanLyKhachHangs = dangNhapBUS.GetQuan_Ly_Khach_Hangs();

            // Thực hiện tìm kiếm theo tiêu chí đã chọn
            switch (searchCriteria)
            {
                case "Tìm Kiếm Theo Mã Khách Hàng":
                    filteredList = allQuanLyKhachHangs.Where(sp => sp.MaKhachHang.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Tên Khách Hàng":
                    filteredList = allQuanLyKhachHangs.Where(sp => sp.TenKhachHang.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo SDT":
                    filteredList = allQuanLyKhachHangs.Where(sp => sp.SDT.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo CCCD":
                    filteredList = allQuanLyKhachHangs.Where(sp => sp.CCCD.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Địa Chỉ":
                    filteredList = allQuanLyKhachHangs.Where(sp => sp.DiaChi.ToUpper().Contains(searchText)).ToList();
                    break;
                case "Tìm Kiếm Theo Ngày Sinh":
                    if (DateTime.TryParse(searchText, out DateTime ns))
                    {
                        filteredList = allQuanLyKhachHangs.Where(sp => sp.NgaySinh.Date == ns.Date).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Tìm Kiếm Theo Giới Tính":
                    filteredList = allQuanLyKhachHangs.Where(sp => sp.GioiTinh.ToUpper().Contains(searchText)).ToList();
                    break;
                default:
                    MessageBox.Show("Không Tìm Thấy Thông Tin Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Hiển thị kết quả tìm kiếm trên DataGridView
            if (filteredList != null)
            {
                dgv_Khach_Hang.DataSource = filteredList;
                txt_Tong_Khach_Hang.Text = filteredList.Count.ToString();
                txt_Tim_Kiem_Khach_Hang.Clear();
                cbb_Tim_Kiem_Khach_Hang.SelectedIndex = -1;
            }
        }
        //Đây là làm mới dữ liệu
        private void LamMoi()
        {
            lbl_Ma_Khach_Hang.Text = string.Empty;
            txt_Tim_Kiem_Khach_Hang.Clear();
            txt_Ten_Khach_Hang.Clear();
            txt_SDT.Clear();
            txt_CCCD.Clear();
            txt_Dia_Chi.Clear();
            dtp_Ngay_Sinh.Value = DateTime.Now;
            cbb_Gioi_Tinh.SelectedIndex = -1;
            var quanlykhachhang = dangNhapBUS.GetQuan_Ly_Khach_Hangs();
            dgv_Khach_Hang.DataSource = quanlykhachhang;
            txt_Tong_Khach_Hang.Text = quanlykhachhang.Count.ToString();
        }

        //Đây là làm mới dữ liệu và truyền vào button
        private void button4_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // Phương thức tạo mã ngẫu nhiên cho khách hàng mới trong phần THÊM
        public string RandomMaTK()
        {
            Random random = new Random();
            return "KH" + random.Next(001, 999).ToString();
        }

        // Xử lý sự kiện khi người dùng nhấn nút Thêm Khách Hàng
        private void btn_Them_Khach_Hang_Click(object sender, EventArgs e)
        {

            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi thêm
            if (string.IsNullOrEmpty(txt_Ten_Khach_Hang.Text) ||
                    string.IsNullOrEmpty(txt_SDT.Text) ||
                    string.IsNullOrEmpty(txt_CCCD.Text) ||
                    string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                    cbb_Gioi_Tinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng khách hàng mới từ dữ liệu nhập vào
            Quan_Ly_Khach_Hang khach_Hang = new Quan_Ly_Khach_Hang
            {
                MaKhachHang = RandomMaTK(),
                TenKhachHang = txt_Ten_Khach_Hang.Text,
                SDT = txt_SDT.Text,
                CCCD = txt_CCCD.Text,
                DiaChi = txt_Dia_Chi.Text,
                NgaySinh = dtp_Ngay_Sinh.Value,
                GioiTinh = cbb_Gioi_Tinh.SelectedItem.ToString()
            };
            try
            {

                // Thêm khách hàng vào cơ sở dữ liệu
                dangNhapBUS.ThemKhachHang(khach_Hang);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi(); // Làm mới form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút Cập Nhật Khách Hàng
        private void btn_Cap_Nhat_Khach_Hang_Click(object sender, EventArgs e)
        {

            // Kiểm tra tính hợp lệ của dữ liệu nhập vào trước khi cập nhật
            if (string.IsNullOrEmpty(txt_Ten_Khach_Hang.Text) ||
                string.IsNullOrEmpty(txt_SDT.Text) ||
                string.IsNullOrEmpty(txt_CCCD.Text) ||
                string.IsNullOrEmpty(txt_Dia_Chi.Text) ||
                cbb_Gioi_Tinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng khách hàng từ dữ liệu nhập vào
            Quan_Ly_Khach_Hang khach_Hang = new Quan_Ly_Khach_Hang
            {
                MaKhachHang = lbl_Ma_Khach_Hang.Text,
                TenKhachHang = txt_Ten_Khach_Hang.Text,
                SDT = txt_SDT.Text,
                CCCD = txt_CCCD.Text,
                DiaChi = txt_Dia_Chi.Text,
                NgaySinh = dtp_Ngay_Sinh.Value,
                GioiTinh = cbb_Gioi_Tinh.SelectedItem.ToString()
            };
            try
            {

                // Cập nhật thông tin khách hàng vào cơ sở dữ liệu
                dangNhapBUS.CapNhatKhachHang(khach_Hang);
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();           // Làm mới form sau khi cập nhật thành công
                QuanLyKhachHang();  // Hiển thị lại danh sách khách hàng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút Xóa Khách Hàng
        private void btn_Xoa_Khach_Hang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_Ma_Khach_Hang.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Xóa khách hàng khỏi cơ sở dữ liệu
                dangNhapBUS.XoaKhachHang(lbl_Ma_Khach_Hang.Text);
                QuanLyKhachHang(); // Làm mới DataGridView sau khi xóa thành công
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
                        if (dgv_Khach_Hang.Rows.Count > 0)
                        {
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Application.Workbooks.Add(Type.Missing);

                            // Ghi tiêu đề cột vào Excel
                            for (int i = 1; i < dgv_Khach_Hang.Columns.Count + 1; i++)
                            {
                                excelApp.Cells[1, i] = dgv_Khach_Hang.Columns[i - 1].HeaderText;
                            }

                            // Ghi dữ liệu từ DataGridView vào Excel
                            for (int i = 0; i < dgv_Khach_Hang.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_Khach_Hang.Columns.Count; j++)
                                {
                                    excelApp.Cells[i + 2, j + 1] = dgv_Khach_Hang.Rows[i].Cells[j].Value.ToString();
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

        private void frm_Quan_Ly_Khach_Hang_Load(object sender, EventArgs e)
        {

        }
    }
}
