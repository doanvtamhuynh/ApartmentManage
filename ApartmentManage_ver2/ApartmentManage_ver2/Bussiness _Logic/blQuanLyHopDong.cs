using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyHopDong
    {
        Data_Access.daQuanLyHopDong daQuanLyHopDong;
        Form frmQuanLyHopDong;
        public blQuanLyHopDong(Form f)
        {
            this.frmQuanLyHopDong = f;
            daQuanLyHopDong = new Data_Access.daQuanLyHopDong();
        }
        public void loadComboboxMaCanHo()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            ComboBox cbMaCanHo = (ComboBox)grbThongTinHopDong.Controls["cbMaCanHo"];
            cbMaCanHo.DataSource = daQuanLyHopDong.loadComboboxMaCanHo();
            cbMaCanHo.DisplayMember = "MACANHO,TENCHUHO";
            cbMaCanHo.ValueMember = "MACANHO";
        }
        public void loadComboboxMaNhanVien()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            ComboBox cbMaNhanVien = (ComboBox)grbThongTinHopDong.Controls["cbMaNhanVien"];
            cbMaNhanVien.DataSource = daQuanLyHopDong.loadComboboxMaNhanVien();
            cbMaNhanVien.DisplayMember = "MANHANVIEN,HOTEN";
            cbMaNhanVien.ValueMember = "MANHANVIEN";
        }
        public void loadComboboxMaHopDong()
        {
            ComboBox cbMaHopDong = (ComboBox)this.frmQuanLyHopDong.Controls["cbMaHopDong"];
            cbMaHopDong.DataSource = daQuanLyHopDong.danhSachCTHopDong();
            cbMaHopDong.DisplayMember = "MAHOPDONG,TENHOPDONG";
            cbMaHopDong.ValueMember = "MAHOPDONG";
        }
        public void loadComboboxMaHoGD()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            ComboBox cbMaHoGiaDinh = (ComboBox)grbThongTinHopDong.Controls["cbMaHoGiaDinh"];
            cbMaHoGiaDinh.DataSource = daQuanLyHopDong.loadComboboxMaHoGD();
            cbMaHoGiaDinh.DisplayMember = "MAHOGD" + "TENCHUHO";
            cbMaHoGiaDinh.ValueMember = "MAHOGD";
        }
        public void loadComboboxLoaiHopDong()
        {
            var loaiHopDong = new BindingList<KeyValuePair<int, String>>();
            loaiHopDong.Add(new KeyValuePair<int, string>(1, "Thuê"));
            loaiHopDong.Add(new KeyValuePair<int, string>(2, "Mua"));
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTin.Controls["cbLoaiHopDong"];
            cbLoaiHopDong.DataSource = loaiHopDong;
            cbLoaiHopDong.DisplayMember = "Value";
            cbLoaiHopDong.ValueMember = "Value";
        }
        public void hienThi()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];
            dgvChiTietHopDong.DataSource = daQuanLyHopDong.danhSachCTHopDong();
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            TextBox txtTenHopDong = (TextBox)grbThongTinHopDong.Controls["txtTenHopDong"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTinHopDong.Controls["cbLoaiHopDong"];
            ComboBox cbMaNhanVien = (ComboBox)grbThongTinHopDong.Controls["cbMaNhanVien"];
            TextBox txtTenNhanVien = (TextBox)grbThongTinHopDong.Controls["txtTenNhanVien"];
            ComboBox cbMaCanHo = (ComboBox)grbThongTinHopDong.Controls["cbMaCanHo"];
            ComboBox cbMaHoGiaDinh = (ComboBox)grbThongTinHopDong.Controls["cbMaHoGiaDinh"];
            TextBox txtTenChuHo = (TextBox)grbThongTinHopDong.Controls["txtTenChuHo"];
            
            txtMaHopDong.DataBindings.Clear();
            txtMaHopDong.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "MAHOPDONG");
            txtTenHopDong.DataBindings.Clear();
            txtTenHopDong.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "TENHOPDONG");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "HOTEN");
            txtTenChuHo.DataBindings.Clear();
            txtTenChuHo.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "TENCHUHO");
            cbLoaiHopDong.DataBindings.Clear();
            cbLoaiHopDong.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "LOAIHOPDONG");
            cbMaCanHo.DataBindings.Clear();
            cbMaCanHo.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "MACANHO");
            cbMaNhanVien.DataBindings.Clear();
            cbMaNhanVien.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "MANHANVIEN");
            cbMaHoGiaDinh.DataBindings.Clear();
            cbMaHoGiaDinh.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "MAHOGD");

            TextBox txtThoiHan = (TextBox)grbChiTietHopDong.Controls["txtThoiHan"];
            TextBox txtGiaTri = (TextBox)grbChiTietHopDong.Controls["txtGiaTri"];
            TextBox txtNoiDung = (TextBox)grbChiTietHopDong.Controls["txtNoiDung"];
            DateTimePicker dtNgayHopDong = (DateTimePicker)grbChiTietHopDong.Controls["dtpNgayKyHopDong"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHopDong.Controls["txtTongTien"];

            txtThoiHan.DataBindings.Clear();
            txtThoiHan.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "THOIHAN");

            txtGiaTri.DataBindings.Clear();
            txtGiaTri.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "GIATRI");

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "NOIDUNG");

            dtNgayHopDong.DataBindings.Clear();
            dtNgayHopDong.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "NGAYKYHOPDONG");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "TONGTIEN");
        }
        public void themHopDong()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];
            dgvChiTietHopDong.DataSource = daQuanLyHopDong.danhSachCTHopDong();
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            TextBox txtTenHopDong = (TextBox)grbThongTinHopDong.Controls["txtTenHopDong"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTinHopDong.Controls["cbLoaiHopDong"];
            ComboBox cbMaNhanVien = (ComboBox)grbThongTinHopDong.Controls["cbMaNhanVien"];
            TextBox txtTenNhanVien = (TextBox)grbThongTinHopDong.Controls["txtTenNhanVien"];
            ComboBox cbMaCanHo = (ComboBox)grbThongTinHopDong.Controls["cbMaCanHo"];
            ComboBox cbMaHoGiaDinh = (ComboBox)grbThongTinHopDong.Controls["cbMaHoGiaDinh"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHopDong.Controls["txtTongTien"];
            TextBox txtTenChuHo = (TextBox)grbThongTinHopDong.Controls["txtTenChuHo"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thêm hợp đồng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHopDong.themHopDong(txtMaHopDong.Text, txtTenHopDong.Text, cbLoaiHopDong.SelectedValue.ToString(), cbMaCanHo.SelectedValue.ToString(),  cbMaNhanVien.SelectedValue.ToString(), cbMaHoGiaDinh.SelectedValue.ToString(), 0))
                {
                    MessageBox.Show("Thêm hợp đồng thành công!");

                }
                else
                {
                    MessageBox.Show("Bạn chưa thể thêm hợp đồng này!");
                }
            }
        }

        public void themChiTietHopDong()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            TextBox txtThoiHan = (TextBox)grbChiTietHopDong.Controls["txtThoiHan"];
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            TextBox txtGiaTri = (TextBox)grbChiTietHopDong.Controls["txtGiaTri"];
            TextBox txtNoiDung = (TextBox)grbChiTietHopDong.Controls["txtNoiDung"];
            DateTimePicker dtNgayHopDong = (DateTimePicker)grbChiTietHopDong.Controls["dtpNgayKyHopDong"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHopDong.Controls["txtTongTien"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTinHopDong.Controls["cbLoaiHopDong"];
            String loai = cbLoaiHopDong.SelectedValue.ToString();
            double tt = 0;
            if (loai == "Thuê")
            {
                tt = (Convert.ToDouble(float.Parse(txtGiaTri.Text) * float.Parse(txtThoiHan.Text)));
            }else
            {
                tt = Convert.ToDouble((float.Parse(txtGiaTri.Text) + float.Parse(txtGiaTri.Text)*0.1));
            }
            txtTongTien.Text = Convert.ToString(tt);
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thêm CT hợp đồng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHopDong.themChiTietHopDong(txtMaHopDong.Text, dtNgayHopDong.Value, txtThoiHan.Text, float.Parse(txtGiaTri.Text), txtNoiDung.Text ))
                {
                    //MessageBox.Show("Thêm CT hợp đồng thành công!");
                    daQuanLyHopDong.themTongTienHopDong(txtMaHopDong.Text, float.Parse(txtTongTien.Text));
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể thêm CT cho hợp đồng này!");
                }
            }
        }
        public void suaHopDong()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];
            dgvChiTietHopDong.DataSource = daQuanLyHopDong.danhSachCTHopDong();
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            TextBox txtTenHopDong = (TextBox)grbThongTinHopDong.Controls["txtTenHopDong"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTinHopDong.Controls["cbLoaiHopDong"];
            ComboBox cbMaNhanVien = (ComboBox)grbThongTinHopDong.Controls["cbMaNhanVien"];
            TextBox txtTenNhanVien = (TextBox)grbThongTinHopDong.Controls["txtTenNhanVien"];
            ComboBox cbMaCanHo = (ComboBox)grbThongTinHopDong.Controls["cbMaCanHo"];
            ComboBox cbMaHoGiaDinh = (ComboBox)grbThongTinHopDong.Controls["cbMaHoGiaDinh"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHopDong.Controls["txtTongTien"];
            TextBox txtTenChuHo = (TextBox)grbThongTinHopDong.Controls["txtTenChuHo"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn cập nhật hợp đồng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHopDong.suaHopDong(txtMaHopDong.Text, txtTenHopDong.Text, cbLoaiHopDong.SelectedValue.ToString(), cbMaCanHo.SelectedValue.ToString(), cbMaNhanVien.SelectedValue.ToString(), cbMaHoGiaDinh.SelectedValue.ToString(), 0))
                {
                    MessageBox.Show("Cập nhật hợp đồng thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể cập nhật hợp đồng này!");
                }
            }
        }
        public void suaChiTietHopDong()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            TextBox txtThoiHan = (TextBox)grbChiTietHopDong.Controls["txtThoiHan"];
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            TextBox txtGiaTri = (TextBox)grbChiTietHopDong.Controls["txtGiaTri"];
            TextBox txtNoiDung = (TextBox)grbChiTietHopDong.Controls["txtNoiDung"];
            DateTimePicker dtNgayHopDong = (DateTimePicker)grbChiTietHopDong.Controls["dtpNgayKyHopDong"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHopDong.Controls["txtTongTien"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTinHopDong.Controls["cbLoaiHopDong"];
            String loai = cbLoaiHopDong.SelectedValue.ToString();
            double tt = 0;
            if (loai == "Thuê")
            {
                tt = (Convert.ToDouble(float.Parse(txtGiaTri.Text) * float.Parse(txtThoiHan.Text)));
            }
            else
            {
                tt = Convert.ToDouble(float.Parse(txtGiaTri.Text) * 0.1);
            }
            txtTongTien.Text = Convert.ToString(tt);
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn cập nhật CT hợp đồng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHopDong.suaChiTietHopDong(txtMaHopDong.Text, dtNgayHopDong.Value, txtThoiHan.Text, float.Parse(txtGiaTri.Text), txtNoiDung.Text))
                {
                    //MessageBox.Show("Cập nhật CT hợp đồng thành công!");
                    daQuanLyHopDong.themTongTienHopDong(txtMaHopDong.Text, float.Parse(txtTongTien.Text));
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể cập nhật CT cho hợp đồng này!");
                }
            }
        }
        public void timHopDong()
        {
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];
            ComboBox cbMaHopDong = (ComboBox)this.frmQuanLyHopDong.Controls["cbMaHopDong"];
            dgvChiTietHopDong.DataSource = daQuanLyHopDong.timHopDong(cbMaHopDong.SelectedValue.ToString());
            bindKhiTim();
        }
        public void bindKhiTim()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            TextBox txtTenHopDong = (TextBox)grbThongTinHopDong.Controls["txtTenHopDong"];
            ComboBox cbLoaiHopDong = (ComboBox)grbThongTinHopDong.Controls["cbLoaiHopDong"];
            ComboBox cbMaNhanVien = (ComboBox)grbThongTinHopDong.Controls["cbMaNhanVien"];
            TextBox txtTenNhanVien = (TextBox)grbThongTinHopDong.Controls["txtTenNhanVien"];
            ComboBox cbMaCanHo = (ComboBox)grbThongTinHopDong.Controls["cbMaCanHo"];
            ComboBox cbMaHoGiaDinh = (ComboBox)grbThongTinHopDong.Controls["cbMaHoGiaDinh"];
            TextBox txtTenChuHo = (TextBox)grbThongTinHopDong.Controls["txtTenChuHo"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];

            txtMaHopDong.DataBindings.Clear();
            txtMaHopDong.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "MAHOPDONG");
            txtTenHopDong.DataBindings.Clear();
            txtTenHopDong.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "TENHOPDONG");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "HOTEN");
            txtTenChuHo.DataBindings.Clear();
            txtTenChuHo.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "TENCHUHO");
            cbLoaiHopDong.DataBindings.Clear();
            cbLoaiHopDong.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "LOAIHOPDONG");
            cbMaCanHo.DataBindings.Clear();
            cbMaCanHo.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "MACANHO");
            cbMaNhanVien.DataBindings.Clear();
            cbMaNhanVien.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "MANHANVIEN");
            cbMaHoGiaDinh.DataBindings.Clear();
            cbMaHoGiaDinh.DataBindings.Add("SelectedValue", dgvChiTietHopDong.DataSource, "MAHOGD");

            TextBox txtThoiHan = (TextBox)grbChiTietHopDong.Controls["txtThoiHan"];
            TextBox txtGiaTri = (TextBox)grbChiTietHopDong.Controls["txtGiaTri"];
            TextBox txtNoiDung = (TextBox)grbChiTietHopDong.Controls["txtNoiDung"];
            DateTimePicker dtNgayHopDong = (DateTimePicker)grbChiTietHopDong.Controls["dtpNgayKyHopDong"];
            TextBox txtTongTien = (TextBox)this.frmQuanLyHopDong.Controls["txtTongTien"];

            txtThoiHan.DataBindings.Clear();
            txtThoiHan.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "THOIHAN");

            txtGiaTri.DataBindings.Clear();
            txtGiaTri.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "GIATRI");

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "NOIDUNG");

            dtNgayHopDong.DataBindings.Clear();
            dtNgayHopDong.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "NGAYKYHOPDONG");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dgvChiTietHopDong.DataSource, "TONGTIEN");
        }

        public void xoaHopDong()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];
            dgvChiTietHopDong.DataSource = daQuanLyHopDong.danhSachCTHopDong();
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa hợp đồng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHopDong.xoaHopDong(txtMaHopDong.Text))
                {
                    MessageBox.Show("Xóa hợp đồng thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn Không thể xóa hợp đồng này!");
                }
            }
        }
        public void xoaChiTietHopDong()
        {
            GroupBox grbThongTinHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbThongTin"];
            GroupBox grbChiTietHopDong = (GroupBox)this.frmQuanLyHopDong.Controls["grbChiTietHopDong"];
            DataGridView dgvChiTietHopDong = (DataGridView)grbChiTietHopDong.Controls["dgvChiTietHopDong"];
            dgvChiTietHopDong.DataSource = daQuanLyHopDong.danhSachCTHopDong();
            TextBox txtMaHopDong = (TextBox)grbThongTinHopDong.Controls["txtMaHopDong"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa hợp đồng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHopDong.xoaChiTietHopDong(txtMaHopDong.Text))
                {
                    MessageBox.Show("Xóa CT hợp đồng thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn Không thể xóa CT hợp đồng này!");
                }
            }
        }
    }
}
