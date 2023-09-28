using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SANPHAM
    {
        Entities db;
        public SANPHAM() 
        {
           connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);
        }
        public tb_SanPham getItem (int idSanPham) 
        {
            return db.tb_SanPham.FirstOrDefault(x => x.IDSP == idSanPham);
        }
        public List<tb_SanPham> getAll()
        {
            return db.tb_SanPham.ToList();
        }

        public void add (tb_SanPham sanPham)
        {
            try 
            {

                db.tb_SanPham.Add(sanPham);
                db.SaveChanges();

            }
            catch (Exception ex) 
            { 
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữu liệu." +  ex.Message);
            }
            
        }
        public void update(tb_SanPham sanPham)
        {
            tb_SanPham _SanPham = db.tb_SanPham.FirstOrDefault(x=>x.IDSP==sanPham.IDSP);
            _SanPham.TENSP = sanPham.TENSP;
            _SanPham.IDSP = sanPham.IDSP;
            _SanPham.DONGIA = sanPham.DONGIA;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữu liệu." + ex.Message);
            }
        }
        public void delete(int idSanPham)
        {
            tb_SanPham sanPham = db.tb_SanPham.FirstOrDefault(x => x.IDSP == idSanPham);

            try
            {
                db.tb_SanPham.Remove(sanPham);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữu liệu." + ex.Message);
            }
        }

        public tb_SanPham getItem(string idSanPham)
        {
            throw new NotImplementedException();
        }
    }
}
