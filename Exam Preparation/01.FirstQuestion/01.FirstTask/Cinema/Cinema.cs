using System;

    class Cinema
    {
        static void Main()
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double pricePremiere = 12.00;
            double priceNormal = 7.50;
            double priceDiscount = 5.00;
            if (typeOfProjection=="Premiere")
            {
                double income = pricePremiere * rows * columns;
                Console.WriteLine("{0:F2} leva", income);
            }
            else if (typeOfProjection == "Normal")
            {
                double income = priceNormal * rows * columns;
                Console.WriteLine("{0:F2} leva", income);
            }
            else if (typeOfProjection == "Discount")
            {
                double income = priceDiscount * rows * columns;
                Console.WriteLine("{0:F2} leva", income);
            }
        }
    }

