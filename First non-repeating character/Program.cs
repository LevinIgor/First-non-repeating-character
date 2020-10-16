using System;
using System.Linq;

namespace First_non_repeating_character
{
    /*
     Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

    For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

    As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter.

    For example, the input 'sTreSS' should return 'T'.

    If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.
     */
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write("Enter string - ");
                Console.WriteLine( Kata.FirstNonRepeatingLetter(Console.ReadLine()));
            }

        }
    }

    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            int count=0;

            for (int i = 0; i < s.Length; i++)
            {
                count = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i].ToString().ToLower()==s[j].ToString().ToLower())
                    {
                        count++;                     
                    }
                    
                }

                if (count == 1)
                {
                    return s[i].ToString();
                }

            }
            return "";
           
            
        }
    }
    public class Kata2
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            return s.GroupBy(char.ToLower)
                    .Where(gr => gr.Count() == 1)
                    .Select(x => x.First().ToString())
                    .DefaultIfEmpty("")
                    .First();
        }
    }

    public class Kata3
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            var ret = s.GroupBy(z => char.ToLower(z)).Where(g => g.Count() == 1).FirstOrDefault();
            return (ret != null) ? ret.First().ToString() : string.Empty;
        }
    }
}
