using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmDangNhap : Form
    {
        Bussiness__Logic.blDangNhap nghiepVu;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blDangNhap(this);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.hienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            nghiepVu.Thoat();
        }

        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtTenDangNhap.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập!");
            }
            if (txtMatKhau.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
            }
            return kt;
        }

        // Xóa icon ! thông báo lỗi khi người dùng đã nhập đúng định dạng
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtTenDangNhap, "");
            erpKiemTraLoi.SetError(txtMatKhau, "");
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

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                erpKiemTraLoi.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMatKhau, "");
            }
        }
    }
}
