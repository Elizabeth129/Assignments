using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    /**
     * Implement method that takes string as an input and 
     * returns its last character.
     * 
     * Example:
     *  GetLastCharacter("a") => 'a'
     *  GetLastCharacter("abcde") => 'e'
     *  GetLastCharacter("12345") => '5'
     */
    private static char GetLastCharacter(string input)
    {
        // WRITE YOUR CODE BELOW THIS LINE
        return input[input.Length - 1];
        // WRITE YOUR CODE ABOVE THIS LINE
    }

    public static void Main()
    {
        Test(GetLastCharacter("a"), 'a', "\"a\" last character");
        Test(GetLastCharacter("abcde"), 'e', "abcde last character");
        Test(GetLastCharacter("12345"), '5', "12345 last character");
    }

    private static void Test(char actual, char expected, string testName)
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
