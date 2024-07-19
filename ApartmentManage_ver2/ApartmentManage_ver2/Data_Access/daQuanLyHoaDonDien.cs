using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyHoaDonDien
    {
        XuLyDuLieu XuLyDuLieu;
        public daQuanLyHoaDonDien()
        {
            XuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable danhSachChiTietHoaDonDien()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonVaChiTietHoaDonDien", null);
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

        public DataTable loadComboTimKiemMaHoaDonDien()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonDien", null);
        }

        public DataTable HienThiHoaDonDien()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonDien", null);
        }


        public bool themHoaDonDien(String maHoaDonDien, String tenHoaDon, String maNhanVien, String maHoGiaDinh, String maCanHo, String ngayIn, String tongTien, String ghiChu)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
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
            SqlParameter[] pr2 = { prmaHoaDonDien, prtenHoaDon, prmaNhanVien, prmaHoGiaDinh, prmaCanHo, prngayIn, prtongTien, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psThemHoaDonDien", pr2);
        }

        public bool xoaHoaDonDien(String maHoaDonDien)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
            SqlParameter[] pr = { prmaHoaDonDien };
            return XuLyDuLieu.thucThiThuTuc("psXoaHoaDonDien", pr);
        }

        public bool suaHoaDonDien(String maHoaDonDien, String tenHoaDon, String maNhanVien, String maHoGiaDinh, String maCanHo, String ngayIn, String tongTien, String ghiChu)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
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

            SqlParameter[] pr = { prmaHoaDonDien, prtenHoaDon, prmaNhanVien, prmaHoGiaDinh, prmaCanHo, prngayIn, prtongTien, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psSuaHoaDonDien", pr);
        }

        public bool themChiTietHoaDonDien(String maHoaDonDien, int soLuong, String donGia, String ghiChu)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
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

            SqlParameter[] pr = { prmaHoaDonDien, prsoLuong, prdonGia, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psThemChiTietHoaDonDien", pr);
        }

        public bool suaChiTietHoaDonDien(String maHoaDonDien, int soLuong, String ghiChu)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
            SqlParameter prsoLuong = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prsoLuong.Value = soLuong;
            SqlParameter prghiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prghiChu.Value = ghiChu;

            SqlParameter[] pr = { prmaHoaDonDien, prsoLuong, prghiChu };
            return XuLyDuLieu.thucThiThuTuc("psSuaChiTietHoaDonDien", pr);
        }

        public bool xoaChiTietHoaDonDien(String maHoaDonDien)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
            SqlParameter[] pr = { prmaHoaDonDien };
            return XuLyDuLieu.thucThiThuTuc("psXoaChiTietHoaDonDien", pr);
        }

        public object themTongTienChoHoaDonDien( String maHoaDonDien, String tongTien)
        {
            SqlParameter prtongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prtongTien.Value = tongTien;
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;
            SqlParameter[] pr = { prmaHoaDonDien, prtongTien };
            return XuLyDuLieu.thucThiGiaTriDonThuTuc("psThemTongTienChoHoaDonDien", pr);
        }

        public DataTable TimKiemChiTietHoaDonDienTheoMaHoaDon(String maHoaDonDien)
        {
            SqlParameter prmaHoaDonDien = new SqlParameter("@MAHOADONDIEN", SqlDbType.NVarChar, 10);
            prmaHoaDonDien.Value = maHoaDonDien;

            SqlParameter[] pr = { prmaHoaDonDien };
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoaDonVaChiTietHoaDonDienTheoMaHoaDon", pr);
        }

    }
}
