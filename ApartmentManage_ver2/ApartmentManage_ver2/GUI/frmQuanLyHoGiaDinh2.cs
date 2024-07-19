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
    public partial class frmQuanLyHoGiaDinh : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyHoGiaDinh nghiepVu;
        public frmQuanLyHoGiaDinh()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoGiaDinh_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyHoGiaDinh(this);
            //nghiepVu.loadComboboxMaHoGD();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kiemTraLoi();
            clearAllERP();
            nghiepVu.themHoGiaDinh();
            nghiepVu.hienThiHoGiaDinh();
            clearAllField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           // nghiepVu.xoaHoGiaDinh();
            nghiepVu.hienThiHoGiaDinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //nghiepVu.suaHoGiaDinh();
            nghiepVu.hienThiHoGiaDinh();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //nghiepVu.timHoGiaDinh();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            nghiepVu.hienThiHoGiaDinh();
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
        private void clearAllField()
        {
            txtMaHoGD.Text = "";
            txtSoCMND.Text = "";
            txtTenChuHo.Text = "";
            txtSoLuongTV.Text = "";
        }
        public bool kiemTraLoi()
        {
            bool ktra = true;
            if (txtMaHoGD.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtMaHoGD, "Vui lòng nhập mã hộ gia đình!");
            }
            if (txtTenChuHo.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtTenChuHo, "Vui lòng nhập tên chủ hộ!");
            }
            if (txtSoCMND.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtTenChuHo, "Vui lòng nhập số chứng minh nhân dân cua chủ hộ!");
            }
            if (txtSoLuongTV.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtTenChuHo, "Vui lòng nhập số lượng thành viên!");
            }
            return ktra;
        }
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMaHoGD, "");
            erpKiemTraLoi.SetError(txtTenChuHo, "");
            erpKiemTraLoi.SetError(txtSoCMND, "");
            erpKiemTraLoi.SetError(txtSoLuongTV, "");
        }
    }
}