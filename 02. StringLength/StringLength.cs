using System;
using System.Text;
    class StringLength
    {
        static string AdjustString(string input)
        {
            int stringLength = input.Length;

            StringBuilder sb = new StringBuilder();

            if (stringLength > 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    sb.Append(input[i]);
                }
            }
            else if (stringLength < 20)
            {
                for (int i = 0; i < stringLength; i++)
                {
                    sb.Append(input[i]);
                }
                for (int i = sb.Length; i < 20; i++)
                {
                    sb.Append("*");
                }
             }
            else
            {
                sb.Append(input);
            }

            return sb.ToString();
        }

        static void Main()
        {
            string input = Console.ReadLine();

            string adjustedString = AdjustString(input);

            Console.WriteLine(adjustedString);
        }
    }
