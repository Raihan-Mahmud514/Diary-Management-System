using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Diary_Management_System
{
    class User
    {
        public int UserId { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public DateTime RePassword{ set; get; }

    }
}
