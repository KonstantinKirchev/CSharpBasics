using System;

class DoubleDowns
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Hello World.");

        int rightCount = 0;
        int leftCount = 0;
        int mid = 0;
        for (int i = 0; i < n-1; i++)
        {
            int num1 = nums[i];
            int num2 = nums[i + 1];
            mid += CountOnes(num1 & num2);
            leftCount += CountOnes((num1 << 1) & num2);
            rightCount += CountOnes((num1 >> 1) & num2);
        }
        Console.WriteLine(rightCount);
        Console.WriteLine(leftCount);
        Console.WriteLine(mid);
    }
    static int CountOnes(int number)
    {
        int result = 0;
       while (number != 0)
        {
            number &= (number - 1);
            /*
             * In this way we working at binary notation. When use '-' at binary notation we extracting ones. 
             * Example: 5 - 1 = 4 in binary is like this:
             *   0101 | Then we using bitwise operator '&' to remove ones thats not need anymore.
             * - 0001 | If you don't use '&' your while never stop becouse you have only one operation.
             * -------| At the example we have 5 so number will be equal to 4 and 4 != 0 and will never be equal with zero.
             *   0100 | Be carefully when working with bitwise operations. When we use '&' we changing value of number integer.
             *   Use workbook and work with binary notation to get more experience
             */
            result++;
        }
        return result;
    }
}