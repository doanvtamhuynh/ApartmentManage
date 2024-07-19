using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManage_ver2.GUI
{
    public partial class frmTraCuuHoGiaDinh : Form
    {
        Bussiness__Logic.blTraCuuHoGiaDinh nghiepvu;
        public frmTraCuuHoGiaDinh()
        {
            InitializeComponent();
        }

        private void frmTraCuuHoGiaDinh_Load(object sender, EventArgs e)
        {
            nghiepvu = new Bussiness__Logic.blTraCuuHoGiaDinh(this);
            nghiepvu.loadComboBoxTimKiemTheoMaKhu();
            nghiepvu.hienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nghiepvu.TraCuuHoGiaDinh();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            nghiepvu.hienThi();
        }
    }
}
