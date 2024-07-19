namespace ApartmentManage_ver2.GUI
{
    partial class frmTraCuuHoGiaDinh
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
            this.grbThongTinCanTraCuuHoGiaDinh = new System.Windows.Forms.GroupBox();
            this.txtTraCuuTheoTenChuHo = new System.Windows.Forms.TextBox();
            this.txtTraCuuTheoMaHoGD = new System.Windows.Forms.TextBox();
            this.cobTraCuuHoGiaDinhTheoMaKhu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.grbDanhSachTraCuuHoGiaDinh = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachTraCuuHoGiaDinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grbThongTinCanTraCuuHoGiaDinh.SuspendLayout();
            this.grbDanhSachTraCuuHoGiaDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTraCuuHoGiaDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinCanTraCuuHoGiaDinh
            // 
            this.grbThongTinCanTraCuuHoGiaDinh.Controls.Add(this.txtTraCuuTheoTenChuHo);
            this.grbThongTinCanTraCuuHoGiaDinh.Controls.Add(this.txtTraCuuTheoMaHoGD);
            this.grbThongTinCanTraCuuHoGiaDinh.Controls.Add(this.cobTraCuuHoGiaDinhTheoMaKhu);
            this.grbThongTinCanTraCuuHoGiaDinh.Controls.Add(this.label3);
            this.grbThongTinCanTraCuuHoGiaDinh.Controls.Add(this.label2);
            this.grbThongTinCanTraCuuHoGiaDinh.Controls.Add(this.label1);
            this.grbThongTinCanTraCuuHoGiaDinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinCanTraCuuHoGiaDinh.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTinCanTraCuuHoGiaDinh.Location = new System.Drawing.Point(12, 64);
            this.grbThongTinCanTraCuuHoGiaDinh.Name = "grbThongTinCanTraCuuHoGiaDinh";
            this.grbThongTinCanTraCuuHoGiaDinh.Size = new System.Drawing.Size(1048, 105);
            this.grbThongTinCanTraCuuHoGiaDinh.TabIndex = 0;
            this.grbThongTinCanTraCuuHoGiaDinh.TabStop = false;
            this.grbThongTinCanTraCuuHoGiaDinh.Text = "Thông tin cần tra cứu";
            // 
            // txtTraCuuTheoTenChuHo
            // 
            this.txtTraCuuTheoTenChuHo.Location = new System.Drawing.Point(543, 40);
            this.txtTraCuuTheoTenChuHo.Name = "txtTraCuuTheoTenChuHo";
            this.txtTraCuuTheoTenChuHo.Size = new System.Drawing.Size(152, 26);
            this.txtTraCuuTheoTenChuHo.TabIndex = 10;
            // 
            // txtTraCuuTheoMaHoGD
            // 
            this.txtTraCuuTheoMaHoGD.Location = new System.Drawing.Point(205, 40);
            this.txtTraCuuTheoMaHoGD.Name = "txtTraCuuTheoMaHoGD";
            this.txtTraCuuTheoMaHoGD.Size = new System.Drawing.Size(152, 26);
            this.txtTraCuuTheoMaHoGD.TabIndex = 9;
            // 
            // cobTraCuuHoGiaDinhTheoMaKhu
            // 
            this.cobTraCuuHoGiaDinhTheoMaKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobTraCuuHoGiaDinhTheoMaKhu.FormattingEnabled = true;
            this.cobTraCuuHoGiaDinhTheoMaKhu.Location = new System.Drawing.Point(849, 40);
            this.cobTraCuuHoGiaDinhTheoMaKhu.Name = "cobTraCuuHoGiaDinhTheoMaKhu";
            this.cobTraCuuHoGiaDinhTheoMaKhu.Size = new System.Drawing.Size(152, 26);
            this.cobTraCuuHoGiaDinhTheoMaKhu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(746, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khu nhà";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(413, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Chủ hộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hộ Gia đình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(393, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 29);
            this.label6.TabIndex = 102;
            this.label6.Text = "TRA CỨU HỘ GIA ĐÌNH";
            // 
            // grbDanhSachTraCuuHoGiaDinh
            // 
            this.grbDanhSachTraCuuHoGiaDinh.Controls.Add(this.dgvDanhSachTraCuuHoGiaDinh);
            this.grbDanhSachTraCuuHoGiaDinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbDanhSachTraCuuHoGiaDinh.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSachTraCuuHoGiaDinh.Location = new System.Drawing.Point(12, 199);
            this.grbDanhSachTraCuuHoGiaDinh.Name = "grbDanhSachTraCuuHoGiaDinh";
            this.grbDanhSachTraCuuHoGiaDinh.Size = new System.Drawing.Size(1048, 322);
            this.grbDanhSachTraCuuHoGiaDinh.TabIndex = 6;
            this.grbDanhSachTraCuuHoGiaDinh.TabStop = false;
            this.grbDanhSachTraCuuHoGiaDinh.Text = "Danh Sách";
            // 
            // dgvDanhSachTraCuuHoGiaDinh
            // 
            this.dgvDanhSachTraCuuHoGiaDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTraCuuHoGiaDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDanhSachTraCuuHoGiaDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachTraCuuHoGiaDinh.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachTraCuuHoGiaDinh.Name = "dgvDanhSachTraCuuHoGiaDinh";
            this.dgvDanhSachTraCuuHoGiaDinh.RowTemplate.Height = 24;
            this.dgvDanhSachTraCuuHoGiaDinh.Size = new System.Drawing.Size(1042, 297);
            this.dgvDanhSachTraCuuHoGiaDinh.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHOGD";
            this.Column1.HeaderText = "Mã hộ Gia đình";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENCHUHO";
            this.Column2.HeaderText = "Tên chủ hộ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOCMND";
            this.Column3.HeaderText = "Số CMND chủ hộ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOLUONGTV";
            this.Column4.HeaderText = "Số lượng TV";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Image = global::ApartmentManage_ver2.Properties.Resources.Home_icon;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(634, 553);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(152, 50);
            this.btnHienThi.TabIndex = 30;
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
            this.btnTimKiem.Location = new System.Drawing.Point(252, 553);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(162, 50);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmTraCuuHoGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 645);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grbDanhSachTraCuuHoGiaDinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbThongTinCanTraCuuHoGiaDinh);
            this.Name = "frmTraCuuHoGiaDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu hộ gia đình";
            this.Load += new System.EventHandler(this.frmTraCuuHoGiaDinh_Load);
            this.grbThongTinCanTraCuuHoGiaDinh.ResumeLayout(false);
            this.grbThongTinCanTraCuuHoGiaDinh.PerformLayout();
            this.grbDanhSachTraCuuHoGiaDinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTraCuuHoGiaDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinCanTraCuuHoGiaDinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbDanhSachTraCuuHoGiaDinh;
        private System.Windows.Forms.DataGridView dgvDanhSachTraCuuHoGiaDinh;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cobTraCuuHoGiaDinhTheoMaKhu;
        private System.Windows.Forms.TextBox txtTraCuuTheoTenChuHo;
        private System.Windows.Forms.TextBox txtTraCuuTheoMaHoGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}