using System;

namespace malden2023_data_encoding_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher;
            cipher = new Cipher(5);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encrypted message is: '{encrypted}'");
        }
        static void Secondary(string[] args)
        {
            string b;
            string d = "";
            b = "Khoor#Zruog$";
            foreach (char ch in b)
            {
                d += (char)(ch - 3);
            }
            Console.WriteLine($"{d}");
        }
    }
}
