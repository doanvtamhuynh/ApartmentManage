using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmQuanLyCanHo : DevExpress.XtraEditors.XtraForm
    {
        Bussiness__Logic.blQuanLyCanHo nghiepVu;
        public frmQuanLyCanHo()
        {
            InitializeComponent();
            this.dgvDanhSachCanHo.DataError += new DataGridViewDataErrorEventHandler(this.dgvDanhSachCanHo_DataError);
        }

        private void frmQuanLyCanHo_Load(object sender, EventArgs e)
        {
            nghiepVu = new Bussiness__Logic.blQuanLyCanHo(this);
            nghiepVu.loadComboboxLoaiCanHo();
            nghiepVu.loadComBoBoxMaHoGD();
            nghiepVu.loadComBoboxMaKhu();
            nghiepVu.loadComBoBoxMaCanHo();
     
            //nghiepVu.hienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraLoi())
            {
                clearAllERP();
                nghiepVu.themCanHo();
                nghiepVu.hienThi();
                nghiepVu.loadComBoBoxMaCanHo();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ và chính xác !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.hienThi();
        }
        public bool kiemTraLoi()
        {
            bool ktra = true;
            if (txtMaCanHo.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtMaCanHo, "Vui lòng nhập mã căn hộ!");
            }
            if (txtGiaCanHo.Text == "")
            {
                ktra = false;
                erpKiemTraLoi.SetError(txtGiaCanHo, "Vui lòng nhập giá căn hộ!");
            }
            return ktra;
        }

        // xóa icon khi nhập đúng định dạng
         private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtMaCanHo, "");
            erpKiemTraLoi.SetError(txtGiaCanHo, "");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.suaCanHo();
            nghiepVu.hienThi();
        }

        private void ptbHinhAnh_Click_1(object sender, EventArgs e)
        {
            nghiepVu.pictureBoxHinhAnh();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.timCanHo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            clearAllERP();
            nghiepVu.xoaCanHo();
            nghiepVu.hienThi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            clearAllERP();
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đóng cửa sổ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
       

        private void txtGiaCanHo_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtGiaCanHo.Text, "[ ^ 0-9]"))
            {
                erpKiemTraLoi.Clear();
            }
            else
            {
                erpKiemTraLoi.SetError(txtGiaCanHo, "Vui lòng nhập số chứng minh nhân dân hợp lệ");
            }
        }

        private void txtMaCanHo_Leave(object sender, EventArgs e)
        {
            if (txtMaCanHo.Text == "")
            {
                erpKiemTraLoi.SetError(txtMaCanHo, "Vui lòng nhập mã căn hộ");
            }
            else
            {
                erpKiemTraLoi.SetError(txtMaCanHo, "");
            }
        }

        private void dgvDanhSachCanHo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvDanhSachCanHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if( e.RowIndex != -1)
            //{
            //    DataGridViewRow dgv = dgvDanhSachCanHo.Rows[e.RowIndex];
            //    try
            //    {
            //        string a = dgv.Cells[4].Value.ToString();
            //        cbTrangThai.Text = a.ToString();
            //        txtTrangThai.Text = a;
            //        this.Controls.Add(cbTrangThai);
            //    }catch(ArgumentException ex) {
            //        MessageBox.Show("khong co dữ liệu");
            //    }
            //}
        }
    }
}