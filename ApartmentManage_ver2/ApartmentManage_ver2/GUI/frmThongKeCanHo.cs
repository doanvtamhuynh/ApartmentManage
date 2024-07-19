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
    public partial class frmThongKeCanHo : Form
    {
        XuLyDuLieu xuLyDuLieu;
        public frmThongKeCanHo()
        {
            InitializeComponent();
            xuLyDuLieu = new XuLyDuLieu();
        }

        private void frmThongKeCanHo_Load(object sender, EventArgs e)
        {

            this.rpvThongKeCanHo.RefreshReport();
            loadComboBoxTrangThai();
        }

        private void loadComboBoxTrangThai()
        {
            String[] trangThai = { "Trống", "Đã thuê", "Đã bán" };
            cobTrangThai.DataSource = trangThai;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SqlParameter prTrangThai = new SqlParameter("@TRANGTHAI", SqlDbType.NVarChar, 30);
            prTrangThai.Value = cobTrangThai.SelectedValue;
            SqlParameter[] pr = { prTrangThai };

            rpvThongKeCanHo.ProcessingMode = ProcessingMode.Local;
            rpvThongKeCanHo.LocalReport.ReportPath = "GUI/Report4.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsThongKeCanHo";
            rds.Value = xuLyDuLieu.bangDuLieuDS("psThongKeCanHo", pr).Tables[0];

            rpvThongKeCanHo.LocalReport.DataSources.Clear();
            rpvThongKeCanHo.LocalReport.DataSources.Add(rds);
            rpvThongKeCanHo.RefreshReport();
        }
    }
}
