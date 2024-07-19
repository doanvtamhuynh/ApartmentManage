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
    class blQuanLyDichVu
    {
        XuLyDuLieu xuLyDuLieu;
        Data_Access.daQuanLyDichVu daQuanLyDichVu;
        Form frmQuanLyDichVu;
        DataTable dt;

        public blQuanLyDichVu(Form f)
        {
            this.frmQuanLyDichVu = f;
            daQuanLyDichVu = new Data_Access.daQuanLyDichVu();
            xuLyDuLieu = new XuLyDuLieu();
        }

        public void loadComboBoxTimKiemDichVu()
        {
            ComboBox cobTimDichVu = (ComboBox)this.frmQuanLyDichVu.Controls["cobTimDichVu"];
            cobTimDichVu.DataSource = daQuanLyDichVu.danhSachDichVu();
            cobTimDichVu.DisplayMember = "TENDICHVU";
            cobTimDichVu.ValueMember = "MADICHVU";
        }

        public void hienThi()
        {
            //groupBox Danh Sach
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyDichVu.Controls["grbDanhSach"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachDichVu = (DataGridView)grbDanhSach.Controls["dgvDanhSachDichVu"];
            dgvDanhSachDichVu.DataSource = daQuanLyDichVu.danhSachDichVu();
        }

        public void bindingData()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyDichVu.Controls["grbThongTin"];

            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyDichVu.Controls["grbDanhSach"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachDichVu = (DataGridView)grbDanhSach.Controls["dgvDanhSachDichVu"];

            TextBox txtMadichvu = (TextBox)grbThongTin.Controls["txtMadichvu"];
            TextBox txtTendichvu = (TextBox)grbThongTin.Controls["txtTendichvu"];
            TextBox txtGia = (TextBox)grbThongTin.Controls["txtGia"];
            txtMadichvu.DataBindings.Clear();
            txtMadichvu.DataBindings.Add("Text", dgvDanhSachDichVu.DataSource, "MADICHVU");
            txtTendichvu.DataBindings.Clear();
            txtTendichvu.DataBindings.Add("Text", dgvDanhSachDichVu.DataSource, "TENDICHVU");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvDanhSachDichVu.DataSource, "GIADICHVU");
        }

        public void themMoiDichVu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyDichVu.Controls["grbThongTin"];
            TextBox txtMadichvu = (TextBox)grbThongTin.Controls["txtMadichvu"];
            TextBox txtTendichvu = (TextBox)grbThongTin.Controls["txtTendichvu"];
            TextBox txtGia = (TextBox)grbThongTin.Controls["txtGia"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN THÊM DỊCH VỤ NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkEmptyString(txtMadichvu.Text) == false)
                {
                    if (daQuanLyDichVu.themDichVu(txtMadichvu.Text, txtTendichvu.Text, txtGia.Text))
                    {
                        MessageBox.Show("ĐÃ LƯU DỊCH VỤ MỚI");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI THÊM MỚI DỊCH VỤ");
                    }
                }
                else
                {
                    MessageBox.Show("LỖI KHI THÊM MỚI DỊCH VỤ");
                }
            }
        }

        public void suaDichVu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyDichVu.Controls["grbThongTin"];
            TextBox txtMadichvu = (TextBox)grbThongTin.Controls["txtMadichvu"];
            TextBox txtTendichvu = (TextBox)grbThongTin.Controls["txtTendichvu"];
            TextBox txtGia = (TextBox)grbThongTin.Controls["txtGia"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN SỬA DỊCH VỤ NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkEmptyString(txtMadichvu.Text) == false)
                {
                    if (daQuanLyDichVu.suaDichVu(txtMadichvu.Text, txtTendichvu.Text, txtGia.Text))
                    {
                        MessageBox.Show("ĐÃ SỬA DỊCH VỤ MỚI");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI SỬA DỊCH VỤ");
                    }
                }
                else
                {
                    MessageBox.Show("LỖI KHI SỬA DỊCH VỤ");
                }
            }
        }

        public void xoaDichVu()
        {
            GroupBox grbThongTin = (GroupBox)this.frmQuanLyDichVu.Controls["grbThongTin"];
            TextBox txtMadichvu = (TextBox)grbThongTin.Controls["txtMadichvu"];
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XOÁ DỊCH VỤ NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkEmptyString(txtMadichvu.Text) == false)
                {
                    if (daQuanLyDichVu.xoaDichVu(txtMadichvu.Text))
                    {
                        MessageBox.Show("ĐÃ XOÁ DỊCH VỤ");
                    }
                    else
                    {
                        MessageBox.Show("LỖI KHI XOÁ DỊCH VỤ");
                    }
                }
                else
                {
                    MessageBox.Show("LỖI KHI XOÁ DỊCH VỤ");
                }
            }
        }

        public void TimKiemDichVu()
        {
            GroupBox grbDanhSach = (GroupBox)this.frmQuanLyDichVu.Controls["grbDanhSach"];
            DataGridView dgvDanhSachDichVu = (DataGridView)grbDanhSach.Controls["dgvDanhSachDichVu"];
            ComboBox cobTimDichVu = (ComboBox)this.frmQuanLyDichVu.Controls["cobTimDichVu"];
            try
            {
                dgvDanhSachDichVu.DataSource = daQuanLyDichVu.TimKiemDichVuTheoTenDichVu(cobTimDichVu.SelectedValue.ToString());
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
