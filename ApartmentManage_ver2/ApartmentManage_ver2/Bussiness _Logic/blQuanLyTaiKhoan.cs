using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyTaiKhoan
    {
        Data_Access.daQuanLyTaiKhoan daQuanLyTaiKhoan;
        Form frmQuanLyTaiKhoan;
        public blQuanLyTaiKhoan(Form f)
        {
            this.frmQuanLyTaiKhoan = f;
            daQuanLyTaiKhoan = new Data_Access.daQuanLyTaiKhoan();
        }

        public void loadComboBoxMaNhanVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            cobMaNhanVien.DataSource = daQuanLyTaiKhoan.loadComboboxMaNhanVien();
            cobMaNhanVien.ValueMember = "MANHANVIEN";
            cobMaNhanVien.DisplayMember = "MANVHOTEN";
        }

        public void loadComboBoxQuyen()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            ComboBox cobQuyen = (ComboBox)grbThongTin.Controls["cobQuyen"];
            cobQuyen.DataSource = daQuanLyTaiKhoan.loadComboboxQuyen();
            cobQuyen.ValueMember = "IDQUYEN";
            cobQuyen.DisplayMember = "IDQUYEN";
        }

        public void loadComboBoxTimKiem()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            ComboBox cobTimKiem = (ComboBox)this.frmQuanLyTaiKhoan.Controls["cobTimKiem"];
            cobTimKiem.DataSource = daQuanLyTaiKhoan.danhSachTaiKhoan();
            cobTimKiem.ValueMember = "TENDANGNHAP";
            cobTimKiem.DisplayMember = "TENDANGNHAP";
        }

        public void hienThi()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbDanhSach"];
            DataGridView dgvDanhSachTaiKhoan = (DataGridView)grbDanhSach.Controls["dgvDanhSachTaiKhoan"];
            dgvDanhSachTaiKhoan.DataSource = daQuanLyTaiKhoan.danhSachTaiKhoan();
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobQuyen = (ComboBox)grbThongTin.Controls["cobQuyen"];
            TextBox txtTenDangNhap = (TextBox)grbThongTin.Controls["txtTenDangNhap"];
            TextBox txtMatKhau = (TextBox)grbThongTin.Controls["txtMatKhau"];
            cobMaNhanVien.DataBindings.Clear();
            cobMaNhanVien.DataBindings.Add("SelectedValue", dgvDanhSachTaiKhoan.DataSource, "MANHANVIEN");
            cobQuyen.DataBindings.Clear();
            cobQuyen.DataBindings.Add("SelectedValue", dgvDanhSachTaiKhoan.DataSource, "IDQUYEN");
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", dgvDanhSachTaiKhoan.DataSource, "TENDANGNHAP");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvDanhSachTaiKhoan.DataSource, "MATKHAU");
        }

        public void themTaiKhoan()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobQuyen = (ComboBox)grbThongTin.Controls["cobQuyen"];
            TextBox txtTenDangNhap = (TextBox)grbThongTin.Controls["txtTenDangNhap"];
            TextBox txtMatKhau = (TextBox)grbThongTin.Controls["txtMatKhau"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thêm tài khoản này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyTaiKhoan.themTaiKhoan(cobMaNhanVien.SelectedValue.ToString(), txtTenDangNhap.Text,
                    txtMatKhau.Text, cobQuyen.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể thêm tài khoản này!");
                }
            }
        }

        public void xoaTaiKhoan()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            TextBox txtTenDangNhap = (TextBox)grbThongTin.Controls["txtTenDangNhap"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa tài khoản này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyTaiKhoan.xoaTaiKhoan(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể xóa tài khoản này!");
                }
            }
        }

        public void suaTaiKhoan()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobQuyen = (ComboBox)grbThongTin.Controls["cobQuyen"];
            TextBox txtTenDangNhap = (TextBox)grbThongTin.Controls["txtTenDangNhap"];
            TextBox txtMatKhau = (TextBox)grbThongTin.Controls["txtMatKhau"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn sửa tài khoản này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyTaiKhoan.suaTaiKhoan(cobMaNhanVien.SelectedValue.ToString(), txtTenDangNhap.Text,
                    txtMatKhau.Text, cobQuyen.SelectedValue.ToString()))
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể sửa tài khoản này!");
                }
            }
        }

        public void timKiemTaiKhoan()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyTaiKhoan.Controls["grbDanhSach"];
            DataGridView dgvDanhSachTaiKhoan = (DataGridView)grbDanhSach.Controls["dgvDanhSachTaiKhoan"];
            ComboBox cobTimKiem = (ComboBox)this.frmQuanLyTaiKhoan.Controls["cobTimKiem"];
            dgvDanhSachTaiKhoan.DataSource = daQuanLyTaiKhoan.timKiemTaiKhoan(cobTimKiem.SelectedValue.ToString());
        }

    }
}
