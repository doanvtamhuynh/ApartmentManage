using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daDangNhap
    {
        XuLyDuLieu xuLyDuLieu;
        public daDangNhap()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }

        public int dangNhap(String tenDangNhap, String matKhau, String idQuyen)
        {
            SqlParameter prTenDangNhap = new SqlParameter("@TENDANGNHAP", SqlDbType.NVarChar, 30);
            prTenDangNhap.Value = tenDangNhap;
            SqlParameter prMatKhau = new SqlParameter("@MATKHAU", SqlDbType.NVarChar, 20);
            prMatKhau.Value = matKhau;
            SqlParameter prIDQuyen = new SqlParameter("@IDQUYEN", SqlDbType.NVarChar, 10);
            prIDQuyen.Value = idQuyen;

            SqlParameter[] pr = { prTenDangNhap, prMatKhau, prIDQuyen };
            int kq = (int)xuLyDuLieu.thucThiGiaTriDonThuTuc("psDangNhap", pr);
            return kq;
        }
    }
}
