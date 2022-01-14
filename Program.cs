using System;

namespace malden2023_data_encoding_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // char ch;
            // ch = 'A';
            // Console.WriteLine($"ch is storing the value: {ch}");

            // int ch_decimal;
            // ch_decimal = ch;
            // Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

            // int toConvert;
            // Console.Write("Enter an integer: ");
            // toConvert = int.Parse(Console.ReadLine());

            // char asChar;
            // asChar = (char)toConvert;
            // Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

            //char b;
            //b = (char)('A'+1);
            //b = (char)('F'-5);
            string b;
            string d = "";
            b = "Khoor#Zruog$";
            foreach (char ch in b)
            {
                d += (char)(ch - 3);
            }
            Console.WriteLine($"{d}");
            //Console.WriteLine($"'A' + 1 = '{b}'");

        }
    }
}
