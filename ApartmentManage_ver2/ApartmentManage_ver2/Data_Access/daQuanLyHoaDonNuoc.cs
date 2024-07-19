using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyHoaDonNuoc
    {
        XuLyDuLieu XuLyDuLieu;

        public daQuanLyHoaDonNuoc()
        {
            XuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable danhSachChiTietHoaDonNuoc()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonVaChiTietHoaDonNuoc", null);
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

        public DataTable loadComboTimKiemMaHoaDonNuoc()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonNuoc", null);
        }

        public bool themHoaDonNuoc(String maHoaDonNuoc, String tenHoaDon, String maNhanVien, String maHoGiaDinh, String maCanHo, String ngayIn, String tongTien, String ghiChu)
        {
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;
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
            //String SQL = " insert into HOADONDIEN(MAHOADONDIEN, TENHOADON, MANHANVIEN, MAHOGD, MACANHO, NGAYIN, TONGTIEN, GHICHU)"
            //        + " values ("
            //        + "'" + maHoaDonDien + "',"
            //        + "'" + tenHoaDon + "',"
            //        + "'" + maNhanVien + "',"
            //        + "'" + maHoGiaDinh + "',"
            //        + "'" + maCanHo + "',"
            //        + "'" + ngayIn + "',"
            //        + "'" + tongTien + "',"
            //        + "'" + ghiChu + "'"
            //        + ")";

            //return XuLyDuLieu.thucThiSQL(SQL);
            SqlParameter[] pr2 = { prmaHoaDonNuoc, prtenHoaDon, prmaNhanVien, prmaHoGiaDinh, prmaCanHo, prngayIn, prtongTien, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psThemHoaDonNuoc", pr2);
        }

        public bool xoaHoaDonNuoc(String maHoaDonNuoc)
        {
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;
            SqlParameter[] pr = { prmaHoaDonNuoc };
            return XuLyDuLieu.thucThiThuTuc("psXoaHoaDonNuoc" +
                "", pr);
        }

        public bool suaHoaDonNuoc(String maHoaDonNuoc, String tenHoaDon, String maNhanVien, String maHoGiaDinh, String maCanHo, String ngayIn, String tongTien, String ghiChu)
        {
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;
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

            SqlParameter[] pr = { prmaHoaDonNuoc, prtenHoaDon, prmaNhanVien, prmaHoGiaDinh, prmaCanHo, prngayIn, prtongTien, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psSuaHoaDonNuoc", pr);
        }

        public bool themChiTietHoaDonNuoc(String maHoaDonNuoc, int soLuong, String donGia, String ghiChu)
        {
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;
            SqlParameter prsoLuong = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prsoLuong.Value = soLuong;
            SqlParameter prdonGia = new SqlParameter("@DONGIA", SqlDbType.Float);
            prdonGia.Value = donGia;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;


            //String SQL = " insert into CTHDDIEN(MAHOADONDIEN,SOLUONG,DONGIA,GHICHU)"
            //        + " values ("
            //        + "'" + maHoaDonDien + "',"
            //        + "'" + soLuong + "',"
            //        + "'" + donGia + "',"
            //        + "'" + ghiChu + "'"
            //        + ")";

            //return XuLyDuLieu.thucThiSQL(SQL);

            SqlParameter[] pr = { prmaHoaDonNuoc, prsoLuong, prdonGia, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psThemChiTietHoaDonNuoc", pr);
        }

        public bool suaChiTietHoaDonNuoc(String maHoaDonNuoc, int soLuong, String ghiChu)
        {
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;
            SqlParameter prsoLuong = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prsoLuong.Value = soLuong;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;

            SqlParameter[] pr = { prmaHoaDonNuoc, prsoLuong, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psSuaChiTietHoaDonNuoc", pr);
        }

        public bool xoaChiTietHoaDonNuoc(String maHoaDonNuoc)
        {
            SqlParameter prmaHoaDoNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDoNuoc.Value = maHoaDonNuoc;
            SqlParameter[] pr = { prmaHoaDoNuoc };
            return XuLyDuLieu.thucThiThuTuc("psXoaChiTietHoaDonNuoc", pr);
        }

        public object themTongTienChoHoaDonNuoc(String maHoaDonNuoc, String tongTien)
        {
            SqlParameter prtongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prtongTien.Value = tongTien;
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;
            SqlParameter[] pr = { prmaHoaDonNuoc, prtongTien };
            return XuLyDuLieu.thucThiGiaTriDonThuTuc("psThemTongTienChoHoaDonNuoc", pr);
        }

        public DataTable TimKiemChiTietHoaDonNuocTheoMaHoaDon(String maHoaDonNuoc)
        {
            SqlParameter prmaHoaDonNuoc = new SqlParameter("@MAHOADONNUOC", SqlDbType.NVarChar, 10);
            prmaHoaDonNuoc.Value = maHoaDonNuoc;

            SqlParameter[] pr = { prmaHoaDonNuoc };
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonVaChiTietHoaDonNuocTheoMaHoaDon", pr);
        }

    }
}
