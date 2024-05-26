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
    public partial class frm_Quan_Ly : Form
    {
        private string Vai_Tro;

        bool panel_LeftExpand;
        private Form currentFormChild;
        public frm_Quan_Ly(string vai_Tro)
        {
            InitializeComponent();
            Opacity = 0;
            tmr_Hien_Dan_Quan_Ly_Cua_Hang.Start();

            Vai_Tro = vai_Tro;

            if (Vai_Tro == "Nhân Viên")
            {
                btn_Quan_Ly_Khach_Hang.Visible = false;
                btn_Quan_Ly_Nhan_Vien.Visible = false;
                btn_Quan_Ly_Tai_Khoan.Visible = false;
            }

        }
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null) // Kiểm tra currentFormChild khác null
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(ChildForm);
            panel_Body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void tmr_Hien_Dan_Quan_Ly_Cua_Hang_Tick_1(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.11;
            }
            else
            {
                tmr_Hien_Dan_Quan_Ly_Cua_Hang.Stop();
            }
        }

        private void tmr_Control_Tick(object sender, EventArgs e)
        {
            if (panel_LeftExpand)
            {
                panel_Left.Width -= 10;
                if (panel_Left.Width == panel_Left.MinimumSize.Width)
                {
                    panel_LeftExpand = false;
                    tmr_Control.Stop();
                }
            }
            else
            {
                panel_Left.Width += 10;
                if (panel_Left.Width == panel_Left.MaximumSize.Width)
                {
                    panel_LeftExpand = true;
                    tmr_Control.Stop();
                }
            }
            tmr_Close.Stop();
        }

        private void menu_Control_Click_1(object sender, EventArgs e)
        {
            tmr_Control.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }


        private void btn_San_Pham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Quan_Ly_San_Pham());
            label1.Text = btn_San_Pham.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.Yellow;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void btn_Nha_Cung_Cap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Nha_Cung_Cap());
            label1.Text = btn_Nha_Cung_Cap.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.Yellow;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void btn_Nha_San_Xuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Nha_San_Xuat());
            label1.Text = btn_Nha_San_Xuat.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.Yellow;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void btn_Thong_Ke_Phieu_Nhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Thong_Ke_Phieu_Nhap());
            label1.Text = btn_Thong_Ke_Phieu_Nhap.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.Yellow;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }


        private void btn_Quan_Ly_Nhan_Vien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Quan_Ly_Nhan_Vien());
            label1.Text = btn_Quan_Ly_Nhan_Vien.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.Yellow;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void btn_Dang_Xuat_Click(object sender, EventArgs e)
        {
            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.Red;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ?", "Xác nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Thong_Ke_Hoa_Don_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Thong_Ke_Hoa_Don());
            label1.Text = btn_Thong_Ke_Hoa_Don.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.Yellow;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void btn_Thong_Ke_Phieu_Xuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Thong_Ke_Phieu_Xuat());
            label1.Text = btn_Thong_Ke_Phieu_Xuat.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.Yellow;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void tmr_Close_Tick(object sender, EventArgs e)
        {
            panel_Left.Width += 10;
            if (panel_Left.Width == panel_Left.MaximumSize.Width)
            {
                panel_LeftExpand = true;
                tmr_Control.Stop();
            }
        }

        private void btn_Quay_lai_Click(object sender, EventArgs e)
        {
            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.Coral;
            btn_Dang_Xuat.BackColor = Color.White;

            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild = null;
            }

            panel_Body.BringToFront();
            panel_Body.Visible = true;
        }

        private void btn_Khach_Hang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Quan_Ly_Khach_Hang());
            label1.Text = btn_Quan_Ly_Khach_Hang.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.Yellow;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.White;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }

        private void btn_Quan_Ly_Tai_Khoan_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Quan_Ly_Tai_Khoan());
            label1.Text = btn_Quan_Ly_Tai_Khoan.Text;
            tmr_Close.Start();

            btn_Quan_Ly_Khach_Hang.BackColor = Color.White;
            btn_San_Pham.BackColor = Color.White;
            btn_Nha_Cung_Cap.BackColor = Color.White;
            btn_Nha_San_Xuat.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Nhap.BackColor = Color.White;
            btn_Thong_Ke_Hoa_Don.BackColor = Color.White;
            btn_Thong_Ke_Phieu_Xuat.BackColor = Color.White;
            btn_Quan_Ly_Nhan_Vien.BackColor = Color.White;
            btn_Quan_Ly_Tai_Khoan.BackColor = Color.Yellow;
            btn_Quay_lai.BackColor = Color.White;
            btn_Dang_Xuat.BackColor = Color.White;
        }
    }
}
