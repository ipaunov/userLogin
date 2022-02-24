using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public String Username { get; set; }

        public String Password { get; set; }
        public String FakNum { get; set; }
        public Int32 Role { get; set; }


        public User(String Username, String Password, String FakNum, Int32 Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.FakNum = FakNum;
            this.Role = Role;
        }
    }
}
