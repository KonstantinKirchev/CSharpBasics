using System;
using System.Text;
using System.Linq;

class ChangeEvenBits
{
    static void Main()
    {     
         int numberOfInputs = int.Parse(Console.ReadLine()); 
         int biggestNumber = Int32.MinValue; // Търся най-голямото число тъй като после ще вървя само по четните битове на числото и те ще се припокриват с по малкото число
         for (int i = 0; i < numberOfInputs; i++) 
         { 
             int number = int.Parse(Console.ReadLine()); 
             biggestNumber = Math.Max(number, biggestNumber); // Така намирам най-голямото число
         } 
         ulong numberToChange = ulong.Parse(Console.ReadLine()); 
         int bitsToChange = getBitsCount(biggestNumber);  // Тук си викам метода който ми отброява битовете
         if (numberOfInputs == 0) // Според мен няма нужда от тази проверка???
         { 
             bitsToChange = 0; 
         }         
         int bitsChanged = 0; // Правя си нова променлива за да отброя сменените битове (броят се само битовете сменени от 0 в 1)
         for (int j = 0; j < bitsToChange; j++) 
         { 
             int currentBit = (int)((numberToChange >> j * 2) & 1); // Така всеки четен бит го проверявам дали е 0 или 1             
             if (currentBit == 0) // ако е 0 влизам в if-a
             { 
                 bitsChanged++;  // така отброявам сменените битове
                 ulong one = 1u; // от това няма смисъл
                 ulong mask = one << j * 2; // така отивам до бита за смяна
                 numberToChange = numberToChange | mask; // така го сменям от 0 на 1
             } 
         } 
         Console.WriteLine(numberToChange); 
         Console.WriteLine(bitsChanged);
     } 
     public static int getBitsCount(int number) 
     { 
         int count = 0;        
 

         while (number > 0) 
         { 
             count++; 
             number = number >> 1; 
         } 
 

         return Math.Max(1, count); 
     } 
 } 


        //I.Вариант за вземане на най-голямо число!!!

        //int count = int.Parse(Console.ReadLine());
        //int[] numbers = new int[count];
        //int countBits = 0;
        //for (int i = 0; i < count; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        //int numberToBeProcessed = int.Parse(Console.ReadLine());
        //int maxNumber = numbers.Max(); // Така си вземам най-голямото число.Трябва да активирам System.Linq!!!


    //    int helperNumbersCount = int.Parse(Console.ReadLine());
    //    int maxHelperNumber = int.MinValue;
    //    for (int i = 0; i < helperNumbersCount; i++)
    //    {
    //        int number = int.Parse(Console.ReadLine());
    //        if (number > maxHelperNumber)
    //        {
    //            maxHelperNumber = number;
    //        }
    //    }
    //    long numberToProcess = long.Parse(Console.ReadLine());
    //    StringBuilder numberAsString = new StringBuilder();
    //    numberAsString.Append(Convert.ToString(numberToProcess, 2));
    //    if (maxHelperNumber == int.MinValue)
    //    {
    //        Console.WriteLine(numberToProcess);
    //        Console.WriteLine(0);
    //        return;
    //    }

    //    string maxHelperNumberAsString = Convert.ToString(maxHelperNumber, 2);
    //    int maxBitCount = maxHelperNumberAsString.Length;

    //    int changedBits = 0;
    //    for (int position = 0; position < maxBitCount * 2; position += 2)
    //    {
    //        if (numberAsString[position] == '0')
    //        {
    //            numberAsString[position] = '1';
    //            changedBits++;
    //        }
    //    }

    //    Console.WriteLine(Convert.ToInt64(numberAsString.ToString(), 2));
    //    Console.WriteLine(changedBits);
    //}

//    static ulong GetBitAtPosition(ulong number, int position)
//    {
//        ulong nRightP = number >> position;
//        ulong bit = nRightP & 1;
//        return bit;
//    }

//    static ulong SetBitToZero(ulong number, int position)
//    {
//        ulong mask = (ulong)(~(1 << position));
//        ulong result = number & mask;
//        return result;
//    }

//    static ulong SetBitToOne(ulong number, int position)
//    {
//        ulong mask = (ulong)(1 << position);
//        ulong result = number | mask;
//        return result;
//    }
//}







