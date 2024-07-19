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
    public partial class frmQuanLyHoaDonDichVu : Form
    {
        String SQL;
        XuLyDuLieu XuLyDuLieu;
        Bussiness__Logic.blQuanLyHoaDonDichVu nghiepVu;
        public frmQuanLyHoaDonDichVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoaDonDichVu_Load(object sender, EventArgs e)
        {
            XuLyDuLieu = new XuLyDuLieu();
            nghiepVu = new Bussiness__Logic.blQuanLyHoaDonDichVu(this);
            try
            {
                nghiepVu.hienThi();
                nghiepVu.bindingData();
                nghiepVu.loadComboBoxMaNhanVien();
                nghiepVu.loadComboBoxMaCanHo();
                nghiepVu.loadComboBoxMaHoGiaDinh();
                nghiepVu.loadComboBoxMaDichVu();
                nghiepVu.loadComboBoxTimKiemHoaDonDichVu();
            }catch(NullReferenceException ex)
            {
                //
            }
        }

        private void cobMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox grbThongTin = (GroupBox)this.Controls["grbThongTin"];
            TextBox txtTenNV = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            try
            {
                ComboBox cob = sender as ComboBox;
                if (cob != null && cob.SelectedValue != null)
                {
                    SQL = " select * from NHANVIEN where MANHANVIEN='" + ((ComboBox)sender).SelectedValue.ToString() + "'";

                    DataTable dt = XuLyDuLieu.bangDuLieu(SQL);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtTenNV.Text = dr["HOTEN"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void cobMaHoGiaDinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox grbThongTin = (GroupBox)this.Controls["grbThongTin"];
            TextBox txtTenChu = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            try
            {
                ComboBox cob = sender as ComboBox;
                if (cob != null && cob.SelectedValue != null)
                {
                    SQL = " select * from HOGIADINH where MAHOGD='" + ((ComboBox)sender).SelectedValue.ToString() + "'";

                    DataTable dt = XuLyDuLieu.bangDuLieu(SQL);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtTenChu.Text = dr["TENCHUHO"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void cobMaCanHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox grbThongTin = (GroupBox)this.Controls["grbThongTin"];
            TextBox txtTenCan = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            try
            {
                ComboBox cob = sender as ComboBox;
                if (cob != null && cob.SelectedValue != null)
                {
                    SQL = " select * from CANHO where MACANHO='" + ((ComboBox)sender).SelectedValue.ToString() + "'";

                    DataTable dt = XuLyDuLieu.bangDuLieu(SQL);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtTenCan.Text = dr["TENCANHO"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearAllERP();
            kiemTraLoi();
            nghiepVu.themMoiHoaDonDichVU();
            nghiepVu.themMoiChiTietHoaDonDichVU();
            nghiepVu.loadComboBoxTimKiemHoaDonDichVu();
            nghiepVu.hienThi();
            nghiepVu.bindingData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaChiTietHoaDonDichVu();
            nghiepVu.xoaHoaDonDichVu();
            nghiepVu.loadComboBoxTimKiemHoaDonDichVu();
            nghiepVu.hienThi();
            nghiepVu.bindingData();
            if (dgvDanhSachChiTietHoaDonDichVu.RowCount == 0) clearAllField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nghiepVu.SuaHoaDonDichVu();
            nghiepVu.SuaChiTietHoaDonDichVu();
            nghiepVu.loadComboBoxTimKiemHoaDonDichVu();
            nghiepVu.hienThi();
            nghiepVu.bindingData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nghiepVu.TimKiemChiTietHoaDonDichVuTheoMaHoaDon();
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

        private void dgvDanhSachChiTietHoaDonDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDanhSachChiTietHoaDonDichVu.RowCount != 0)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgv = dgvDanhSachChiTietHoaDonDichVu.Rows[e.RowIndex];
                    try
                    {
                        
                        string a = dgv.Cells[9].Value.ToString();
                        float b = float.Parse(a) * (1 + 0.1f);
                        string c = Convert.ToString(b);
                        txtTongTien.Text = c;
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("CHƯA CÓ DỮ LIỆU");
                    }
                }
            }
            else
            {
                MessageBox.Show("CHƯA CÓ DỮ LIỆU");
            }
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtMaHoaDonDichVu.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMaHoaDonDichVu, "Vui lòng nhập mã hoá đơn!");
            }
            if (txtTenHoaDon.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTenHoaDon, "Vui lòng nhập tên hoá đơn!");
            }
            if (txtTenNhanVien.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTenNhanVien, "Vui lòng nhập tên nhân viên!");
            }
            if (txtTenChuHo.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTenChuHo, "Vui lòng nhập tên chủ hộ!");
            }
            if (txtTenCanHo.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtTenCanHo, "Vui lòng nhập tên căn hộ!");
            }
            return kt;
        }

        // Xóa icon ! thông báo lỗi khi người dùng đã nhập đúng định dạng
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMaHoaDonDichVu, "");
            erpKiemTraLoi.SetError(txtTenHoaDon, "");
            erpKiemTraLoi.SetError(txtTenNhanVien, "");
            erpKiemTraLoi.SetError(txtTenChuHo, "");
            erpKiemTraLoi.SetError(txtTenCanHo, "");
        }

        private void cobMaDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.Controls["grbThongTinChiTiet"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            try
            {
                ComboBox cob = sender as ComboBox;
                if (cob != null && cob.SelectedValue != null)
                {
                    SQL = " select * from DICHVU where MADICHVU='" + ((ComboBox)sender).SelectedValue.ToString() + "'";

                    DataTable dt = XuLyDuLieu.bangDuLieu(SQL);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtDongia.Text = dr["GIADICHVU"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void clearAllField()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.Controls["grbThongTin"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDDV = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDDV"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtGhiChuHoaDonDichVu = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDichVu"];
            TextBox txtTongTien = (TextBox)this.Controls["txtTongTien"];
            txtMaHoaDonDichVu.Text = "";

        }

        private void txtMaHoaDonDichVu_Leave(object sender, EventArgs e)
        {
            if (txtMaHoaDonDichVu.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaHoaDonDichVu, "Vui lòng nhập tên hoá đơn!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMaHoaDonDichVu, "");
            }
        }
    }
}
