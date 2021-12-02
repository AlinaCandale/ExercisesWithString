using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StringEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CleanTheText("Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.");
            //Console.WriteLine(AddAtTheEnd("abc"));
            //Console.WriteLine(AddAtTheEnd("string"));
            //ObfucateEmail("awesome@dotnet.com");
            //ReString("w3resource");
            //ReString("w3");
            //ReString("w");
            //ReplaceChar("restart");
            //SwapCharsIn2Strings("abc", "xyz");
            //CheckStringForNotAndPoor("The lyrics is not that poor!");
            //CheckStringForNotAndPoor("The lyrics is not good!");
            //GetLongestWord("The lyrics is not that poor!");
            //GetStringBeforeSpecifiedChar("https://www.siit.com/net-exercises", '-');
            //StringStartWith("awesome string", 'a');
            //SubstringOccurences("alabala portocala", "ala");
            //SwapCommaWithDot("32.054,23");
            //RemoveSpaces("   a  labala po r t o   cala ");
            //CheckIfPalindrome("alabala");
            //CheckIfPalindrome("alina");

        }


        //static void CleanTheText(string myString)
        //{
        //    char[] splitchar = { '^', '<', '>', '&', '+', '@', '%', '$', ' ', ',' };
        //    string[] word = myString.Split(splitchar);
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < word.Length; ++i)
        //    {
        //        if (word[i].Length != 0)
        //        {
        //            sb.Append(word[i]);
        //            sb.Append(" ");
        //        }
        //    }
        //    Console.WriteLine(sb);

        ////You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)
        //}


        //static string AddAtTheEnd(string myString)
        //{
        //    if (myString.Length >= 3)
        //    {
        //        if (myString.EndsWith("ing"))
        //        {
        //            myString += "ly";
        //        }
        //        else
        //        {
        //            myString += "ing";
        //        }
        //    }
        //    return myString;

        ////Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead.
        ////If the string length of the given string is less than 3, leave it unchanged.
        //}


        //static void ObfucateEmail(string myEmail)
        //{
        //    string maskedEmail = null;
        //    for (int i = 0; i < myEmail.IndexOf('@'); i++)
        //    {
        //        maskedEmail += "*";
        //    }
        //    maskedEmail += myEmail.Substring(myEmail.IndexOf('@'));
        //    Console.WriteLine(maskedEmail);

        //    //You have some text that contains your email address. And you want to hide that. You decide to censor your email: to replace all characters in it with asterisks ('*')
        //    //except the domain. Assume your email address will always be in format [username]@[domain]. You need to replace the username with asterisks of equal number of letters
        //    //and keep the domain unchanged. You will get as input the email address you need to obfuscate
        //}


        //static void ReString(string myString)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    if (myString.Length < 2)
        //    {
        //        Console.WriteLine("Empty String");
        //    }
        //    else if (myString.Length == 2)
        //    {
        //        Console.WriteLine(string.Concat(myString, myString));
        //    }
        //    else
        //    {
        //        sb.Append(myString[0]);
        //        sb.Append(myString[1]);
        //        sb.Append(myString[myString.Length - 2]);
        //        sb.Append(myString[myString.Length - 1]);
        //        Console.WriteLine(sb);
        //    }

        ////Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string.
        //}


        //static void ReplaceChar(string myString)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(myString[0]);
        //    myString = myString.Replace('r', '$');
        //    sb.Append(myString).Remove(1, 1);
        //    Console.WriteLine(sb);

        ////Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
        //}


        //static void SwapCharsIn2Strings(string myFirstString, string mySecondString)
        //{
        //    string result = myFirstString + " " + mySecondString;
        //    result = SwapCharacters(result, 0, myFirstString.Length + 1 );
        //    result = SwapCharacters(result, 1, myFirstString.Length + 2);
        //    Console.WriteLine(result);

        ////Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        //}

        //static string SwapCharacters(string value, int position1, int position2)
        //{
        //    char[] array = value.ToCharArray(); 
        //    char temp = array[position1]; 
        //    array[position1] = array[position2]; 
        //    array[position2] = temp; 
        //    return new string(array); 
        //}


        //static void CheckStringForNotAndPoor(string myString)
        //{
        //    if (myString.Contains("not") && myString.Contains("poor"))
        //    {
        //        if (myString.IndexOf("not") < myString.IndexOf("poor"))
        //        {
        //            myString = myString.Insert(myString.IndexOf("not"), "good").Remove(myString.IndexOf("not") + 4, myString.IndexOf("poor") - myString.IndexOf("not") + 4);
        //        }
        //    }
        //    Console.WriteLine(myString);

        //// Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'poor' follows the 'not', replace the whole 'not'...'poor'
        //// substring with 'good'. Return the resulting string.
        //}


        //static void GetLongestWord(string myString)
        //{
        //    string[] myStringArray = myString.Split(' ');
        //    int longestLength = myStringArray[0].Length;
        //    foreach (var word in myStringArray)
        //    {
        //        if (longestLength < word.Length)
        //        {
        //            longestLength = word.Length;
        //        }
        //    }
        //    Console.WriteLine(longestLength);

        //// Write a method that takes a list of words and returns the length of the longest one.
        //}


        //static void GetStringBeforeSpecifiedChar(string myString, char specified)
        //{
        //    myString = myString.Substring(0, myString.IndexOf(specified));
        //    Console.WriteLine(myString);

        //}
        ////Write a method to get the last part of a string before a specified character.


        //static void StringStartWith(string myString, char start)
        //{
        //    if (myString.StartsWith(start))
        //    {
        //        Console.WriteLine($"Yes, starts with {start}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"No, the string does not start with {start}");
        //    }

        ////Write a method to check whether a string starts with specified characters
        //}


        //static void SubstringOccurences(string myString, string substring)
        //{
        //    int count = Regex.Matches(myString, substring).Count;
        //    Console.WriteLine(count);

        ////Write a method to count occurrences of a substring in a string
        //}


        //static void SwapCommaWithDot(string myString)
        //{
        //    char[] charArray = myString.ToCharArray();
        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        if (charArray[i] == ',')
        //        {
        //            charArray[i] = '.';
        //        }
        //        else if (charArray[i] == '.')
        //        {
        //            charArray[i] = ',';
        //        }
        //    }

        //    Console.WriteLine(new string(charArray));

        ////Write a method to swap comma and dot in a string.
        //}


        //static void RemoveSpaces(string myString)
        //{
        //    Console.WriteLine(myString.Replace(" ", string.Empty));

        ////Write a method to remove spaces from a given string.
        //}


        //static void CheckIfPalindrome(string myString)
        //{
        //    Console.WriteLine(myString.SequenceEqual(myString.Reverse()));

        ////Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True
        //}

    }
}
