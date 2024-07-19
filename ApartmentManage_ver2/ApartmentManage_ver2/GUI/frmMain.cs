using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void changeInterface()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue";
        }

        public bool kiemTraForm(String nameForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(nameForm))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            changeInterface();
        }

        private void bbtnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmDoiMatKhau"))
            {
                frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
                frmDoiMatKhau.MdiParent = this;
                frmDoiMatKhau.Show();
            }
        }

        private void bbtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (!kiemTraForm("frmDangNhap"))
                {
                    this.Hide();
                    frmDangNhap frmDangNhap = new frmDangNhap();
                    frmDangNhap.Show();
                }
            }
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bbtnQuanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyTaiKhoan"))
            {
                frmQuanLyTaiKhoan frmQuanLyTaikhoan = new frmQuanLyTaiKhoan();
                frmQuanLyTaikhoan.MdiParent = this;
                frmQuanLyTaikhoan.Show();
            }
        }

        private void bbtnQuanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyNhanVien"))
            {
                frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
                frmQuanLyNhanVien.MdiParent = this;
                frmQuanLyNhanVien.Show();
            }
        }

        private void bbtnQuanLyCanHo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyCanHo"))
            {
                frmQuanLyCanHo frmQuanLyCanHo = new frmQuanLyCanHo();
                frmQuanLyCanHo.MdiParent = this;
                frmQuanLyCanHo.Show();
            }
        }

        private void bbtnQuanLyHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyNhanVien"))
            {
                frmQuanLyHopDong frmQuanLyHopDong = new frmQuanLyHopDong();
                frmQuanLyHopDong.MdiParent = this;
                frmQuanLyHopDong.Show();
            }
        }

        private void bbtnQuanLyHoGiaDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyHoGiaDinh"))
            {
                frmQuanLyHoGiaDinh frmQuanLyHoGiaDinh = new frmQuanLyHoGiaDinh();
                frmQuanLyHoGiaDinh.MdiParent = this;
                frmQuanLyHoGiaDinh.Show();
            }
        }

        private void bbtnQuanLyThanhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyThanhVien"))
            {
                frmQuanLyThanhVien frmQuanLyThanhVien = new frmQuanLyThanhVien();
                frmQuanLyThanhVien.MdiParent = this;
                frmQuanLyThanhVien.Show();
            }
        }

        private void bbtnThongKeDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmThongKeDichVu"))
            {
                frmThongKeDichVu frmThongKeDichVu = new frmThongKeDichVu();
                frmThongKeDichVu.MdiParent = this;
                frmThongKeDichVu.Show();
            }
        }

        private void bbtnThongKeTienDien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmThongKeTienDien"))
            {
                frmThongKeTienDien frmThongKeTienDien = new frmThongKeTienDien();
                frmThongKeTienDien.MdiParent = this;
                frmThongKeTienDien.Show();
            }
        }

        private void bbtnThongKeTienNuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmThongKeTienNuoc"))
            {
                frmThongKeTienNuoc frmThongKeTienNuoc = new frmThongKeTienNuoc();
                frmThongKeTienNuoc.MdiParent = this;
                frmThongKeTienNuoc.Show();
            }
        }

        private void bbtnQuanLyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyDichVu"))
            {
                frmQuanLyDichVu frmQuanLyDichVu = new frmQuanLyDichVu();
                frmQuanLyDichVu.MdiParent = this;
                frmQuanLyDichVu.Show();
            }
        }

        private void bbtnQuanLyHoaDonDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyHoaDonDichVu"))
            {
                frmQuanLyHoaDonDichVu frmQuanLyHoaDonDichVu = new frmQuanLyHoaDonDichVu();
                frmQuanLyHoaDonDichVu.MdiParent = this;
                frmQuanLyHoaDonDichVu.Show();
            }
        }

        private void bbtnThongKeCanHo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmThongKeCanHo"))
            {
                frmThongKeCanHo frmThongKeCanHo = new frmThongKeCanHo();
                frmThongKeCanHo.MdiParent = this;
                frmThongKeCanHo.Show();
            }
        }

        private void bbtnQuanLyNuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyHoaDonNuoc"))
            {
                frmQuanLyHoaDonNuoc frmQuanLyHoaDonNuoc = new frmQuanLyHoaDonNuoc();
                frmQuanLyHoaDonNuoc.MdiParent = this;
                frmQuanLyHoaDonNuoc.Show();
            }
        }

        private void bbtnQuanLyDien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmQuanLyHoaDonDien"))
            {
                frmQuanLyHoaDonDien frmQuanLyHoaDonDien = new frmQuanLyHoaDonDien();
                frmQuanLyHoaDonDien.MdiParent = this;
                frmQuanLyHoaDonDien.Show();
            }
        }

        private void bbtnThongKeDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmThongKeDoanhThu"))
            {
                frmThongKeDoanhThu frmThongKeDoanhThu = new frmThongKeDoanhThu();
                frmThongKeDoanhThu.MdiParent = this;
                frmThongKeDoanhThu.Show();
            }
        }

        private void bbtnTraCuuHoGiaDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmTraCuuHoGiaDinh"))
            {
                frmTraCuuHoGiaDinh frmTraCuuHoGiaDinh = new frmTraCuuHoGiaDinh();
                frmTraCuuHoGiaDinh.MdiParent = this;
                frmTraCuuHoGiaDinh.Show();
            }
        }

        private void bbtnLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraForm("frmTroGiup"))
            {
                frmTroGiup frmTroGiup = new frmTroGiup();
                frmTroGiup.MdiParent = this;
                frmTroGiup.Show();
            }
        }

        private void bbtnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (!kiemTraForm("frmThongTin"))
            {
                frmThongTin frmThongTin = new frmThongTin();
                frmThongTin.MdiParent = this;
                frmThongTin.Show();
            }
        }
    }
}
