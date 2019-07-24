using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Playground
{
    /**
     * Implement method StringLength, which takes string as an argument 
     * and returns its length.
     * 
     * Example:
     *  reverse(null) => 0
     *  reverse("") => 0
     *  reverse("AAA") => 3
     */
    private static int StringLength(String input)
    {
        // WRITE YOUR CODE BELOW THIS LINE

        try
        {
            return input.Length;
        }
        catch (NullReferenceException)
        {
            return 0;
        }
        // WRITE YOUR CODE ABOVE THIS LINE
    }

    public static void Main(String[] args)
    {
        Test(StringLength(null), 0, "length of null");
        Test(StringLength(""), 0, "length of empty string");
        Test(StringLength("AAA"), 3, "length of AAA");
    }

    private static void Test(int actual, int expected, String testName)
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