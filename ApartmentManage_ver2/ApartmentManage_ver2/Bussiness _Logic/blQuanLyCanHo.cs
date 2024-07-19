using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyCanHo
    {
        Data_Access.daQuanLyCanHo daQuanLyCanHo;
        Form frmQuanLyCanHo;
        public blQuanLyCanHo(Form f)
        {
            this.frmQuanLyCanHo = f;
            daQuanLyCanHo = new Data_Access.daQuanLyCanHo();
        }
        public void loadComBoboxMaKhu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            ComboBox cbMaKhu = (ComboBox)grbThongTin.Controls["cbMaKhu"];
            cbMaKhu.DataSource = daQuanLyCanHo.loadComboBoxMaKhu();
            cbMaKhu.ValueMember = "MAKHU";
            cbMaKhu.DisplayMember = "TENKHU";
        }
        public void loadComBoBoxMaHoGD()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            ComboBox cbMaHoGD = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            cbMaHoGD.DataSource = daQuanLyCanHo.loadComBoBoxHoGiaDinh();
            cbMaHoGD.DisplayMember = "TENCHUHO";
            cbMaHoGD.ValueMember = "MAHOGD";
        }

        public void loadComBoBoxMaCanHo()
        {
            ComboBox cbMaCanHo = (ComboBox)this.frmQuanLyCanHo.Controls["cbMaCanHo"];
            cbMaCanHo.DataSource = daQuanLyCanHo.danhSachCanHo();
            cbMaCanHo.DisplayMember = "MACANHO";
            cbMaCanHo.ValueMember = "MACANHO";
        }

        public void loadComboboxLoaiCanHo()
        {
            var loaiCanHo = new BindingList<KeyValuePair<int, String>>();
            loaiCanHo.Add(new KeyValuePair<int, string>(1, "Cao cấp"));
            loaiCanHo.Add(new KeyValuePair<int, string>(2, "Căn bản"));
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            ComboBox cbLoaiCanHo = (ComboBox)grbThongTin.Controls["cbLoaiCanHo"];
            cbLoaiCanHo.DataSource = loaiCanHo;
            cbLoaiCanHo.DisplayMember = "Value";
            cbLoaiCanHo.ValueMember = "Value";
        }
        
        public void hienThi()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyCanHo.Controls["grbDanhSachCanHo"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachCanHo"];
            dgvDanhSach.DataSource = daQuanLyCanHo.danhSachCanHo();
            ComboBox cbMaKhu = (ComboBox)grbThongTin.Controls["cbMaKhu"];
            ComboBox cbMaHoGD = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            ComboBox cbloaiCanHo = (ComboBox)grbThongTin.Controls["cbLoaiCanHo"];
            
            TextBox txtMaCanHo = (TextBox)grbThongTin.Controls["txtMaCanHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGiaCanHo = (TextBox)grbThongTin.Controls["txtGiaCanHo"];
            TextBox txtGhiChu = (TextBox)grbThongTin.Controls["txtGhiChu"];
            PictureBox pbHinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            TextBox txtTrangThai = (TextBox)grbThongTin.Controls["txtTrangThai"];

            txtMaCanHo.DataBindings.Clear();
            txtMaCanHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "MACANHO");

            txtTenCanHo.DataBindings.Clear();
            txtTenCanHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "TENCANHO");

            cbloaiCanHo.DataBindings.Clear();
            cbloaiCanHo.DataBindings.Add("SelectedValue", dgvDanhSach.DataSource, "LOAICANHO");

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhSach.DataSource, "TRANGTHAI");

  
            txtGiaCanHo.DataBindings.Clear();
            txtGiaCanHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "GIACANHO");

            pbHinhAnh.DataBindings.Clear();
            pbHinhAnh.DataBindings.Add("Image", dgvDanhSach.DataSource, "HINHANH", true);

            cbMaKhu.DataBindings.Clear();
            cbMaKhu.DataBindings.Add("SelectedValue", dgvDanhSach.DataSource, "MAKHU");

            cbMaHoGD.DataBindings.Clear();
            cbMaHoGD.DataBindings.Add("SelectedValue", dgvDanhSach.DataSource, "MAHOGD");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhSach.DataSource, "GHICHU");
        }
        public void themCanHo()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyCanHo.Controls["grbDanhSachCanHo"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachCanHo"];
            ComboBox cbMaKhu = (ComboBox)grbThongTin.Controls["cbMaKhu"];
            ComboBox cbMaHoGD = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            ComboBox cbloaiCanHo = (ComboBox)grbThongTin.Controls["cbLoaiCanHo"];
            TextBox txtMaCanHo = (TextBox)grbThongTin.Controls["txtMaCanHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGiaCanHo = (TextBox)grbThongTin.Controls["txtGiaCanHo"];
            TextBox txtGhiChu = (TextBox)grbThongTin.Controls["txtGhiChu"];
            PictureBox pbHinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            TextBox txtTrangThai = (TextBox)grbThongTin.Controls["txtTrangThai"];
            txtTrangThai.Text = "Trống";
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn thêm căn hộ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (daQuanLyCanHo.themCanHo(txtMaCanHo.Text,txtTenCanHo.Text, cbloaiCanHo.SelectedValue.ToString(), pbHinhAnh, float.Parse(txtGiaCanHo.Text),txtTrangThai.Text, txtGhiChu.Text, cbMaKhu.SelectedValue.ToString(), cbMaHoGD.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Thêm căn hộ thành công!");
                        txtMaCanHo.Text = "";
                        txtTenCanHo.Text = "";
                        txtGhiChu.Text = "";
                        txtGiaCanHo.Text = "";
                        pbHinhAnh.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thể thêm căn hộ này!");
                    }
                }
            }
            catch (ArgumentNullException ex) { MessageBox.Show("Vui lòng chọn ảnh cho căn hộ"); }

        }
        public void suaCanHo()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyCanHo.Controls["grbDanhSachCanHo"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachCanHo"];
            ComboBox cbMaKhu = (ComboBox)grbThongTin.Controls["cbMaKhu"];
            ComboBox cbMaHoGD = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            ComboBox cbloaiCanHo = (ComboBox)grbThongTin.Controls["cbLoaiCanHo"];
            TextBox txtMaCanHo = (TextBox)grbThongTin.Controls["txtMaCanHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGiaCanHo = (TextBox)grbThongTin.Controls["txtGiaCanHo"];
            TextBox txtGhiChu = (TextBox)grbThongTin.Controls["txtGhiChu"];
            PictureBox pbHinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            TextBox txtTrangThai = (TextBox)grbThongTin.Controls["txtTrangThai"];
            txtTrangThai.Text = "Trống";

            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn cập nhật căn hộ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyCanHo.suaCanHo(txtMaCanHo.Text, txtTenCanHo.Text, cbloaiCanHo.SelectedValue.ToString(), pbHinhAnh, float.Parse(txtGiaCanHo.Text), txtGhiChu.Text, cbMaKhu.SelectedValue.ToString(), cbMaHoGD.SelectedValue.ToString()))
                {
                    MessageBox.Show("Cập nhật căn hộ thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa cập nhật lại căn hộ này!");
                }
            }
        }
        public void xoaCanHo()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            TextBox txtMaCanHo = (TextBox)grbThongTin.Controls["txtMaCanHo"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa căn hộ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyCanHo.xoaCanHo(txtMaCanHo.Text))
                {
                    MessageBox.Show("Xóa căn hộ thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa xóa căn hộ này!");
                }
            }
        }
        public void timCanHo()
        {
            ComboBox cbMaCanHo = (ComboBox)this.frmQuanLyCanHo.Controls["cbMaCanHo"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyCanHo.Controls["grbDanhSachCanHo"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachCanHo"];
            dgvDanhSach.DataSource = daQuanLyCanHo.timCanHo(cbMaCanHo.SelectedValue.ToString());
            bind();
        }
        private void bind()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyCanHo.Controls["grbDanhSachCanHo"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachCanHo"];
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            ComboBox cbMaKhu = (ComboBox)grbThongTin.Controls["cbMaKhu"];
            ComboBox cbMaHoGD = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            ComboBox cbloaiCanHo = (ComboBox)grbThongTin.Controls["cbLoaiCanHo"];
            TextBox txtMaCanHo = (TextBox)grbThongTin.Controls["txtMaCanHo"];
            TextBox txtTenCanHo = (TextBox)grbThongTin.Controls["txtTenCanHo"];
            TextBox txtGiaCanHo = (TextBox)grbThongTin.Controls["txtGiaCanHo"];
            TextBox txtGhiChu = (TextBox)grbThongTin.Controls["txtGhiChu"];
            PictureBox pbHinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            txtMaCanHo.DataBindings.Clear();
            txtMaCanHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "MACANHO");
            txtTenCanHo.DataBindings.Clear();
            txtTenCanHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "TENCANHO");
            cbloaiCanHo.DataBindings.Clear();
            cbloaiCanHo.DataBindings.Add("SelectedValue", dgvDanhSach.DataSource, "LOAICANHO");
            txtGiaCanHo.DataBindings.Clear();
            txtGiaCanHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "GIACANHO");
            pbHinhAnh.DataBindings.Clear();
            pbHinhAnh.DataBindings.Add("Image", dgvDanhSach.DataSource, "HINHANH", true);
            cbMaKhu.DataBindings.Clear();
            cbMaKhu.DataBindings.Add("SelectedValue", dgvDanhSach.DataSource, "MAKHU");
            cbMaHoGD.DataBindings.Clear();
            cbMaHoGD.DataBindings.Add("SelectedValue", dgvDanhSach.DataSource, "MAHOGD");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhSach.DataSource, "GHICHU");
        }
        public void pictureBoxHinhAnh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyCanHo.Controls["grbThongTin"];
            PictureBox pbHinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "file image|*.PNG|*.jpg|*.bmp";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pbHinhAnh.ImageLocation = openFileDialog.FileName;
            }
        }


    }
}
