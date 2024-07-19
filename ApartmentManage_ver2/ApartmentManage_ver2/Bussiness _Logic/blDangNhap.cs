using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blDangNhap
    {
        Data_Access.daDangNhap daDangNhap;
        Form frmDangNhap;
        public blDangNhap(Form f)
        {
            this.frmDangNhap = f;
            daDangNhap = new Data_Access.daDangNhap();
        }

        public void hienThi()
        {
            TextBox txtTenDangNhap = (TextBox)this.frmDangNhap.Controls["txtTenDangNhap"];
            TextBox txtMatKhau = (TextBox)this.frmDangNhap.Controls["txtMatKhau"];

            if (daDangNhap.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text, "ADMIN") > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmDangNhap.Hide();
                GUI.frmMain frm = new GUI.frmMain();
                frm.Show();
                frm.bbtnDangNhap.Enabled = false;
                frm.ribPageQuanLy.Visible = false;
                frm.ribPageThongKe.Visible = false;
                frm.ribPageTraCuu.Visible = false;
                frm.Text = "HAPPINESS HOME - ADMIN";
            }
            else
            if (daDangNhap.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text, "QuanLy") > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmDangNhap.Hide();
                GUI.frmMain frm = new GUI.frmMain();
                frm.Show();
                frm.bbtnQuanLyTaiKhoan.Enabled = false;
                frm.bbtnDangNhap.Enabled = false;
                frm.Text = "HAPPINESS HOME - Ban Quản lý";
            }
            else
            if (daDangNhap.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text, "NhanVien") > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmDangNhap.Hide();
                GUI.frmMain frm = new GUI.frmMain();
                frm.Show();
                frm.bbtnQuanLyTaiKhoan.Enabled = false;
                frm.bbtnDangNhap.Enabled = false;
                frm.bbtnQuanLyNhanVien.Enabled = false;             
                frm.Text = "HAPPINESS HOME - Nhân Viên";
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu hoặc tài khoản!");
            }
        }

        public void Thoat()
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
