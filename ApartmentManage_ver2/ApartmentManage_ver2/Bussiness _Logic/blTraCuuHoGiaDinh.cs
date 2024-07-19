using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ApartmentManage_ver2.Bussiness__Logic
{
    class blTraCuuHoGiaDinh
    {
        XuLyDuLieu xuLyDuLieu;
        Data_Access.daTraCuuHoGiaDinh daTraCuuHoGiaDinh;
        Form frmTraCuuHoGiaDinh;
        DataTable dt;

        public blTraCuuHoGiaDinh(Form f)
        {
            this.frmTraCuuHoGiaDinh = f;
            daTraCuuHoGiaDinh = new Data_Access.daTraCuuHoGiaDinh();
            xuLyDuLieu = new XuLyDuLieu();
        }

        //public void loadComboBoxTimKiemTheoMaHoGD()
        //{
        //    GroupBox grbThongTinCanTraCuuHoGiaDinh = (GroupBox)this.frmTraCuuHoGiaDinh.Controls["grbThongTinCanTraCuuHoGiaDinh"];
        //    ComboBox cobTraCuuTheoMaHoGD = (ComboBox)grbThongTinCanTraCuuHoGiaDinh.Controls["cobTraCuuTheoMaHoGD"];
        //    cobTraCuuTheoMaHoGD.DataSource = daTraCuuHoGiaDinh.loadComboboxMaHoGiaDinh();
        //    cobTraCuuTheoMaHoGD.DisplayMember = "MAHOGD";
        //    cobTraCuuTheoMaHoGD.ValueMember = "MAHOGD";
        //}

        //public void loadComboBoxTimKiemTheoTenChuHo()
        //{
        //    GroupBox grbThongTinCanTraCuuHoGiaDinh = (GroupBox)this.frmTraCuuHoGiaDinh.Controls["grbThongTinCanTraCuuHoGiaDinh"];
        //    ComboBox cobTraCuuTheoTenChuHo = (ComboBox)grbThongTinCanTraCuuHoGiaDinh.Controls["cobTraCuuTheoTenChuHo"];
        //    cobTraCuuTheoTenChuHo.DataSource = daTraCuuHoGiaDinh.loadComboboxTenChuHo();
        //    cobTraCuuTheoTenChuHo.DisplayMember = "TENCHUHO";
        //    cobTraCuuTheoTenChuHo.ValueMember = "TENCHUHO";
        //}

        public void loadComboBoxTimKiemTheoMaKhu()
        {
            GroupBox grbThongTinCanTraCuuHoGiaDinh = (GroupBox)this.frmTraCuuHoGiaDinh.Controls["grbThongTinCanTraCuuHoGiaDinh"];
            ComboBox cobTraCuuHoGiaDinhTheoMaKhu = (ComboBox)grbThongTinCanTraCuuHoGiaDinh.Controls["cobTraCuuHoGiaDinhTheoMaKhu"];
            cobTraCuuHoGiaDinhTheoMaKhu.DataSource = daTraCuuHoGiaDinh.loadComboboxMaKhu();
            cobTraCuuHoGiaDinhTheoMaKhu.DisplayMember = "MAKHU";
            cobTraCuuHoGiaDinhTheoMaKhu.ValueMember = "MAKHU";
        }

        public void hienThi()
        {
            //groupBox Danh Sach
            GroupBox grbDanhSachTraCuuHoGiaDinh = (GroupBox)this.frmTraCuuHoGiaDinh.Controls["grbDanhSachTraCuuHoGiaDinh"];
            //đổ dữ liệu vào datagridview
            DataGridView dgvDanhSachTraCuuHoGiaDinh = (DataGridView)grbDanhSachTraCuuHoGiaDinh.Controls["dgvDanhSachTraCuuHoGiaDinh"];
            dgvDanhSachTraCuuHoGiaDinh.DataSource = daTraCuuHoGiaDinh.HienThiHoGiaDinh();
        }

        public void TraCuuHoGiaDinh()
        {
            GroupBox grbDanhSachTraCuuHoGiaDinh = (GroupBox)this.frmTraCuuHoGiaDinh.Controls["grbDanhSachTraCuuHoGiaDinh"];
            DataGridView dgvDanhSachTraCuuHoGiaDinh = (DataGridView)grbDanhSachTraCuuHoGiaDinh.Controls["dgvDanhSachTraCuuHoGiaDinh"];
            GroupBox grbThongTinCanTraCuuHoGiaDinh = (GroupBox)this.frmTraCuuHoGiaDinh.Controls["grbThongTinCanTraCuuHoGiaDinh"];
            ComboBox cobTraCuuHoGiaDinhTheoMaKhu = (ComboBox)grbThongTinCanTraCuuHoGiaDinh.Controls["cobTraCuuHoGiaDinhTheoMaKhu"];
            TextBox txtTraCuuTheoMaHoGD = (TextBox)grbThongTinCanTraCuuHoGiaDinh.Controls["txtTraCuuTheoMaHoGD"];
            TextBox txtTraCuuTheoTenChuHo = (TextBox)grbThongTinCanTraCuuHoGiaDinh.Controls["txtTraCuuTheoTenChuHo"];
            try
            {
                dgvDanhSachTraCuuHoGiaDinh.DataSource = daTraCuuHoGiaDinh.TimKiemHoGiaDinh(txtTraCuuTheoMaHoGD.Text.Trim(),
                                                                                            txtTraCuuTheoTenChuHo.Text.Trim(),
                                                                                            cobTraCuuHoGiaDinhTheoMaKhu.SelectedValue.ToString());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("CHƯA CÓ DỮ LIỆU");
            }
        }
    }
}
