using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmThongKeTienDien : Form
    {
        XuLyDuLieu xuLyDuLieu;
        public frmThongKeTienDien()
        {
            InitializeComponent();
            xuLyDuLieu = new XuLyDuLieu();
        }

        private void frmThongKeTienDien_Load(object sender, EventArgs e)
        {

            this.rpvThongKeTienDien.RefreshReport();
            loadComboBoxThang();
        }

        private void loadComboBoxThang()
        {
            int[] thang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cobThang.DataSource = thang;
        }

        private void btnThongKeTheoThang_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter prThang = new SqlParameter("@THANG", SqlDbType.Int);
                prThang.Value = cobThang.SelectedValue;
                SqlParameter prNam = new SqlParameter("@NAM", SqlDbType.Int);
                prNam.Value = txtNam.Text;

                SqlParameter[] pr = { prThang, prNam };

                clearAllERP();
                kiemTraLoi();

                rpvThongKeTienDien.ProcessingMode = ProcessingMode.Local;
                rpvThongKeTienDien.LocalReport.ReportPath = "GUI/Report1.rdlc";

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsThongKeTienDien";
                rds.Value = xuLyDuLieu.bangDuLieuDS("psThongKeTienDien", pr).Tables[0];

                rpvThongKeTienDien.LocalReport.DataSources.Clear();
                rpvThongKeTienDien.LocalReport.DataSources.Add(rds);
                rpvThongKeTienDien.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThongKeTheoNam_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter prNam = new SqlParameter("@NAM", SqlDbType.Int);
                prNam.Value = txtNam.Text;

                SqlParameter[] pr = { prNam };

                clearAllERP();
                kiemTraLoi();

                rpvThongKeTienDien.ProcessingMode = ProcessingMode.Local;
                rpvThongKeTienDien.LocalReport.ReportPath = "GUI/Report1.rdlc";

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsThongKeTienDien";
                rds.Value = xuLyDuLieu.bangDuLieuDS("psThongKeTienDienTheoNam", pr).Tables[0];

                rpvThongKeTienDien.LocalReport.DataSources.Clear();
                rpvThongKeTienDien.LocalReport.DataSources.Add(rds);
                rpvThongKeTienDien.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtNam_Leave(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
            {
                erpKiemTraLoi.SetError(txtNam, "Vui lòng nhập Năm!");
            }
            else
            {
                erpKiemTraLoi.SetError(txtNam, "");
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private bool kiemTraLoi()
        {
            bool kt = true;
            if (txtNam.Text == "")
            {
                kt = false;
                erpKiemTraLoi.SetError(txtNam, "Vui lòng nhập năm!");
            }
            return kt;
        }

        // Xóa icon ! thông báo lỗi khi người dùng đã nhập đúng định dạng
        private void clearAllERP()
        {
            erpKiemTraLoi.SetError(txtNam, "");
        }
    }
}
