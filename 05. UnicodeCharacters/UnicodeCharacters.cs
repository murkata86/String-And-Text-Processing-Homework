using System;
using System.Text;
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)input[i]);
            }
            Console.WriteLine();
        }
    }
