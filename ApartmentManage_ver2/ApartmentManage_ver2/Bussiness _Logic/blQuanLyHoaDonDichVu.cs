using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyHoaDonDichVu
    {
        XuLyDuLieu XuLyDuLieu;
        Data_Access.daQuanLyHoaDonDichVu daQuanLyHoaDonDichVu;
        Form frmQuanLyHoaDonDichVu;
        DataTable tableHDD;

        public blQuanLyHoaDonDichVu(Form f)
        {
            this.frmQuanLyHoaDonDichVu = f;
            daQuanLyHoaDonDichVu = new Data_Access.daQuanLyHoaDonDichVu();
            XuLyDuLieu = new XuLyDuLieu();
        }

        public void loadComboBoxMaNhanVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            cobMaNhanVien.DataSource = daQuanLyHoaDonDichVu.loadComboboxMaNhanVien();
            cobMaNhanVien.ValueMember = "MANHANVIEN";
            cobMaNhanVien.DisplayMember = "MANHANVIEN";
        }

        public void loadComboBoxMaHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            cobMaHoGiaDinh.DataSource = daQuanLyHoaDonDichVu.loadComboboxMaHoGiaDinh();
            cobMaHoGiaDinh.DisplayMember = "MAHOGD";
            cobMaHoGiaDinh.ValueMember = "MAHOGD";
        }

        public void loadComboBoxMaCanHo()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            cobMaCanHo.DataSource = daQuanLyHoaDonDichVu.loadComboboxMaCanHo();
            cobMaCanHo.DisplayMember = "MACANHO";
            cobMaCanHo.ValueMember = "MACANHO";
        }

        public void loadComboBoxMaDichVu()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTinChiTiet"];
            ComboBox cobMaDichVu = (ComboBox)grbThongTinChiTiet.Controls["cobMaDichVu"];
            cobMaDichVu.DataSource = daQuanLyHoaDonDichVu.loadComboboxMaDichVu();
            cobMaDichVu.DisplayMember = "MADICHVU";
            cobMaDichVu.ValueMember = "MADICHVU";
        }

        public void loadComboBoxTimKiemHoaDonDichVu()
        {
            ComboBox cobTimHoaDonDichVu = (ComboBox)this.frmQuanLyHoaDonDichVu.Controls["cobTimHoaDonDichVu"];
            cobTimHoaDonDichVu.DataSource = daQuanLyHoaDonDichVu.loadComboTimKiemMaHoaDonDichVu();
            //cobTimHoaDonDichVu.DisplayMember = "MAHOADONDIEN";
            //cobTimHoaDonDichVu.ValueMember = "MAHOADONDIEN";
            try
            {
                cobTimHoaDonDichVu.DisplayMember = "MAHOADONDV";
                cobTimHoaDonDichVu.ValueMember = "MAHOADONDV";
            }catch(ArgumentException ae)
            {
                //
            }
        }

        public void hienThi()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonDichVu = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDichVu"];
            dgvDanhSachChiTietHoaDonDichVu.DataSource = daQuanLyHoaDonDichVu.danhSachChiTietDichVu();

        }

        public void bindingData()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            DataGridView dgvDanhSachChiTietHoaDonDichVu = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDichVu"];
            //DataTable table = new DataTable();
            //table = DaQuanLyHoaDonDien.HienThiHoaDonDien();
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDDV = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDDV"];
            ComboBox cobMaDichVu = (ComboBox)grbThongTinChiTiet.Controls["cobMaDichVu"];
            //dataBinding cho groupbox thong tin chi tiet
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDichVu.DataSource, "SOLUONG");
            txtDongia.DataBindings.Clear();
            txtDongia.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDichVu.DataSource, "DONGIA");
            txtGhiChuCTHDDV.DataBindings.Clear();
            txtGhiChuCTHDDV.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDichVu.DataSource, "GHICHU");
            cobMaDichVu.DataBindings.Clear();
            cobMaDichVu.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDichVu.DataSource, "MADICHVU");
            //data binding cho groupbox thong tin chung
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtGhiChuHoaDonDichVu = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDichVu"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDichVu.Controls["txtTongTien"];
            txtMaHoaDonDichVu.DataBindings.Clear();
            txtMaHoaDonDichVu.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDichVu.DataSource, "MAHOADONDV");
            txtTenHoaDon.DataBindings.Clear();
            txtTenHoaDon.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDichVu.DataSource, "TENHOADON");
            txtGhiChuHoaDonDichVu.DataBindings.Clear();
            txtGhiChuHoaDonDichVu.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDichVu.DataSource, "GHICHU");
            cobMaCanHo.DataBindings.Clear();
            cobMaCanHo.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDichVu.DataSource, "MACANHO");
            cobMaNhanVien.DataBindings.Clear();
            cobMaNhanVien.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDichVu.DataSource, "MANHANVIEN");
            cobMaHoGiaDinh.DataBindings.Clear();
            cobMaHoGiaDinh.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDichVu.DataSource, "MAHOGD");
        }

        public void themMoiHoaDonDichVU()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtTenNhanVien = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGhiChuHoaDonDichVu = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDichVu"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDichVu.Controls["txtTongTien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN THÊM HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkEmptyString(txtMaHoaDonDichVu.Text) == false)
                {
                    if (daQuanLyHoaDonDichVu.themHoaDonDichVu(txtMaHoaDonDichVu.Text,
                                                       txtTenHoaDon.Text,
                                                       cobMaNhanVien.SelectedValue.ToString(),
                                                       cobMaHoGiaDinh.SelectedValue.ToString(),
                                                       cobMaCanHo.SelectedValue.ToString(),
                                                       dtpNgayIn.Value.ToShortDateString(),
                                                       "0",
                                                       txtGhiChuHoaDonDichVu.Text))
                    {
                        MessageBox.Show("ĐÃ LƯU HOÁ ĐƠN DỊCH VỤ");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI THÊM HOÁ ĐƠN DỊCH VỤ");
                    }
                }
                else
                {
                    MessageBox.Show("LỖI KHI THÊM HOÁ ĐƠN");
                }
            }
        }

        public void SuaHoaDonDichVu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtTenNhanVien = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGhiChuHoaDonDichVu = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDichVu"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDichVu.Controls["txtTongTien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN SỬA HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (daQuanLyHoaDonDichVu.suaHoaDonDichVu(txtMaHoaDonDichVu.Text,
                                                   txtTenHoaDon.Text,
                                                   cobMaNhanVien.SelectedValue.ToString(),
                                                   cobMaHoGiaDinh.SelectedValue.ToString(),
                                                   cobMaCanHo.SelectedValue.ToString(),
                                                   dtpNgayIn.Value.ToShortDateString(),
                                                   "0",
                                                   txtGhiChuHoaDonDichVu.Text))
                {
                    MessageBox.Show("ĐÃ LƯU HOÁ ĐƠN DỊCH VỤ");
                }
                else
                {
                    MessageBox.Show("LỖI KHI SỬA HOÁ ĐƠN DỊCH VỤ");
                }
            }
        }

        public static bool isBetween(int x, int lower, int upper)
        {
            return lower <= x && x <= upper;
        }

        int soluong;
        float dongia;
        float tongtien;
        public void themMoiChiTietHoaDonDichVU()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            DataGridView dgvDanhSachChiTietHoaDonDichVu = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDichVu"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDDV = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDDV"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDichVu.Controls["txtTongTien"];
            ComboBox cobMaDichVu = (ComboBox)grbThongTinChiTiet.Controls["cobMaDichVu"];

            dongia = 0;

            try
            {
                soluong = Int16.Parse(txtSoLuong.Text);
                dongia = float.Parse(txtDongia.Text);
                tongtien = (soluong * dongia);
                string TT = Convert.ToString(tongtien);
                txtTongTien.Text = TT;

                DialogResult result;
                result = MessageBox.Show("BẠN CÓ MUỐN THÊM CHI TIẾT HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (checkEmptyString(txtMaHoaDonDichVu.Text) == false)
                    {
                        if (daQuanLyHoaDonDichVu.themChiTietHoaDonDichVu(txtMaHoaDonDichVu.Text, soluong, txtDongia.Text, txtGhiChuCTHDDV.Text, cobMaDichVu.SelectedValue.ToString()))
                        {
                            MessageBox.Show("ĐÃ LƯU CHI TIẾT HOÁ ĐƠN");
                            daQuanLyHoaDonDichVu.themTongTienChoHoaDonDichVu(txtMaHoaDonDichVu.Text, txtTongTien.Text);
                        }
                        else
                        {
                            MessageBox.Show("LỖI KHI THÊM CHI TIẾT HOÁ ĐƠN");
                        }
                    }
                    else
                    {
                        MessageBox.Show("LÔI KHI THÊM CHI TIẾT HOÁ ĐƠN");
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("CHƯA NHẬP SỐ LƯỢNG CHO CHI TIẾT HOÁ ĐƠN");
            }
        }

        public void SuaChiTietHoaDonDichVu()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            DataGridView dgvDanhSachChiTietHoaDonDichVu = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDichVu"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDDV = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDDV"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDichVu.Controls["txtTongTien"];
            ComboBox cobMaDichVu = (ComboBox)grbThongTinChiTiet.Controls["cobMaDichVu"];

            dongia = 0;
            soluong = Int16.Parse(txtSoLuong.Text);
            dongia = float.Parse(txtDongia.Text);
            tongtien = (soluong * dongia);
            string TT = Convert.ToString(tongtien);
            txtTongTien.Text = TT;

            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN SỬA CHI TIẾT HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (checkEmptyString(txtMaHoaDonDichVu.Text) == false)
                {
                    if (daQuanLyHoaDonDichVu.suaChiTietHoaDonDichVu(txtMaHoaDonDichVu.Text, soluong, txtDongia.Text, txtGhiChuCTHDDV.Text, cobMaDichVu.SelectedValue.ToString()))
                    {
                        MessageBox.Show("ĐÃ SỬA CHI TIẾT HOÁ ĐƠN");
                        daQuanLyHoaDonDichVu.themTongTienChoHoaDonDichVu (txtMaHoaDonDichVu.Text, txtTongTien.Text);
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI SỬA CHI TIẾT HOÁ ĐƠN");
                    }
                }
                else
                {
                    MessageBox.Show("LÔI KHI SỬA CHI TIẾT HOÁ ĐƠN");
                }
            }
        }

        public void xoaHoaDonDichVu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (daQuanLyHoaDonDichVu.xoaHoaDonDichVu(txtMaHoaDonDichVu.Text))
                {
                    MessageBox.Show("ĐÃ XOÁ HOÁ ĐƠN DỊCH VỤ");
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ HOÁ ĐƠN DỊCH VỤ");
                }
            }
        }

        public void xoaChiTietHoaDonDichVu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTin"];
            TextBox txtMaHoaDonDichVu = (TextBox)grbThongTin.Controls["txtMaHoaDonDichVu"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ CHI TIẾT NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (daQuanLyHoaDonDichVu.xoaChiTietHoaDonDichVu(txtMaHoaDonDichVu.Text))
                {
                    MessageBox.Show("ĐÃ XOÁ CHI TIẾT HOÁ ĐƠN DỊCH VỤ");
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ CHI TIẾT HOÁ ĐƠN DỊCH VỤ");
                }
            }
        }

        public void TimKiemChiTietHoaDonDichVuTheoMaHoaDon()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDichVu.Controls["grbThongTinChiTiet"];
            DataGridView dgvDanhSachChiTietHoaDonDichVu = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDichVu"];
            ComboBox cobTimHoaDonDichVu = (ComboBox)this.frmQuanLyHoaDonDichVu.Controls["cobTimHoaDonDichVu"];
            try
            {
                dgvDanhSachChiTietHoaDonDichVu.DataSource = daQuanLyHoaDonDichVu.TimKiemHoaDonDichVuTheoMaHoaDon(cobTimHoaDonDichVu.SelectedValue.ToString());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("CHƯA CÓ DỮ LIỆU");
            }
        }

        public bool checkEmptyString(String str)
        {
            return str == "" ? true : false;
        }
    }
}
