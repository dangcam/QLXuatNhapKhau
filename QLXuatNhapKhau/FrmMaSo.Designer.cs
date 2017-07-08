using System.Windows.Forms;

namespace QLXuatNhapKhau
{
    partial class FrmMaSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaSo));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnXemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxMaSo = new DevExpress.XtraEditors.ListBoxControl();
            this.txtMaSo = new DevExpress.XtraEditors.TextEdit();
            this.btnXemThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMaSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).BeginInit();
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(127, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(286, 52);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "TÌM KIẾM \r\nTHEO MÃ SỐ SẢN PHẨM\r\n";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(66, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "MÃ SỐ";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Appearance.Options.UseFont = true;
            this.btnXemChiTiet.Location = new System.Drawing.Point(208, 219);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(172, 30);
            this.btnXemChiTiet.TabIndex = 4;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // listBoxMaSo
            // 
            this.listBoxMaSo.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMaSo.Appearance.Options.UseFont = true;
            this.listBoxMaSo.Location = new System.Drawing.Point(514, 49);
            this.listBoxMaSo.Name = "listBoxMaSo";
            this.listBoxMaSo.Size = new System.Drawing.Size(280, 303);
            this.listBoxMaSo.TabIndex = 6;
            this.listBoxMaSo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMaSo_MouseClick);
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(158, 165);
            this.txtMaSo.MenuManager = this.ribbonControl1;
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Properties.Appearance.Options.UseFont = true;
            this.txtMaSo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaSo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaSo.Size = new System.Drawing.Size(280, 30);
            this.txtMaSo.TabIndex = 8;
            // 
            // btnXemThem
            // 
            this.btnXemThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThem.Appearance.Options.UseFont = true;
            this.btnXemThem.Location = new System.Drawing.Point(599, 369);
            this.btnXemThem.Name = "btnXemThem";
            this.btnXemThem.Size = new System.Drawing.Size(106, 30);
            this.btnXemThem.TabIndex = 9;
            this.btnXemThem.Text = "Xem thêm";
            this.btnXemThem.Click += new System.EventHandler(this.btnXemThem_Click);
            // 
            // FrmMaSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.btnXemThem);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.listBoxMaSo);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMaSo";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm theo Mã Số";
            this.Load += new System.EventHandler(this.FrmMaSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMaSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXemChiTiet;
        private DevExpress.XtraEditors.ListBoxControl listBoxMaSo;
        private DevExpress.XtraEditors.TextEdit txtMaSo;
        private DevExpress.XtraEditors.SimpleButton btnXemThem;
    }
}