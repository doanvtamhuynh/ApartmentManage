using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyCanHo
    {
        XuLyDuLieu xuLyDuLieu;
        public daQuanLyCanHo()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }
        public DataTable danhSachCanHo()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiCanHo", null);
        }
        public DataTable loadComboBoxMaKhu()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiMaKhu", null);
        }
        public DataTable loadComBoBoxHoGiaDinh()
        {
             return xuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }

        public bool themCanHo(String maCanHo, String tenCanHo, String loaiCanHo, PictureBox hinhAnh, float giaCanHo, String trangThai, String ghiChu, String maKhu, String maHoGD)
        {
            byte[] arrayPictureCanHo = File.ReadAllBytes(hinhAnh.ImageLocation);

            SqlParameter prMaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prMaCanHo.Value = maCanHo;
            SqlParameter prtenCanHo = new SqlParameter("@TENCANHO", SqlDbType.NVarChar, 20);
            prtenCanHo.Value = tenCanHo;
            SqlParameter prLoaiCanHo = new SqlParameter("@LOAICANHO", SqlDbType.NVarChar, 10);
            prLoaiCanHo.Value = loaiCanHo;
            SqlParameter prHinhAnh = new SqlParameter("@HINHANH", SqlDbType.Image);
            prHinhAnh.Value = arrayPictureCanHo;
            SqlParameter prGiaCanHo = new SqlParameter("@GIACANHO", SqlDbType.Float);
            prGiaCanHo.Value = giaCanHo;
            SqlParameter prTrangThai = new SqlParameter("@TRANGTHAI", SqlDbType.NVarChar, 30);
            prTrangThai.Value = trangThai;
            SqlParameter prGhiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prGhiChu.Value = ghiChu;
            SqlParameter prMaKhu = new SqlParameter("@MAKHU", SqlDbType.NVarChar, 10);
            prMaKhu.Value = maKhu;
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaCanHo, prtenCanHo, prLoaiCanHo, prHinhAnh, prGiaCanHo,prTrangThai, prGhiChu, prMaKhu, prMaHoGD};
            return xuLyDuLieu.thucThiThuTuc("psThemCanHo", pr);

        }
        public bool suaCanHo(String maCanHo, String tenCanHo,String loaiCanHo, PictureBox hinhAnh, float giaCanHo,  String ghiChu, String maKhu, String maHoGD)
        {
            byte[] arrayPictureCanHo = ImageToByteArray(hinhAnh.Image);

            SqlParameter prMaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prMaCanHo.Value = maCanHo;
            SqlParameter prtenCanHo = new SqlParameter("@TENCANHO", SqlDbType.NVarChar, 20);
            prtenCanHo.Value = tenCanHo;
            SqlParameter prLoaiCanHo = new SqlParameter("@LOAICANHO", SqlDbType.NVarChar, 10);
            prLoaiCanHo.Value = loaiCanHo;
            SqlParameter prHinhAnh = new SqlParameter("@HINHANH", SqlDbType.Image);
            prHinhAnh.Value = arrayPictureCanHo;
            SqlParameter prGiaCanHo = new SqlParameter("@GIACANHO", SqlDbType.Float);
            prGiaCanHo.Value = giaCanHo;
            //SqlParameter prTrangThai = new SqlParameter("@TRANGTHAI", SqlDbType.NVarChar, 30);
            //prTrangThai.Value = trangThai;
            SqlParameter prGhiChu = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 50);
            prGhiChu.Value = ghiChu;
            SqlParameter prMaKhu = new SqlParameter("@MAKHU", SqlDbType.NVarChar, 10);
            prMaKhu.Value = maKhu;
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaCanHo,prtenCanHo, prLoaiCanHo, prHinhAnh, prGiaCanHo,  prGhiChu, prMaKhu, prMaHoGD };
            return xuLyDuLieu.thucThiThuTuc("psSuaCanHo", pr);
        }
        public bool xoaCanHo(String maCanHo)
        {
            SqlParameter prMaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prMaCanHo.Value = maCanHo;
            SqlParameter[] pr = { prMaCanHo };
            return xuLyDuLieu.thucThiThuTuc("psXoaCanHo", pr);
        }
        public DataTable timCanHo(String maCanHo)
        {
            SqlParameter prMaCanHo = new SqlParameter("@MACANHO", SqlDbType.NVarChar, 10);
            prMaCanHo.Value = maCanHo;
            SqlParameter[] pr = { prMaCanHo };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimCanHo", pr);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
