using System.Data;

namespace QLXuatNhapKhau.DAO
{
    public class DuLieuDAO
    {
        Connection db = null;
        public DuLieuDAO()
        {
            db = new Connection();
        }
        public DataTable DSDuLieu()
        {
            return db.ExcuteQuery("Select  * From DULIEU",
                CommandType.Text, null);
        }
        public DataTable getCountDuLieu()
        {
            return db.ExcuteQuery("Select  * From getCountDuLieu()",
                CommandType.Text, null);
        }
        public DataTable getDuLieu(int vitri)
        {
            return db.ExcuteQuery("Select  * From dbo.getCTDuLieu('" + vitri + "')",
                CommandType.Text, null);
        }
        public DataTable getBaoCao(string maso)
        {
            return db.ExcuteQuery("Select  * From dbo.getBaoCao('" + maso + "')",
                CommandType.Text, null);
        }
        public DataTable getMaSoDuLieu(int bd, int kt)
        {
            return db.ExcuteQuery("Select  * From dbo.getMaSoDuLieu('" + bd + "','" + kt + "')",
                CommandType.Text, null);
        }
    }
}
