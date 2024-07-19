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
    public partial class frmQuanLyThanhVien : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyThanhVien nghiepVu;
        String maHoGD;
        public frmQuanLyThanhVien()
        {
            InitializeComponent();
            this.dgvDanhSachThanhVien.DataError += new DataGridViewDataErrorEventHandler(this.dgvDanhSachThanhVien_DataError);
        }

        public frmQuanLyThanhVien(String maHoGiaDinh)
        {
            InitializeComponent();
            this.maHoGD = maHoGiaDinh;
        }
        private void frmQuanLyThanhVien_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyThanhVien(this);
            nghiepVu.loadComBoboxMaHoGD();
            nghiepVu.loadComboboxMaThanhVien();
            // nghiepVu.hienThi();
            try
            {
                nghiepVu.hienThiDanhSachThanhVienTheoHoGiaDinh(maHoGD);
            }
            catch (Exception ex) { };
          //  hienThiDanhSachThanhVienTheoHoGD(maHoGD);
        }
  
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMaTV, "");
            erpKiemTraLoi.SetError(txtMaTV, "");
            erpKiemTraLoi.SetError(txtHoTen, "");
            erpKiemTraLoi.SetError(txtSoCMND, "");
            erpKiemTraLoi.SetError(txtSoDienThoai, "");
            erpKiemTraLoi.SetError(txtEmail, "");
        }
        public bool kiemTraLoi()
        {
            bool ktra = true;
            if (txtMaTV.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtMaTV, "Vui lòng nhập mã thành viên không bỏ trống!");
            }
            if (txtHoTen.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtHoTen, "Vui lòng nhập họ tên không bỏ trống!");
            }
            if (txtSoCMND.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtSoCMND, "Vui lòng nhập số chứng minh nhân!");
            }
            if (txtSoDienThoai.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtSoDienThoai, "Vui lòng nhập số diện thoại không bỏ trống!");
            }
            if (txtEmail.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtEmail, "Vui lòng nhập email không bỏ trống!");
            }
            return ktra;
        }
       

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraLoi())
            {
                clearAllERP();
                nghiepVu.themThanhVien();
                nghiepVu.hienThi();
                nghiepVu.loadComBoboxMaHoGD();
                nghiepVu.loadComboboxMaThanhVien();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chính xác để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ptbHinhAnh_Click(object sender, EventArgs e)
        {
            nghiepVu.pictureBoxHinhAnh();
        }

        private void dgvDanhSachThanhVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.hienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.suaThanhVien();
            nghiepVu.hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.xoaThanhVien();
            nghiepVu.hienThi();
            nghiepVu.loadComboboxMaThanhVien();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            clearAllERP();
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.timThanhVien();
        }


        private void txtMaTV_Leave(object sender, EventArgs e)
        {
            if (txtMaTV.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaTV, "Vui lòng nhập mã thành viên");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMaTV, "");

            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                erpKiemTraLoi.SetError(txtHoTen, "Vui lòng nhập họ tên");
            }
            else
            {
                erpKiemTraLoi.SetError(txtHoTen, "");

            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                erpKiemTraLoi.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại");
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
                erpKiemTraLoi.SetError(txtSoCMND, "Vui lòng nhập số chứng minh nhân dân");
            }
            else
            {
                erpKiemTraLoi.SetError(txtSoCMND, "");

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                erpKiemTraLoi.SetError(txtEmail, "Vui lòng nhập email");
            }
            else
            {
                erpKiemTraLoi.SetError(txtEmail, "");

            }
        }
    }
}