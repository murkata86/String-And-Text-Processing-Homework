using System;
using System.Text;
    class TextFilter
    {
        static void ReplaceBannedWords(string text, string[] bannerdWords)
        {
            for (int i = 0; i < bannerdWords.Length; i++)
            {
                text = text.Replace(bannerdWords[i], new string('*', bannerdWords[i].Length));
            }

            Console.WriteLine(text);
        }

        static void Main()
        {
            string words = Console.ReadLine();
            string[] bannedWords = words.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string inputText = Console.ReadLine();

            ReplaceBannedWords(inputText, bannedWords);
        }
    }
