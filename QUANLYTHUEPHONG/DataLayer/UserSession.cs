using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserSession
    {
        public static tb_Users CurrentUser { get; private set; }
        public static void StartSession(tb_Users user)
        {
            CurrentUser = user;
        }

        public static void EndSession()
        {
            CurrentUser = null;
        }
    }

    public class User
    {
        public string Username { get; set; }
    }


}

