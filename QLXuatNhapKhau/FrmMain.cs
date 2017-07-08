using DevExpress.XtraBars.Ribbon;
using QLXuatNhapKhau.DAO;
using System;
using System.Windows.Forms;

namespace QLXuatNhapKhau
{
    public partial class FrmMain : RibbonForm
    {
        ReadConfig readConfig;
        DuLieuDAO dl = null;
        Form frmMaSo;
        public FrmMain()
        {
            InitializeComponent();
            readConfig = new ReadConfig();        
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            readConfig.Read();
            dl = new DuLieuDAO();
            lblNgayLamViec.Text = "Ngày làm việc: " + DateTime.Now.ToShortDateString();
            frmMaSo = new FrmMaSo(dl);
        }

        private void btnTTChiTiet_Click(object sender, EventArgs e)
        {
            FrmTTChiTiet frm = new FrmTTChiTiet(dl);
            frm.ShowDialog();
        }

        private void btnTimMaSo_Click(object sender, EventArgs e)
        {
            frmMaSo.ShowDialog();
        }
    }
}
