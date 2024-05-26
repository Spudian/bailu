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
using DAL;

namespace MI_AN_LIEN_LIN_Q
{
    public partial class frm_Chon_Vai_Tro : Form
    {

        private string Vai_Tro = "";

        public frm_Chon_Vai_Tro()
        {
            InitializeComponent();
            Opacity = 0;
            tmr_Hien_Dan_Chon_Vai_Tro.Start();

             // tạo timer hiệu ứng ẩn
            tmr_An_Dan_Chon_Vai_Tro = new Timer();
            tmr_An_Dan_Chon_Vai_Tro.Interval = 50; // Đặt khoảng tg  50 mili giây
            tmr_An_Dan_Chon_Vai_Tro.Tick += new EventHandler(tmr_An_Dan_Chon_Vai_Tro_Tick);
        }




        private void btn_Dang_Nhap_Khach_HangClick(object sender, EventArgs e)
        {
            Vai_Tro = "Khách Hàng";
            frm_Dang_Nhap dnkh = new frm_Dang_Nhap(Vai_Tro);
            Hide();
            dnkh.ShowDialog();
            Show();
        }


        private void btn_Dang_Nhap_Nhan_Vien_Click(object sender, EventArgs e)
        {

            Vai_Tro = "Nhân Viên";
            frm_Dang_Nhap dnkh = new frm_Dang_Nhap(Vai_Tro);
            Hide();
            dnkh.ShowDialog();
            Show();
        }

        private void btn_Dang_Nhap_Quan_Ly_Click(object sender, EventArgs e)
        {
            Vai_Tro = "Quản Lý";
            frm_Dang_Nhap dnkh = new frm_Dang_Nhap(Vai_Tro);
            Hide();
            dnkh.ShowDialog();
            Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ?", "Xác nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                tmr_An_Dan_Chon_Vai_Tro.Start();
            }
        }

  
        private void tmr_Hien_Dan_Chon_Vai_Tro_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += 0.09;
            else
                tmr_Hien_Dan_Chon_Vai_Tro.Stop();
        }

        private void tmr_An_Dan_Chon_Vai_Tro_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.11;
            }
            else
            {
                tmr_An_Dan_Chon_Vai_Tro.Stop();
                Close();
            }
        }

        private void ptb_Thoat_Dang_Nhap_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ?", "Xác nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                tmr_An_Dan_Chon_Vai_Tro.Start();
            }
        }
    }
}
