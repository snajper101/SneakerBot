using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class Profile
    {
        public string Token;
        public string Username;
        public int Permission;

        public Profile()
        {

        }

        public Profile(string Token, string Username, int Permission)
        {
            this.Token = Token;
            this.Username = Username;
            this.Permission = Permission;
        }
    }
}
