using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', n)
                        + new string('*', 1)
                        + new string('.', n));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', n - 1 - i)
                            + new string('*', 1)
                            + new string('.', 1 + (2 * i))
                            + new string('*', 1)
                            + new string('.', n - 1 - i));
        }
        Console.WriteLine(new string('*', n / 2 + 1)
                        + new string('.', n - 1)
                        + new string('*', n / 2 + 1));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', 1 + i)
                            + new string('*', 1)
                            + new string('.', ((n * 2) - 3) - (2 * i))
                            + new string('*', 1)
                            + new string('.', 1 + i));

        }
        Console.WriteLine(new string('.', n / 2)
                        + new string('*', 1)
                        + new string('.', n / 2 - 1)
                        + new string('*', 1)
                        + new string('.', n / 2 - 1)
                        + new string('*', 1)
                        + new string('.', n / 2));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', n / 2 - 1 - i)
                            + new string('*', 1)
                            + new string('.', n / 2 - 1)
                            + new string('*', 1)
                            + new string('.', 1 + (2 * i))
                            + new string('*', 1)
                            + new string('.', n / 2 - 1)
                            + new string('*', 1)
                            + new string('.', n / 2 - 1 - i));
        }
        Console.WriteLine(new string('*', n / 2 + 1)
        + new string('.', n - 1)
        + new string('*', n / 2 + 1));
        

        //int n = int.Parse(Console.ReadLine());

        //int length = (n / 2) + (n - 1) + 2;
        //string line = "";
        //int outerDot = n;
        //int innerDot = 1;
        //int count = 1;
        //for (int row = 1; row <= length; row++)
        //{
        //    if (row == 1)
        //    {
        //        line = new String('.', outerDot) + "*" + new String('.', outerDot);
        //        outerDot--;
        //    }
        //    else if (row > 1 && row <= n / 2)
        //    {
        //        line = new String('.', outerDot) + "*" + new String('.', innerDot) + "*" + new String('.', outerDot);
        //        outerDot--;
        //        innerDot += 2;
        //    }
        //    else if (row == (n / 2) + 1 || row == length)
        //    {
        //        line = new String('*', (n / 2) + 1) + new String('.', n - 1) + new String('*', (n / 2) + 1);
        //        outerDot = 1;
        //        innerDot += (((n / 2) - 1) * 2);
        //    }
        //    else if (row > (n / 2) + 1 && row <= n)
        //    {
        //        line = new String('.', outerDot) + "*" + new String('.', innerDot) + "*" + new String('.', outerDot);
        //        outerDot++;
        //        innerDot -= 2;
        //    }
        //    else if (row == n + 1)
        //    {
        //        innerDot = n / 2 - 1;
        //        line = new String('.', outerDot) + "*" + new String('.', innerDot) + "*" + new String('.', innerDot) + "*" + new String('.', outerDot);
        //        outerDot--;
        //    }
        //    else if (row > n + 1 && row < length)
        //    {
        //        line = new String('.', outerDot) + "*" + new String('.', innerDot) + "*" + new String('.', count) + "*" + new String('.', innerDot) + "*" + new String('.', outerDot);
        //        count += 2;
        //        outerDot--;
        //    }
        //    else
        //    {
        //        break;
        //    }
        //    Console.WriteLine(line);
        }
    }




