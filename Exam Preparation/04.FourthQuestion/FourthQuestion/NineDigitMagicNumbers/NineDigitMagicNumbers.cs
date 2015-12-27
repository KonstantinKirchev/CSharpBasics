using System;

    class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool isTrue = false;
            for (int a = 1; a <= 7; a++)
            {
                for (int b = 1; b <= 7; b++)
                {
                    for (int c = 1; c <= 7; c++)
                    {
                        for (int d = 1; d <= 7; d++)
                        {
                            for (int e = 1; e <= 7; e++)
                            {
                                for (int f = 1; f <= 7; f++)
                                {
                                    for (int g = 1; g <= 7; g++)
                                    {
                                        for (int h = 1; h <= 7; h++)
                                        {
                                            for (int i = 1; i <= 7; i++)
                                            {
                                                if ((g*100 + h*10 + i) - (d*100 + e*10 + f) == diff 
                                                    && (d*100 + e*10 + f) - (a*100 + b*10 + c) == diff
                                                    && a + b + c + d + e + f + g + h + i == sum)
                                                {
                                                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}",a,b,c,d,e,f,g,h,i);
                                                    isTrue = true;
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
            if (isTrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }

