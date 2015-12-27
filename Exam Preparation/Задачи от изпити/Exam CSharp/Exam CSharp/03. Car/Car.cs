using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string line = "";
        int outerDot = n - 1;
        int innerDot = n;

        int length = n + ((n / 2) - 1);

        for (int row = 1; row <= length; row++)
        {
            if (row == 1)
            {
                line = new String('.', n) + new String('*', n) + new String('.', n);
            }
            else if (row >= 2 && row <= n / 2)
            {
                line = new String('.', outerDot) + "*" + new String('.', innerDot) + "*" + new String('.', outerDot);
                innerDot += 2;
                outerDot--;
            }
            else if (row == (n / 2) + 1)
            {
                line = new String('*', outerDot) + "*" + new String('.', innerDot) + "*" + new String('*', outerDot);
            }
            else if (row > (n / 2) + 1 && row < n)
            {
                line = "*" + new String('.', (n * 3) - 2) + "*";
            }
            else if (row == n)
            {
                line = new String('*', n * 3);
            }
            else if (row > n && row < length)
            {
                line = new String('.', n / 2) + "*" + new String('.', (n / 2) - 1) + "*" + new String('.', n - 2) + "*" + new String('.', (n / 2) - 1) + "*" + new String('.', n / 2);
            }
            else
            {
                line = new String('.', n / 2) + new String('*', (n / 2) + 1) + new String('.', n) + new String('*', (n / 2) + 1) + new String('.', n / 2);
            }
            Console.WriteLine(line);
        }
    }
}