﻿using System.Security.Cryptography;
using System.Text;

namespace Todo_LocalAuth_API_GUI.utility
{
    public class HashPassword
    {
        public static string PasswordHash(string password)
        {
            using (HashAlgorithm hash = SHA256.Create())
            {
                byte[] hashBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
