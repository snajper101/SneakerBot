using SneakerBot.AuthLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class SupportTicket
    {
        public int TicketID;
        public int Status;
        public string Topic;
        public List<SupportReply> supportReply;

        public SupportTicket()
        {

        }

        public SupportTicket(int TicketID, int Status, string Topic, List<SupportReply> supportReply)
        {
            this.TicketID = TicketID;
            this.Status = Status;
            this.Topic = Topic;
            this.supportReply = supportReply;
        }
    }
}
