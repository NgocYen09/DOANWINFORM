using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOGIN
    {

        Entities db;
        public LOGIN()
        {

            connect cn = new connect();
            string connectString = cn.getConnect();
            db = new Entities(connectString);

        }

        public tb_Users getItem(string tentk)
        {
            return db.tb_Users.FirstOrDefault(x => x.USERNAME == tentk);
        }
        public List<tb_Users> getAll()
        {
            return db.tb_Users.ToList();
        }
    }
}
