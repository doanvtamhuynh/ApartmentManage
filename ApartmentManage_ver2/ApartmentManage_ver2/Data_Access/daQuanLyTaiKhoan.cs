using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyTaiKhoan
    {
        XuLyDuLieu xuLyDuLieu;
        public daQuanLyTaiKhoan()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable danhSachTaiKhoan()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiDanhSachTaiKhoan", null);
        }

        public DataTable loadComboboxMaNhanVien()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psLoadComboBoxNhanVien", null);
        }

        public DataTable loadComboboxQuyen()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiQuyen", null);
        }

        public bool themTaiKhoan(String maNhanVien, String tenDangNhap, String matKhau, String quyen)
        {
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NVarChar, 10);
            prMaNhanVien.Value = maNhanVien;
            SqlParameter prTenDangNhap = new SqlParameter("@TENDANGNHAP", SqlDbType.NVarChar, 30);
            prTenDangNhap.Value = tenDangNhap;
            SqlParameter prMatKhau = new SqlParameter("@MATKHAU", SqlDbType.NVarChar, 20);
            prMatKhau.Value = matKhau;
            SqlParameter prQuyen = new SqlParameter("@IDQUYEN", SqlDbType.NVarChar, 10);
            prQuyen.Value = quyen;

            SqlParameter[] pr = { prMaNhanVien, prTenDangNhap, prMatKhau, prQuyen };
            return xuLyDuLieu.thucThiThuTuc("psThemTaiKhoan", pr);
        }

        public bool xoaTaiKhoan(String tenDangNhap)
        {
            SqlParameter prTenDangNhap = new SqlParameter("@TENDANGNHAP", SqlDbType.NVarChar, 30);
            prTenDangNhap.Value = tenDangNhap;

            SqlParameter[] pr = { prTenDangNhap};
            return xuLyDuLieu.thucThiThuTuc("psXoaTaiKhoan", pr);
        }

        public bool suaTaiKhoan(String maNhanVien, String tenDangNhap, String matKhau, String quyen)
        {
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NVarChar, 10);
            prMaNhanVien.Value = maNhanVien;
            SqlParameter prTenDangNhap = new SqlParameter("@TENDANGNHAP", SqlDbType.NVarChar, 30);
            prTenDangNhap.Value = tenDangNhap;
            SqlParameter prMatKhau = new SqlParameter("@MATKHAU", SqlDbType.NVarChar, 20);
            prMatKhau.Value = matKhau;
            SqlParameter prQuyen = new SqlParameter("@IDQUYEN", SqlDbType.NVarChar, 10);
            prQuyen.Value = quyen;

            SqlParameter[] pr = { prMaNhanVien, prTenDangNhap, prMatKhau, prQuyen };
            return xuLyDuLieu.thucThiThuTuc("psSuaTaiKhoan", pr);
        }

        public DataTable timKiemTaiKhoan(String tenDangNhap)
        {
            SqlParameter prTenDangNhap = new SqlParameter("@TENDANGNHAP", SqlDbType.NVarChar, 30);
            prTenDangNhap.Value = tenDangNhap;

            SqlParameter[] pr = { prTenDangNhap };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimKiemTaiKhoan", pr);
        }
    }
}
