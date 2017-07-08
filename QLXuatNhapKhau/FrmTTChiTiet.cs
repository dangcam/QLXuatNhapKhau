using DevExpress.XtraBars.Ribbon;
using QLXuatNhapKhau.DAO;
using System;
using System.Data;

namespace QLXuatNhapKhau
{
    public partial class FrmTTChiTiet : RibbonForm
    {
        DuLieuDAO dl = null;
        DataTable dt = null;
        int dau = 1;
        int cuoi = 1;
        public FrmTTChiTiet(DuLieuDAO dl)
        {
            InitializeComponent();
            this.dl = dl;
        }
        private void LoadData()
        {
            txtMaSo.Text = dt.Rows[0][0].ToString();
            string loaimu = dt.Rows[0][1].ToString();
            txtLoaiMu.Text = loaimu.Substring(2);
            txtLoaiBanh.Text = dt.Rows[0][2].ToString();
            txtLoSo.Text = dt.Rows[0][3].ToString();
            txtNguon.Text = dt.Rows[0][4].ToString();
            txtBanhSo.Text = dt.Rows[0][5].ToString();
            txtNgaySX.Text = dt.Rows[0][6].ToString().Replace(" 12:00:00 AM","");
            txtNhaMay.Text = dt.Rows[0][7].ToString();
            txtNgayTest.Text = dt.Rows[0][9].ToString().Replace(" 12:00:00 AM", "");
            txtTChat.Text = dt.Rows[0][10].ToString();
            txtTro.Text = dt.Rows[0][11].ToString();
            txtBHoi.Text = dt.Rows[0][12].ToString();
            txtNiTo.Text = dt.Rows[0][13].ToString();
            txtPo.Text = dt.Rows[0][14].ToString();
            txtPri.Text = dt.Rows[0][15].ToString();
            txtMau.Text = dt.Rows[0][16].ToString();
            txtVrl.Text = dt.Rows[0][17].ToString();
            txtSoPBXH.Text = dt.Rows[0][18].ToString();
            txtNam.Text = dt.Rows[0][19].ToString();
            txtNgayXuat.Text = dt.Rows[0][20].ToString().Replace(" 12:00:00 AM", "");
            txtSoHD.Text = dt.Rows[0][21].ToString();
            txtSoPo.Text = dt.Rows[0][22].ToString();
            txtKhachHang.Text = dt.Rows[0][23].ToString();

            btnTruoc.Enabled = true;
            btnSau.Enabled = true;
            if(dau<=1)
            {
                btnTruoc.Enabled = false;
            }
            if(dau>=cuoi)
            {
                btnSau.Enabled = false;
            }
        }
        private void FrmTTChiTiet_Load(object sender, EventArgs e)
        {
            dt = dl.getDuLieu(1);
            try
            {
                cuoi = int.Parse(dl.getCountDuLieu().Rows[0][0].ToString());
            }
            catch { }
            LoadData();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dau = 1;
            dt = dl.getDuLieu(dau);
            LoadData();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            dau--;
            dt = dl.getDuLieu(dau);
            LoadData();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            dau++;
            dt = dl.getDuLieu(dau);
            LoadData();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dau = cuoi;
            dt = dl.getDuLieu(cuoi);
            LoadData();
        }
    }
}
