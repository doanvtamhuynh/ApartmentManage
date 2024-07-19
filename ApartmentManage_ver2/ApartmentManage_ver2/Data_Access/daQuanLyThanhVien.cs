using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ApartmentManage_ver2.Data_Access
{
    class daQuanLyThanhVien
    {
        XuLyDuLieu xuLyDuLieu;
        public daQuanLyThanhVien()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }
        public DataTable danhSachThanhVien()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiThanhVien", null);
        }

        public DataTable loadComboboxHoGiaDinh()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiHoGiaDinh", null);
        }
        
        public bool themThanhVien(String maTV, String hoTen, String gioiTinh, String soCMND, DateTime ngaySinh, String soDienThoai, String email, PictureBox hinhAnh, String maHoGD)
        {
            byte[] arrayPictureThanhVien = File.ReadAllBytes(hinhAnh.ImageLocation);
            SqlParameter prMaTV = new SqlParameter("@MATHANHVIEN", SqlDbType.NVarChar, 10);
            prMaTV.Value = maTV;
            SqlParameter prHoTen = new SqlParameter("@HOTENTHANHVIEN", SqlDbType.NVarChar, 50);
            prHoTen.Value = hoTen;
            SqlParameter prGioiTinh = new SqlParameter("@GIOITINHTV", SqlDbType.NVarChar, 10);
            prGioiTinh.Value = gioiTinh;
            SqlParameter prSoCMND = new SqlParameter("@SOCMND", SqlDbType.NVarChar, 20);
            prSoCMND.Value = soCMND;
            SqlParameter prNgaySinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            prNgaySinh.Value = ngaySinh;
            SqlParameter prSoDT = new SqlParameter("@SDT", SqlDbType.NVarChar, 10);
            prSoDT.Value = soDienThoai;
            SqlParameter prEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 20);
            prEmail.Value = email;
            SqlParameter prHinhAnh = new SqlParameter("@HINHANH", SqlDbType.Image);
            prHinhAnh.Value = arrayPictureThanhVien;
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaTV, prHoTen, prGioiTinh, prSoCMND, prNgaySinh, prSoDT, prEmail, prHinhAnh, prMaHoGD };
            return xuLyDuLieu.thucThiThuTuc("psThemThanhVienHoGD", pr);
        }
        public bool xoaThanhVienHoGD(String maTV)
        {
            SqlParameter prMaTV = new SqlParameter("@MATHANHVIEN", SqlDbType.NVarChar, 10);
            prMaTV.Value = maTV;
            SqlParameter[] pr = { prMaTV };
            return xuLyDuLieu.thucThiThuTuc("psXoaThanhVienHoGD", pr);
        }
        public bool suaThanhVien(String maTV, String hoTen, String gioiTinh, String soCMND, DateTime ngaySinh, String soDienThoai, String email, PictureBox hinhAnh, String maHoGD)
        {
            byte[] arrayPictureThanhVien = ImageToByteArray(hinhAnh.Image);
            SqlParameter prMaTV = new SqlParameter("@MATHANHVIEN", SqlDbType.NVarChar, 10);
            prMaTV.Value = maTV;
            SqlParameter prHoTen = new SqlParameter("@HOTENTHANHVIEN", SqlDbType.NVarChar, 50);
            prHoTen.Value = hoTen;
            SqlParameter prGioiTinh = new SqlParameter("@GIOITINHTV", SqlDbType.NVarChar, 10);
            prGioiTinh.Value = gioiTinh;
            SqlParameter prSoCMND = new SqlParameter("@SOCMND", SqlDbType.NVarChar, 20);
            prSoCMND.Value = soCMND;
            SqlParameter prNgaySinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            prNgaySinh.Value = ngaySinh;
            SqlParameter prSoDT = new SqlParameter("@SDT", SqlDbType.NVarChar, 10);
            prSoDT.Value = soDienThoai;
            SqlParameter prEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 20);
            prEmail.Value = email;
            SqlParameter prHinhAnh = new SqlParameter("@HINHANH", SqlDbType.Image);
            prHinhAnh.Value = arrayPictureThanhVien;
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaTV, prHoTen, prGioiTinh, prSoCMND, prNgaySinh, prSoDT, prEmail, prHinhAnh, prMaHoGD };
            return xuLyDuLieu.thucThiThuTuc("psSuaThanhVienHoGD", pr);
        }
        public DataTable timThanhVien(String maTV)
        {
            SqlParameter prMaTV = new SqlParameter("@MATHANHVIEN", SqlDbType.NVarChar, 10);
            prMaTV.Value = maTV;
            SqlParameter[] pr = { prMaTV };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimThanhVien", pr);
        }
        public DataTable hienThiThanhVienTheoGiaDinh(String maHoGD)
        {
            SqlParameter prMaHoGD = new SqlParameter("@MAHOGD", SqlDbType.NVarChar, 10);
            prMaHoGD.Value = maHoGD;
            SqlParameter[] pr = { prMaHoGD };
            return xuLyDuLieu.bangDuLieuThuTuc("psHIENTHITHANHVIENTHEOHO", pr);
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
