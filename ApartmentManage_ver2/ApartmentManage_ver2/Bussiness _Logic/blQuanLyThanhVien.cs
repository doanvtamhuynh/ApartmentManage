using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyThanhVien
    {
        Data_Access.daQuanLyThanhVien daQuanLyThanhVien;
        Form frmQuanLyThanhVien;
        String gioiTinh;
        public blQuanLyThanhVien( Form f)
        {
            this.frmQuanLyThanhVien = f;
            daQuanLyThanhVien = new Data_Access.daQuanLyThanhVien();
        }
       
        public void loadComBoboxMaHoGD()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            ComboBox cbMaHoGd = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            cbMaHoGd.DataSource = daQuanLyThanhVien.loadComboboxHoGiaDinh();
            cbMaHoGd.DisplayMember ="TENCHUHO";
            cbMaHoGd.ValueMember = "MAHOGD";
        }
        public void loadComboboxMaThanhVien()
        {
            ComboBox cbMaTV = (ComboBox)this.frmQuanLyThanhVien.Controls["cbMaThanhVien"];
            cbMaTV.DataSource = daQuanLyThanhVien.danhSachThanhVien();
            cbMaTV.DisplayMember = "MATHANHVIEN,HOTENTHANHVIEN";
            cbMaTV.ValueMember = "MATHANHVIEN";
        }
        public void hienThi()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyThanhVien.Controls["grbDanhSachThanhVien"];
            DataGridView dgvDanhSachThanhVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachThanhVien"];
            dgvDanhSachThanhVien.DataSource = daQuanLyThanhVien.danhSachThanhVien();
            TextBox txtMaTV = (TextBox)grbThongTin.Controls["txtMaTV"];
            TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
            TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
            DateTimePicker dtpNgaySinh = (DateTimePicker)grbThongTin.Controls["dtpNgaySinh"];
            RadioButton rdbNam = (RadioButton)grbThongTin.Controls["rdbNam"];
            RadioButton rdbNu = (RadioButton)grbThongTin.Controls["rdbNu"];
            PictureBox hinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            ComboBox cbMaHoGd = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];

            txtMaTV.DataBindings.Clear();
            txtMaTV.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "MATHANHVIEN");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "HOTENTHANHVIEN");

            txtSoCMND.DataBindings.Clear();
            txtSoCMND.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "SOCMND");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "SDT");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "EMAIL");

            cbMaHoGd.DataBindings.Clear();
            cbMaHoGd.DataBindings.Add("SelectedValue", dgvDanhSachThanhVien.DataSource, "MAHOGD");

            hinhAnh.DataBindings.Clear();
            hinhAnh.DataBindings.Add("Image", dgvDanhSachThanhVien.DataSource, "HINHANH",true);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "NGAYSINH");

            rdbNam.DataBindings.Clear();
            Binding binding = new Binding("Checked", dgvDanhSachThanhVien.DataSource, "GIOITINHTV");
            binding.Format += new ConvertEventHandler(binding_Format);
            binding.Parse += new ConvertEventHandler(binding_Parse);
            rdbNam.DataBindings.Add(binding);
            rdbNu.DataBindings.Clear();
            Binding binding2 = new Binding("Checked", dgvDanhSachThanhVien.DataSource, "GIOITINHTV");
            binding2.Format += new ConvertEventHandler(binding2_Format);
            binding2.Parse += new ConvertEventHandler(binding2_Parse);
            rdbNu.DataBindings.Add(binding2);

        }
        void binding_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value.ToString() == "Nam") e.Value = true;
            else e.Value = false;

        }
        void binding_Parse(object sender, ConvertEventArgs e)
        {
            if ((bool)e.Value) e.Value = "Nam";
            else e.Value = "Nữ";

        }
        void binding2_Format(object sender, ConvertEventArgs e)
        {
             if (e.Value.ToString() == "Nữ") e.Value = true;
            else e.Value = false;

        }
        void binding2_Parse(object sender, ConvertEventArgs e)
        {
            //if ((bool)e.Value) e.Value = "Nam";
            if ((bool)e.Value) e.Value = "Nữ";
            else e.Value = "Nam";

        }
       
        public void themThanhVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyThanhVien.Controls["grbDanhSachThanhVien"];
            DataGridView dgvDanhSachThanhVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachThanhVien"];
            TextBox txtMaTV = (TextBox)grbThongTin.Controls["txtMaTV"];
            TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
            TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
            DateTimePicker dtpNgaySinh = (DateTimePicker)grbThongTin.Controls["dtpNgaySinh"];
            RadioButton rdbNam = (RadioButton)grbThongTin.Controls["rdbNam"];
            RadioButton rdbNu = (RadioButton)grbThongTin.Controls["rdbNu"];
            PictureBox hinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            ComboBox cbMaHoGd = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn thêm thêm thành viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (daQuanLyThanhVien.themThanhVien(txtMaTV.Text, txtHoTen.Text,this.checkGioiTinh(), txtSoCMND.Text, dtpNgaySinh.Value, txtSoDienThoai.Text, txtEmail.Text, hinhAnh, cbMaHoGd.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Thêm thành viên thành công!");
                        txtMaTV.Text = "";
                        txtHoTen.Text = "";
                        txtSoCMND.Text = "";
                        txtSoDienThoai.Text = "";
                        txtEmail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thể thêm thành viên này!");
                    }
                }
            }
            catch (ArgumentNullException ex) { MessageBox.Show("Vui lòng chọn ảnh cho thành viên"); }
        }
        public void xoaThanhVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            TextBox txtMaTV = (TextBox)grbThongTin.Controls["txtMaTV"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa thành viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyThanhVien.xoaThanhVienHoGD(txtMaTV.Text))
                {
                    MessageBox.Show("Xóa thành viên thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể xóa thành viên này!");
                }
            }
        }
        public void suaThanhVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyThanhVien.Controls["grbDanhSachThanhVien"];
            DataGridView dgvDanhSachThanhVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachThanhVien"];
            TextBox txtMaTV = (TextBox)grbThongTin.Controls["txtMaTV"];
            TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
            TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
            DateTimePicker dtpNgaySinh = (DateTimePicker)grbThongTin.Controls["dtpNgaySinh"];
            RadioButton rdbNam = (RadioButton)grbThongTin.Controls["rdbNam"];
            RadioButton rdbNu = (RadioButton)grbThongTin.Controls["rdbNu"];
            PictureBox hinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            ComboBox cbMaHoGd = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];

            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn cập nhật thành viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyThanhVien.suaThanhVien(txtMaTV.Text, txtHoTen.Text, this.checkGioiTinh(), txtSoCMND.Text, dtpNgaySinh.Value, txtSoDienThoai.Text, txtEmail.Text, hinhAnh, cbMaHoGd.SelectedValue.ToString()))
                {
                    MessageBox.Show("Cập nhật thành viên thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể cập nhật thành viên này!");
                }
            }
        }


        public void timThanhVien()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyThanhVien.Controls["grbDanhSachThanhVien"];
            DataGridView dgvDanhSachThanhVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachThanhVien"];
            ComboBox cbMaTV = (ComboBox)this.frmQuanLyThanhVien.Controls["cbMaThanhVien"];
            dgvDanhSachThanhVien.DataSource = daQuanLyThanhVien.timThanhVien(cbMaTV.SelectedValue.ToString());
            bind();
        }

        // bind dữ liệu khi tìm
        public void bind()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyThanhVien.Controls["grbDanhSachThanhVien"];
            DataGridView dgvDanhSachThanhVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachThanhVien"];
            TextBox txtMaTV = (TextBox)grbThongTin.Controls["txtMaTV"];
            TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
            TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
            DateTimePicker dtpNgaySinh = (DateTimePicker)grbThongTin.Controls["dtpNgaySinh"];
            RadioButton rdbNam = (RadioButton)grbThongTin.Controls["rdbNam"];
            RadioButton rdbNu = (RadioButton)grbThongTin.Controls["rdbNu"];
            PictureBox hinhAnh = (PictureBox)grbThongTin.Controls["ptbHinhAnh"];
            ComboBox cbMaHoGd = (ComboBox)grbThongTin.Controls["cbMaHoGiaDinh"];
            txtMaTV.DataBindings.Clear();
            txtMaTV.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "MATHANHVIEN");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "HOTENTHANHVIEN");

            txtSoCMND.DataBindings.Clear();
            txtSoCMND.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "SOCMND");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "SDT");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "EMAIL");

            cbMaHoGd.DataBindings.Clear();
            cbMaHoGd.DataBindings.Add("SelectedValue", dgvDanhSachThanhVien.DataSource, "MAHOGD");

            hinhAnh.DataBindings.Clear();
            hinhAnh.DataBindings.Add("Image", dgvDanhSachThanhVien.DataSource, "HINHANH", true);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhSachThanhVien.DataSource, "NGAYSINH");

            rdbNam.DataBindings.Clear();
            Binding binding = new Binding("Checked", dgvDanhSachThanhVien.DataSource, "GIOITINHTV");
            binding.Format += new ConvertEventHandler(binding_Format);
            binding.Parse += new ConvertEventHandler(binding_Parse);
            rdbNam.DataBindings.Add(binding);
            rdbNu.DataBindings.Clear();
            Binding binding2 = new Binding("Checked", dgvDanhSachThanhVien.DataSource, "GIOITINHTV");
            binding2.Format += new ConvertEventHandler(binding2_Format);
            binding2.Parse += new ConvertEventHandler(binding2_Parse);
            rdbNu.DataBindings.Add(binding2);

        }
        private String checkGioiTinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
            RadioButton rdbNam = (RadioButton)grbThongTin.Controls["rdbNam"];
            RadioButton rdbNu = (RadioButton)grbThongTin.Controls["rdbNu"];
            if (rdbNam.Checked)
            {
                return gioiTinh = "Nam";
            }
            if (rdbNu.Checked)
            {
                return gioiTinh = "Nữ";
            }
            return gioiTinh;
        }
        public void pictureBoxHinhAnh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyThanhVien.Controls["grbThongTin"];
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
        

        public void hienThiDanhSachThanhVienTheoHoGiaDinh(String maHoGD)
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyThanhVien.Controls["grbDanhSachThanhVien"];
            DataGridView dgvDanhSachThanhVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachThanhVien"];
            dgvDanhSachThanhVien.DataSource = daQuanLyThanhVien.hienThiThanhVienTheoGiaDinh(maHoGD);
            bind();
        }
    }
}
