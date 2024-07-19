namespace ApartmentManage_ver2.GUI
{
    partial class frmThongKeDoanhThu
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobThang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpvThongKeDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.erpKiemTraLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongKe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongKe
            // 
            this.grbThongKe.Controls.Add(this.btnThongKeTheoNam);
            this.grbThongKe.Controls.Add(this.txtNam);
            this.grbThongKe.Controls.Add(this.btnThongKe);
            this.grbThongKe.Controls.Add(this.label2);
            this.grbThongKe.Controls.Add(this.label1);
            this.grbThongKe.Controls.Add(this.cobThang);
            this.grbThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongKe.ForeColor = System.Drawing.Color.Blue;
            this.grbThongKe.Location = new System.Drawing.Point(0, 0);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(1382, 114);
            this.grbThongKe.TabIndex = 1;
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
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = global::ApartmentManage_ver2.Properties.Resources.chartyaxissettings_32x32;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(776, 22);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(176, 70);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê theo tháng";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rpvThongKeDoanhThu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1382, 639);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả thống kê";
            // 
            // rpvThongKeDoanhThu
            // 
            this.rpvThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvThongKeDoanhThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rpvThongKeDoanhThu.LocalReport.ReportEmbeddedResource = "ApartmentManage_ver2.GUI.Report5.rdlc";
            this.rpvThongKeDoanhThu.Location = new System.Drawing.Point(3, 26);
            this.rpvThongKeDoanhThu.Name = "rpvThongKeDoanhThu";
            this.rpvThongKeDoanhThu.Size = new System.Drawing.Size(1376, 610);
            this.rpvThongKeDoanhThu.TabIndex = 99;
            // 
            // erpKiemTraLoi
            // 
            this.erpKiemTraLoi.ContainerControl = this;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongKe);
            this.Name = "frmThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.grbThongKe.ResumeLayout(false);
            this.grbThongKe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongKe;
        private System.Windows.Forms.Button btnThongKeTheoNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeDoanhThu;
        private System.Windows.Forms.ErrorProvider erpKiemTraLoi;
    }
}