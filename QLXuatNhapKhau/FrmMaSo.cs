using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using QLXuatNhapKhau.DAO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLXuatNhapKhau
{
    public partial class FrmMaSo : RibbonForm
    {
        int _load = 200;
        DuLieuDAO dl = null;
        DataTable dt = null;
        int cuoi = 1;
        int dau = 1;
        CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
        System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Bold);
        System.Drawing.Font font2 = new System.Drawing.Font("Times New Roman", 12);
        int tongSoB = 0;
        int tongTrongL = 0;
        public FrmMaSo(DuLieuDAO dl)
        {
            InitializeComponent();
            this.dl = dl;
        }
        private void LoadData()
        {
            /*listBoxMaSo.DataSource = dt;
            listBoxMaSo.DisplayMember = "MASO";
            listBoxMaSo.ValueMember = "MASO";*/
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBoxMaSo.Items.Add(dt.Rows[i][0].ToString());

                }
            }
            catch { }
        }
        private void FrmMaSo_Load(object sender, EventArgs e)
        {
            dt = dl.getMaSoDuLieu(1, _load);
            dau = _load;
            LoadData();
            try
            {
                cuoi = int.Parse(dl.getCountDuLieu().Rows[0][0].ToString());
            }
            catch { }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            dt = dl.getBaoCao(txtMaSo.Text);
            if(dt.Rows.Count>0)
            {
                createReport(dt,txtMaSo.Text);
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy mã số.");
            }
        }

        private void listBoxMaSo_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaSo.Text = listBoxMaSo.SelectedValue.ToString();
        }

        private void btnXemThem_Click(object sender, EventArgs e)
        {
            if(dau<cuoi)
            {
                dt = dl.getMaSoDuLieu(dau, dau + _load);
                dau = dau + _load;
                for(int i = 0;i<dt.Rows.Count;i++)
                {
                    listBoxMaSo.Items.Add(dt.Rows[i][0].ToString());
                    
                }
            }
        }

        private void createReport(DataTable dt, string MaSo)
        {
            tongSoB = 0;
            tongTrongL = 0;
            try
            {
                tongSoB = int.Parse(dt.Compute("SUM(BANHSO)", null).ToString());
            }
            catch { }
            try
            {
                tongTrongL = int.Parse(dt.Compute("SUM(TLNHAP)", null).ToString());
            }
            catch { }
            rptBaoCao rpt = new rptBaoCao();
            rpt.DataSource = null;
            rpt.xrlblMaSo.Text = MaSo;
            rpt.xrlblSoHopDong.Text = dt.Rows[0][11].ToString();
            rpt.xrlblKhachHang.Text = dt.Rows[0][13].ToString();
            rpt.xrlblSoPo.Text = dt.Rows[0][12].ToString();
            rpt.xrlbPBXH.Text = dt.Rows[0][0].ToString()+" - năm "+dt.Rows[0][7].ToString();
            //
            XRTableRow row = new XRTableRow();
            XRTableCell cell = new XRTableCell();
            cell.WidthF = 20;
            cell.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top) | (DevExpress.XtraPrinting.BorderSide.Left)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            row.Cells.Add(cell);

            cell = new XRTableCell();
            cell.Text = dt.Rows[0]["NGAYXUAT"].ToString().Replace(" 12:00:00 AM", ""); ;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            cell.Font = font;
            cell.WidthF = 500;
            cell.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top) | (DevExpress.XtraPrinting.BorderSide.Right)
           | DevExpress.XtraPrinting.BorderSide.Bottom)));
            row.Cells.Add(cell);

            cell = new XRTableCell();
            cell.Text = tongSoB.ToString("0,0", elGR);
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.Font = font;
            cell.WidthF = 80;
            row.Cells.Add(cell);

            cell = new XRTableCell();
            cell.Text = tongTrongL.ToString("0,0", elGR);
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.Font = font;
            cell.WidthF = 100;
            row.Cells.Add(cell);

            rpt.xrTable.Rows.Add(row);
            //
            for(int i=0;i<dt.Rows.Count;i++)
            {
                row = new XRTableRow();
                cell = new XRTableCell();
                cell.Text = (i + 1).ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font2;
                cell.WidthF = 100;
                row.Cells.Add(cell);

                cell = new XRTableCell();
                cell.Text = dt.Rows[i]["LOSO"].ToString() +" "+dt.Rows[i]["NGUON"].ToString().Substring(0,1);
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font;
                cell.WidthF = 80;
                row.Cells.Add(cell);

                cell = new XRTableCell();
                cell.Text = dt.Rows[i]["NAMSX"].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font2;
                cell.WidthF = 80;
                row.Cells.Add(cell);

                cell = new XRTableCell();
                cell.Text = dt.Rows[i]["LOAIMU"].ToString().Substring(2) + " - " + dt.Rows[i]["BANH"].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font2;
                cell.WidthF = 140;
                row.Cells.Add(cell);

                cell = new XRTableCell();
                cell.Text = dt.Rows[i]["NHAMAY"].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font2;
                cell.WidthF = 120;
                row.Cells.Add(cell);

                cell = new XRTableCell();
                cell.Text = dt.Rows[i]["BANHSO"].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font2;
                cell.WidthF = 80;
                row.Cells.Add(cell);

                cell = new XRTableCell();
                cell.Text = dt.Rows[i]["TLNHAP"].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font2;
                cell.WidthF = 100;
                row.Cells.Add(cell);

                rpt.xrTable.Rows.Add(row);
            }
            //
            row = new XRTableRow();
            cell = new XRTableCell();
            cell.Text = "CỘNG";
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.Font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold);
            cell.WidthF = 520;
            row.Cells.Add(cell);

            cell = new XRTableCell();
            cell.Text = tongSoB.ToString("0,0", elGR);
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.Font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold);
            cell.WidthF = 80;
            row.Cells.Add(cell);

            cell = new XRTableCell();
            cell.Text = tongTrongL.ToString("0,0", elGR);
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.Font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold);
            cell.WidthF = 100;
            row.Cells.Add(cell);

            rpt.xrTable.Rows.Add(row);

            //
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        } 

    }
}
