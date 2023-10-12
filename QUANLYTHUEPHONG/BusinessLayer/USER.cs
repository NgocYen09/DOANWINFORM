using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class USER
    {
    
        Entities db;

        public USER()
        {
            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);

        }
  
   
       
        public tb_Users getItem(int uid )
        {
            return db.tb_Users.FirstOrDefault(x => x.UID == uid);
        }
        public List<tb_Users> getAll()
        {
            return db.tb_Users.ToList();
        }   
        public void add(tb_Users users)
        {
            try
            {
                db.tb_Users.Add(users);
                db.SaveChanges();   
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra." +ex.Message);
            }
        }
        public void update(tb_Users users)
        {
            tb_Users _users = db.tb_Users.FirstOrDefault(x=> x.UID == users.UID);
            _users.FULLNAME = users.FULLNAME;
            _users.PASSWD = users.PASSWD;
            _users.CHUCVU = users.CHUCVU;
            //_users.DISABLED = users.DISABLED;
            _users.USERNAME = users.USERNAME;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception ("Có lỗi."+ex.Message);
            }
        }
        public void delete(int id)
        {
            tb_Users users = db.tb_Users.FirstOrDefault( x=> x.UID == id);
            try
            {
                db.tb_Users.Remove(users);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra."+ex.Message);
            }
        }

    }
}
