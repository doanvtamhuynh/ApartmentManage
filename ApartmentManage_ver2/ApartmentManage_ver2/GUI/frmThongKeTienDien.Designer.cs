namespace ApartmentManage_ver2.GUI
{
    partial class frmThongKeTienDien
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
            this.grbThongKe = new System.Windows.Forms.GroupBox();
            this.btnThongKeTheoNam = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnThongKeTheoThang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobThang = new System.Windows.Forms.ComboBox();
            this.grbHienThi = new System.Windows.Forms.GroupBox();
            this.rpvThongKeTienDien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.erpKiemTraLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongKe.SuspendLayout();
            this.grbHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongKe
            // 
            this.grbThongKe.Controls.Add(this.btnThongKeTheoNam);
            this.grbThongKe.Controls.Add(this.txtNam);
            this.grbThongKe.Controls.Add(this.btnThongKeTheoThang);
            this.grbThongKe.Controls.Add(this.label2);
            this.grbThongKe.Controls.Add(this.label1);
            this.grbThongKe.Controls.Add(this.cobThang);
            this.grbThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongKe.ForeColor = System.Drawing.Color.Blue;
            this.grbThongKe.Location = new System.Drawing.Point(0, 0);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(1382, 114);
            this.grbThongKe.TabIndex = 100;
            this.grbThongKe.TabStop = false;
            this.grbThongKe.Text = "THỐNG KÊ";
            // 
            // btnThongKeTheoNam
            // 
            this.btnThongKeTheoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoNam.ForeColor = System.Drawing.Color.Black;
            this.btnThongKeTheoNam.Image = global::ApartmentManage_ver2.Properties.Resources.chartyaxissettings_32x32;
            this.btnThongKeTheoNam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeTheoNam.Location = new System.Drawing.Point(1005, 22);
            this.btnThongKeTheoNam.Name = "btnThongKeTheoNam";
            this.btnThongKeTheoNam.Size = new System.Drawing.Size(176, 70);
            this.btnThongKeTheoNam.TabIndex = 4;
            this.btnThongKeTheoNam.Text = "Thống kê theo năm";
            this.btnThongKeTheoNam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeTheoNam.UseVisualStyleBackColor = true;
            this.btnThongKeTheoNam.Click += new System.EventHandler(this.btnThongKeTheoNam_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(509, 65);
            this.txtNam.MaxLength = 4;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(162, 30);
            this.txtNam.TabIndex = 2;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            this.txtNam.Leave += new System.EventHandler(this.txtNam_Leave);
            // 
            // btnThongKeTheoThang
            // 
            this.btnThongKeTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoThang.ForeColor = System.Drawing.Color.Black;
            this.btnThongKeTheoThang.Image = global::ApartmentManage_ver2.Properties.Resources.chartyaxissettings_32x32;
            this.btnThongKeTheoThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeTheoThang.Location = new System.Drawing.Point(776, 22);
            this.btnThongKeTheoThang.Name = "btnThongKeTheoThang";
            this.btnThongKeTheoThang.Size = new System.Drawing.Size(176, 70);
            this.btnThongKeTheoThang.TabIndex = 3;
            this.btnThongKeTheoThang.Text = "Thống kê theo tháng";
            this.btnThongKeTheoThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeTheoThang.UseVisualStyleBackColor = true;
            this.btnThongKeTheoThang.Click += new System.EventHandler(this.btnThongKeTheoThang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(390, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // cobThang
            // 
            this.cobThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobThang.FormattingEnabled = true;
            this.cobThang.Location = new System.Drawing.Point(509, 22);
            this.cobThang.Name = "cobThang";
            this.cobThang.Size = new System.Drawing.Size(162, 33);
            this.cobThang.TabIndex = 1;
            // 
            // grbHienThi
            // 
            this.grbHienThi.Controls.Add(this.rpvThongKeTienDien);
            this.grbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHienThi.ForeColor = System.Drawing.Color.Blue;
            this.grbHienThi.Location = new System.Drawing.Point(0, 114);
            this.grbHienThi.Name = "grbHienThi";
            this.grbHienThi.Size = new System.Drawing.Size(1382, 639);
            this.grbHienThi.TabIndex = 101;
            this.grbHienThi.TabStop = false;
            this.grbHienThi.Text = "Kết quả thống kê";
            // 
            // rpvThongKeTienDien
            // 
            this.rpvThongKeTienDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvThongKeTienDien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rpvThongKeTienDien.Location = new System.Drawing.Point(3, 26);
            this.rpvThongKeTienDien.Name = "rpvThongKeTienDien";
            this.rpvThongKeTienDien.Size = new System.Drawing.Size(1376, 610);
            this.rpvThongKeTienDien.TabIndex = 0;
            // 
            // erpKiemTraLoi
            // 
            this.erpKiemTraLoi.ContainerControl = this;
            // 
            // frmThongKeTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.grbHienThi);
            this.Controls.Add(this.grbThongKe);
            this.Name = "frmThongKeTienDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tiền điện";
            this.Load += new System.EventHandler(this.frmThongKeTienDien_Load);
            this.grbThongKe.ResumeLayout(false);
            this.grbThongKe.PerformLayout();
            this.grbHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbThongKe;
        private System.Windows.Forms.Button btnThongKeTheoNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnThongKeTheoThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobThang;
        private System.Windows.Forms.GroupBox grbHienThi;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeTienDien;
        private System.Windows.Forms.ErrorProvider erpKiemTraLoi;
    }
}