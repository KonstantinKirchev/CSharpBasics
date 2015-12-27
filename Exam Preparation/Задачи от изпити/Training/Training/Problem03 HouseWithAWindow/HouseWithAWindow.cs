using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HouseWithAWindow
{
    static void Main()
    {

        // house with a window
        int input = int.Parse(Console.ReadLine());

        string top = new string('.', input - 1) + new string('*', 1) + new string('.', input - 1);
        string middle = new string('*', (input * 2) - 1);

        Console.WriteLine(top);
        //roof
        for (int i = 0, j = 1; i < input - 1; i++, j += 2)
        {
            Console.WriteLine(new string('.', (input - 2) - i) + new string('*', 1) + new string('.', j) + new string('*', 1) + new string('.', (input - 2) - i));
        }
        Console.WriteLine(middle);
        //floors
        for (int i = 0; i <= input; i++)
        {
            if (i == (input / 4)) //middle
            {
                for (int k = 0; k < input / 2; k++)
                {
                    Console.WriteLine(new string('*', 1) + new string('.', input / 2) + new string('*', input - 3) + new string('.', input / 2) + new string('*', 1));
                    i++;
                }
            }
            else
            {
                Console.WriteLine(new string('*', 1) + new string('.', (input * 2) - 3) + new string('*', 1));
            }
        }
        Console.WriteLine(middle);


    }
}