using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blQuanLyHoGiaDinh
    {
        Data_Access.daQuanLyHoGiaDinh daQuanLyHoGiaDinh;
        Form frmQuanLyHoGiaDinh;
        public blQuanLyHoGiaDinh(Form f)
        {
            this.frmQuanLyHoGiaDinh = f;
            daQuanLyHoGiaDinh = new Data_Access.daQuanLyHoGiaDinh();
        }
        public void loadComboboxMaHoGiaDinh()
        {
            ComboBox cbMaHoGD = (ComboBox)this.frmQuanLyHoGiaDinh.Controls["cbMaHoGiaDinh"];
            cbMaHoGD.DataSource = daQuanLyHoGiaDinh.danhSachHoGiaDinh();
            cbMaHoGD.DisplayMember = "MAHOGD" + "TENCHUHO";
            cbMaHoGD.ValueMember = "MAHOGD";

        }
        public void hienThiHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbDanhSachHoGiaDinh"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachHoGiaDinh"];
            dgvDanhSach.DataSource = daQuanLyHoGiaDinh.danhSachHoGiaDinh();
            TextBox txtMaHoGiaDinh = (TextBox)grbThongTin.Controls["txtMaHoGD"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtSoLuongTv = (TextBox)grbThongTin.Controls["txtSoLuongTV"];

            txtMaHoGiaDinh.DataBindings.Clear();
            txtMaHoGiaDinh.DataBindings.Add("Text", dgvDanhSach.DataSource, "MAHOGD");
            txtTenChuHo.DataBindings.Clear();
            txtTenChuHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "TENCHUHO");
            txtSoLuongTv.DataBindings.Clear();
            txtSoLuongTv.DataBindings.Add("Text", dgvDanhSach.DataSource, "SOLUONGTV");
            txtSoCMND.DataBindings.Clear();
            txtSoCMND.DataBindings.Add("Text", dgvDanhSach.DataSource, "SOCMND");
            
        }
        public void buttonXemDanhSachTV()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbDanhSachHoGiaDinh"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachHoGiaDinh"];
            //dgvDanhSach.DataSource = daQuanLyHoGiaDinh.danhSachHoGiaDinh();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Danh sách thành viên";
            btn.Name = "button";
            btn.Text = "Xem";
            btn.Width = 130;
            btn.UseColumnTextForButtonValue = true;
            dgvDanhSach.Columns.Add(btn);
        }
        public void themHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbDanhSachHoGiaDinh"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachHoGiaDinh"];
            TextBox txtMaHoGiaDinh = (TextBox)grbThongTin.Controls["txtMaHoGD"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtSoLuongTv = (TextBox)grbThongTin.Controls["txtSoLuongTV"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thêm hộ gia đình này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHoGiaDinh.themHoGiaDinh(txtMaHoGiaDinh.Text, txtTenChuHo.Text, txtSoCMND.Text, Convert.ToInt16(txtSoLuongTv.Text)))
                {
                    MessageBox.Show("Thêm hộ gia đình thành công!");
                    txtMaHoGiaDinh.Text = "";
                    txtTenChuHo.Text = "";
                    txtSoCMND.Text = "";
                    txtSoLuongTv.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể thêm hộ gia đình này!");
                }
            }
        }
        public void xoaHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbThongTin"];
            TextBox txtMaHoGiaDinh = (TextBox)grbThongTin.Controls["txtMaHoGD"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa hộ gia đình này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHoGiaDinh.xoaHoGiaDinh(txtMaHoGiaDinh.Text))
                {
                    MessageBox.Show("Xóa hộ gia đình thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể xóa hộ gia đình này!");
                }
            }
        }
        public void suaHoGiaDinh()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbDanhSachHoGiaDinh"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachHoGiaDinh"];
            TextBox txtMaHoGiaDinh = (TextBox)grbThongTin.Controls["txtMaHoGD"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtSoLuongTv = (TextBox)grbThongTin.Controls["txtSoLuongTV"];
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn cập nhật hộ gia đình này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daQuanLyHoGiaDinh.suaHoGiaDinh(txtMaHoGiaDinh.Text, txtTenChuHo.Text, txtSoCMND.Text, Convert.ToInt16(txtSoLuongTv.Text)))
                {
                    MessageBox.Show("Cập nhật hộ gia đình thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể cập nhật hộ gia đình này!");
                }
            }
        }
        public void timHoGiaDinh()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbDanhSachHoGiaDinh"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachHoGiaDinh"];
            ComboBox cbMaHoGD = (ComboBox)this.frmQuanLyHoGiaDinh.Controls["cbMaHoGiaDinh"];
            dgvDanhSach.DataSource = daQuanLyHoGiaDinh.timHoGiaDinh(cbMaHoGD.SelectedValue.ToString());
            bind();
        }

        public void bind()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbThongTin"];
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyHoGiaDinh.Controls["grbDanhSachHoGiaDinh"];
            DataGridView dgvDanhSach = (DataGridView)grbDanhSach.Controls["dgvDanhSachHoGiaDinh"];
       
            TextBox txtMaHoGiaDinh = (TextBox)grbThongTin.Controls["txtMaHoGD"];
            TextBox txtTenChuHo = (TextBox)grbThongTin.Controls["txtTenChuHo"];
            TextBox txtSoCMND = (TextBox)grbThongTin.Controls["txtSoCMND"];
            TextBox txtSoLuongTv = (TextBox)grbThongTin.Controls["txtSoLuongTV"];

            txtMaHoGiaDinh.DataBindings.Clear();
            txtMaHoGiaDinh.DataBindings.Add("Text", dgvDanhSach.DataSource, "MAHOGD");
            txtTenChuHo.DataBindings.Clear();
            txtTenChuHo.DataBindings.Add("Text", dgvDanhSach.DataSource, "TENCHUHO");
            txtSoLuongTv.DataBindings.Clear();
            txtSoLuongTv.DataBindings.Add("Text", dgvDanhSach.DataSource, "SOLUONGTV");
            txtSoCMND.DataBindings.Clear();
            txtSoCMND.DataBindings.Add("Text", dgvDanhSach.DataSource, "SOCMND");

        }
    }
}
