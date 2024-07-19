using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyDichVu
    {
        XuLyDuLieu xuLyDuLieu;
        
        public daQuanLyDichVu()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable danhSachDichVu()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiDanhSachDichVu", null);
        }

        public bool themDichVu(String madichvu, String tendichvu, String gia)
        {
            SqlParameter prmadichvu = new SqlParameter("@MADICHVU", SqlDbType.NVarChar, 10);
            prmadichvu.Value = madichvu;
            SqlParameter prtendichvu = new SqlParameter("@TENDICHVU", SqlDbType.NVarChar, 30);
            prtendichvu.Value = tendichvu;
            SqlParameter prgia = new SqlParameter("@GIADICHVU", SqlDbType.Float);
            prgia.Value = gia;

            SqlParameter[] pr2 = { prmadichvu, prtendichvu, prgia };
            return xuLyDuLieu.thucThiThuTuc("psThemDichVu", pr2);
        }

        public bool xoaDichVu(String madichvu)
        {
            SqlParameter prmadichvu = new SqlParameter("@MADICHVU", SqlDbType.NVarChar, 10);
            prmadichvu.Value = madichvu;

            SqlParameter[] pr2 = { prmadichvu };
            return xuLyDuLieu.thucThiThuTuc("psXoaDichVu", pr2);
        }

        public bool suaDichVu(String madichvu, String tendichvu, String gia)
        {
            SqlParameter prmadichvu = new SqlParameter("@MADICHVU", SqlDbType.NVarChar, 10);
            prmadichvu.Value = madichvu;
            SqlParameter prtendichvu = new SqlParameter("@TENDICHVU", SqlDbType.NVarChar, 30);
            prtendichvu.Value = tendichvu;
            SqlParameter prgia = new SqlParameter("@GIADICHVU", SqlDbType.Float);
            prgia.Value = gia;

            SqlParameter[] pr2 = { prmadichvu, prtendichvu, prgia };
            return xuLyDuLieu.thucThiThuTuc("psSuaDichVu", pr2);
        }

        public DataTable TimKiemDichVuTheoTenDichVu(String madichvu)
        {
            SqlParameter prmadichvu = new SqlParameter("@MADICHVU", SqlDbType.NVarChar, 10);
            prmadichvu.Value = madichvu;

            SqlParameter[] pr = { prmadichvu };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimKiemDichVuTheoTenDichVu", pr);
        }
    }
}
