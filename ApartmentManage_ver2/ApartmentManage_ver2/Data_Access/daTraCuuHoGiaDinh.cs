using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daTraCuuHoGiaDinh
    {
        XuLyDuLieu XuLyDuLieu;

        public daTraCuuHoGiaDinh()
        {
            XuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable HienThiHoGiaDinh()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }

        public DataTable loadComboboxMaHoGiaDinh()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }

        public DataTable loadComboboxTenChuHo()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }

        public DataTable loadComboboxMaKhu()
        {
            return XuLyDuLieu.bangDuLieuThuTuc("psHienThiKhu", null);
        }

        public DataTable TimKiemHoGiaDinh(String mahogd, String tenchuho, String makhu)
        {
            SqlParameter prmaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prmaHoGD.Value = mahogd;
            SqlParameter prtenchuho = new SqlParameter("@TENCHUHO", SqlDbType.NVarChar, 30);
            prtenchuho.Value = tenchuho;
            SqlParameter prmakhu = new SqlParameter("@MAKHU", SqlDbType.NVarChar, 10);
            prmakhu.Value = makhu;



            if ((mahogd == "") && (tenchuho == ""))
            {
                SqlParameter[] pr = { prmakhu };
                return XuLyDuLieu.bangDuLieuThuTuc("psHienThiDanhSachTraCuuTheoMaKhu", pr);
            }
            else if ((tenchuho == ""))
            {
                SqlParameter[] pr = { prmaHoGD, prmakhu };
                return XuLyDuLieu.bangDuLieuThuTuc("psHienThiDanhSachTraCuuTheoMaHoGD", pr);
            }
            else if ((mahogd == ""))
            {
                SqlParameter[] pr = { prtenchuho, prmakhu };
                return XuLyDuLieu.bangDuLieuThuTuc("psHienThiDanhSachTraCuuTheoTenChuHo", pr);
            }
            else
            {
                SqlParameter[] pr = { prmaHoGD, prtenchuho, prmakhu };
                return XuLyDuLieu.bangDuLieuThuTuc("psHienThiDanhSachTraCuuHoGiaDinh", pr);
            }
        }
    }
}
