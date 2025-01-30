﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RPM_PR_23._106_Oshepkov_PR3_v2.Services
{
    internal class Hash
    {
        public static string HashPassword(string password)
        {
            using (SHA256 shs256Hash = SHA256.Create())
            {
                byte[] sourceBytePassword = Encoding.UTF8.GetBytes(password);
                byte[] hash = shs256Hash.ComputeHash(sourceBytePassword);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

    }
}
