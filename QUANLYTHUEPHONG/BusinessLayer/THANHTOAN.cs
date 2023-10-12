using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace BusinessLayer
{
    
    public class THANHTOAN
    {

        Entities db;
        public THANHTOAN()
        {

            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);

        }
        public tb_THANHTOAN getItem(int idtt)
        {
            return db.tb_THANHTOAN.FirstOrDefault(x => x.IDTT == idtt);
        }
        public List<tb_THANHTOAN> getAll()
        {
            return db.tb_THANHTOAN.ToList();
        }
        public decimal GetTotalRevenueByDate(DateTime selectedDate)
        {
           DateTime starDate = selectedDate.Date;
            DateTime endDate = selectedDate.AddDays(1);

            var revenueForDatedb = db.tb_THANHTOAN
                .Where(tt => tt.NGAYTT >= starDate && tt.NGAYTT< endDate)
                .Select(tt => tt.TONGTIENTT)
                .ToList();
            decimal totalRevenue = (decimal)revenueForDatedb.Sum();
            return totalRevenue;   
        }

    }
}
