using System;
using System.Text;
    class ReverseString
    {
        static string ReversingString(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string reversedString = ReversingString(input);

            Console.WriteLine(reversedString);  
			Console.WriteLine(); //Just playing with github			
        }
    }
