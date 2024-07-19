namespace ApartmentManage_ver2.GUI
{
    partial class frmQuanLyCanHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyCanHo));
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ptbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbLoaiCanHo = new System.Windows.Forms.ComboBox();
            this.cbMaHoGiaDinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaKhu = new System.Windows.Forms.ComboBox();
            this.txtGiaCanHo = new System.Windows.Forms.TextBox();
            this.txtMaCanHo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhSachCanHo = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachCanHo = new System.Windows.Forms.DataGridView();
            this.clMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.clGiaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaKHu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaHoGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMaCanHo = new System.Windows.Forms.ComboBox();
            this.erpKiemTraLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenCanHo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).BeginInit();
            this.grbDanhSachCanHo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCanHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(369, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CĂN HỘ";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtTenCanHo);
            this.grbThongTin.Controls.Add(this.label11);
            this.grbThongTin.Controls.Add(this.txtTrangThai);
            this.grbThongTin.Controls.Add(this.label9);
            this.grbThongTin.Controls.Add(this.ptbHinhAnh);
            this.grbThongTin.Controls.Add(this.txtGhiChu);
            this.grbThongTin.Controls.Add(this.cbLoaiCanHo);
            this.grbThongTin.Controls.Add(this.cbMaHoGiaDinh);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.cbMaKhu);
            this.grbThongTin.Controls.Add(this.txtGiaCanHo);
            this.grbThongTin.Controls.Add(this.txtMaCanHo);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(24, 63);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbThongTin.Size = new System.Drawing.Size(866, 241);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin căn hộ";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTrangThai.Location = new System.Drawing.Point(462, 164);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(140, 28);
            this.txtTrangThai.TabIndex = 17;
            this.txtTrangThai.Text = "Trống";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(695, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hình ảnh";
            // 
            // ptbHinhAnh
            // 
            this.ptbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbHinhAnh.Location = new System.Drawing.Point(633, 52);
            this.ptbHinhAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbHinhAnh.Name = "ptbHinhAnh";
            this.ptbHinhAnh.Size = new System.Drawing.Size(225, 182);
            this.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHinhAnh.TabIndex = 15;
            this.ptbHinhAnh.TabStop = false;
            this.ptbHinhAnh.Click += new System.EventHandler(this.ptbHinhAnh_Click_1);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGhiChu.Location = new System.Drawing.Point(143, 173);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(140, 28);
            this.txtGhiChu.TabIndex = 3;
            // 
            // cbLoaiCanHo
            // 
            this.cbLoaiCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiCanHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLoaiCanHo.FormattingEnabled = true;
            this.cbLoaiCanHo.Location = new System.Drawing.Point(462, 127);
            this.cbLoaiCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiCanHo.Name = "cbLoaiCanHo";
            this.cbLoaiCanHo.Size = new System.Drawing.Size(140, 29);
            this.cbLoaiCanHo.TabIndex = 6;
            // 
            // cbMaHoGiaDinh
            // 
            this.cbMaHoGiaDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHoGiaDinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaHoGiaDinh.FormattingEnabled = true;
            this.cbMaHoGiaDinh.Location = new System.Drawing.Point(462, 90);
            this.cbMaHoGiaDinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaHoGiaDinh.Name = "cbMaHoGiaDinh";
            this.cbMaHoGiaDinh.Size = new System.Drawing.Size(140, 29);
            this.cbMaHoGiaDinh.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(323, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Trạng thái";
            // 
            // cbMaKhu
            // 
            this.cbMaKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaKhu.FormattingEnabled = true;
            this.cbMaKhu.Location = new System.Drawing.Point(462, 52);
            this.cbMaKhu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaKhu.Name = "cbMaKhu";
            this.cbMaKhu.Size = new System.Drawing.Size(140, 29);
            this.cbMaKhu.TabIndex = 4;
            // 
            // txtGiaCanHo
            // 
            this.txtGiaCanHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGiaCanHo.Location = new System.Drawing.Point(143, 137);
            this.txtGiaCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaCanHo.Name = "txtGiaCanHo";
            this.txtGiaCanHo.Size = new System.Drawing.Size(140, 28);
            this.txtGiaCanHo.TabIndex = 2;
            this.txtGiaCanHo.Leave += new System.EventHandler(this.txtGiaCanHo_Leave);
            // 
            // txtMaCanHo
            // 
            this.txtMaCanHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaCanHo.Location = new System.Drawing.Point(143, 62);
            this.txtMaCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCanHo.Name = "txtMaCanHo";
            this.txtMaCanHo.Size = new System.Drawing.Size(140, 28);
            this.txtMaCanHo.TabIndex = 1;
            this.txtMaCanHo.Leave += new System.EventHandler(this.txtMaCanHo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(323, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại căn hộ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(323, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã hộ gia đình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(323, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã khu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã căn hộ";
            // 
            // grbDanhSachCanHo
            // 
            this.grbDanhSachCanHo.Controls.Add(this.dgvDanhSachCanHo);
            this.grbDanhSachCanHo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbDanhSachCanHo.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSachCanHo.Location = new System.Drawing.Point(24, 327);
            this.grbDanhSachCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDanhSachCanHo.Name = "grbDanhSachCanHo";
            this.grbDanhSachCanHo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDanhSachCanHo.Size = new System.Drawing.Size(866, 239);
            this.grbDanhSachCanHo.TabIndex = 2;
            this.grbDanhSachCanHo.TabStop = false;
            this.grbDanhSachCanHo.Text = "Danh sách căn hộ";
            // 
            // dgvDanhSachCanHo
            // 
            this.dgvDanhSachCanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCanHo,
            this.clLoaiCanHo,
            this.clHinhAnh,
            this.clGiaCanHo,
            this.clTrangThai,
            this.clMaKHu,
            this.clMaHoGD,
            this.clGhiChu});
            this.dgvDanhSachCanHo.Location = new System.Drawing.Point(0, 28);
            this.dgvDanhSachCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachCanHo.Name = "dgvDanhSachCanHo";
            this.dgvDanhSachCanHo.ReadOnly = true;
            this.dgvDanhSachCanHo.Size = new System.Drawing.Size(866, 203);
            this.dgvDanhSachCanHo.TabIndex = 99;
            this.dgvDanhSachCanHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachCanHo_CellClick);
            this.dgvDanhSachCanHo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhSachCanHo_DataError);
            // 
            // clMaCanHo
            // 
            this.clMaCanHo.DataPropertyName = "MACANHO";
            this.clMaCanHo.HeaderText = "Mã căn hộ";
            this.clMaCanHo.Name = "clMaCanHo";
            this.clMaCanHo.ReadOnly = true;
            // 
            // clLoaiCanHo
            // 
            this.clLoaiCanHo.DataPropertyName = "LOAICANHO";
            this.clLoaiCanHo.HeaderText = "Loại căn hộ";
            this.clLoaiCanHo.Name = "clLoaiCanHo";
            this.clLoaiCanHo.ReadOnly = true;
            // 
            // clHinhAnh
            // 
            this.clHinhAnh.DataPropertyName = "HINHANH";
            this.clHinhAnh.HeaderText = "Hình ảnh";
            this.clHinhAnh.Name = "clHinhAnh";
            this.clHinhAnh.ReadOnly = true;
            this.clHinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clHinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clGiaCanHo
            // 
            this.clGiaCanHo.DataPropertyName = "GIACANHO";
            this.clGiaCanHo.HeaderText = "Giá căn hộ";
            this.clGiaCanHo.Name = "clGiaCanHo";
            this.clGiaCanHo.ReadOnly = true;
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "TRANGTHAI";
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            // 
            // clMaKHu
            // 
            this.clMaKHu.DataPropertyName = "MAKHU";
            this.clMaKHu.HeaderText = "Mã khu";
            this.clMaKHu.Name = "clMaKHu";
            this.clMaKHu.ReadOnly = true;
            // 
            // clMaHoGD
            // 
            this.clMaHoGD.DataPropertyName = "MAHOGD";
            this.clMaHoGD.HeaderText = "Mã hộ gia đình";
            this.clMaHoGD.Name = "clMaHoGD";
            this.clMaHoGD.ReadOnly = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GHICHU";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(413, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã căn hộ";
            // 
            // cbMaCanHo
            // 
            this.cbMaCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaCanHo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaCanHo.FormattingEnabled = true;
            this.cbMaCanHo.Location = new System.Drawing.Point(374, 628);
            this.cbMaCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaCanHo.Name = "cbMaCanHo";
            this.cbMaCanHo.Size = new System.Drawing.Size(153, 25);
            this.cbMaCanHo.TabIndex = 10;
            // 
            // erpKiemTraLoi
            // 
            this.erpKiemTraLoi.ContainerControl = this;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(790, 604);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 50);
            this.btnDong.TabIndex = 13;
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
            this.btnHienThi.Location = new System.Drawing.Point(658, 604);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(111, 50);
            this.btnHienThi.TabIndex = 12;
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
            this.btnTim.Location = new System.Drawing.Point(547, 603);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 50);
            this.btnTim.TabIndex = 11;
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
            this.btnXoa.Location = new System.Drawing.Point(140, 604);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(259, 604);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(24, 603);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenCanHo
            // 
            this.txtTenCanHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenCanHo.Location = new System.Drawing.Point(143, 98);
            this.txtTenCanHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenCanHo.Name = "txtTenCanHo";
            this.txtTenCanHo.Size = new System.Drawing.Size(140, 28);
            this.txtTenCanHo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(21, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tên căn hộ";
            // 
            // frmQuanLyCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 667);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.cbMaCanHo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbDanhSachCanHo);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLyCanHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý căn hộ";
            this.Load += new System.EventHandler(this.frmQuanLyCanHo_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).EndInit();
            this.grbDanhSachCanHo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCanHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtGiaCanHo;
        private System.Windows.Forms.TextBox txtMaCanHo;
        private System.Windows.Forms.PictureBox ptbHinhAnh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbDanhSachCanHo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMaCanHo;
        public System.Windows.Forms.Button btnHienThi;
        public System.Windows.Forms.Button btnDong;
        public System.Windows.Forms.ComboBox cbLoaiCanHo;
        public System.Windows.Forms.ComboBox cbMaHoGiaDinh;
        public System.Windows.Forms.ComboBox cbMaKhu;
        private System.Windows.Forms.ErrorProvider erpKiemTraLoi;
        public System.Windows.Forms.DataGridView dgvDanhSachCanHo;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiCanHo;
        private System.Windows.Forms.DataGridViewImageColumn clHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHoGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.TextBox txtTenCanHo;
        private System.Windows.Forms.Label label11;
    }
}