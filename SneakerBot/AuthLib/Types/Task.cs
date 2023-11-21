using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot.AuthLib.Types
{
    public class Task
    {
        public string Name;
        public string Website;
        public string Link;
        public Account Account;
        public string Product;
        public string Status;
        public string Size;
        public int ID;
        public BillingProfile BillingProfile;
        public Proxy proxy;
        public Task()
        {

        }

        public Task(string Name, string Website, string Link, Account Account, string Product, string Status,string Size, int ID, BillingProfile BillingProfile, Proxy proxy)
        {
            this.Name = Name;
            this.Website = Website;
            this.Link = Link;
            this.Account = Account;
            this.Product = Product;
            this.Status = Status;
            this.Size = Size;
            this.ID = ID;
            this.BillingProfile = BillingProfile;
            this.proxy = proxy;
        }
    }
}
