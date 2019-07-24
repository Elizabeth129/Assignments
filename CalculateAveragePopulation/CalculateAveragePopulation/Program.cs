using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    /**
     * Given a map of countries and their population calcualte 
     * average population in the country.
     * 
     * Example:
     *  findSmallestElement([0]) => 0
     *  findSmallestElement([1, 1, 1]) => 1
     *  findSmallestElement([-1, -4, -3, -2]) => -4
     */
    private static int CalculateAveragePopulation(Dictionary<string, int> population)
    {
        // WRITE YOUR CODE BELOW THIS LINE
        int average = 0, i = 0;
        try
        {
            foreach (KeyValuePair<string, int> keyValue in population)
            {
                average += keyValue.Value;
                i++;
            }
            return average / i;
        }
        catch (DivideByZeroException)
        {
            return 0;
        }
        // WRITE YOUR CODE ABOVE THIS LINE
    }

    public static void Main()
    {
        Test(CalculateAveragePopulation(new Dictionary<string, int>() { { "Ukraine", 42000000 } }), 42000000, "singleCountry");
        Test(CalculateAveragePopulation(new Dictionary<string, int>()), 0, "emptyArray");
        Test(CalculateAveragePopulation(
            new Dictionary<string, int>()
            {
                {"Ukraine", 42000000},
                {"Belarus", 9500000},
                {"Moldova", 3500000},
                {"Switzerland", 8400000}
            }),
            15850000,
            "multipleCountries"
        );

    }

    private static void Test(int actual, int expected, string testName)
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
