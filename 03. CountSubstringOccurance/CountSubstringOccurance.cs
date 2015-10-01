using System;
using System.Text;
    class CountSubstringOccurance
    {
        static int GetSubstringCount(string text, string keyword)
        { 
            text = text.ToLower();
            keyword = keyword.ToLower();

            int count = 0;
            int substringPosition = text.IndexOf(keyword);

            while (substringPosition != -1)
            {
                count++;
                substringPosition = text.IndexOf(keyword, substringPosition + 1);

            }

            return count;
        }

        static void Main()
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter substring to search for");
            string keyword = Console.ReadLine();

            Console.WriteLine(GetSubstringCount(input, keyword));        
        }
    }
