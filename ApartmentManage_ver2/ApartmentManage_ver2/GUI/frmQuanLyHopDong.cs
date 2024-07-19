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
    public partial class frmQuanLyHopDong : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyHopDong nghiepVu;
        XuLyDuLieu xuLyDuLieu;
        String sql;
        public frmQuanLyHopDong()
        {
            InitializeComponent();
            this.dgvChiTietHopDong.DataError += new DataGridViewDataErrorEventHandler(this.dgvChiTietHopDong_DataError);
        }
      
        private void frmQuanLyHopDong_Load(object sender, EventArgs e)
        {
            xuLyDuLieu = new XuLyDuLieu();
            nghiepVu = new Bussiness__Logic.blQuanLyHopDong (this);
            nghiepVu.loadComboboxLoaiHopDong();
            nghiepVu.loadComboboxMaCanHo();
            nghiepVu.loadComboboxMaNhanVien();
            nghiepVu.loadComboboxMaHoGD();
            nghiepVu.loadComboboxMaHopDong();
            nghiepVu.hienThi();

        }

        private void txtMaHopDong_Leave(object sender, EventArgs e)
        {
            if(txtMaHopDong.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaHopDong, "Vui lòng nhập mã hợp đồng");
            }else
            {
                erpKiemTraLoi.SetError(txtMaHopDong, "");

            }
        }

        private void txtTenHopDong_Leave(object sender, EventArgs e)
        {
            if (txtTenHopDong.Text == "")
            {
                erpKiemTraLoi.SetError(txtTenHopDong, "Vui lòng nhập tên hợp đồng");
            }
            else
            {
                erpKiemTraLoi.SetError(txtTenHopDong, "");
            }
        }

        private void txtThoiHan_Leave(object sender, EventArgs e)
        {
            if (txtThoiHan.Text == "")
            {
                erpKiemTraLoi.SetError(txtThoiHan, "Vui lòng nhập thời hạn");
            }
            else
            {
                erpKiemTraLoi.SetError(txtThoiHan, "");

            }
        }

        private void txtGiaTri_Leave(object sender, EventArgs e)
        {
            if (txtGiaTri.Text == "")
            {
                erpKiemTraLoi.SetError(txtGiaTri, "Vui lòng nhập giá trị");
            }
            else
            {
                erpKiemTraLoi.SetError(txtGiaTri, "");

            }
        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNoiDung_Leave(object sender, EventArgs e)
        {
            if (txtNoiDung.Text == "")
            {
                erpKiemTraLoi.SetError(txtNoiDung, "Vui lòng nhập nội dung hợp đồng");
            }
            else
            {
                erpKiemTraLoi.SetError(txtNoiDung, "");

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraLoi())
            {
                clearAllERP();
                nghiepVu.themHopDong();
                nghiepVu.themChiTietHopDong();
                nghiepVu.hienThi();
                nghiepVu.loadComboboxMaHopDong();
            }else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.suaHopDong();
            nghiepVu.suaChiTietHopDong();
            nghiepVu.hienThi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.timHopDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaChiTietHopDong();
            nghiepVu.xoaHopDong();
            nghiepVu.hienThi();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            clearAllERP();
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
        public bool kiemTraLoi()
        {
            bool ktra = true;
            if (txtMaHopDong.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtMaHopDong, "Vui lòng nhập mã hợp đồng không bỏ trống!");
            }
            if (txtNoiDung.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtNoiDung, "Vui lòng nhập nội dung không bỏ trống!");
            }
            if (txtGiaTri.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtGiaTri, "Vui lòng nhập giá trị hợp đồng!");
            }
            if (txtTenHopDong.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtTenHopDong, "Vui lòng nhập tên hợp đồng!");
            }
            if (txtThoiHan.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtThoiHan, "Vui lòng nhập thời hạn hợp đồng!");
            }
            return ktra;
        }
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtTenHopDong, "");
            erpKiemTraLoi.SetError(txtMaHopDong, "");
            erpKiemTraLoi.SetError(txtGiaTri, "");
            erpKiemTraLoi.SetError(txtThoiHan, "");
            erpKiemTraLoi.SetError(txtNoiDung, "");
        }
        private void dgvChiTietHopDong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void cbMaCanHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox gbChiTietHopDong = (GroupBox)this.Controls["grbChiTietHopDong"];
            TextBox txtGiaTri = (TextBox)grbChiTietHopDong.Controls["txtGiaTri"];
            try
            {
                System.Windows.Forms.ComboBox cob = sender as System.Windows.Forms.ComboBox;
                if (cob != null && cob.SelectedValue != null)
                {
                    sql = "select *from CANHO where MACANHO='" + ((System.Windows.Forms.ComboBox)sender).SelectedValue.ToString() + "'";
                    DataTable dt = xuLyDuLieu.bangDuLieu(sql);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtGiaTri.Text = dr["GIACANHO"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}