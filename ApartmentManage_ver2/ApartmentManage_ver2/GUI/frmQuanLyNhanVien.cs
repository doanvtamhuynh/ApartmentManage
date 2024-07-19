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
using System.Text.RegularExpressions;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyNhanVien nghiepVu;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            this.dgvDanhSachNhanVien.DataError += new DataGridViewDataErrorEventHandler(this.dgvDanhSachNhanVien_DataError);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, pattern)){
                erpKiemTraLoi.Clear();
            }
            else
            {
                erpKiemTraLoi.SetError(txtEmail, "Vui lòng nhập email hợp lệ!");
            }
        }


        private void txtSoDienThoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyNhanVien(this);
            nghiepVu.loadComboBoxPhongBan();
            nghiepVu.loadComboBoxTimKiem();
            nghiepVu.hienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.themNhanVien();
            nghiepVu.hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaNhanVien();
            nghiepVu.hienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.suaNhanVien();
            nghiepVu.hienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nghiepVu.timKiemNhanVien();
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

        private void ptbAnhNhanVien_DoubleClick(object sender, EventArgs e)
        {
            nghiepVu.loadAnhNhanVien();
        }

        private void dgvDanhSachNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtMaNhanVien.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMaNhanVien, "Vui lòng nhập mã nhân viên!");
            }
            if (txtHoTen.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtHoTen, "Vui lòng nhập họ tên!");
            }
            if (txtDiaChi.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtDiaChi, "Vui lòng nhập địa chỉ!");
            }
            if (txtSoDienThoai.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại!");
            }
            if (txtSoCMND.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtSoCMND, "Vui lòng nhập số CMND!");
            }
            return kt;
        }

        // Xóa icon ! thông báo lỗi khi người dùng đã nhập đúng định dạng
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMaNhanVien, "");
            erpKiemTraLoi.SetError(txtHoTen, "");
            erpKiemTraLoi.SetError(txtDiaChi, "");
            erpKiemTraLoi.SetError(txtSoDienThoai, "");
            erpKiemTraLoi.SetError(txtSoCMND, "");
        }

        private void txtMaNhanVien_Leave(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaNhanVien, "Vui lòng nhập mã nhân viên!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMaNhanVien, "");
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                erpKiemTraLoi.SetError(txtHoTen, "Vui lòng nhập họ tên!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtHoTen, "");
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                erpKiemTraLoi.SetError(txtDiaChi, "Vui lòng nhập địa chỉ!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtDiaChi, "");
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                erpKiemTraLoi.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtSoDienThoai, "");
            }
        }

        private void txtSoCMND_Leave(object sender, EventArgs e)
        {
            if (txtSoCMND.Text == "")
            {
                erpKiemTraLoi.SetError(txtSoCMND, "Vui lòng nhập số CMND!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtSoCMND, "");
            }
        }
    }
}