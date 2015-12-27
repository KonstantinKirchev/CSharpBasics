using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsForExam
{
    class Program
    {
        static void Main(string[] args)
        {
        I.
            string[] input = Console.ReadLine().ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string processedInput = string.Join("", input);
        II.
            int currentSum = numbers[index]; // инициализирам си текуща сума започваща от първото число в масива
            int maxSum = int.MinValue; // това го правя за да намеря максималната сума
            maxSum = Math.Max(maxSum, currentSum); // тук сравнявам двете суми и взимам по-голямата
       III.
           long currentSymbolCode = (long)processedInput[i]; // така си вземам стойността на всяка буква от ASCII таблицата
       IV.
           char[] letter = letters.ToCharArray(); // цепя стринга на отделни чарове и ги пъхам в масив от чарове
        V.
          for (int i = 4; i <= n; i++)
			{
				BigInteger tribNew = trib1 + trib2 + trib3;
				trib1 = trib2;
				trib2 = trib3;
				trib3 = tribNew;
			}
			Console.WriteLine(trib3);  // така се намира трибоначи (и съответно по подобен начин и фибоначи)
       VI.
           Console.WriteLine("No, diff={0}", Math.Max(sumEven, sumOdd) - Math.Min(sumEven, sumOdd)) // така намирам разликата между по-голямата и по-малката сума
      VII.
            string message = Console.ReadLine();
            string letters = message.ToUpper(); // обръщам всички букви да са главни
            char[] letter = letters.ToCharArray(); // разбивам думите на отделни букви
      VIII. - // Погледни задача OddEvenElements има много полезни неща в нея!!!
       IX.
       string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse); // така си вземам числата от стринг масива
        //int[] numbers = input.Select(int.Parse).ToArray(); // така също мога да си взема числата от стринг масива
        //int[] numbers = new int[input.Length]; // 3ти вариант за вземане на числата от стринг масива
        //for (int i = 0; i < input.Length; i++)
        //{
        //    numbers[i] = int.Parse(input[i]);                    
        //}         
        int maxMax = Int32.MinValue;
        List<int> three = new List<int>();
        for (int i = 0; i < numbers.Length; i += 3)
        {
            int maxSum = numbers.Skip(i).Take(3).Sum(); // взимам по 3 числа и ги сумирам

            if (maxSum > maxMax)
            {
                maxMax = maxSum;
                three = numbers.Skip(i).Take(3).ToList(); // трите числа с най-голяма сума ги слагам в лист
            }
        }
        three.ForEach(x => Console.Write(x + " ")); // а тук отпечатвам поставените в листа 3 числа
      X.      
            int cablesCount = totalLength / 504;
            int remainder = totalLength % 504; // така взимам остатъка
        }
    }
}
