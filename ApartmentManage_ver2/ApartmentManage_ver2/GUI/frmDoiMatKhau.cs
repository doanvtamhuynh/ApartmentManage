using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blDoiMatKhau nghiepVu;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blDoiMatKhau(this);

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.doiMatKhau();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy đổi mật khẩu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtTenDangNhap.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập!");
            }
            if (txtMatKhauCu.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMatKhauCu, "Vui lòng nhập mật khẩu cũ!");
            }
            if (txtMatKhauMoi.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMatKhauMoi, "Vui lòng nhập mật khẩu mới!");
            }
            if (txtXacNhanMatKhauMoi.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtXacNhanMatKhauMoi, "Vui lòng xác nhận mật khẩu mới!");
            }
            return kt;
        }

        // Xóa icon ! thông báo lỗi khi người dùng đã nhập đúng định dạng
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtTenDangNhap, "");
            erpKiemTraLoi.SetError(txtMatKhauCu, "");
            erpKiemTraLoi.SetError(txtMatKhauMoi, "");
            erpKiemTraLoi.SetError(txtXacNhanMatKhauMoi, "");
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                erpKiemTraLoi.SetError(txtMatKhauMoi, "Vui lòng nhập mật khẩu mới!");
            }else
            {
                erpKiemTraLoi.SetError(txtMatKhauMoi, "");
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                erpKiemTraLoi.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtTenDangNhap, "");
            }
        }

        private void txtMatKhauCu_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                erpKiemTraLoi.SetError(txtMatKhauCu, "Vui lòng nhập mật khẩu cũ!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMatKhauCu, "");
            }
        }

        private void txtXacNhanMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhauMoi.Text.Equals(txtMatKhauMoi.Text))
            {
                erpKiemTraLoi.SetError(txtXacNhanMatKhauMoi, "");
            }
            else
            {
                erpKiemTraLoi.SetError(txtXacNhanMatKhauMoi, "Mật khẩu xác nhận không khớp!");
            }
        }
    }
}