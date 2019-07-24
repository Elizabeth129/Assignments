using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    /**
     * Implement method that takes array of ints and returns the 
     * smallest element of the array.
     * 
     * Example:
     *  FindSmallestElement([0]) => 0
     *  FindSmallestElement([1, 1, 1]) => 1
     *  FindSmallestElement([-1, -4, -3, -2]) => -4
     */
    private static int FindSmallestElement(int[] nums)
    {
        // WRITE YOUR CODE BELOW THIS LINE
        int min;
        try
        {
            min = nums[0];
        }
        catch (IndexOutOfRangeException)
        {
            return 0;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }
        return min;
        // WRITE YOUR CODE ABOVE THIS LINE
    }

    public static void Main()
    {
        Test(FindSmallestElement(new int[] { 0 }), 0, "arrayWithOneElement");
        Test(FindSmallestElement(new int[0]), 0, "emptyArray");
        Test(FindSmallestElement(new int[] { 1, 1, 1, 1 }), 1, "arrayWithSameElements");
        Test(FindSmallestElement(new int[] { 1, 2, 3, 4 }), 1, "arrayWithLargestElementInTheEnd");
        Test(FindSmallestElement(new int[] { 1, 4, 3, 2 }), 1, "arrayWithLargestElementInTheMiddle");
        Test(FindSmallestElement(new int[] { -1, -4, -3, -2 }), -4, "arrayWithNegativeElements");
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
