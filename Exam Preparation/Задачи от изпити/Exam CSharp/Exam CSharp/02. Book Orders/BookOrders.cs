using System;

class BookOrders
{
    static void Main()
    {
        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
        //input
        int orders = int.Parse(Console.ReadLine());
        int allBooks = 0;
        decimal price = 0;

        for (int order = 0; order < orders; order++)
        {
            int packets = int.Parse(Console.ReadLine());
            int books = int.Parse(Console.ReadLine());
            decimal bookPrice = decimal.Parse(Console.ReadLine());

            //logic

            books *= packets;
            allBooks += books;

            decimal discount = 0.0m;
            if (packets >= 10 && packets <= 19)
            {
                discount = 0.05m;
            }
            else if (packets >= 20 && packets <= 29)
            {
                discount = 0.06m;
            }
            else if (packets >= 30 && packets <= 39)
            {
                discount = 0.07m;
            }
            else if (packets >= 40 && packets <= 49)
            {
                discount = 0.08m;
            }
            else if (packets >= 50 && packets <= 59)
            {
                discount = 0.09m;
            }
            else if (packets >= 60 && packets <= 69)
            {
                discount = 0.10m;
            }
            else if (packets >= 70 && packets <= 79)
            {
                discount = 0.11m;
            }
            else if (packets >= 80 && packets <= 89)
            {
                discount = 0.12m;
            }
            else if (packets >= 90 && packets <= 99)
            {
                discount = 0.13m;
            }
            else if (packets >= 100 && packets <= 109)
            {
                discount = 0.14m;
            }
            else if (packets >= 110)
            {
                discount = 0.15m;
            }

            price += (books * (bookPrice - (bookPrice * discount)));
        }
        //output
        Console.WriteLine(allBooks);
        Console.WriteLine("{0:F2}", price);
    }
}