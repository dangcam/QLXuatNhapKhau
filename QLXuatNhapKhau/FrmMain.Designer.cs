namespace QLXuatNhapKhau
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayLamViec = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnTimMaSo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoPBXH = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoHopDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnTTChiTiet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(834, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.labelControl1.Location = new System.Drawing.Point(80, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(363, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "CÔNG TY TNHH MTV CAO SU PHÚ RIỀNG";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl2.Location = new System.Drawing.Point(141, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(243, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "PHÒNG XUẤT NHẬP KHẨU";
            // 
            // lblNgayLamViec
            // 
            this.lblNgayLamViec.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLamViec.Appearance.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNgayLamViec.Location = new System.Drawing.Point(549, 96);
            this.lblNgayLamViec.Name = "lblNgayLamViec";
            this.lblNgayLamViec.Size = new System.Drawing.Size(183, 18);
            this.lblNgayLamViec.TabIndex = 3;
            this.lblNgayLamViec.Text = "Ngày làm việc : 05/09/2016";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl3.Location = new System.Drawing.Point(293, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(253, 26);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // btnTimMaSo
            // 
            this.btnTimMaSo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaSo.Appearance.Options.UseFont = true;
            this.btnTimMaSo.Location = new System.Drawing.Point(322, 207);
            this.btnTimMaSo.Name = "btnTimMaSo";
            this.btnTimMaSo.Size = new System.Drawing.Size(200, 25);
            this.btnTimMaSo.TabIndex = 6;
            this.btnTimMaSo.Text = "Tìm kiếm theo Mã số";
            this.btnTimMaSo.Click += new System.EventHandler(this.btnTimMaSo_Click);
            // 
            // btnSoPBXH
            // 
            this.btnSoPBXH.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoPBXH.Appearance.Options.UseFont = true;
            this.btnSoPBXH.Location = new System.Drawing.Point(322, 238);
            this.btnSoPBXH.Name = "btnSoPBXH";
            this.btnSoPBXH.Size = new System.Drawing.Size(200, 25);
            this.btnSoPBXH.TabIndex = 6;
            this.btnSoPBXH.Text = "Tìm kiếm theo Số PBXH";
            // 
            // btnSoHopDong
            // 
            this.btnSoHopDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoHopDong.Appearance.Options.UseFont = true;
            this.btnSoHopDong.Location = new System.Drawing.Point(322, 269);
            this.btnSoHopDong.Name = "btnSoHopDong";
            this.btnSoHopDong.Size = new System.Drawing.Size(200, 25);
            this.btnSoHopDong.TabIndex = 6;
            this.btnSoHopDong.Text = "Tìm kiếm theo Số Hợp Đồng";
            // 
            // btnTTChiTiet
            // 
            this.btnTTChiTiet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTChiTiet.Appearance.Options.UseFont = true;
            this.btnTTChiTiet.Location = new System.Drawing.Point(322, 300);
            this.btnTTChiTiet.Name = "btnTTChiTiet";
            this.btnTTChiTiet.Size = new System.Drawing.Size(200, 25);
            this.btnTTChiTiet.TabIndex = 6;
            this.btnTTChiTiet.Text = "Xem thông tin chi tiết";
            this.btnTTChiTiet.Click += new System.EventHandler(this.btnTTChiTiet_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.btnTTChiTiet);
            this.Controls.Add(this.btnSoHopDong);
            this.Controls.Add(this.btnSoPBXH);
            this.Controls.Add(this.btnTimMaSo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblNgayLamViec);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truy Xuất Dữ Liệu";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblNgayLamViec;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTimMaSo;
        private DevExpress.XtraEditors.SimpleButton btnSoPBXH;
        private DevExpress.XtraEditors.SimpleButton btnSoHopDong;
        private DevExpress.XtraEditors.SimpleButton btnTTChiTiet;
    }
}

