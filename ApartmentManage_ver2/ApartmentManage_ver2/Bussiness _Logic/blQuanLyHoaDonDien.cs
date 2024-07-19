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
    class blQuanLyHoaDonDien
    {
        XuLyDuLieu XuLyDuLieu;
        Data_Access.daQuanLyHoaDonDien DaQuanLyHoaDonDien;
        Form frmQuanLyHoaDonDien;
        DataTable tableHDD;

        public blQuanLyHoaDonDien(Form f)
        {
            this.frmQuanLyHoaDonDien = f;
            DaQuanLyHoaDonDien = new Data_Access.daQuanLyHoaDonDien();
            XuLyDuLieu = new XuLyDuLieu();
        }

        public void loadComboBoxMaNhanVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            cobMaNhanVien.DataSource = DaQuanLyHoaDonDien.loadComboboxMaNhanVien();
            cobMaNhanVien.ValueMember = "MANHANVIEN";
            cobMaNhanVien.DisplayMember = "MANHANVIEN";
        }

        public void loadComboBoxMaHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            cobMaHoGiaDinh.DataSource = DaQuanLyHoaDonDien.loadComboboxMaHoGiaDinh();
            cobMaHoGiaDinh.DisplayMember = "MAHOGD";
            cobMaHoGiaDinh.ValueMember = "MAHOGD";
        }

        public void loadComboBoxMaCanHo()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            cobMaCanHo.DataSource = DaQuanLyHoaDonDien.loadComboboxMaCanHo();
            cobMaCanHo.DisplayMember = "MACANHO";
            cobMaCanHo.ValueMember = "MACANHO";
        }

        public void loadComboBoxTimKiemHoaDonDien()
        {
            ComboBox cobTimMaHoaDonDien = (ComboBox)this.frmQuanLyHoaDonDien.Controls["cobTimMaHoaDonDien"];
            cobTimMaHoaDonDien.DataSource = DaQuanLyHoaDonDien.loadComboTimKiemMaHoaDonDien();
            cobTimMaHoaDonDien.DisplayMember = "MAHOADONDIEN";
            cobTimMaHoaDonDien.ValueMember = "MAHOADONDIEN";
        }


        float tongTien;
        public void hienThi()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];
            dgvDanhSachChiTietHoaDonDien.DataSource = DaQuanLyHoaDonDien.danhSachChiTietHoaDonDien();
            
        }

        public void bangChiTietHoaDon()
        {//groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];
            dgvDanhSachChiTietHoaDonDien.DataSource = DaQuanLyHoaDonDien.danhSachChiTietHoaDonDien();
            tableHDD = new DataTable();
            tableHDD.Columns.Add("MAHOADONDIEN", typeof(string));
            tableHDD.Columns.Add("SOLUONG", typeof(int));
            tableHDD.Columns.Add("DONGIA", typeof(float));
            tableHDD.Columns.Add("THANHTIEN", typeof(float), " SOLUONG*DONGIA ");
            dgvDanhSachChiTietHoaDonDien.DataSource = tableHDD;
        }

        public void hienThiThanhTien()
        {
            //groupBox Thong tin chi tiet hoa don
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];

        }

        public void bindingData()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];
            DataTable table = new DataTable();
            table = DaQuanLyHoaDonDien.HienThiHoaDonDien();
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDD = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDD"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            //txtTenHoaDon.Select();
            //dataBinding cho groupbox thong tin chi tiet
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDien.DataSource, "SOLUONG");
            txtDongia.DataBindings.Clear();
            txtDongia.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDien.DataSource, "DONGIA");
            txtGhiChuCTHDD.DataBindings.Clear();
            txtGhiChuCTHDD.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDien.DataSource, "GHICHU");
            //data binding cho groupbox thong tin chung
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtGhiChuHoaDonDien = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDien"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDien.Controls["txtTongTien"];
            txtMaHoaDonDien.DataBindings.Clear();
            txtMaHoaDonDien.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDien.DataSource, "MAHOADONDIEN");
            txtTenHoaDon.DataBindings.Clear();
            txtTenHoaDon.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDien.DataSource, "TENHOADON");
            txtGhiChuHoaDonDien.DataBindings.Clear();
            txtGhiChuHoaDonDien.DataBindings.Add("Text", dgvDanhSachChiTietHoaDonDien.DataSource, "GHICHU");
            cobMaCanHo.DataBindings.Clear();
            cobMaCanHo.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDien.DataSource, "MACANHO");
            cobMaNhanVien.DataBindings.Clear();
            cobMaNhanVien.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDien.DataSource, "MANHANVIEN");
            cobMaHoGiaDinh.DataBindings.Clear();
            cobMaHoGiaDinh.DataBindings.Add("SelectedValue", dgvDanhSachChiTietHoaDonDien.DataSource, "MAHOGD");

        }

        public void themMoiHoaDonDien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtTenNhanVien = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGhiChuHoaDonDien = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDien"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDien.Controls["txtTongTien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN THÊM HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkEmptyString(txtMaHoaDonDien.Text)==false)
                {
                    if (DaQuanLyHoaDonDien.themHoaDonDien(txtMaHoaDonDien.Text,
                                                       txtTenHoaDon.Text,
                                                       cobMaNhanVien.SelectedValue.ToString(),
                                                       cobMaHoGiaDinh.SelectedValue.ToString(),
                                                       cobMaCanHo.SelectedValue.ToString(),
                                                       dtpNgayIn.Value.ToShortDateString(),
                                                       "0",
                                                       txtGhiChuHoaDonDien.Text))
                    {
                        MessageBox.Show("ĐÃ LƯU HOÁ ĐƠN ĐIỆN");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI THÊM HOÁ ĐƠN ĐIỆN");
                    }
                }
                else
                {
                    MessageBox.Show("LỖI KHI THÊM HOÁ ĐƠN");
                }
            }
        }

        public void SuaHoaDonDien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            ComboBox cobMaNhanVien = (ComboBox)grbThongTin.Controls["cobMaNhanVien"];
            ComboBox cobMaHoGiaDinh = (ComboBox)grbThongTin.Controls["cobMaHoGiaDinh"];
            ComboBox cobMaCanHo = (ComboBox)grbThongTin.Controls["cobMaCanHo"];
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            TextBox txtTenHoaDon = (TextBox)grbThongTin.Controls["txtTenHoaDon"];
            TextBox txtTenNhanVien = (TextBox)grbThongTin.Controls["txtTenNhanVien"];
            DateTimePicker dtpNgayIn = (DateTimePicker)grbThongTin.Controls["dtpNgayIn"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGhiChuHoaDonDien = (TextBox)grbThongTin.Controls["txtGhiChuHoaDonDien"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDien.Controls["txtTongTien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN SỬA HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                    if (DaQuanLyHoaDonDien.suaHoaDonDien(txtMaHoaDonDien.Text,
                                                       txtTenHoaDon.Text,
                                                       cobMaNhanVien.SelectedValue.ToString(),
                                                       cobMaHoGiaDinh.SelectedValue.ToString(),
                                                       cobMaCanHo.SelectedValue.ToString(),
                                                       dtpNgayIn.Value.ToShortDateString(),
                                                       "0",
                                                       txtGhiChuHoaDonDien.Text))
                    {
                        MessageBox.Show("ĐÃ LƯU HOÁ ĐƠN ĐIỆN");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI SỬA HOÁ ĐƠN ĐIỆN");
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
        public void themMoiChiTietHoaDonDien()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDD = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDD"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDien.Controls["txtTongTien"];

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
                    if (checkEmptyString(txtMaHoaDonDien.Text)==false)
                    {
                        if (DaQuanLyHoaDonDien.themChiTietHoaDonDien(txtMaHoaDonDien.Text, soluong, txtDongia.Text, txtGhiChuCTHDD.Text))
                        {
                            MessageBox.Show("ĐÃ LƯU CHI TIẾT HOÁ ĐƠN");
                            DaQuanLyHoaDonDien.themTongTienChoHoaDonDien(txtMaHoaDonDien.Text, txtTongTien.Text);
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
            catch(FormatException fe)
            {
                MessageBox.Show("CHƯA NHẬP SỐ LƯỢNG CHO CHI TIẾT HOÁ ĐƠN");
            }
            
        }

        public void SuaChiTietHoaDonDien()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            TextBox txtSoLuong = (TextBox)grbThongTinChiTiet.Controls["txtSoLuong"];
            TextBox txtDongia = (TextBox)grbThongTinChiTiet.Controls["txtDongia"];
            TextBox txtGhiChuCTHDD = (TextBox)grbThongTinChiTiet.Controls["txtGhiChuCTHDD"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHoaDonDien.Controls["txtTongTien"];

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
                if (DaQuanLyHoaDonDien.suaChiTietHoaDonDien(txtMaHoaDonDien.Text, soluong, txtGhiChuCTHDD.Text))
                {
                    MessageBox.Show("ĐÃ SỬA CHI TIẾT HOÁ ĐƠN ĐIỆN");
                    DaQuanLyHoaDonDien.themTongTienChoHoaDonDien(txtMaHoaDonDien.Text, txtTongTien.Text);
                }
                else
                {
                    MessageBox.Show("LỖI KHI SỬA CHI TIẾT HOÁ ĐƠN ĐIỆN");
                }
            }
        }

        public void xoaHoaDonDien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ HOÁ ĐƠN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (DaQuanLyHoaDonDien.xoaHoaDonDien(txtMaHoaDonDien.Text))
                {
                    MessageBox.Show("ĐÃ XOÁ HOÁ ĐƠN ĐIỆN");
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ HOÁ ĐƠN ĐIỆN");
                }
            }
        }

        public void xoaChiTietHoaDonDien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTin"];
            TextBox txtMaHoaDonDien = (TextBox)grbThongTin.Controls["txtMaHoaDonDien"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ CHI TIẾT NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (DaQuanLyHoaDonDien.xoaChiTietHoaDonDien(txtMaHoaDonDien.Text))
                {
                    MessageBox.Show("ĐÃ XOÁ CHI TIẾT HOÁ ĐƠN ĐIỆN");
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ CHI TIẾT HOÁ ĐƠN ĐIỆN");
                }
            }
        }

        public void TimKiemChiTietHoaDonDienTheoMaHoaDon()
        {
            GroupBox grbThongTinChiTiet = (GroupBox)this.frmQuanLyHoaDonDien.Controls["grbThongTinChiTiet"];
            DataGridView dgvDanhSachChiTietHoaDonDien = (DataGridView)grbThongTinChiTiet.Controls["dgvDanhSachChiTietHoaDonDien"];
            ComboBox cobTimMaHoaDonDien = (ComboBox)this.frmQuanLyHoaDonDien.Controls["cobTimMaHoaDonDien"];
            try
            {
                dgvDanhSachChiTietHoaDonDien.DataSource = DaQuanLyHoaDonDien.TimKiemChiTietHoaDonDienTheoMaHoaDon(cobTimMaHoaDonDien.SelectedValue.ToString());
            }catch(NullReferenceException ex)
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
