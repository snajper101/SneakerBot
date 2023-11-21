using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBot.Api
{
    internal static class GenerateToken
    {
        internal static string Token()
        {
            if (Properties.Settings.Default.Token != "")
            {
                if (!IsValidToken(Properties.Settings.Default.Token))
                {
                    byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                    byte[] key = Guid.NewGuid().ToByteArray();
                    string token = Convert.ToBase64String(time.Concat(key).ToArray());
                    Properties.Settings.Default.Token = token;
                    Properties.Settings.Default.Save();
                    return token;
                }
                else
                {

                    return Properties.Settings.Default.Token;
                }
            }
            else
            {
                byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                byte[] key = Guid.NewGuid().ToByteArray();
                string token = Convert.ToBase64String(time.Concat(key).ToArray());
                Properties.Settings.Default.Token = token;
                Properties.Settings.Default.Save();
                return token;
            }
        }

        internal static bool IsValidToken(string token)
        {
            byte[] data = Convert.FromBase64String(token);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));

            if (when < DateTime.UtcNow.AddHours(-24))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static string getProccessorId()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

    }
}
