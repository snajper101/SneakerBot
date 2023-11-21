using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class Account
    {
        public string Store;
        public string Email;
        public string Password;
        public Account()
        {

        }

        public Account(string Store, string Email, string Password)
        {
            this.Store = Store;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
