using System;

    class TicTacToePower
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine()); // колона
            int y = int.Parse(Console.ReadLine()); // ред
            int initialValue = int.Parse(Console.ReadLine()); // стойността на първата клетка в матрицата
            int index = y * 3 + x + 1; // така намирам индекса под който стой всяко число в матрицата
            int trueValue = initialValue + index - 1; // така намирам стойността на съответният индекс
            Console.WriteLine((long)Math.Pow(trueValue,index)); // тук повдигам стойността на съответния индекс на индекса под който стой. Каствам към long защото числото е повдигнато на степен!!!
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int firstValue = int.Parse(Console.ReadLine());
            //long result = 0;
            //int position = x + 1;
            //if (y==1)
            //{
            //    position = x + 4;
            //}
            //if (y==2)
            //{
            //    position = x + 7;
            //}
            //firstValue += position - 1;
            //result = (long)Math.Pow(firstValue, position);
            //Console.WriteLine(result);
            //Main();
        }
       
    }

