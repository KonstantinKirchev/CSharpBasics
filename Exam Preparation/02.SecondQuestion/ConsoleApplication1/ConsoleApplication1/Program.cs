using System;

    class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int count = 0;
            for (int a = 5; a <= 9; a++)
            {
                for (int b = 5; b <= 9; b++)
                {
                    for (int c = 5; c <= 9; c++)
                    {
                        for (int d = 5; d <= 9; d++)
                        {
                            for (int e = 5; e <= 9; e++)
                            {
                                for (int f = 5; f <= 9; f++)
                                {
                                    for (int g = 5; g <= 9; g++)
                                    {
                                        for (int h = 5; h <= 9; h++)
                                        {
                                            for (int i = 5; i <= 9; i++)
                                            {
                                                if ((g * 100 + h * 10 + i) - (d * 100 + e * 10 + f) == diff && (d * 100 + e * 10 + f) - (a * 100 + b * 10 + c) == diff && a+b+c+d+e+f+g+h+i==sum)
                                                {
                                                    count++;
                                                 
                                                    Console.WriteLine(a*100000000+b*10000000+c*1000000+d*100000+e*10000+f*1000+g*100+h*10+i);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } 
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
            }
        }   
    }

