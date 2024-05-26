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
using BUS;

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Tao_Tai_Khoan_Khach_Hang : Form
    {
        public frm_Tao_Tai_Khoan_Khach_Hang()
        {
            InitializeComponent();
            GenerateRandomCode();
        }
        private string _otpCode;
        private string GenerateRandomCode()
        {
            Random random = new Random();
            return "TK" + random.Next(001, 999).ToString();
        }
        string strcon = @"Data Source=.;Initial Catalog=MI_AN_LIEN_1002;Integrated Security=True;Encrypt=False";
        private void SendOTPToEmail(string email, string otp)
        {
            try
            {
                EmailService emailService = new EmailService();
                string messageBody = "Cửa hàng TeamTwo Xin Chào Bạn !! \nCửa Hàng Xin Cung Cấp Cho Bạn MÃ OTP \nMã OTP Của Bạn Là: " + otp + "\nVui Lòng KHÔNG Chia Sẻ Mã Này Cho Bất Kì Ai. \n\nChúc Bạn Một Ngày Thật Tốt Lành \nNếu Có Vấn Đề Gì Xin Vui Lòng Liên Hệ Qua Số Điện Thoại: 0367219692(MR.Quang) hoặc Gmail: cuahangteamtwo@gmail.com";
                emailService.SendEmail("cuahangteamtwo@gmail.com", email, "Mã xác minh", messageBody);

                _otpCode = otp;

                MessageBox.Show("Mã OTP đã được gửi đến email của bạn. Vui lòng kiểm tra email và nhập mã OTP để hoàn tất đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi gửi mã OTP qua email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateRandomOTP()
        {
            Random random = new Random();
            return random.Next(111, 9999).ToString();
        }
        private void btn_OTP_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;

            try
            {
                using (var db = new DangKyDataContext(strcon))
                {
                    var existingAccount = db.BANG_TAI_KHOANs.SingleOrDefault(tk => tk.EMAIL == txt_Email.Text);
                    if (existingAccount != null)
                    {
                        MessageBox.Show("Email này đã tồn tại. Vui lòng sử dụng email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string otp = GenerateRandomOTP();
                SendOTPToEmail(email, otp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi kiểm tra email hoặc gửi mã OTP: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsOTPVerified(string enteredOTP)
        {
            return enteredOTP == _otpCode;
        }
        private void btn_Dang_Ky_Click(object sender, EventArgs e)
        {
            string matk = GenerateRandomCode();
            DateTime ngaytao = DateTime.Now;
            string vaitro = "Khách Hàng";
            try
            {
                if (!IsOTPVerified(txt_OTP.Text))
                {
                    MessageBox.Show("Mã OTP không chính xác. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DangKyDataContext(strcon))
                {
                    var existingAccount = db.BANG_TAI_KHOANs.SingleOrDefault(tk => tk.TAI_KHOAN == txt_Tai_Khoan.Text);
                    if (existingAccount != null)
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng sử dụng tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var existingSDT = db.KHACH_HANGs.SingleOrDefault(kh => kh.SDT == txt_SDT.Text);
                    if (existingSDT != null)
                    {
                        MessageBox.Show("Số điện thoại này đã tồn tại. Vui lòng sử dụng số điện thoại khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var existingCCCD = db.KHACH_HANGs.SingleOrDefault(kh => kh.CCCD == txt_CCCD.Text);
                    if (existingCCCD != null)
                    {
                        MessageBox.Show("CCCD này đã tồn tại. Vui lòng sử dụng CCCD khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var dktk = new BANG_TAI_KHOAN
                    {
                        VAI_TRO = vaitro,
                        TAI_KHOAN = txt_Tai_Khoan.Text,
                        MAT_KHAU = txt_Mat_Khau.Text,
                        EMAIL = txt_Email.Text,
                        MA_TAI_KHOAN = matk,
                        NGAY_TAO = ngaytao
                    };
                    db.BANG_TAI_KHOANs.InsertOnSubmit(dktk);
                    db.SubmitChanges();

                    var dkkh = new KHACH_HANG
                    {
                        MA_KHACH_HANG = matk,
                        ID_TAI_KHOAN = dktk.ID_TAI_KHOAN,
                        TEN_KHACH_HANG = txt_Ten_KH.Text,
                        SDT = txt_SDT.Text,
                        CCCD = txt_CCCD.Text,
                        DIA_CHI = txt_Dia_Chi.Text,
                        NGAY_SINH = DateTime.Parse(dtp_Ngay_Sinh.Text),
                        GIOI_TINH = cbb_Gioi_Tinh.Text
                    };
                    db.KHACH_HANGs.InsertOnSubmit(dkkh);

                    db.SubmitChanges();
                    MessageBox.Show("Quý Khách Đăng Ký Thành Công!\nQuý Khách Vui Lòng Đăng Nhập Bằng Tài Khoản Mới Tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
