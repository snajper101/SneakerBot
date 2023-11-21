using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class Proxy
    {
        public int ID;
        public string IP;
        public int Port;
        public Proxy()
        {

        }

        public Proxy(int ID, string IP, int Port)
        {
            this.ID = ID;
            this.IP = IP;
            this.Port = Port;
        }
    }
}
