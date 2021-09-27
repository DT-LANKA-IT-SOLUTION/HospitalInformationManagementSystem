using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Other
{
    class EncryptionLab
    {
        private const string mySecurityKey = "aPdRgUkX";
        public static string EncryptText(string plainText)
        {
            DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();

            byte[] myEncryptArray = Encoding.UTF8.GetBytes(plainText);

            byte[] myEncryptKay = Encoding.UTF8.GetBytes(mySecurityKey);

            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };

            MemoryStream mst = new MemoryStream();

            CryptoStream cst = new CryptoStream(mst, DESCSP.CreateEncryptor(myEncryptKay, IV), CryptoStreamMode.Write);

            cst.Write(myEncryptArray, 0, myEncryptArray.Length);

            cst.FlushFinalBlock();

            return Convert.ToBase64String(mst.ToArray());
        }

        public static string DecryptText(string encryptText)
        {
            DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();

            byte[] myDecryptArray = new byte[encryptText.Length];

            myDecryptArray = Convert.FromBase64String(encryptText);

            byte[] myEncryptKay = Encoding.UTF8.GetBytes(mySecurityKey);

            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };

            MemoryStream mst = new MemoryStream();

            CryptoStream cst = new CryptoStream(mst, DESCSP.CreateDecryptor(myEncryptKay, IV), CryptoStreamMode.Write);

            cst.Write(myDecryptArray, 0, myDecryptArray.Length);

            cst.FlushFinalBlock();

            return Encoding.UTF8.GetString(mst.ToArray());
        }
    }
}
