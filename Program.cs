using System;

namespace malden2023_data_encoding_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            

    
            string filePath = args[0];
            // Console.WriteLine($"Loading '{filePath}'.");
            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: '{message}'");

            
            int shift;
            shift = 1;
            
            while (shift <=10)
            {
            Cipher cipher;
            cipher = new Cipher(shift);
            string final;
            final = cipher.Decrypt(message);
            Console.WriteLine($"Shift {shift}: {final}");
            shift = shift + 1;
            }

            
        }
    }
}
