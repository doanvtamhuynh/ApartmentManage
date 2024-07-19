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
    public partial class frmQuanLyHoGiaDinh : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyHoGiaDinh nghiepVu;
         public String gtri;

        public frmQuanLyHoGiaDinh()
        {
            InitializeComponent();
            this.dgvDanhSachHoGiaDinh.DataError += new DataGridViewDataErrorEventHandler(this.dgvDanhSachHoGiaDinh_DataError);
        }
       
        private void frmQuanLyThanhVien_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyHoGiaDinh(this);
            nghiepVu.loadComboboxMaHoGiaDinh();
            try
            {
                gtri = dgvDanhSachHoGiaDinh.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex) { }
            nghiepVu.buttonXemDanhSachTV();
           // hienThiDanhSachTV();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraLoi())
            {
                clearAllERP();
                nghiepVu.themHoGiaDinh();
                nghiepVu.hienThiHoGiaDinh();
                nghiepVu.loadComboboxMaHoGiaDinh();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chính xác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaHoGiaDinh();
            nghiepVu.hienThiHoGiaDinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.suaHoGiaDinh();
            nghiepVu.hienThiHoGiaDinh();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.timHoGiaDinh();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.hienThiHoGiaDinh();
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

        public bool kiemTraLoi()
        {
            bool ktra = true;
            if (txtMaHoGD.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtMaHoGD, "Vui lòng nhập mã hộ gia đình không bỏ trống!");
            }
            if (txtTenChuHo.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtTenChuHo, "Vui lòng nhập tên chủ hộ không bỏ trống!");
            }
            if (txtSoLuongTV.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtSoLuongTV, "Vui lòng nhập số lượng thành viên!");
            }
            if (txtSoCMND.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtSoCMND, "Vui lòng nhập số chứng minh nhân không bỏ trống!");
            }
            return ktra;
        }

        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMaHoGD, "");
            erpKiemTraLoi.SetError(txtSoCMND, "");
            erpKiemTraLoi.SetError(txtSoLuongTV, "");
            erpKiemTraLoi.SetError(txtTenChuHo, "");
        }
        private void txtSoCMND_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtSoCMND.Text, "[ ^ 0-9]"))
            {
                erpKiemTraLoi.Clear();
            }else
            {
                erpKiemTraLoi.SetError(txtSoCMND, "Vui lòng nhập số chứng minh nhân dân hợp lệ");
            }
        }
        
        private void txtSoLuongTV_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoLuongTV.Text, "[ ^ 0-9]"))
            {
                erpKiemTraLoi.Clear();
            }
            else
            {
                erpKiemTraLoi.SetError(txtSoLuongTV, "Vui lòng nhập số thành viên hợp lệ [0-9]");
            }
        }
        // nhấn button Xem trong gridview sẽ hiển thị thành viên của tứng hộ gia đình
        private void dgvDanhSachHoGiaDinh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gtri = dgvDanhSachHoGiaDinh.CurrentRow.Cells[1].Value.ToString();
            frmQuanLyThanhVien frm = new frmQuanLyThanhVien(gtri);
            frm.Show();
          // MessageBox.Show(gtri, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void hienThiDanhSachTV()
        {
           
        }

        private void txtMaHoGD_Leave(object sender, EventArgs e)
        {
            if (txtMaHoGD.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaHoGD, "Vui lòng nhập mã hộ gia đình");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMaHoGD, "");
            }
        }

        private void txtTenChuHo_Leave(object sender, EventArgs e)
        {
            if (txtTenChuHo.Text == "")
            {
                erpKiemTraLoi.SetError(txtTenChuHo, "Vui lòng nhập tên chủ hộ");
            }
            else
            {
                erpKiemTraLoi.SetError(txtTenChuHo, "");
            }
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuongTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvDanhSachHoGiaDinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}