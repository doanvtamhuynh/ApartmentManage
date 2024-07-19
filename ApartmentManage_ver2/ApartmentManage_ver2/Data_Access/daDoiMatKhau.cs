using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApartmentManage_ver2.Data_Access
{
    class daDoiMatKhau
    {
        XuLyDuLieu xuLyDuLieu;
        public daDoiMatKhau()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }

        public bool doiMatKhau(String tenDangNhap, String matKhauCu, String matKhauMoi, String xacNhanMatKhauMoi)
        {
            SqlParameter prTenDangNhap = new SqlParameter("@TENDANGNHAP", SqlDbType.NVarChar, 30);
            prTenDangNhap.Value = tenDangNhap;
            SqlParameter prMatKhau = new SqlParameter("@MATKHAUCU", SqlDbType.NVarChar, 20);
            prMatKhau.Value = matKhauCu;
            SqlParameter prMatKhauMoi = new SqlParameter("@MATKHAUMOI", SqlDbType.NVarChar, 20);
            prMatKhauMoi.Value = matKhauMoi;
            SqlParameter prXacNhanMatKhauMoi = new SqlParameter("@XACNHANMATKHAUMOI", SqlDbType.NVarChar, 20);
            prXacNhanMatKhauMoi.Value = xacNhanMatKhauMoi;

                
            SqlParameter[] pr = { prTenDangNhap, prMatKhau, prMatKhauMoi, prXacNhanMatKhauMoi };
            return xuLyDuLieu.thucThiThuTuc("psDoiMatKhau", pr);
        }
    }
}
