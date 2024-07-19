using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    
    class daQuanLyHoGiaDinh
    {
        XuLyDuLieu xuLyDuLieu;
        public daQuanLyHoGiaDinh()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }
        public DataTable danhSachHoGiaDinh()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh",null);
        }
        public bool themHoGiaDinh(String maHoGD, String tenChuHo, String soCMND, int soLuongTV)
        {
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter prTenChuHo = new SqlParameter("@TENCHUHO", SqlDbType.NVarChar, 30);
            prTenChuHo.Value = tenChuHo;
            SqlParameter prSoCMND = new SqlParameter("@SOCMND", SqlDbType.NVarChar, 18);
            prSoCMND.Value = soCMND;
            SqlParameter prSoLuongTV = new SqlParameter("@SOLUONGTV", SqlDbType.Int);
            prSoLuongTV.Value = soLuongTV;
            SqlParameter[] pr = { prMaHoGD, prTenChuHo, prSoCMND, prSoLuongTV };
            return xuLyDuLieu.thucThiThuTuc("psThemHoGiaDinh", pr);
        }
        public bool xoaHoGiaDinh (String maHoGD)
        {
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaHoGD };
            return xuLyDuLieu.thucThiThuTuc("psXoaHoGiaDinh", pr);
        }
        public bool suaHoGiaDinh(String maHoGD, String tenChuHo, String soCMND, int soLuongTV)
        {
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter prTenChuHo = new SqlParameter("@TENCHUHO", SqlDbType.NVarChar, 30);
            prTenChuHo.Value = tenChuHo;
            SqlParameter prSoCMND = new SqlParameter("@SOCMND", SqlDbType.NVarChar, 30);
            prSoCMND.Value = soCMND;
            SqlParameter prSoLuongTV = new SqlParameter("@SOLUONGTV", SqlDbType.Int);
            prSoLuongTV.Value = soLuongTV;
            SqlParameter[] pr = { prMaHoGD, prTenChuHo, prSoCMND, prSoLuongTV };
            return xuLyDuLieu.thucThiThuTuc("psSuaHoGiaDinh", pr);
        }
        public DataTable timHoGiaDinh(String maHoGD)
        {
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaHoGD };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimHoGiaDinh", pr);
        }
    }
}
