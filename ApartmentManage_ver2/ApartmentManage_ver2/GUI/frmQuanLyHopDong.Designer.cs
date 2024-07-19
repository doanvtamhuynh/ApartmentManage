namespace ApartmentManage_ver2.GUI
{
    partial class frmQuanLyHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHopDong));
            this.cbMaHopDong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.erpKiemTraLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvChiTietHopDong = new System.Windows.Forms.DataGridView();
            this.clMaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayKyHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaHoGiaDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenChuHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChiTietHopDong = new System.Windows.Forms.GroupBox();
            this.dtpNgayKyHopDong = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cbMaHoGiaDinh = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.cbLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.cbMaCanHo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTenHopDong = new System.Windows.Forms.TextBox();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHopDong)).BeginInit();
            this.grbChiTietHopDong.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMaHopDong
            // 
            this.cbMaHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHopDong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHopDong.FormattingEnabled = true;
            this.cbMaHopDong.Location = new System.Drawing.Point(372, 631);
            this.cbMaHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaHopDong.Name = "cbMaHopDong";
            this.cbMaHopDong.Size = new System.Drawing.Size(153, 25);
            this.cbMaHopDong.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(395, 608);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mã hợp đồng";
            // 
            // erpKiemTraLoi
            // 
            this.erpKiemTraLoi.ContainerControl = this;
            // 
            // dgvChiTietHopDong
            // 
            this.dgvChiTietHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHopDong,
            this.clNgayKyHD,
            this.clThoiHan,
            this.clGiaTri,
            this.clLoaiHopDong,
            this.cltenHopDong,
            this.clMaCanHo,
            this.clMaNhanVien,
            this.clTenNhanVien,
            this.clMaHoGiaDinh,
            this.clTenChuHo,
            this.clNoiDung});
            this.dgvChiTietHopDong.Location = new System.Drawing.Point(2, 126);
            this.dgvChiTietHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChiTietHopDong.Name = "dgvChiTietHopDong";
            this.dgvChiTietHopDong.ReadOnly = true;
            this.dgvChiTietHopDong.Size = new System.Drawing.Size(940, 185);
            this.dgvChiTietHopDong.TabIndex = 100;
            this.dgvChiTietHopDong.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvChiTietHopDong_DataError);
            // 
            // clMaHopDong
            // 
            this.clMaHopDong.DataPropertyName = "MAHOPDONG";
            this.clMaHopDong.HeaderText = "Mã hợp đồng";
            this.clMaHopDong.Name = "clMaHopDong";
            this.clMaHopDong.ReadOnly = true;
            this.clMaHopDong.Width = 120;
            // 
            // clNgayKyHD
            // 
            this.clNgayKyHD.DataPropertyName = "NGAYKYHOPDONG";
            this.clNgayKyHD.HeaderText = "Ngày ký hợp đồng";
            this.clNgayKyHD.Name = "clNgayKyHD";
            this.clNgayKyHD.ReadOnly = true;
            this.clNgayKyHD.Width = 150;
            // 
            // clThoiHan
            // 
            this.clThoiHan.DataPropertyName = "THOIHAN";
            this.clThoiHan.HeaderText = "Thời hạn";
            this.clThoiHan.Name = "clThoiHan";
            this.clThoiHan.ReadOnly = true;
            this.clThoiHan.Width = 120;
            // 
            // clGiaTri
            // 
            this.clGiaTri.DataPropertyName = "GIATRI";
            this.clGiaTri.HeaderText = "Giá trị ";
            this.clGiaTri.Name = "clGiaTri";
            this.clGiaTri.ReadOnly = true;
            this.clGiaTri.Width = 120;
            // 
            // clLoaiHopDong
            // 
            this.clLoaiHopDong.DataPropertyName = "LOAIHOPDONG";
            this.clLoaiHopDong.HeaderText = "Loại hợp đồng";
            this.clLoaiHopDong.Name = "clLoaiHopDong";
            this.clLoaiHopDong.ReadOnly = true;
            // 
            // cltenHopDong
            // 
            this.cltenHopDong.DataPropertyName = "TENHOPDONG";
            this.cltenHopDong.HeaderText = "Tên hợp đồng";
            this.cltenHopDong.Name = "cltenHopDong";
            this.cltenHopDong.ReadOnly = true;
            // 
            // clMaCanHo
            // 
            this.clMaCanHo.DataPropertyName = "MACANHO";
            this.clMaCanHo.HeaderText = "Mã căn hộ";
            this.clMaCanHo.Name = "clMaCanHo";
            this.clMaCanHo.ReadOnly = true;
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.DataPropertyName = "MANHANVIEN";
            this.clMaNhanVien.HeaderText = "Mã nhân viên";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.ReadOnly = true;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.DataPropertyName = "HOTEN";
            this.clTenNhanVien.HeaderText = "Tên nhân viên";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.ReadOnly = true;
            // 
            // clMaHoGiaDinh
            // 
            this.clMaHoGiaDinh.DataPropertyName = "MAHOGD";
            this.clMaHoGiaDinh.HeaderText = "Mã hộ gia đình";
            this.clMaHoGiaDinh.Name = "clMaHoGiaDinh";
            this.clMaHoGiaDinh.ReadOnly = true;
            // 
            // clTenChuHo
            // 
            this.clTenChuHo.DataPropertyName = "TENCHUHO";
            this.clTenChuHo.HeaderText = "Tên chủ hộ";
            this.clTenChuHo.Name = "clTenChuHo";
            this.clTenChuHo.ReadOnly = true;
            // 
            // clNoiDung
            // 
            this.clNoiDung.DataPropertyName = "NOIDUNG";
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            this.clNoiDung.Width = 200;
            // 
            // grbChiTietHopDong
            // 
            this.grbChiTietHopDong.Controls.Add(this.dtpNgayKyHopDong);
            this.grbChiTietHopDong.Controls.Add(this.txtNoiDung);
            this.grbChiTietHopDong.Controls.Add(this.label13);
            this.grbChiTietHopDong.Controls.Add(this.dgvChiTietHopDong);
            this.grbChiTietHopDong.Controls.Add(this.txtGiaTri);
            this.grbChiTietHopDong.Controls.Add(this.txtThoiHan);
            this.grbChiTietHopDong.Controls.Add(this.label12);
            this.grbChiTietHopDong.Controls.Add(this.label9);
            this.grbChiTietHopDong.Controls.Add(this.label11);
            this.grbChiTietHopDong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbChiTietHopDong.ForeColor = System.Drawing.Color.Blue;
            this.grbChiTietHopDong.Location = new System.Drawing.Point(14, 212);
            this.grbChiTietHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbChiTietHopDong.Name = "grbChiTietHopDong";
            this.grbChiTietHopDong.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbChiTietHopDong.Size = new System.Drawing.Size(950, 320);
            this.grbChiTietHopDong.TabIndex = 22;
            this.grbChiTietHopDong.TabStop = false;
            this.grbChiTietHopDong.Text = "Chi tiết hợp đồng";
            // 
            // dtpNgayKyHopDong
            // 
            this.dtpNgayKyHopDong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKyHopDong.Location = new System.Drawing.Point(625, 25);
            this.dtpNgayKyHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayKyHopDong.Name = "dtpNgayKyHopDong";
            this.dtpNgayKyHopDong.Size = new System.Drawing.Size(140, 28);
            this.dtpNgayKyHopDong.TabIndex = 12;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoiDung.Location = new System.Drawing.Point(625, 75);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(140, 28);
            this.txtNoiDung.TabIndex = 13;
            this.txtNoiDung.Leave += new System.EventHandler(this.txtNoiDung_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(463, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Nội dung";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGiaTri.Location = new System.Drawing.Point(252, 75);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.ReadOnly = true;
            this.txtGiaTri.Size = new System.Drawing.Size(140, 28);
            this.txtGiaTri.TabIndex = 11;
            this.txtGiaTri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTri_KeyPress);
            this.txtGiaTri.Leave += new System.EventHandler(this.txtGiaTri_Leave);
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtThoiHan.Location = new System.Drawing.Point(252, 32);
            this.txtThoiHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(140, 28);
            this.txtThoiHan.TabIndex = 10;
            this.txtThoiHan.Leave += new System.EventHandler(this.txtThoiHan_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(101, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Thời hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(461, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngày ký hợp đồng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(101, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Giá trị";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cbMaHoGiaDinh);
            this.grbThongTin.Controls.Add(this.label17);
            this.grbThongTin.Controls.Add(this.txtTenNhanVien);
            this.grbThongTin.Controls.Add(this.cbLoaiHopDong);
            this.grbThongTin.Controls.Add(this.txtTenChuHo);
            this.grbThongTin.Controls.Add(this.cbMaCanHo);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.cbMaNhanVien);
            this.grbThongTin.Controls.Add(this.txtTenHopDong);
            this.grbThongTin.Controls.Add(this.txtMaHopDong);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(14, 50);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbThongTin.Size = new System.Drawing.Size(950, 154);
            this.grbThongTin.TabIndex = 21;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hợp đồng";
            // 
            // cbMaHoGiaDinh
            // 
            this.cbMaHoGiaDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHoGiaDinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaHoGiaDinh.FormattingEnabled = true;
            this.cbMaHoGiaDinh.Location = new System.Drawing.Point(797, 65);
            this.cbMaHoGiaDinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaHoGiaDinh.Name = "cbMaHoGiaDinh";
            this.cbMaHoGiaDinh.Size = new System.Drawing.Size(140, 29);
            this.cbMaHoGiaDinh.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label17.Location = new System.Drawing.Point(637, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "Mã hộ gia đình";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenNhanVien.Location = new System.Drawing.Point(460, 70);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(140, 28);
            this.txtTenNhanVien.TabIndex = 5;
            // 
            // cbLoaiHopDong
            // 
            this.cbLoaiHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHopDong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLoaiHopDong.FormattingEnabled = true;
            this.cbLoaiHopDong.Location = new System.Drawing.Point(162, 107);
            this.cbLoaiHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiHopDong.Name = "cbLoaiHopDong";
            this.cbLoaiHopDong.Size = new System.Drawing.Size(140, 29);
            this.cbLoaiHopDong.TabIndex = 3;
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenChuHo.Location = new System.Drawing.Point(799, 102);
            this.txtTenChuHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.ReadOnly = true;
            this.txtTenChuHo.Size = new System.Drawing.Size(140, 28);
            this.txtTenChuHo.TabIndex = 8;
            // 
            // cbMaCanHo
            // 
            this.cbMaCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaCanHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaCanHo.FormattingEnabled = true;
            this.cbMaCanHo.Location = new System.Drawing.Point(797, 28);
            this.cbMaCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaCanHo.Name = "cbMaCanHo";
            this.cbMaCanHo.Size = new System.Drawing.Size(140, 29);
            this.cbMaCanHo.TabIndex = 6;
            this.cbMaCanHo.SelectedIndexChanged += new System.EventHandler(this.cbMaCanHo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(637, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên chủ hộ";
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(460, 33);
            this.cbMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(140, 29);
            this.cbMaNhanVien.TabIndex = 4;
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenHopDong.Location = new System.Drawing.Point(162, 70);
            this.txtTenHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(140, 28);
            this.txtTenHopDong.TabIndex = 2;
            this.txtTenHopDong.Leave += new System.EventHandler(this.txtTenHopDong_Leave);
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaHopDong.Location = new System.Drawing.Point(162, 33);
            this.txtMaHopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(140, 28);
            this.txtMaHopDong.TabIndex = 1;
            this.txtMaHopDong.Leave += new System.EventHandler(this.txtMaHopDong_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(637, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã căn hộ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(320, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(320, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(257, 608);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(787, 608);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 50);
            this.btnDong.TabIndex = 30;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThi.Image")));
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(656, 608);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(111, 50);
            this.btnHienThi.TabIndex = 27;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(545, 607);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 50);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(138, 608);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(22, 607);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTongTien.Location = new System.Drawing.Point(756, 562);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(140, 26);
            this.txtTongTien.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Location = new System.Drawing.Point(605, 566);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tổng tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(754, 538);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 21);
            this.label15.TabIndex = 102;
            this.label15.Text = "Thuế VAT 10%";
            // 
            // frmQuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 672);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbMaHopDong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbChiTietHopDong);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLyHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hợp đồng";
            this.Load += new System.EventHandler(this.frmQuanLyHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHopDong)).EndInit();
            this.grbChiTietHopDong.ResumeLayout(false);
            this.grbChiTietHopDong.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbMaHopDong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider erpKiemTraLoi;
        public System.Windows.Forms.Button btnDong;
        public System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbChiTietHopDong;
        public System.Windows.Forms.DataGridView dgvChiTietHopDong;
        private System.Windows.Forms.GroupBox grbThongTin;
        public System.Windows.Forms.ComboBox cbLoaiHopDong;
        private System.Windows.Forms.TextBox txtTenChuHo;
        public System.Windows.Forms.ComboBox cbMaCanHo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayKyHopDong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayKyHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHoGiaDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenChuHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiDung;
        public System.Windows.Forms.ComboBox cbMaHoGiaDinh;
        private System.Windows.Forms.Label label17;
    }
}