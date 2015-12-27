using System;

    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("Enter a number between 0 and 999: "); 
            int number = int.Parse(Console.ReadLine()); 
             while (number < 0 || number > 999) 
             { 
                 Console.WriteLine("Out of range"); 
                 Console.Write("Try again: "); 
                 number = int.Parse(Console.ReadLine()); 
             } 
             Console.Write("Your number is: "); 
             string[] zeroNine = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}; 
             string[] tenNineteen = new string[10] {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",  
                 "seventeen", "eighteen", "nineteen"}; 
             string[] lastZero = new string[10] {"zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"}; 
 
 
             string[] zeroNineUpper = new string[10] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }; 
             string[] tenNineteenUpper = new string[10] {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",  
                 "Seventeen", "Eighteen", "Nineteen"}; 
             string[] lastZeroUpper = new string[10] { "zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }; 
             if (number < 10) 
             { 
                 Console.WriteLine(zeroNineUpper[number]); 
             } 
             else if (number > 9 && number < 20) 
             { 
                 number = number % 10; 
                 Console.WriteLine(tenNineteenUpper[number]); 
             } 
             else if (number > 19  && number < 100) 
             { 
                 if (number % 10 == 0) 
                 { 
                     Console.WriteLine(lastZeroUpper[number/10]); 
                 } 
                 else 
                 { 
                     Console.WriteLine(lastZeroUpper[number / 10] + " " + zeroNine[number % 10]); 
                 } 
             } 
             else if (number > 99 && number < 1000) 
             { 
                 if (number % 100 == 0) 
                 { 
                     Console.WriteLine(zeroNineUpper[number / 100] + " hundred"); 
                 } 
                 else if (number - ((number / 100) * 100) < 20 && number - ((number / 100) * 100) > 9) 
                 { 
                     Console.WriteLine(zeroNineUpper[number / 100] + " hundred and " + tenNineteen[number % 10]); 
                 } 
                 else if (number - ((number / 100) * 100) < 10) 
                 { 
                     Console.WriteLine(zeroNineUpper[number / 100] + " hundred and " + zeroNine[number % 10]); 
                 } 
                 else if ((number - ((number / 100) * 100)) % 10 == 0) 
                 { 
                     Console.WriteLine(zeroNineUpper[number / 100] + " hundred and " + lastZero[(number / 10) % 10]); 
                 } 
 
 
                 else 
                 { 
                     Console.WriteLine(zeroNineUpper[number / 100] + " hundred and " + lastZero[(number / 10) % 10]+ " " + zeroNine[number % 10]); 
                 } 
             } 
         

            Main();
        }
    }

