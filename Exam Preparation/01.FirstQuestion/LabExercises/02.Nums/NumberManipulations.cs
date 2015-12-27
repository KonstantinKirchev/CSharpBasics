using System;

    class NumberManipulations
    {
        static void Main()
        {
            //01.03. int number = int.Parse(Console.ReadLine());
            //double p = double.Parse(Console.ReadLine());
            //int firstDigit = number % 10;
            //int secondDigit = number % 1000;
            //int pDigit = 0;
            //Console.WriteLine(firstDigit);
            //Console.WriteLine(secondDigit);
            //03. int number = int.Parse(Console.ReadLine());
            //double p = double.Parse(Console.ReadLine());
            //int pDigid = (int)Math.Pow(10, p-1);
            //Console.WriteLine((number/pDigid)%10);
            //06. int number = int.Parse(Console.ReadLine());
            //for (int i = 0; number > 0; i++)
            //{
            //    Console.Write(number % 10);
            //    number /= 10;
            //}
            //Main();
            //04. int number = int.Parse(Console.ReadLine());
            //string output = ""+number % 10;
            //number /= 10; 
            //for (int i = 0; number > 0; i++)
            //{
            //    output =  number % 10 + "-" + output;
            //    number /= 10;
            //}
            //Console.WriteLine(output);
            //Main();
            //05. int number = int.Parse(Console.ReadLine());
            //int output = 0;
            //int count = 0;
            //for (int i = 0; number > 0; i++)
            //{
            //    output = number % 10;
            //    number /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);
            //Main();
            //06. int number = int.Parse(Console.ReadLine());
            //int output = 0;
            //int sum = 0;
            //for (int i = 0; number > 0; i++)
            //{
            //    output = number % 10;
            //    number /= 10;
            //    sum += output;
            //}
            //Console.WriteLine(sum);
            //Main();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; number > 0; i++)
            {
                Console.Write(number % 10 + "-");
                number /= 10;
            }
            
            Main();

        }
    }

