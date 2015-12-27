using System;

class Car
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', number)
                        + new string('*', number)
                        + new string('.', number));
        for (int i = 0; i < number / 2 - 1; i++)
        {
            Console.WriteLine(new string('.', (number - 1) - i)
                            + new string('*', 1)
                            + new string('.', number + 2 * i)
                            + new string('*', 1)
                            + new string('.', (number - 1) - i));
        }
        Console.WriteLine(new string('*', number / 2 + 1)
                        + new string('.', number * 2 - 2)
                        + new string('*', number / 2 + 1));
        for (int i = 0; i < (number - 4) / 2; i++)
        {
            Console.WriteLine(new string('*', 1)
                            + new string('.', number * 3 - 2)
                            + new string('*', 1));
        }
        Console.WriteLine(new string('*', number * 3));
        for (int i = 0; i < (number - 4) / 2; i++)
        {
            Console.WriteLine(new string('.', number / 2)
                        + new string('*', 1)
                        + new string('.', number / 2 - 1)
                        + new string('*', 1)
                        + new string('.', number - 2)
                        + new string('*', 1)
                        + new string('.', number / 2 - 1)
                        + new string('*', 1)
                        + new string('.', number / 2));
        }
        Console.WriteLine(new string('.', number / 2)
                        + new string('*', number / 2 + 1)
                        + new string('.', number - 2)
                        + new string('*', number / 2 + 1)
                        + new string('.', number / 2));
    }
}

//int n = int.Parse(Console.ReadLine());
//        string line = "";
//        int outerDot = n - 1;
//        int innerDot = n;

//        int length = n + ((n / 2) - 1);

//        for (int row = 1; row <= length; row++)
//        {
//            if (row == 1)
//            {
//                line = new String('.', n) + new String('*', n) + new String('.', n);
//            }
//            else if (row >= 2 && row <= n / 2)
//            {
//                line = new String('.', outerDot) + "*" + new String('.', innerDot) + "*" + new String('.', outerDot);
//                innerDot += 2;
//                outerDot--;
//            }
//            else if (row == (n / 2) + 1)
//            {
//                line = new String('*', outerDot) + "*" + new String('.', innerDot) + "*" + new String('*', outerDot);
//            }
//            else if (row > (n / 2) + 1 && row < n)
//            {
//                line = "*" + new String('.', (n * 3) - 2) + "*";
//            }
//            else if (row == n)
//            {
//                line = new String('*', n * 3);
//            }
//            else if (row > n && row < length)
//            {
//                line = new String('.', n / 2) + "*" + new String('.', (n / 2) - 1) + "*" + new String('.', n - 2) + "*" + new String('.', (n / 2) - 1) + "*" + new String('.', n / 2);
//            }
//            else
//            {
//                line = new String('.', n / 2) + new String('*', (n / 2) + 1) + new String('.', n) + new String('*', (n / 2) + 1) + new String('.', n / 2);
//            }
//            Console.WriteLine(line);
//        }


