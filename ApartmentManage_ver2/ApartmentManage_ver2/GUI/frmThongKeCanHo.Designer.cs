namespace ApartmentManage_ver2.GUI
{
    partial class frmThongKeCanHo
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
            this.grbThongKe = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cobTrangThai = new System.Windows.Forms.ComboBox();
            this.grbHienThi = new System.Windows.Forms.GroupBox();
            this.rpvThongKeCanHo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grbThongKe.SuspendLayout();
            this.grbHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongKe
            // 
            this.grbThongKe.Controls.Add(this.btnThongKe);
            this.grbThongKe.Controls.Add(this.label1);
            this.grbThongKe.Controls.Add(this.cobTrangThai);
            this.grbThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongKe.ForeColor = System.Drawing.Color.Blue;
            this.grbThongKe.Location = new System.Drawing.Point(0, 0);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(1382, 103);
            this.grbThongKe.TabIndex = 1;
            this.grbThongKe.TabStop = false;
            this.grbThongKe.Text = "THỐNG KÊ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = global::ApartmentManage_ver2.Properties.Resources.chartyaxissettings_32x32;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(780, 29);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(142, 51);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(392, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trạng thái";
            // 
            // cobTrangThai
            // 
            this.cobTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobTrangThai.FormattingEnabled = true;
            this.cobTrangThai.Location = new System.Drawing.Point(511, 37);
            this.cobTrangThai.Name = "cobTrangThai";
            this.cobTrangThai.Size = new System.Drawing.Size(162, 33);
            this.cobTrangThai.TabIndex = 1;
            // 
            // grbHienThi
            // 
            this.grbHienThi.Controls.Add(this.rpvThongKeCanHo);
            this.grbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHienThi.ForeColor = System.Drawing.Color.Blue;
            this.grbHienThi.Location = new System.Drawing.Point(0, 103);
            this.grbHienThi.Name = "grbHienThi";
            this.grbHienThi.Size = new System.Drawing.Size(1382, 650);
            this.grbHienThi.TabIndex = 2;
            this.grbHienThi.TabStop = false;
            this.grbHienThi.Text = "Kết quả thống kê";
            // 
            // rpvThongKeCanHo
            // 
            this.rpvThongKeCanHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvThongKeCanHo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rpvThongKeCanHo.LocalReport.ReportEmbeddedResource = "ApartmentManage_ver2.GUI.Report4.rdlc";
            this.rpvThongKeCanHo.Location = new System.Drawing.Point(3, 26);
            this.rpvThongKeCanHo.Name = "rpvThongKeCanHo";
            this.rpvThongKeCanHo.Size = new System.Drawing.Size(1376, 621);
            this.rpvThongKeCanHo.TabIndex = 0;
            // 
            // frmThongKeCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.grbHienThi);
            this.Controls.Add(this.grbThongKe);
            this.Name = "frmThongKeCanHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê căn hộ";
            this.Load += new System.EventHandler(this.frmThongKeCanHo_Load);
            this.grbThongKe.ResumeLayout(false);
            this.grbThongKe.PerformLayout();
            this.grbHienThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobTrangThai;
        private System.Windows.Forms.GroupBox grbHienThi;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeCanHo;
    }
}