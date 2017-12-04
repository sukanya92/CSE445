using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DllEncrypt
{
    public class Cryption
    {
        static byte[] seed = ASCIIEncoding.ASCII.GetBytes("cse44598");
        //A seed binary array for encryption
        public static string Encrypt(string plainString)  // encryption using DES
        {
            if (string.IsNullOrEmpty(plainString))
            {
                throw new ArgumentNullException("The input string for encryption cannont be empty or null");
            }
            SymmetricAlgorithm saProvider = DES.Create();  //Lib class
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, saProvider.CreateEncryptor(seed, seed), CryptoStreamMode.Write);
            StreamWriter sWriter = new StreamWriter(cStream);
            sWriter.Write(plainString);
            sWriter.Flush();  //flush the string terminator in sWrite
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.GetBuffer(), 0, (int)mStream.Length);
        }
        public static string Decrypt(string encryptedString)   // decryption using DES
        {
            if (string.IsNullOrEmpty(encryptedString))
            {
                throw new ArgumentNullException("The string for decryption cannot be empty or null");
            }
            SymmetricAlgorithm saProvider = DES.Create();
            MemoryStream memStream = new MemoryStream(Convert.FromBase64String(encryptedString));
            CryptoStream cStream = new CryptoStream(memStream, saProvider.CreateDecryptor(seed, seed), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cStream);
            return reader.ReadLine();
        }

    }

}














