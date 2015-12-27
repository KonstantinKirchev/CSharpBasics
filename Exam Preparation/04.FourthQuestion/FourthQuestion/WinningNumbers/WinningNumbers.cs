using System;

    class WinningNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += (input[i] - 'a' + 1);
            }
            int productLeft = 1;
            int productRight = 1;
            bool isTrue = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int h = 0; h < 10; h++)
                        {
                            for (int k = 0; k < 10; k++)
                            {
                                for (int g = 0; g < 10; g++)
                                {
                                    productLeft = i * j * l;
                                    productRight = h * k * g;
                                    if (productLeft == productRight && productLeft == sum && productRight == sum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",i,j,l,h,k,g);
                                        isTrue = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }

