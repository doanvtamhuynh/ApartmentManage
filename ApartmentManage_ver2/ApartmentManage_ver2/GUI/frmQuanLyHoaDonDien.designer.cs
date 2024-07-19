namespace ApartmentManage_ver2.GUI
{
    partial class frmQuanLyHoaDonDien
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobTimMaHoaDonDien = new System.Windows.Forms.ComboBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtGhiChuHoaDonDien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenCanHo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cobMaCanHo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cobMaHoGiaDinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayIn = new System.Windows.Forms.DateTimePicker();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaHoaDonDien = new System.Windows.Forms.TextBox();
            this.cobMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvDanhSachChiTietHoaDonDien = new System.Windows.Forms.DataGridView();
            this.clMahoadondien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenhoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtGhiChuCTHDD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.erpKiemTraLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnIn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietHoaDonDien)).BeginInit();
            this.grbThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(364, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "QUẢN LÝ HOÁ ĐƠN ĐIỆN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(448, 778);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hoá đơn";
            // 
            // cobTimMaHoaDonDien
            // 
            this.cobTimMaHoaDonDien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobTimMaHoaDonDien.FormattingEnabled = true;
            this.cobTimMaHoaDonDien.Location = new System.Drawing.Point(422, 811);
            this.cobTimMaHoaDonDien.Name = "cobTimMaHoaDonDien";
            this.cobTimMaHoaDonDien.Size = new System.Drawing.Size(150, 24);
            this.cobTimMaHoaDonDien.TabIndex = 25;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtGhiChuHoaDonDien);
            this.grbThongTin.Controls.Add(this.label11);
            this.grbThongTin.Controls.Add(this.txtTenCanHo);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.cobMaCanHo);
            this.grbThongTin.Controls.Add(this.label9);
            this.grbThongTin.Controls.Add(this.txtTenChuHo);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.cobMaHoGiaDinh);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.dtpNgayIn);
            this.grbThongTin.Controls.Add(this.txtTenNhanVien);
            this.grbThongTin.Controls.Add(this.txtTenHoaDon);
            this.grbThongTin.Controls.Add(this.txtMaHoaDonDien);
            this.grbThongTin.Controls.Add(this.cobMaNhanVien);
            this.grbThongTin.Controls.Add(this.label10);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label13);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(48, 52);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(1111, 298);
            this.grbThongTin.TabIndex = 19;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chung";
            // 
            // txtGhiChuHoaDonDien
            // 
            this.txtGhiChuHoaDonDien.Location = new System.Drawing.Point(738, 235);
            this.txtGhiChuHoaDonDien.Name = "txtGhiChuHoaDonDien";
            this.txtGhiChuHoaDonDien.Size = new System.Drawing.Size(170, 28);
            this.txtGhiChuHoaDonDien.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(588, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ghi chú";
            // 
            // txtTenCanHo
            // 
            this.txtTenCanHo.Location = new System.Drawing.Point(738, 181);
            this.txtTenCanHo.Name = "txtTenCanHo";
            this.txtTenCanHo.ReadOnly = true;
            this.txtTenCanHo.Size = new System.Drawing.Size(170, 28);
            this.txtTenCanHo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(588, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên căn hộ";
            // 
            // cobMaCanHo
            // 
            this.cobMaCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMaCanHo.FormattingEnabled = true;
            this.cobMaCanHo.Location = new System.Drawing.Point(738, 131);
            this.cobMaCanHo.Name = "cobMaCanHo";
            this.cobMaCanHo.Size = new System.Drawing.Size(170, 29);
            this.cobMaCanHo.TabIndex = 16;
            this.cobMaCanHo.SelectedIndexChanged += new System.EventHandler(this.cobMaCanHo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(588, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã căn hộ";
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.Location = new System.Drawing.Point(738, 83);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.ReadOnly = true;
            this.txtTenChuHo.Size = new System.Drawing.Size(170, 28);
            this.txtTenChuHo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(588, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên chủ hộ";
            // 
            // cobMaHoGiaDinh
            // 
            this.cobMaHoGiaDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMaHoGiaDinh.FormattingEnabled = true;
            this.cobMaHoGiaDinh.Location = new System.Drawing.Point(738, 33);
            this.cobMaHoGiaDinh.Name = "cobMaHoGiaDinh";
            this.cobMaHoGiaDinh.Size = new System.Drawing.Size(170, 29);
            this.cobMaHoGiaDinh.TabIndex = 12;
            this.cobMaHoGiaDinh.SelectedIndexChanged += new System.EventHandler(this.cobMaHoGiaDinh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(588, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã hộ gia đình";
            // 
            // dtpNgayIn
            // 
            this.dtpNgayIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayIn.Location = new System.Drawing.Point(276, 231);
            this.dtpNgayIn.Name = "dtpNgayIn";
            this.dtpNgayIn.Size = new System.Drawing.Size(170, 28);
            this.dtpNgayIn.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(276, 181);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(170, 28);
            this.txtTenNhanVien.TabIndex = 5;
            // 
            // txtTenHoaDon
            // 
            this.txtTenHoaDon.Location = new System.Drawing.Point(276, 83);
            this.txtTenHoaDon.Name = "txtTenHoaDon";
            this.txtTenHoaDon.Size = new System.Drawing.Size(170, 28);
            this.txtTenHoaDon.TabIndex = 2;
            this.txtTenHoaDon.Leave += new System.EventHandler(this.txtTenHoaDon_Leave);
            // 
            // txtMaHoaDonDien
            // 
            this.txtMaHoaDonDien.Location = new System.Drawing.Point(276, 33);
            this.txtMaHoaDonDien.Name = "txtMaHoaDonDien";
            this.txtMaHoaDonDien.Size = new System.Drawing.Size(170, 28);
            this.txtMaHoaDonDien.TabIndex = 1;
            this.txtMaHoaDonDien.Leave += new System.EventHandler(this.txtMaHoaDonDien_Leave);
            // 
            // cobMaNhanVien
            // 
            this.cobMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMaNhanVien.FormattingEnabled = true;
            this.cobMaNhanVien.Location = new System.Drawing.Point(276, 131);
            this.cobMaNhanVien.Name = "cobMaNhanVien";
            this.cobMaNhanVien.Size = new System.Drawing.Size(170, 29);
            this.cobMaNhanVien.TabIndex = 10;
            this.cobMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cobMaNhanVien_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(108, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(108, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(108, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày in";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(108, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã hoá đơn điện";
            // 
            // dgvDanhSachChiTietHoaDonDien
            // 
            this.dgvDanhSachChiTietHoaDonDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietHoaDonDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMahoadondien,
            this.clTenhoadon,
            this.clSoLuong,
            this.clDonGia,
            this.clMaNhanVien,
            this.Column1,
            this.Column2,
            this.Column3,
            this.clThanhTien,
            this.clGhiChu});
            this.dgvDanhSachChiTietHoaDonDien.Location = new System.Drawing.Point(3, 148);
            this.dgvDanhSachChiTietHoaDonDien.Name = "dgvDanhSachChiTietHoaDonDien";
            this.dgvDanhSachChiTietHoaDonDien.ReadOnly = true;
            this.dgvDanhSachChiTietHoaDonDien.RowTemplate.Height = 24;
            this.dgvDanhSachChiTietHoaDonDien.Size = new System.Drawing.Size(1111, 228);
            this.dgvDanhSachChiTietHoaDonDien.TabIndex = 99;
            this.dgvDanhSachChiTietHoaDonDien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChiTietHoaDonDien_CellClick);
            // 
            // clMahoadondien
            // 
            this.clMahoadondien.DataPropertyName = "MAHOADONDIEN";
            this.clMahoadondien.HeaderText = "Mã hoá đơn điện";
            this.clMahoadondien.Name = "clMahoadondien";
            this.clMahoadondien.ReadOnly = true;
            // 
            // clTenhoadon
            // 
            this.clTenhoadon.DataPropertyName = "TENHOADON";
            this.clTenhoadon.HeaderText = "Tên hoá đơn";
            this.clTenhoadon.Name = "clTenhoadon";
            this.clTenhoadon.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SOLUONG";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DONGIA";
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.DataPropertyName = "MANHANVIEN";
            this.clMaNhanVien.HeaderText = "Mã nhân viên";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHOGD";
            this.Column1.HeaderText = "Mã hộ GD";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MACANHO";
            this.Column2.HeaderText = "Mã căn hộ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYIN";
            this.Column3.HeaderText = "Ngày in";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "THANHTIEN";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GHICHU";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            // 
            // grbThongTinChiTiet
            // 
            this.grbThongTinChiTiet.Controls.Add(this.label15);
            this.grbThongTinChiTiet.Controls.Add(this.label12);
            this.grbThongTinChiTiet.Controls.Add(this.txtDongia);
            this.grbThongTinChiTiet.Controls.Add(this.label);
            this.grbThongTinChiTiet.Controls.Add(this.txtGhiChuCTHDD);
            this.grbThongTinChiTiet.Controls.Add(this.dgvDanhSachChiTietHoaDonDien);
            this.grbThongTinChiTiet.Controls.Add(this.label14);
            this.grbThongTinChiTiet.Controls.Add(this.label16);
            this.grbThongTinChiTiet.Controls.Add(this.txtSoLuong);
            this.grbThongTinChiTiet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTinChiTiet.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTinChiTiet.Location = new System.Drawing.Point(45, 356);
            this.grbThongTinChiTiet.Name = "grbThongTinChiTiet";
            this.grbThongTinChiTiet.Size = new System.Drawing.Size(1114, 379);
            this.grbThongTinChiTiet.TabIndex = 21;
            this.grbThongTinChiTiet.TabStop = false;
            this.grbThongTinChiTiet.Text = "Chi tiết hoá đơn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(508, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 21);
            this.label15.TabIndex = 101;
            this.label15.Text = "Thuế VAT 10%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(235, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 100;
            this.label12.Text = "kWh";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(146, 101);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.ReadOnly = true;
            this.txtDongia.Size = new System.Drawing.Size(170, 28);
            this.txtDongia.TabIndex = 26;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(64, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 21);
            this.label.TabIndex = 21;
            this.label.Text = "Đơn giá";
            // 
            // txtGhiChuCTHDD
            // 
            this.txtGhiChuCTHDD.Location = new System.Drawing.Point(589, 42);
            this.txtGhiChuCTHDD.Name = "txtGhiChuCTHDD";
            this.txtGhiChuCTHDD.Size = new System.Drawing.Size(319, 28);
            this.txtGhiChuCTHDD.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(508, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 21);
            this.label14.TabIndex = 27;
            this.label14.Text = "Ghi chú";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(53, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(146, 42);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(87, 28);
            this.txtSoLuong.TabIndex = 25;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(799, 748);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 21);
            this.label18.TabIndex = 21;
            this.label18.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(923, 747);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(170, 22);
            this.txtTongTien.TabIndex = 100;
            // 
            // erpKiemTraLoi
            // 
            this.erpKiemTraLoi.ContainerControl = this;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::ApartmentManage_ver2.Properties.Resources.print_32x32;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(914, 791);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 50);
            this.btnIn.TabIndex = 101;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::ApartmentManage_ver2.Properties.Resources.cancel_32x322;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1033, 790);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 50);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Image = global::ApartmentManage_ver2.Properties.Resources.Home_icon;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(756, 790);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(152, 50);
            this.btnHienThi.TabIndex = 28;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::ApartmentManage_ver2.Properties.Resources.Start_Menu_Search_icon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(578, 791);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(162, 50);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::ApartmentManage_ver2.Properties.Resources.edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(302, 790);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 50);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::ApartmentManage_ver2.Properties.Resources.Trash_can_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(182, 791);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 50);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::ApartmentManage_ver2.Properties.Resources.add_1_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(48, 791);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 50);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyHoaDonDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 881);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cobTimMaHoaDonDien);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbThongTinChiTiet);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label6);
            this.Name = "frmQuanLyHoaDonDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn điện";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDonDien_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietHoaDonDien)).EndInit();
            this.grbThongTinChiTiet.ResumeLayout(false);
            this.grbThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobTimMaHoaDonDien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cobMaCanHo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenChuHo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobMaHoGiaDinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayIn;
        private System.Windows.Forms.ComboBox cobMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTenCanHo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDonDien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietHoaDonDien;
        private System.Windows.Forms.GroupBox grbThongTinChiTiet;
        private System.Windows.Forms.TextBox txtGhiChuCTHDD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGhiChuHoaDonDien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMahoadondien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.ErrorProvider erpKiemTraLoi;
        private System.Windows.Forms.Button btnIn;
    }
}