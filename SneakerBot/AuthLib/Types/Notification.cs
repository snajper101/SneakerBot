using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class Notification
    {
        public int ID;
        public bool Read;
        public string Title;
        public string Message;
        public string CreationDate;
        public string ReadDate;

        public Notification()
        {

        }

        public Notification(int ID, bool Read, string Title, string Message, string CreationDate)
        {
            this.ID = ID;
            this.Read = Read;
            this.Title = Title;
            this.Message = Message;
            this.CreationDate = CreationDate;
        }
    }
}
