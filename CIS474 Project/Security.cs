using System;
using System.Text;
using System.Security.Cryptography;

namespace CIS474_Project
{
    internal class Security
    {
        public String Sha256(String data)
        {
            using (SHA256 sha = SHA256.Create())
            {
                //Compute the hash and slap that bad boy into an array of bytes
                byte[] byteArray = sha.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder hash = new StringBuilder();

                for (int i = 0; i < byteArray.Length; i++)
                { 
                    hash.Append(byteArray[i].ToString("x2"));
                }

                return hash.ToString();
            }
        }
    }
}
