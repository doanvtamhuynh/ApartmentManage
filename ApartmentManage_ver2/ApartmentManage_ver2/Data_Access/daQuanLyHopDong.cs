using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyHopDong
    {
        XuLyDuLieu xuLyDuLieu;
       
        public daQuanLyHopDong()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }
        public DataTable danhSachCTHopDong()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiHopDongVaChiTietHopDong", null);
        }
        public DataTable dsHopDong()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiHopDong", null);
        }
        public DataTable loadComboboxMaNhanVien()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiNhanVien", null);
        }
        public DataTable loadComboboxMaCanHo()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiCanHo", null);
        }
        public DataTable loadComboboxMaHoGD()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }
        public bool themHopDong(String maHopDong, String tenHopDong, String loaiHopDong, String maCanHo, String maNhanVien, String mahoGiaDinh, float tongTien)
        {
            SqlParameter prMaHD = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHD.Value = maHopDong;
            SqlParameter prTenHopDong = new SqlParameter("@TENHOPDONG", SqlDbType.NVarChar, 50);
            prTenHopDong.Value = tenHopDong;
            SqlParameter prLoaiHopDong = new SqlParameter("@LOAIHOPDONG", SqlDbType.NVarChar, 10);
            prLoaiHopDong.Value = loaiHopDong;
            SqlParameter prMaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prMaCanHo.Value = maCanHo;
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NVarChar, 10);
            prMaNhanVien.Value = maNhanVien;
            SqlParameter prMaHoGiaDinh = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGiaDinh.Value = mahoGiaDinh;
            SqlParameter prTongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prTongTien.Value = tongTien;
            SqlParameter[] pr = { prMaHD, prTenHopDong, prLoaiHopDong, prMaCanHo, prMaNhanVien, prMaHoGiaDinh, prTongTien };
            return xuLyDuLieu.thucThiThuTuc("psThemMoiHopDong2", pr);
        }
        public bool themChiTietHopDong(String maHopDong, DateTime ngayKyHopDong, String thoiHan, float giaTri, String noiDung)
        {
            SqlParameter prMaHopDong = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHopDong.Value = maHopDong;
            SqlParameter prNgayKyHopDong = new SqlParameter("@NGAYKYHOPDONG", SqlDbType.DateTime);
            prNgayKyHopDong.Value = ngayKyHopDong;
            SqlParameter prThoiHan = new SqlParameter("@THOIHAN", SqlDbType.NVarChar, 10);
            prThoiHan.Value = thoiHan;
            SqlParameter prGiaTri = new SqlParameter("@GIATRI", SqlDbType.Float);
            prGiaTri.Value = giaTri;
            SqlParameter prNoiDung = new SqlParameter("@NOIDUNG", SqlDbType.NVarChar, 50);
            prNoiDung.Value = noiDung;

            SqlParameter[] pr = { prMaHopDong, prNgayKyHopDong, prThoiHan, prGiaTri, prNoiDung };
            return xuLyDuLieu.thucThiThuTuc("psThemChiTietHopDong", pr);
        }
        public object themTongTienHopDong(String maHopDong, float tongTien)
        {
            SqlParameter prTongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prTongTien.Value = tongTien;
            SqlParameter prMaHopDong = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHopDong.Value = maHopDong;
            SqlParameter[] pr = { prMaHopDong, prTongTien };
            return xuLyDuLieu.thucThiGiaTriDonThuTuc("psThemTongTienHopDong", pr);
        }
        public bool suaHopDong(String maHopDong, String tenHopDong, String loaiHopDong, String maCanHo, String maNhanVien, String mahoGiaDinh, float tongTien)
        {
            SqlParameter prMaHD = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHD.Value = maHopDong;
            SqlParameter prTenHopDong = new SqlParameter("@TENHOPDONG", SqlDbType.NVarChar, 50);
            prTenHopDong.Value = tenHopDong;
            SqlParameter prLoaiHopDong = new SqlParameter("@LOAIHOPDONG", SqlDbType.NVarChar, 10);
            prLoaiHopDong.Value = loaiHopDong;
            SqlParameter prMaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prMaCanHo.Value = maCanHo;
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NVarChar, 10);
            prMaNhanVien.Value = maNhanVien;
            SqlParameter prMaHoGiaDinh = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGiaDinh.Value = mahoGiaDinh;
            SqlParameter prTongTien = new SqlParameter("@TONGTIEN", SqlDbType.Float);
            prTongTien.Value = tongTien;
            SqlParameter[] pr = { prMaHD, prTenHopDong, prLoaiHopDong, prMaCanHo, prMaNhanVien, prMaHoGiaDinh, prTongTien };
            return xuLyDuLieu.thucThiThuTuc("psSuaHopDong", pr);
        }
        public bool xoaHopDong(String maHopDong)
        {
            SqlParameter prMaHD = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHD.Value = maHopDong;
            SqlParameter[] pr = { prMaHD };
            return xuLyDuLieu.thucThiThuTuc("psXoaHopDong", pr);
        }
        public bool suaChiTietHopDong(String maHopDong, DateTime ngayKyHopDong, String thoiHan, float giaTri, String noiDung)
        {
            SqlParameter prMaHopDong = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHopDong.Value = maHopDong;
            SqlParameter prNgayKyHopDong = new SqlParameter("@NGAYKYHOPDONG", SqlDbType.DateTime);
            prNgayKyHopDong.Value = ngayKyHopDong;
            SqlParameter prThoiHan = new SqlParameter("@THOIHAN", SqlDbType.NVarChar, 10);
            prThoiHan.Value = thoiHan;
            SqlParameter prGiaTri = new SqlParameter("@GIATRI", SqlDbType.Float);
            prGiaTri.Value = giaTri;
            SqlParameter prNoiDung = new SqlParameter("@NOIDUNG", SqlDbType.NVarChar, 50);
            prNoiDung.Value = noiDung;

            SqlParameter[] pr = { prMaHopDong, prNgayKyHopDong, prThoiHan, prGiaTri, prNoiDung };
            return xuLyDuLieu.thucThiThuTuc("psSuaChiTietHopDong", pr);
        }
        public bool xoaChiTietHopDong(String maHopDong)
        {
            SqlParameter prMaHopDong = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHopDong.Value = maHopDong;
            
            SqlParameter[] pr = { prMaHopDong };
            return xuLyDuLieu.thucThiThuTuc("psXoaCTHopDong", pr);
        }

        public DataTable timHopDong(String maHopDong)
        {
            SqlParameter prMaHopDong = new SqlParameter("@MAHOPDONG", SqlDbType.NVarChar, 10);
            prMaHopDong.Value = maHopDong;

            SqlParameter[] pr = { prMaHopDong };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimHopDong", pr);
        }
    }
}
