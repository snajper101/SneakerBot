using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System.IO;
using OpenQA.Selenium.Interactions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Drawing;

namespace SneakerBot
{
    internal static class API
    {
        internal static string language = "pl";

        internal static List<string> nike_avaible_models = new List<string>();
        internal static List<string> yeezy_supply_models = new List<string>();

        public static string ImageToString(Image image)
        {
            if (image == null)
                return String.Empty;

            var stream = new MemoryStream();
            image.Save(stream, image.RawFormat);
            var bytes = stream.ToArray();

            return Convert.ToBase64String(bytes);
        }

        private static Random random = new Random();
        public static string RandomLicence(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstwxyz0123456789!#$%*()+=-";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GetLast(this string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
        public static Image StringToImage(string base64String)
        {
            if (String.IsNullOrWhiteSpace(base64String))
                return null;
            var bytes = Convert.FromBase64String(base64String);
            var stream = new MemoryStream(bytes);
            return Image.FromStream(stream);
        }


        public static string Encrypt(string text, string hash)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }

        }
        public static string Decrypt(string text,string hash)
        {
            if (text != null)
            {
                byte[] data = Convert.FromBase64String(text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            else
            {
                return "";
            }
        }

        public static void Wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public static void Remove_ChromeDriver()
        {
            Process[] processes = Process.GetProcessesByName("chromedriver");

            foreach (Process process in processes)
            {
                try
                {
                    process.Kill();
                    process.Close();
                    process.CloseMainWindow();
                }
                catch
                {

                }
            }
        }

        internal static void Login(string Email, string Password, IWebDriver driver)
        {
            IWebElement email = driver.FindElement(By.XPath("//input[@name='emailAddress']"));
            email.SendKeys(Email);

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys(Password);
        }

        internal static byte[] downloadData(string url)
        {
            byte[] downloadedData;
            downloadedData = new byte[0];
            try
            {

                WebRequest req = WebRequest.Create(url);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();

                byte[] buffer = new byte[1024];

                int dataLength = (int)response.ContentLength;

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                while (true)
                {
                    //Try to read the data
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        memStream.Write(buffer, 0, bytesRead);
                    }
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                stream.Close();
                memStream.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return downloadedData;
        }

        public enum Websites
        {
            Nike,
            Supreme,
        };

        public static bool containsDigit(String s)
        {
            bool containsDigit = false;

            if (s != null)
            {
                foreach(char c in s.ToCharArray())
                {
                    if (containsDigit = Char.IsDigit(c))
                    {
                        break;
                    }
                }
            }

            return containsDigit;
        }
    }
}
