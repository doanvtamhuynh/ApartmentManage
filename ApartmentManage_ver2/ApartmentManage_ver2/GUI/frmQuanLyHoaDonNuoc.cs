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
    public partial class frmQuanLyHoaDonNuoc : Form
    {
        String SQL;
        XuLyDuLieu XuLyDuLieu;
        Bussiness__Logic.blQuanLyHoaDonNuoc nghiepVu;
        public frmQuanLyHoaDonNuoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoaDonNuoc_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyHoaDonNuoc(this);
            XuLyDuLieu = new XuLyDuLieu();
            try
            {
                nghiepVu.hienThi();
                nghiepVu.bindingData();
                nghiepVu.loadComboBoxMaCanHo();
                nghiepVu.loadComboBoxMaNhanVien();
                nghiepVu.loadComboBoxMaHoGiaDinh();
                nghiepVu.loadComboBoxTimKiemHoaDonNuoc();
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
            nghiepVu.themMoiHoaDonNuoc();
            nghiepVu.themMoiChiTietHoaDonNuoc();
            nghiepVu.loadComboBoxTimKiemHoaDonNuoc();
            nghiepVu.hienThi();
            nghiepVu.bindingData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiepVu.xoaChiTietHoaDonNuoc();
            nghiepVu.xoaHoaDonNuoc();
            nghiepVu.hienThi();
            nghiepVu.bindingData();
            nghiepVu.loadComboBoxTimKiemHoaDonNuoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nghiepVu.TimKiemChiTietHoaDonNuocTheoMaHoaDon();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            nghiepVu.SuaHoaDonNuoc();
            nghiepVu.SuaChiTietHoaDonNuoc();
            nghiepVu.hienThi();
            nghiepVu.bindingData();
        }

        private void dgvDanhSachChiTietHoaDonNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dgvDanhSachChiTietHoaDonNuoc.Rows[e.RowIndex];
                try
                {
                    string a = dgv.Cells[8].Value.ToString();
                    float b = float.Parse(a) * (1 + 0.1f);
                    string c = Convert.ToString(b);
                    txtTongTien.Text = c;
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("CHƯA CÓ DỮ LIỆU");
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtMaHoaDonNuoc.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtMaHoaDonNuoc, "Vui lòng nhập mã hoá đơn nước!");
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
            erpKiemTraLoi.SetError(txtMaHoaDonNuoc, "");
            erpKiemTraLoi.SetError(txtTenHoaDon, "");
            erpKiemTraLoi.SetError(txtTenNhanVien, "");
            erpKiemTraLoi.SetError(txtTenChuHo, "");
            erpKiemTraLoi.SetError(txtTenCanHo, "");
        }

        private void txtMaHoaDonNuoc_Leave(object sender, EventArgs e)
        {
            if (txtMaHoaDonNuoc.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaHoaDonNuoc, "Vui lòng nhập mã hoá đơn nước");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMaHoaDonNuoc, "");
            }
        }

        private void txtTenHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtTenHoaDon.Text == "")
            {
                erpKiemTraLoi.SetError(txtTenHoaDon, "Vui lòng nhập tên hoá đơn nước");
            }
            else
            {
                erpKiemTraLoi.SetError(txtTenHoaDon, "");
            }
        }
    }
}
