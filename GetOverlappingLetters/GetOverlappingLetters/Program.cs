using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    /**
     * Given two strings, first and second. Find all letters (ignoring case)
     * which are present in both strings. Ignore whitespaces.
     */
    private static HashSet<char> GetOverlappingLetters(string first, string second)
    {
        // WRITE YOUR CODE BELOW THIS LINE
        var res = new HashSet<char>();
        first = first.ToLower();
        second = second.ToLower();
        int c;
        for (int i = 0; i < first.Length; i++)
        {
            c = second.IndexOf(first[i]);
            if (c > -1)
            {
                res.Add(first[i]);
            }
        }


        return res;
        // WRITE YOUR CODE ABOVE THIS LINE
    }

    public static void Main()
    {
        Test(GetOverlappingLetters("a", "b"), new HashSet<char>(), "empty overlap");
        Test(GetOverlappingLetters("aa", "a"), new HashSet<char>("a"), "duplicated string in overlap");
        Test(GetOverlappingLetters("A", "a"), new HashSet<char>("a"), "case insensitive overlap");
        Test(
            GetOverlappingLetters("Happy New Year", "nyhz"),
            new HashSet<char>("hyn"),
            "simple phrase");
    }

    private static void Test(HashSet<char> actual, HashSet<char> expected, String testName)
    {
        if (!expected.SetEquals(actual))
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
