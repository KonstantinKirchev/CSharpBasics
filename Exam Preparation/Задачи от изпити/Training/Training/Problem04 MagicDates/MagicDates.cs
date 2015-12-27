using System;

class MagicDates
{
    static void Main()  
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int target = int.Parse(Console.ReadLine());

        DateTime begin = new DateTime(startYear, 01, 01);
        DateTime end = new DateTime(endYear, 12, 31);
        int resultsCount = 0;
        for (DateTime currentDate = begin; currentDate <= end; currentDate = currentDate.AddDays(1))
        {
            int dayDigitOne = (currentDate.Day / 10) % 10;
            int dayDigitTwo = (currentDate.Day / 1) % 10;
            int monthDigitOne = (currentDate.Month / 10) % 10;
            int monthDigitTwo = (currentDate.Month / 1) % 10;
            int yearDigitOne = (currentDate.Year / 1000) % 10;
            int yearDigitTwo = (currentDate.Year / 100) % 10;
            int yearDigitThree = (currentDate.Year / 10) % 10;
            int yearDigitFour = (currentDate.Year / 1) % 10;

            int[] date = new int[8] { dayDigitOne, dayDigitTwo, monthDigitOne, monthDigitTwo, yearDigitOne, yearDigitTwo, yearDigitThree, yearDigitFour };
            int firstProduct = 0, secondProduct = 0, thirdProduct = 0, fourthProduct = 0, fifthProduct = 0, sixthProduct = 0, seventhProduct = 0;
            firstProduct = date[0] * date[1] + date[0] * date[2] + date[0] * date[3] + date[0] * date[4] + date[0] * date[5] + date[0] * date[6] + date[0] * date[7];
            secondProduct = date[1] * date[2] + date[1] * date[3] + date[1] * date[4] + date[1] * date[5] + date[1] * date[6] + date[1] * date[7];
            thirdProduct = date[2] * date[3] + date[2] * date[4] + date[2] * date[5] + date[2] * date[6] + date[2] * date[7];
            fourthProduct = date[3] * date[4] + date[3] * date[5] + date[3] * date[6] + date[3] * date[7];
            fifthProduct = date[4] * date[5] + date[4] * date[6] + date[4] * date[7];
            sixthProduct = date[5] * date[6] + date[5] * date[7];
            seventhProduct = date[6] * date[7];

            int sumOfProducts = firstProduct + secondProduct + thirdProduct + fourthProduct + fifthProduct + sixthProduct + seventhProduct;
            if (sumOfProducts == target)
            {
                Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", date[0], date[1], date[2], date[3], date[4], date[5], date[6], date[7]);
                resultsCount++;
            }
        }
        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}