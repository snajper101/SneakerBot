using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot
{
    public class BillingProfile
    {
        public string Name;
        public string Email;
        public string PhoneNumber;
        public string CardHolder;
        public string CardNumber;
        public string ShippingAdress;
        public string Expiry_Month;
        public int Expiry_Year;
        public string CVV;
        public string Delivery_First_Name;
        public string Delivery_Last_Name;
        public string Delivery_Addres;
        public string Delivery_City;
        public string Delivery_Zip_Code;
        public string Delivery_Country;

        public string Billings_First_Name;
        public string Billings_Last_Name;
        public string Billings_Addres;
        public string Billings_City;
        public string Billings_Zip_Code;
        public string Billings_Country;
        public BillingProfile()
        {

        }

        public BillingProfile( string Name, string Email,string PhoneNumber, string CardHolder, string CardNumber,string Expiry_Month, int Expiry_Year,string CVV, string Delivery_First_Name,string Delivery_Last_Name, string Delivery_Addres, string Delivery_City, string Delivery_Zip_Code, string Delivery_Country, string Billings_First_Name, string Billings_Last_Name, string Billings_Addres, string Billings_City, string Billings_Zip_Code, string Billings_Country)
        { 
            this.Name = Name;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber.Replace("-", "");
            this.CardHolder = CardHolder;
            this.CardNumber = CardNumber;
            this.Expiry_Month = Expiry_Month;
            this.Expiry_Year = Expiry_Year;
            this.CVV = CVV;
            this.Delivery_First_Name = Delivery_First_Name;
            this.Delivery_Last_Name = Delivery_Last_Name;
            this.Delivery_Addres = Delivery_Addres;
            this.Delivery_City = Delivery_City;
            this.Delivery_Zip_Code = Delivery_Zip_Code;
            this.Delivery_Country = Delivery_Country;

            this.Billings_First_Name = Billings_First_Name;
            this.Billings_Last_Name = Billings_Last_Name;
            this.Billings_Addres = Billings_Addres;
            this.Billings_City = Billings_City;
            this.Billings_Zip_Code = Billings_Zip_Code;
            this.Billings_Country = Billings_Country;
        }
    }
}
