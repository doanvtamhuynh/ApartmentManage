using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyNhanVien
    {
        Data_Access.daQuanLyNhanVien daQuanLyNhanVien;
        Form frmQuanLyNhanVien;
        XuLyDuLieu xuLyDuLieu;
        String SQL;
        public blQuanLyNhanVien(Form f)
        {
            this.frmQuanLyNhanVien = f;
            daQuanLyNhanVien = new Data_Access.daQuanLyNhanVien();
            xuLyDuLieu = new XuLyDuLieu();
        }

        public void loadComboBoxPhongBan()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
            ComboBox cobMaPhongBan = (ComboBox)grbThongTin.Controls["cobMaPhongBan"];
            cobMaPhongBan.DataSource = daQuanLyNhanVien.loadComboboxMaPhongBan();
            cobMaPhongBan.ValueMember = "MAPHONGBAN";
            cobMaPhongBan.DisplayMember = "TENPHONGBAN";
        }

        public void loadComboBoxTimKiem()
        {
            ComboBox cobTimKiem = (ComboBox)this.frmQuanLyNhanVien.Controls["cobTimKiem"];
            cobTimKiem.DataSource = daQuanLyNhanVien.danhSachNhanVien();
            cobTimKiem.ValueMember = "MANHANVIEN";
            cobTimKiem.DisplayMember = "HOTEN";
        }
        private String rdbtngioiTinh()
        {
            String gioiTinh;
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
            RadioButton rdbtnNam = (RadioButton)grbThongTin.Controls["rdbtnNam"];
            RadioButton rdbtnNu = (RadioButton)grbThongTin.Controls["rdbtnNu"];
            if (rdbtnNam.Checked)
            {
                gioiTinh = rdbtnNam.Text;
            }
            else
            {
                gioiTinh = rdbtnNu.Text;
            }
            return gioiTinh;
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
            if ((bool)e.Value) e.Value = "Nữ";
            else e.Value = "Nam";
        }
        public void loadAnhNhanVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
            PictureBox ptbAnhNhanVien = (PictureBox)grbThongTin.Controls["ptbAnhNhanVien"];
            OpenFileDialog oFileDlog = new OpenFileDialog();
            oFileDlog.Multiselect = false;
            oFileDlog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png | All files (*.*) | *.*";
            DialogResult result = oFileDlog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ptbAnhNhanVien.ImageLocation = oFileDlog.FileName;
            }
        }


        public void hienThi()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyNhanVien.Controls["grbDanhSach"];
            DataGridView dgvDanhSachNhanVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachNhanVien"];
            dgvDanhSachNhanVien.DataSource = daQuanLyNhanVien.danhSachNhanVien();
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
            TextBox txtMaNhanVien = (TextBox)grbThongTin.Controls["txtMaNhanVien"];
            TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
            RadioButton rdbtnNam = (RadioButton)grbThongTin.Controls["rdbtnNam"];
            RadioButton rdbtnNu = (RadioButton)grbThongTin.Controls["rdbtnNu"];
            TextBox txtDiaChi = (TextBox)grbThongTin.Controls["txtDiaChi"];
            TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
            DateTimePicker dtpNGAYSINH = (DateTimePicker)grbThongTin.Controls["dtpNGAYSINH"];
            TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            PictureBox ptbAnhNhanVien = (PictureBox)grbThongTin.Controls["ptbAnhNhanVien"];
            ComboBox cobMaPhongBan = (ComboBox)grbThongTin.Controls["cobMaPhongBan"];
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "MANHANVIEN");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "HOTEN");
            rdbtnNam.DataBindings.Clear();
            Binding binding = new Binding("Checked", dgvDanhSachNhanVien.DataSource, "GIOITINH");
            binding.Format += new ConvertEventHandler(binding_Format);
            binding.Parse += new ConvertEventHandler(binding_Parse);
            rdbtnNam.DataBindings.Add(binding);
            rdbtnNu.DataBindings.Clear();
            Binding binding2 = new Binding("Checked", dgvDanhSachNhanVien.DataSource, "GIOITINH");
            binding2.Format += new ConvertEventHandler(binding2_Format);
            binding2.Parse += new ConvertEventHandler(binding2_Parse);
            rdbtnNu.DataBindings.Add(binding2);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "DIACHI");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "SDT");
            dtpNGAYSINH.DataBindings.Clear();
            dtpNGAYSINH.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "NGAYSINH");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "EMAIL");
            txtSoCMND.DataBindings.Clear();
            txtSoCMND.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "SOCMND");
            ptbAnhNhanVien.DataBindings.Clear();
            ptbAnhNhanVien.DataBindings.Add("Image", dgvDanhSachNhanVien.DataSource, "HINHANH", true);
            cobMaPhongBan.DataBindings.Clear();
            cobMaPhongBan.DataBindings.Add("SelectedValue", dgvDanhSachNhanVien.DataSource, "MAPHONGBAN");
        }

        public void themNhanVien()
        {
            try
            {
                GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
                TextBox txtMaNhanVien = (TextBox)grbThongTin.Controls["txtMaNhanVien"];
                TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
                RadioButton rdbtnNam = (RadioButton)grbThongTin.Controls["rdbtnNam"];
                RadioButton rdbtnNu = (RadioButton)grbThongTin.Controls["rdbtnNu"];
                TextBox txtDiaChi = (TextBox)grbThongTin.Controls["txtDiaChi"];
                TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
                DateTimePicker dtpNGAYSINH = (DateTimePicker)grbThongTin.Controls["dtpNGAYSINH"];
                TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
                TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
                PictureBox ptbAnhNhanVien = (PictureBox)grbThongTin.Controls["ptbAnhNhanVien"];
                ComboBox cobMaPhongBan = (ComboBox)grbThongTin.Controls["cobMaPhongBan"];
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn thêm tài khoản này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (daQuanLyNhanVien.themNhanVien(txtMaNhanVien.Text, txtHoTen.Text, rdbtngioiTinh(),
                        txtDiaChi.Text, txtSoDienThoai.Text, dtpNGAYSINH.Value, txtEmail.Text, txtSoCMND.Text,
                        ptbAnhNhanVien, cobMaPhongBan.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thể thêm nhân viên này!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn ảnh cho nhân viên!");
            }
           
        }

        public void suaNhanVien()
        {
                GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
                TextBox txtMaNhanVien = (TextBox)grbThongTin.Controls["txtMaNhanVien"];
                TextBox txtHoTen = (TextBox)grbThongTin.Controls["txtHoTen"];
                RadioButton rdbtnNam = (RadioButton)grbThongTin.Controls["rdbtnNam"];
                RadioButton rdbtnNu = (RadioButton)grbThongTin.Controls["rdbtnNu"];
                TextBox txtDiaChi = (TextBox)grbThongTin.Controls["txtDiaChi"];
                TextBox txtSoDienThoai = (TextBox)grbThongTin.Controls["txtSoDienThoai"];
                DateTimePicker dtpNGAYSINH = (DateTimePicker)grbThongTin.Controls["dtpNGAYSINH"];
                TextBox txtEmail = (TextBox)grbThongTin.Controls["txtEmail"];
                TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
                PictureBox ptbAnhNhanVien = (PictureBox)grbThongTin.Controls["ptbAnhNhanVien"];
                ComboBox cobMaPhongBan = (ComboBox)grbThongTin.Controls["cobMaPhongBan"];
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn sửa nhân viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (daQuanLyNhanVien.suaNhanVien(txtMaNhanVien.Text, txtHoTen.Text, rdbtngioiTinh(),
                        txtDiaChi.Text, txtSoDienThoai.Text, dtpNGAYSINH.Value, txtEmail.Text, txtSoCMND.Text,
                        ptbAnhNhanVien, cobMaPhongBan.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Sửa nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thể sửa nhân viên này!");
                    }
                }
        }

        public void xoaNhanVien()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyNhanVien.Controls["grbThongTin"];
            TextBox txtMaNhanVien = (TextBox)grbThongTin.Controls["txtMaNhanVien"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyNhanVien.xoaNhanVien(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể xóa nhân viên này!");
                }
            }
        }

        public void timKiemNhanVien()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyNhanVien.Controls["grbDanhSach"];
            DataGridView dgvDanhSachNhanVien = (DataGridView)grbDanhSach.Controls["dgvDanhSachNhanVien"];
            ComboBox cobTimKiem = (ComboBox)this.frmQuanLyNhanVien.Controls["cobTimKiem"];
            dgvDanhSachNhanVien.DataSource = daQuanLyNhanVien.timKiemNhanVien(cobTimKiem.SelectedValue.ToString());
        }
    }
}
