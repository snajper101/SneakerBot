using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class SupportReply
    {
        public int ID;
        public Profile profile;
        public string content;
        public DateTime DateTime;

        public SupportReply() { }

        public SupportReply(int ID, Profile profile,string content, DateTime DateTime)
        {
            this.ID = ID;
            this.profile = profile;
            this.content = content;
            this.DateTime = DateTime;
        }
    }
}
