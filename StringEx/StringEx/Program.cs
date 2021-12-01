using System;
using System.Text;

namespace StringEx
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveAtIndex("misterios", 5);
            RemoveOddIndex("misterios");
            UpperAndLoweCase("Maria");
            ReverseString("alina");
            ReverseStringIfLenghtCondition("C# devine tot mai interesant");
            ReverseStringIfLenghtCondition("C#");
            UpperCaseIfCondition("MiRian invata C#");
            UpperCaseIfCondition("Mirian invata C#");
            RemoveNewline("This is a Test String.\n   This is a next line.\n'");
            FormatString("Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, " +
                "the formatted string should have maximum of 50 characters per line. In this case we will have 5 lines of text.");
            PercentageFormat();
            RemoveChars("alibaba si noua baba", "ba");
            ToLowercaseNchars("MIANa na na nala", 3);
            ChangeWord("this is real");
            SumOfDigitsInString("Alina are 12 programari a cate 10, 15 si 30 minute");

        }


        static void RemoveAtIndex(string myString, int n)
        {
            Console.WriteLine(myString.Remove(n, 1));

            // Write a method that to remove the nth index character from a nonempty string.
        }


        static void RemoveOddIndex(string myString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < myString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(myString[i]);
                }
            }
            Console.WriteLine(sb.ToString());

            //Write a method that to remove the characters which have odd index values of a given string.
        }


        static void UpperAndLoweCase(string myString)
        {
            Console.WriteLine($"Upper Case is: {myString.ToUpper()} and lower case is: {myString.ToLower()}");
            //Write a method that takes input from the user and displays that input back in upper and lower cases.
        }


        static void ReverseString(string myString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = myString.Length - 1; i >= 0; i--)
            {
                sb.Append(myString[i]);
            }
            Console.WriteLine(sb.ToString());

            //Write a method that reverses a string.
        }


        static void ReverseStringIfLenghtCondition(string myString)
        {
            if (myString.Length % 4 == 0)
            {
                ReverseString(myString);
            }
            else
            {
                Console.WriteLine("String's length is not a multiple of 4");
            }
            //Write a method that reverses a string if it's length is a multiple of 4
        }


        static void UpperCaseIfCondition(string myString)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (Char.IsUpper(myString[i]))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                Console.WriteLine(myString.ToUpper());
            }
            else
            {
                Console.WriteLine("Given string does not contains 2 uppercase characters in the first 4 characters");
            }
            //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
        }


        static void RemoveNewline(string myString)
        {
            Console.WriteLine(myString.Replace("\n", String.Empty));

            //Write a method that to remove a newline.
        }


        static void FormatString(string myString)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            for (i = 50; i < myString.Length; i += 50)
            {
                sb.Append(myString.Substring(i - 50, 50));
                sb.Append('\n');
            }
            sb.Append(myString.Substring(i - 50));
            Console.WriteLine(sb);
            //Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the formatted string
            //should have maximum of 50 characters per line. In this case we will have 3 lines of text.
        }


        static void PercentageFormat()
        {
            Console.WriteLine(String.Format("{0:P}", 0.8526));
            // Write a method that formats a number with a percentage
        }


        static void RemoveChars(string myString, string charsToRemove)
        {
            Console.WriteLine(myString.Replace(charsToRemove, String.Empty));

            //Write a method that strips a set of characters from a string.
        }


        static void ToLowercaseNchars(string myString, int nrOfChars)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(myString.Substring(0, nrOfChars).ToLower() + myString.Substring(nrOfChars));
            Console.WriteLine(sb);

            //Write a method that transforms to lowercase first n characters in a string
        }


        static string CapitalizeFirstandLastChar(string myWord)
        {
            int n = myWord.Length;
            if (n == 1)
            {
                return myWord.ToUpper();
            }
            if (n == 2)
            {
                return myWord.ToUpper();
            }
            return myWord.Substring(0, 1).ToUpper() + myWord.Substring(1, n - 2) + myWord.Substring(n - 1, 1).ToUpper();
        }


        static void ChangeWord(string myString)
        {
            string[] word = myString.Split(" ");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < word.Length; ++i)
            {
                sb.Append(CapitalizeFirstandLastChar(word[i]));
                sb.Append(" ");
            }
            Console.WriteLine(sb);
            //Write a method to capitalize first and last letters of each word of a given string.
        }


        static void SumOfDigitsInString(string myString)
        {
            int sum = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if (Char.IsDigit(myString[i]))
                {
                    sum += myString[i] - '0';
                }
            }
            Console.WriteLine(sum);
            //Write a method to compute sum of digits of a given string (if any).
        }
    }
}
