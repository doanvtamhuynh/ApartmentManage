using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyHoaDonNuoc
    {
        XuLyDuLieu XuLyDuLieu;
        Data_Access.daQuanLyHoaDonNuoc DaQuanLyHoaDonNuoc;
        Form frmQuanLyHoaDonNuoc;
        DataTable tableHDN;

        public blQuanLyHoaDonNuoc(Form f)
        {
            this.frmQuanLyHoaDonNuoc = f;
            DaQuanLyHoaDonNuoc = new Data_Access.daQuanLyHoaDonNuoc();
            XuLyDuLieu = new XuLyDuLieu();
        }

        public void loadComboBoxMaNhanVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            cobMaNhanVien.DataSource = DaQuanLyHoaDonNuoc.loadComboboxMaNhanVien();
            cobMaNhanVien.ValueMember = "MANHANVIEN";
            cobMaNhanVien.DisplayMember = "MANHANVIEN";
        }

        public void loadComboBoxMaHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            cobMaHoGiaDinh.DataSource = DaQuanLyHoaDonNuoc.loadComboboxMaHoGiaDinh();
            cobMaHoGiaDinh.DisplayMember = "MAHOGD";
            cobMaHoGiaDinh.ValueMember = "MAHOGD";
        }

        public void loadComboBoxMaCanHo()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            cobMaCanHo.DataSource = DaQuanLyHoaDonNuoc.loadComboboxMaCanHo();
            cobMaCanHo.DisplayMember = "MACANHO";
            cobMaCanHo.ValueMember = "MACANHO";
        }

        public void loadComboBoxTimKiemHoaDonNuoc()
        {
            ComboBox cobTimMaHoaDonDien = (ComboBox)this.frmQuanLyHoaDonNuoc.Controls["cobTimMaHoaDonNuoc"];
            cobTimMaHoaDonDien.DataSource = DaQuanLyHoaDonNuoc.loadComboTimKiemMaHoaDonNuoc();
            cobTimMaHoaDonDien.DisplayMember = "MAHOADONNUOC";
            cobTimMaHoaDonDien.ValueMember = "MAHOADONNUOC";
        }

        public void hienThi()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonNuoc = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonNuoc"];
            dgvDanhSachChiTietHoaDonNuoc.DataSource = DaQuanLyHoaDonNuoc.danhSachChiTietHoaDonNuoc();
        }

        public void bindingData()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonNuoc = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonNuoc"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
          
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDN = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDN"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            txtTenHoaDon.Select();
            //dataBinding cho groupbox thong tin chi tiet
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonNuoc.DataSource, "SOLUONG");
            txtDongia.DataBindings.Clear();
            txtDongia.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonNuoc.DataSource, "DONGIA");
            txtGhiChuCTHDN.DataBindings.Clear();
            txtGhiChuCTHDN.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonNuoc.DataSource, "GHICHU");
            //data binding cho groupbox thong tin chung
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtGhiChuHoaDonNuoc = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonNuoc"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonNuoc.Controls["txtTongTien"];
            txtMaHoaDonNuoc.DataBindings.Clear();
            txtMaHoaDonNuoc.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonNuoc.DataSource, "MAHOADONNUOC");
            txtTenHoaDon.DataBindings.Clear();
            txtTenHoaDon.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonNuoc.DataSource, "TENHOADON");
            txtGhiChuHoaDonNuoc.DataBindings.Clear();
            txtGhiChuHoaDonNuoc.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonNuoc.DataSource, "GHICHU");
            cobMaCanHo.DataBindings.Clear();
            cobMaCanHo.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonNuoc.DataSource, "MACANHO");
            cobMaNhanVien.DataBindings.Clear();
            cobMaNhanVien.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonNuoc.DataSource, "MANHANVIEN");
            cobMaHoGiaDinh.DataBindings.Clear();
            cobMaHoGiaDinh.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonNuoc.DataSource, "MAHOGD");
        }

        public void themMoiHoaDonNuoc()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtTenNhanVien = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGhiChuHoaDonNuoc = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonNuoc"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonNuoc.Controls["txtTongTien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN THÊM HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (checkIsEmptyString(txtMaHoaDonNuoc.Text)==false)
                {
                    if (DaQuanLyHoaDonNuoc.themHoaDonNuoc(txtMaHoaDonNuoc.Text,
                                                        txtTenHoaDon.Text,
                                                        cobMaNhanVien.SelectedValue.ToString(),
                                                        cobMaHoGiaDinh.SelectedValue.ToString(),
                                                        cobMaCanHo.SelectedValue.ToString(),
                                                        dtpNgayIn.Value.ToShortDateString(),
                                                        "0",
                                                        txtGhiChuHoaDonNuoc.Text))
                    {
                        MessageBox.Show("ĐÃ THÊM HOÁ ĐƠN NƯỚC");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI THÊM HOÁ ĐƠN NƯỚC");
                    }
                }
                else
                {
                    MessageBox.Show("LỖI KHI THÊM HOÁ ĐƠN NƯỚC");
                }
            }
        }

        public void SuaHoaDonNuoc()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtTenNhanVien = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGhiChuHoaDonNuoc = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonNuoc"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonNuoc.Controls["txtTongTien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN SỬA HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                if (DaQuanLyHoaDonNuoc.suaHoaDonNuoc(txtMaHoaDonNuoc.Text,
                                                        txtTenHoaDon.Text,
                                                        cobMaNhanVien.SelectedValue.ToString(),
                                                        cobMaHoGiaDinh.SelectedValue.ToString(),
                                                        cobMaCanHo.SelectedValue.ToString(),
                                                        dtpNgayIn.Value.ToShortDateString(),
                                                        "0",
                                                        txtGhiChuHoaDonNuoc.Text))
                {
                    MessageBox.Show("ĐÃ SỬA HOÁ ĐƠN NƯỚC");
                }
                else
                {
                    MessageBox.Show("LỖI KHI SỬA HOÁ ĐƠN NƯỚC");
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
        public void themMoiChiTietHoaDonNuoc()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonNuoc = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonNuoc"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDN = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDN"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonNuoc.Controls["txtTongTien"];

            dongia = 0;
            try
            {
                soluong = Int16.Parse(txtSoLuong.Text);
                if (isBetween(soluong, 0, 50))
                {
                    dongia = 1.678f;
                }
                else if (isBetween(soluong, 51, 100))
                {
                    dongia = 1.734f;
                }
                else if (isBetween(soluong, 101, 200))
                {
                    dongia = 2.014f;
                }
                else if (isBetween(soluong, 201, 300))
                {
                    dongia = 2.536f;
                }
                else if (isBetween(soluong, 301, 400))
                {
                    dongia = 2.834f;
                }
                else dongia = 2.927f;
                tongtien = (soluong * dongia);
                string DonGia = Convert.ToString(dongia);
                txtDongia.Text = DonGia;
                string TT = Convert.ToString(tongtien);
                txtTongTien.Text = TT;

                DialogResult result;
                result = MessageBox.Show("BẠN CÓ MUỐN THÊM CHI TIẾT HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (checkIsEmptyString(txtMaHoaDonNuoc.Text)==false)
                    {
                        if (DaQuanLyHoaDonNuoc.themChiTietHoaDonNuoc(txtMaHoaDonNuoc.Text, soluong, txtDongia.Text, txtGhiChuCTHDN.Text))
                        {
                            MessageBox.Show("ĐÃ THÊM CHI TIẾT HOÁ ĐƠN NƯỚC");
                            DaQuanLyHoaDonNuoc.themTongTienChoHoaDonNuoc(txtMaHoaDonNuoc.Text, txtTongTien.Text);
                        }
                        else
                        {
                            MessageBox.Show("LỖI KHI THÊM CHI TIẾT HOÁ ĐƠN NƯỚC");
                        }
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI THÊM CHI TIẾT HOÁ ĐƠN NƯỚC");
                    }
                }
            }catch(FormatException fe)
            {
                MessageBox.Show("CHƯA NHẬP SỐ LƯỢNG");
            }
        }

        public void SuaChiTietHoaDonNuoc()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonNuoc = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonNuoc"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDN = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDN"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonNuoc.Controls["txtTongTien"];

            dongia = 0;
            soluong = Int16.Parse(txtSoLuong.Text);
            if (isBetween(soluong, 0, 50))
            {
                dongia = 1.678f;
            }
            else if (isBetween(soluong, 51, 100))
            {
                dongia = 1.734f;
            }
            else if (isBetween(soluong, 101, 200))
            {
                dongia = 2.014f;
            }
            else if (isBetween(soluong, 201, 300))
            {
                dongia = 2.536f;
            }
            else if (isBetween(soluong, 301, 400))
            {
                dongia = 2.834f;
            }
            else dongia = 2.927f;
            tongtien = (float)soluong + dongia;
            string DonGia = Convert.ToString(dongia);
            string TongTien = Convert.ToString(tongtien);
            txtTongTien.Text = TongTien;

            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN SỬA CHI TIẾT HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (DaQuanLyHoaDonNuoc.suaChiTietHoaDonNuoc(txtMaHoaDonNuoc.Text, soluong, txtGhiChuCTHDN.Text))
                {
                    MessageBox.Show("ĐÃ SỬA CHI TIẾT HOÁ ĐƠN NƯỚC");
                    DaQuanLyHoaDonNuoc.themTongTienChoHoaDonNuoc(txtMaHoaDonNuoc.Text, txtTongTien.Text);
                }
                else
                {
                    MessageBox.Show("LỖI KHI SỬA CHI TIẾT HOÁ ĐƠN NƯỚC");
                }
            }
        }

        public void xoaHoaDonNuoc()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (DaQuanLyHoaDonNuoc.xoaHoaDonNuoc(txtMaHoaDonNuoc.Text))
                {
                    MessageBox.Show("ĐÃ XOÁ HOÁ ĐƠN NƯỚC");
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ HOÁ ĐƠN NƯỚC");
                }
            }
        }

        public void xoaChiTietHoaDonNuoc()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTin"];
            TextBox txtMaHoaDonNuoc = (TextBox)grbThongTin.Controls["txtMaHoaDonNuoc"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ CHI TIẾT NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (DaQuanLyHoaDonNuoc.xoaChiTietHoaDonNuoc(txtMaHoaDonNuoc.Text))
                {
                    MessageBox.Show("ĐÃ XOÁ CHI TIẾT HOÁ ĐƠN NƯỚC");
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ CHI TIẾT HOÁ ĐƠN NƯỚC");
                }
            }
        }

        public void TimKiemChiTietHoaDonNuocTheoMaHoaDon()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonNuoc.Controls["grbThongTinChiTiet"];
            DataGridView dgvDanhSachChiTietHoaDonNuoc = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonNuoc"];
            ComboBox cobTimMaHoaDonNuoc = (ComboBox)this.frmQuanLyHoaDonNuoc.Controls["cobTimMaHoaDonNuoc"];
            try
            {
                dgvDanhSachChiTietHoaDonNuoc.DataSource = DaQuanLyHoaDonNuoc.TimKiemChiTietHoaDonNuocTheoMaHoaDon(cobTimMaHoaDonNuoc.SelectedValue.ToString());
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("CHƯA CÓ DỮ LIỆU ĐỂ TÌM KIẾM");
            }
        }

        public bool checkIsEmptyString(String str)
        {
            return str == "" ? true : false;
        }

    }
}
