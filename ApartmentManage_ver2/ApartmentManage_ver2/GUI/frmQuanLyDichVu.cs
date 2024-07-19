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
    public partial class frmQuanLyDichVu : Form
    {
        String SQL;
        XuLyDuLieu xuLyDuLieu;
        Bussiness__Logic.blQuanLyDichVu nghiepVu;
        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyDichVu(this);
            xuLyDuLieu = new XuLyDuLieu();
            try
            {
                nghiepVu.hienThi();
                nghiepVu.bindingData();
                nghiepVu.loadComboBoxTimKiemDichVu();
            }catch(ArgumentException ex)
            {
                //
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.themMoiDichVu();
            nghiepVu.hienThi();
            nghiepVu.loadComboBoxTimKiemDichVu();
            nghiepVu.bindingData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaDichVu();
            nghiepVu.hienThi();
            nghiepVu.loadComboBoxTimKiemDichVu();
            nghiepVu.bindingData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nghiepVu.suaDichVu();
            nghiepVu.hienThi();
            nghiepVu.loadComboBoxTimKiemDichVu();
            nghiepVu.bindingData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nghiepVu.TimKiemDichVu();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            nghiepVu.hienThi();
            nghiepVu.bindingData();
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

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtMadichvu.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMadichvu, "Vui lòng nhập mã dịch vụ!");
            }
            if (txtTendichvu.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTendichvu, "Vui lòng nhập tên dịch vụ!");
            }
            if (txtGia.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtGia, "Vui lòng nhập giá dịch vụ!");
            }
            return kt;
        }

        // Xóa icon ! thông báo lỗi khi người dùng đã nhập đúng định dạng
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMadichvu, "");
            erpKiemTraLoi.SetError(txtTendichvu, "");
            erpKiemTraLoi.SetError(txtGia, "");
        }

        private void txtMadichvu_Leave(object sender, EventArgs e)
        {
            if (txtMadichvu.Text == "")
            {
                erpKiemTraLoi.SetError(txtMadichvu, "Vui lòng nhập mã dịch vụ!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMadichvu, "");
            }
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            if (txtGia.Text == "")
            {
                erpKiemTraLoi.SetError(txtGia, "Vui lòng nhập giá dịch vụ!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtGia, "");
            }
        }
    }
}
