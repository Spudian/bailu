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

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Dang_Nhap : Form
    {
        private string Vai_Tro;

        public frm_Dang_Nhap(string vai_Tro)
        {
            InitializeComponent();
          
            Vai_Tro = vai_Tro;
            if(Vai_Tro == "Khách Hàng")
            {
                btn_Tao_Tai_Khoan.Visible = true;
            }
            if (Vai_Tro == "Nhân Viên")
            {
                btn_Tao_Tai_Khoan.Visible = false;
            }
            if (Vai_Tro == "Quản Lý")
            {
                btn_Tao_Tai_Khoan.Visible = false;
            }


            Opacity = 0;
            tmr_Hien_Dan_Dang_Nhap.Start();

            // tạo timer hiệu ứng ẩn
            tmr_An_Dan_Dang_Nhap = new Timer();
            tmr_An_Dan_Dang_Nhap.Interval = 50; // Đặt khoảng tg  50 mili giây
            tmr_An_Dan_Dang_Nhap.Tick += new EventHandler(tmr_An_Dan_Dang_Nhap_Tick);
        }

        private void btn_Dang_Nhap_Click(object sender, EventArgs e)
        {
            if (txt_Tai_Khoan_Khach_Hang.Text != "" && txt_Mat_Khau_Khach_Hang.Text != "")
            {
                DangNhapBUS dn = new DangNhapBUS();
                if (dn.checkLogin(txt_Tai_Khoan_Khach_Hang.Text.Trim(), txt_Mat_Khau_Khach_Hang.Text.Trim(), "Khách Hàng"))
                {             
                    if (Vai_Tro == "Khách Hàng")
                    {
                        MessageBox.Show("Xin Chúc Mừng Bạn Đã Đăng Nhập Khách Hàng Thành Công !!!", "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_Xem_San_Pham msp = new frm_Xem_San_Pham();
                        this.Hide();
                        msp.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập không đúng Vai Trò !!!", "Đăng Nhập Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (dn.checkLogin(txt_Tai_Khoan_Khach_Hang.Text.Trim(), txt_Mat_Khau_Khach_Hang.Text.Trim(), "Nhân Viên"))
                {
                    if (Vai_Tro == "Nhân Viên")
                    {
                        MessageBox.Show("Xin Chúc Mừng Bạn Đã Đăng Nhập Nhân Viên Thành Công !!!", "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_Quan_Ly qlsp = new frm_Quan_Ly(Vai_Tro);
                        this.Hide();
                        qlsp.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập không đúng Vai Trò !!!", "Đăng Nhập Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (dn.checkLogin(txt_Tai_Khoan_Khach_Hang.Text.Trim(), txt_Mat_Khau_Khach_Hang.Text.Trim(), "Quản Lý"))
                {
                    if (Vai_Tro == "Quản Lý")
                    {
                        MessageBox.Show("Xin Chúc Mừng Bạn Đã Đăng Nhập Quản Lý Thành Công !!!", "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_Quan_Ly qlch = new frm_Quan_Ly(Vai_Tro);
                        this.Hide();
                        qlch.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập không đúng Vai Trò !!!", "Đăng Nhập Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng Nhập không thành công !!!", "Đăng Nhập Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txt_Tai_Khoan_Khach_Hang.Text = "";
                txt_Mat_Khau_Khach_Hang.Text = "";          
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ", "Xin Đăng Nhập Đầy Đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Quen_Mat_Khau_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn tìm lại mật khẩu ?", "Xác nhận Quên Mật Khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                frm_Quen_Mat_Khau qmk = new frm_Quen_Mat_Khau();
                this.Hide();
                qmk.ShowDialog();
                this.Show();
            }
        }


        private void btn_Tao_Tai_Khoan_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn tạo tài khoản ?", "Xác nhận tạo tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                frm_Tao_Tai_Khoan_Khach_Hang ttk = new frm_Tao_Tai_Khoan_Khach_Hang();
                this.Hide();
                ttk.ShowDialog();
                this.Show();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ?", "Xác nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                tmr_An_Dan_Dang_Nhap.Start();
            }
        }


        private void btn_Thoat_Khoi_Ung_Dung_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng không??? ?", "Xác nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
            }
        }


        private void tmr_Hien_Dan_Dang_Nhap_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += 0.09;
            else
                tmr_Hien_Dan_Dang_Nhap.Stop();
        }

        private void tmr_An_Dan_Dang_Nhap_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.11;
            }
            else
            {
                tmr_An_Dan_Dang_Nhap.Stop();
                Close();
            }
        }

        private void btn_Doi_Mat_Khau_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc muốn Đổi Mật Khẩu Mới Không ???", "Xác nhận tạo tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                frm_Doi_Mat_Khau dmk = new frm_Doi_Mat_Khau();
                this.Hide();
                dmk.ShowDialog();
                this.Show();
            }
        }
    }
}
