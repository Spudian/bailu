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
    public partial class frm_Doi_Mat_Khau : Form
    {
        public frm_Doi_Mat_Khau()
        {
            InitializeComponent();
        }
        public AuthenticationManager authManager = new AuthenticationManager();

        private void btn_Gmail_Click(object sender, EventArgs e)
        {
            string email = txt_Gmail.Text;
            DangNhapDAL dnAL = new DangNhapDAL();
            bool emailExists = dnAL.getBANG_TAI_KHOAN().Any(u => u.EMAIL.Trim().Equals(email, StringComparison.OrdinalIgnoreCase));

            if (!emailExists)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int otp = authManager.GenerateOTP();
                string messageBody = " Cửa hàng TeamTwo Xin Chào Bạn !! \n Cửa Hàng Xin Cung Cấp Cho Bạn MÃ OTP \n Mã OTP Của Bạn Là: " + otp + "\n Vui Lòng KHÔNG Chia Sẻ Mã Này Cho Bất Kì Ai. \n \n Chúc Bạn Một Ngày Thật Tốt Lành \n Nếu Có Vấn Đề Gì Xin Vui Lòng Liên Hệ Qua Số Điện Thoại:   0367219692(MR.Quang) hoặc Gmail:cuahangteamtwo@gmail.com";
                authManager.sendOTP(email, otp.ToString());
                txt_OTP.Enabled = true;
                txt_Gmail.Enabled = false;
                btn_Nhap.Enabled = true;
                txt_OTP.Tag = otp.ToString();
                MessageBox.Show("Mail đã gửi về. Vui lòng kiểm tra email và nhập mã OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi email. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            string email = txt_Gmail.Text;
            string OTP = txt_OTP.Text;
            string actualOtp = txt_OTP.Tag?.ToString();
            string newPass = txt_Mat_Khau_Moi.Text;
            string confirmPass = txt_Nhap_Lai_Mat_Khau.Text;

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (authManager.VerifyOTP(OTP, actualOtp))
            {
                if (authManager.ChangePassword(email, newPass))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!\nQuý Khách Vui Lòng Đăng Nhập Bằng Mật Khẩu Mới Tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại. Kiểm tra lại quy trình cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
