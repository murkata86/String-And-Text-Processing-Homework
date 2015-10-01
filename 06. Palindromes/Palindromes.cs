using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Palindromes
    {
        static void GetPalindromes(string[] text)
        {
            bool isPalindrome = true;
            List<string> palindromesList = new List<string>();

            foreach (var word in text)
            {
                int wordLength = word.Length;

                for (int i = 0; i < wordLength; i++)
                    {
                 
                        int minIndex = i;
                        int maxIndex = (wordLength - 1) - i;

                        if (word[minIndex] != word[maxIndex])
                        {
                            isPalindrome = false;
                            break;
                        }
                        else
                        {
                            isPalindrome = true;

                        }
                    }

                    if (isPalindrome)
                    {
                        palindromesList.Add(word);
                    } 
            }

            palindromesList.Sort();
            IEnumerable<string> sortedPalindromes = palindromesList.Distinct();

            Console.WriteLine(string.Join(", ", sortedPalindromes));
        }

        static void Main()
        {
            char[] separators = new char[] { ' ', ',', '.', '?', '!' };

            string input = Console.ReadLine();
            string[] entryString = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            GetPalindromes(entryString);
        }
    }