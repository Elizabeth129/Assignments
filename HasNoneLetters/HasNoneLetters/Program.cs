using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    /**
     * Return true if none the letters in the `blacklist`
     * are present in the `phrase`. If at least one letter from 
     * `blacklist` is present in the `phrase` return false;
     *
     * Comparison should be case insensitive. Meaning 'A' == 'a'.
     */
    private static bool HasNoneLetters(string blacklist, string phrase)
    {
        // WRITE YOUR CODE BELOW THIS LINE
        blacklist = blacklist.ToUpper();
        phrase = phrase.ToUpper();
        int c;
        for (int i = 0; i < phrase.Length; i++)
        {
            c = blacklist.IndexOf(phrase[i]);
            if (c > -1)
            {
                return false;
            }
        }
        return true;
        // WRITE YOUR CODE ABOVE THIS LINE
    }

    public static void Main()
    {
        Test(HasNoneLetters("abcdef", "fgh"), false, "one letter overlap");
        Test(HasNoneLetters("abcdef", "gh"), true, "contains none");
        Test(HasNoneLetters("ABCD", "def"), false, "pattern case insensitive overlap");
        Test(HasNoneLetters("abcd", "DEF"), false, "phrase case insensitive overlap");
    }

    private static void Test(bool actual, bool expected, string testName)
    {
        if (actual != expected)
        {
            string errorMessage = $"Test {testName} failed: {actual} is not equal to expected {expected}";
            Console.WriteLine("ERROR: " + errorMessage);
        }
        else
        {
            Console.WriteLine("SUCCESS: " + testName + " passed");
        }
    }
}
