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
    class daQuanLyNhanVien
    {
        XuLyDuLieu xuLyDuLieu;
        public daQuanLyNhanVien()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable danhSachNhanVien()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiNhanVien", null);
        }

        public DataTable loadComboboxMaPhongBan()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psHienThiPhongBan", null);
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public bool themNhanVien(String maNhanVien, String hoTen, String gioiTinh, String diaChi,
            String SDT, DateTime ngaySinh, String Email, String soCMND, PictureBox anhNhanVien, String maPhongBan)
        {
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMaNhanVien.Value = maNhanVien;
            SqlParameter prHoTen = new SqlParameter("@HOTEN", SqlDbType.NVarChar, 30);
            prHoTen.Value = hoTen;
            SqlParameter prGioiTinh = new SqlParameter("@GIOITINH", SqlDbType.NVarChar, 10);
            prGioiTinh.Value = gioiTinh;
            SqlParameter prDiaChi = new SqlParameter("@DIACHI", SqlDbType.NVarChar, 50);
            prDiaChi.Value = diaChi;
            SqlParameter prSDT = new SqlParameter("@SDT", SqlDbType.NVarChar, 10);
            prSDT.Value = SDT;
            SqlParameter prNgaySinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            prNgaySinh.Value = ngaySinh;
            SqlParameter prEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 30);
            prEmail.Value = Email;
            SqlParameter prSoCMND = new SqlParameter("@SOCMND", SqlDbType.NVarChar, 18);
            prSoCMND.Value = soCMND;
            byte[] arrayAnhNhanVien = File.ReadAllBytes(anhNhanVien.ImageLocation);
            SqlParameter prAnhNhanVien = new SqlParameter("@HINHANH", SqlDbType.Image);
            prAnhNhanVien.Value = arrayAnhNhanVien;
            SqlParameter prMaPhongBan = new SqlParameter("@MAPHONGBAN", SqlDbType.NChar, 10);
            prMaPhongBan.Value = maPhongBan;
            SqlParameter[] pr = { prMaNhanVien, prHoTen, prGioiTinh, prDiaChi, prSDT, prNgaySinh, prEmail,
            prSoCMND, prAnhNhanVien, prMaPhongBan};
            return xuLyDuLieu.thucThiThuTuc("psThemNhanVien", pr);
        }

        public bool suaNhanVien(String maNhanVien, String hoTen, String gioiTinh, String diaChi,
            String SDT, DateTime ngaySinh, String Email, String soCMND, PictureBox anhNhanVien, String maPhongBan)
        {
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMaNhanVien.Value = maNhanVien;
            SqlParameter prHoTen = new SqlParameter("@HOTEN", SqlDbType.NVarChar, 30);
            prHoTen.Value = hoTen;
            SqlParameter prGioiTinh = new SqlParameter("@GIOITINH", SqlDbType.NVarChar, 10);
            prGioiTinh.Value = gioiTinh;
            SqlParameter prDiaChi = new SqlParameter("@DIACHI", SqlDbType.NVarChar, 50);
            prDiaChi.Value = diaChi;
            SqlParameter prSDT = new SqlParameter("@SDT", SqlDbType.NVarChar, 10);
            prSDT.Value = SDT;
            SqlParameter prNgaySinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            prNgaySinh.Value = ngaySinh;
            SqlParameter prEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 30);
            prEmail.Value = Email;
            SqlParameter prSoCMND = new SqlParameter("@SOCMND", SqlDbType.NVarChar, 18);
            prSoCMND.Value = soCMND;
            byte[] arrayAnhNhanVien = imageToByteArray(anhNhanVien.Image);
            SqlParameter prAnhNhanVien = new SqlParameter("@HINHANH", SqlDbType.Image);
            prAnhNhanVien.Value = arrayAnhNhanVien;
            SqlParameter prMaPhongBan = new SqlParameter("@MAPHONGBAN", SqlDbType.NChar, 10);
            prMaPhongBan.Value = maPhongBan;
            SqlParameter[] pr = { prMaNhanVien, prHoTen, prGioiTinh, prDiaChi, prSDT, prNgaySinh, prEmail,
            prSoCMND, prAnhNhanVien, prMaPhongBan};
            return xuLyDuLieu.thucThiThuTuc("psSuaNhanVien", pr);
        }

        public bool xoaNhanVien(String maNhanVien)
        {
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMaNhanVien.Value = maNhanVien;

            SqlParameter[] pr = { prMaNhanVien };
            return xuLyDuLieu.thucThiThuTuc("psXoaNhanVien", pr);
        }

        public DataTable timKiemNhanVien(String maNhanVien)
        {
            SqlParameter prMaNhanVien = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMaNhanVien.Value = maNhanVien;

            SqlParameter[] pr = { prMaNhanVien };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimKiemNhanVien", pr);
        }
    }
}
