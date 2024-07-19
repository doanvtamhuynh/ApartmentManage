using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyHoaDonDichVu
    {
        XuLyDuLieu XuLyDuLieu;

        public daQuanLyHoaDonDichVu()
        {
            XuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable danhSachChiTietDichVu()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonVaChiTietDichVu", null);
        }

        public DataTable loadComboboxMaNhanVien()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiNhanVien", null);
        }

        public DataTable loadComboboxMaHoGiaDinh()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }

        public DataTable loadComboboxMaCanHo()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiCanHo", null);
        }

        public DataTable loadComboboxMaDichVu()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiDichVu", null);
        }

        public DataTable loadComboTimKiemMaHoaDonDichVu()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonDichVu", null);
        }

        public DataTable HienThiHoaDonDien()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonDichVu", null);
        }

        public bool themHoaDonDichVu(String mahoadondichvu, String tenHoaDon, String maNhanVien, String maHoGiaDinh, String maCanHo, String ngayIn, String tongTien, String ghiChu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = mahoadondichvu;
            SqlParameter prtenHoaDon = new SqlParameter("@TENHOADON", SqlDbType.NVarChar, 30);
            prtenHoaDon.Value = tenHoaDon;
            SqlParameter prmaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NVarChar, 10);
            prmaNhanVien.Value = maNhanVien;
            SqlParameter prmaHoGiaDinh = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prmaHoGiaDinh.Value = maHoGiaDinh;
            SqlParameter prmaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prmaCanHo.Value = maCanHo;
            SqlParameter prngayIn = new SqlParameter("@NGAYIN", SqlDbType.DateTime);
            prngayIn.Value = ngayIn;
            SqlParameter prtongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prtongTien.Value = tongTien;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;
            SqlParameter[] pr2 = { prmaHoaDonDichVu, prtenHoaDon, prmaNhanVien, prmaHoGiaDinh, prmaCanHo, prngayIn, prtongTien, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psThemHoaDonDichVu", pr2);
        }

        public bool xoaHoaDonDichVu(String mahoadondichvu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = mahoadondichvu;
            SqlParameter[] pr = { prmaHoaDonDichVu };
            return XuLyDuLieu.thucThiThuTuc("psXoaHoaDonDichVu", pr);
        }

        public bool suaHoaDonDichVu(String mahoadondichvu, String tenHoaDon, String maNhanVien, String maHoGiaDinh, String maCanHo, String ngayIn, String tongTien, String ghiChu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = mahoadondichvu;
            SqlParameter prtenHoaDon = new SqlParameter("@TENHOADON", SqlDbType.NVarChar, 30);
            prtenHoaDon.Value = tenHoaDon;
            SqlParameter prmaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NVarChar, 10);
            prmaNhanVien.Value = maNhanVien;
            SqlParameter prmaHoGiaDinh = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prmaHoGiaDinh.Value = maHoGiaDinh;
            SqlParameter prmaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prmaCanHo.Value = maCanHo;
            SqlParameter prngayIn = new SqlParameter("@NGAYIN", SqlDbType.DateTime);
            prngayIn.Value = ngayIn;
            SqlParameter prtongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prtongTien.Value = tongTien;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;
            SqlParameter[] pr2 = { prmaHoaDonDichVu, prtenHoaDon, prmaNhanVien, prmaHoGiaDinh, prmaCanHo, prngayIn, prtongTien, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psSuaHoaDonDichVu", pr2);
        }

        public bool themChiTietHoaDonDichVu(String mahoadondichvu,int soLuong, String donGia, String ghiChu, String madichvu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = mahoadondichvu;
            SqlParameter prsoLuong = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prsoLuong.Value = soLuong;
            SqlParameter prdonGia = new SqlParameter("@DONGIA", SqlDbType.Float);
            prdonGia.Value = donGia;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;
            SqlParameter prmadichvu = new SqlParameter("@MADICHVU", SqlDbType.NVarChar, 50);
            prmadichvu.Value = madichvu;

            SqlParameter[] pr = { prmaHoaDonDichVu, prsoLuong, prdonGia, prghiChu, prmadichvu };
            return XuLyDuLieu.thucThiThuTuc("psThemChiTietHoaDonDichVu", pr);
        }

        public bool suaChiTietHoaDonDichVu(String mahoadondichvu, int soLuong, String donGia, String ghiChu, String madichvu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = mahoadondichvu;
            SqlParameter prsoLuong = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prsoLuong.Value = soLuong;
            SqlParameter prdonGia = new SqlParameter("@DONGIA", SqlDbType.Float);
            prdonGia.Value = donGia;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;
            SqlParameter prmadichvu = new SqlParameter("@MADICHVU", SqlDbType.NVarChar, 50);
            prmadichvu.Value = madichvu;

            SqlParameter[] pr = { prmaHoaDonDichVu, prsoLuong, prdonGia, prghiChu, prmadichvu };
            return XuLyDuLieu.thucThiThuTuc("psSuaChiTietHoaDonDichVu", pr);
        }

        public bool xoaChiTietHoaDonDichVu(String mahoadondichvu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = mahoadondichvu;
            SqlParameter[] pr = { prmaHoaDonDichVu };
            return XuLyDuLieu.thucThiThuTuc("psXoaChiTietHoaDonDichVu", pr);
        }

        public object themTongTienChoHoaDonDichVu(String maHoaDonDichVu, String tongTien)
        {
            SqlParameter prtongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prtongTien.Value = tongTien;
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = maHoaDonDichVu;
            SqlParameter[] pr = { prmaHoaDonDichVu, prtongTien };
            return XuLyDuLieu.thucThiGiaTriDonThuTuc("psThemTongTienChoHoaDonDichVu", pr);
        }

        public DataTable TimKiemHoaDonDichVuTheoMaHoaDon(String maHoaDonDichVu)
        {
            SqlParameter prmaHoaDonDichVu = new SqlParameter("@MAHOADONDV", SqlDbType.NVarChar, 10);
            prmaHoaDonDichVu.Value = maHoaDonDichVu;

            SqlParameter[] pr = { prmaHoaDonDichVu };
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonVaChiTietDichVuTheoMaHoaDon", pr);
        }
    }
}
