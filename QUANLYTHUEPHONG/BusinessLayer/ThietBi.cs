using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThietBi
    {
        Entities db;
        public ThietBi()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public tb_ThietBi getItem(int idThietBi)
        {
            return db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idThietBi);
        }
        public List<tb_ThietBi> getAll()
        {
            return db.tb_ThietBi.ToList();
        }

        public void add (tb_ThietBi thietBi)
        {
            try
            {

                db.tb_ThietBi.Add(thietBi);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữu liệu." + ex.Message);
            }
        }

        public void update (tb_ThietBi thietBi)
        {
            tb_ThietBi _ThietBi = db.tb_ThietBi.FirstOrDefault(x => x.IDTB== thietBi.IDTB);
            _ThietBi.TENTB = thietBi.TENTB;
            _ThietBi.IDTB = thietBi.IDTB;
            _ThietBi.DONGIA = thietBi.DONGIA;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữu liệu." + ex.Message);
            }
        }
        public void delete (int idThietBi)
        {
            tb_ThietBi thietBi = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idThietBi);

            try
            {
                db.tb_ThietBi.Remove(thietBi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữu liệu." + ex.Message);
            }
        }
        public  tb_ThietBi getItem (string idThietBi)
        {
            throw new NotImplementedException();
        }
    }
}
    
