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

namespace ApartmentManage_ver2
{
    public partial class frmQuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyTaiKhoan nghiepVu;
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyTaiKhoan(this);
            nghiepVu.loadComboBoxMaNhanVien();
            nghiepVu.loadComboBoxQuyen();
            nghiepVu.loadComboBoxTimKiem();
            nghiepVu.hienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kiemTraLoi();
            clearAllERP();
            nghiepVu.themTaiKhoan();
            nghiepVu.hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaTaiKhoan();
            nghiepVu.hienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.suaTaiKhoan();
            nghiepVu.hienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nghiepVu.timKiemTaiKhoan();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            nghiepVu.hienThi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                erpKiemTraLoi.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMatKhau, "");

            }
        }
    }
}