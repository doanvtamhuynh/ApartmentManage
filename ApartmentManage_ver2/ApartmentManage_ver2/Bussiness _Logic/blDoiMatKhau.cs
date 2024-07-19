using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blDoiMatKhau
    {
        Data_Access.daDoiMatKhau daDoiMatKhau;
        Form frmDoiMatKhau;

        public blDoiMatKhau(Form f)
        {
            this.frmDoiMatKhau = f;
            daDoiMatKhau = new Data_Access.daDoiMatKhau();
        }

        public void doiMatKhau()
        {
            GroupBox grb = (GroupBox)this.frmDoiMatKhau.Controls["grbDoiMatKhau"];
            TextBox txtTenDangNhap = (TextBox)grb.Controls["txtTenDangNhap"];
            TextBox txtMatKhauCu = (TextBox)grb.Controls["txtMatKhauCu"];
            TextBox txtMatKhauMoi = (TextBox)grb.Controls["txtMatKhauMoi"];
            TextBox txtXacNhanMatKhauMoi = (TextBox)grb.Controls["txtXacNhanMatKhauMoi"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daDoiMatKhau.doiMatKhau(txtTenDangNhap.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text, txtXacNhanMatKhauMoi.Text))
                {
                    clearAllField();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa bị thay đổi!");
                }
            }
        }
        //Xóa các chữ đã nhập trong textbox khi thực hiện thành công!
        public void clearAllField()
        {
            GroupBox grb = (GroupBox)this.frmDoiMatKhau.Controls["grbDoiMatKhau"];
            TextBox txtTenDangNhap = (TextBox)grb.Controls["txtTenDangNhap"];
            TextBox txtMatKhauCu = (TextBox)grb.Controls["txtMatKhauCu"];
            TextBox txtMatKhauMoi = (TextBox)grb.Controls["txtMatKhauMoi"];
            TextBox txtXacNhanMatKhauMoi = (TextBox)grb.Controls["txtXacNhanMatKhauMoi"];

            txtTenDangNhap.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXacNhanMatKhauMoi.Text = "";
        }

    }
}
