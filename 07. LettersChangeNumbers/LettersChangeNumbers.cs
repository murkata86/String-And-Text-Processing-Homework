using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LettersChangeNumbers
{
    static int GetAlphabetIndex(char letter)
    {
        int index = 0;

        if (letter.ToString() == letter.ToString().ToLower())
        {
            return index = ((int)letter - (int)'a') + 1;
        }
        else
        {
            return index = ((int)letter - (int)'A') + 1;
        }
    }

    static decimal CalculateSum(string[] sequence)
    {

        decimal sequencesum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            string currentElement = sequence[i];

            decimal result = 0;
            char firstChar = currentElement[0];
            char secondChar = currentElement[currentElement.Length - 1];

            StringBuilder sb = new StringBuilder();

            for (int j = 1; j < currentElement.Length - 1; j++)
            {
                sb.Append(currentElement[j]);
            }

            decimal theNumber = decimal.Parse(sb.ToString());

            int firstCharIndex = GetAlphabetIndex(firstChar);
            int secondCharIndex = GetAlphabetIndex(secondChar);
        
            if (firstChar.ToString() == firstChar.ToString().ToLower())
            {
                result = firstCharIndex * theNumber;
            }
            else
            {
                result = theNumber / firstCharIndex;
            }
        
            if (secondChar.ToString() == secondChar.ToString().ToLower())
            {
                result += secondCharIndex;
            }
            else
            {
                result -= secondCharIndex;
            }
        
            sequencesum += result;
        
        }
        
        return sequencesum;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        string[] sequence = input.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        decimal totalSum = CalculateSum(sequence);

        Console.WriteLine("{0:F2}", totalSum);

		int count = 0;

		while (count <= 5)
		{
			Console.WriteLine("Test {0}", count);
			count++;
		}
    }
}
