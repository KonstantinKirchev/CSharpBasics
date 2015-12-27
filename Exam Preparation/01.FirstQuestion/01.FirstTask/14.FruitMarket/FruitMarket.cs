using System;
using System.Collections.Generic;

class FruitMarket
{
    static void Main()
    {
        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"banana", 1.8},
            {"cucumber", 2.75},
            {"tomato", 3.2},
            {"orange", 1.6},
            {"apple", 0.86}
        };

        string dayOfWeek = Console.ReadLine();
        double quantity1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        switch (dayOfWeek)
        {
            case "Friday":
                products["banana"] -= 10.0 / 100 * products["banana"];
                products["cucumber"] -= 10.0 / 100 * products["cucumber"];
                products["tomato"] -= 10.0 / 100 * products["tomato"];
                products["orange"] -= 10.0 / 100 * products["orange"];
                products["apple"] -= 10.0 / 100 * products["apple"];
                break;
            case "Sunday":
                products["banana"] -= 5.0 / 100 * products["banana"];
                products["cucumber"] -= 5.0 / 100 * products["cucumber"];
                products["tomato"] -= 5.0 / 100 * products["tomato"];
                products["orange"] -= 5.0 / 100 * products["orange"];
                products["apple"] -= 5.0 / 100 * products["apple"];
                break;
            case "Tuesday":
                products["banana"] -= 20.0 / 100 * products["banana"];
                products["orange"] -= 20.0 / 100 * products["orange"];
                products["apple"] -= 20.0 / 100 * products["apple"];
                break;
            case "Wednesday":
                products["cucumber"] -= 10.0 / 100 * products["cucumber"];
                products["tomato"] -= 10.0 / 100 * products["tomato"];
                break;
            case "Thursday":
                products["banana"] -= 30.0 / 100 * products["banana"];
                break;
        }
        double total = quantity1 * products[product1] + quantity2 * products[product2] + quantity3 * products[product3];
        Console.WriteLine("{0:F2}",total);


        //string dayOfWeek = Console.ReadLine();
        //decimal quantity1 = decimal.Parse(Console.ReadLine());
        //string product1 = Console.ReadLine();
        //decimal quantity2 = decimal.Parse(Console.ReadLine());
        //string product2 = Console.ReadLine();
        //decimal quantity3 = decimal.Parse(Console.ReadLine());
        //string product3 = Console.ReadLine();

        //decimal totalPrice =
        //    quantity1 * GetPrice(product1, dayOfWeek) +
        //    quantity2 * GetPrice(product2, dayOfWeek) +
        //    quantity3 * GetPrice(product3, dayOfWeek);
        //Console.WriteLine("{0:f2}", totalPrice);
    }

    static decimal GetPrice(string productName, string dayOfWeek)
    {
        // Assign standard price and check for fruit
        decimal price = 0;
        bool isFruit = false;
        switch (productName)
        {
            case "banana": price = 1.80m; isFruit = true; break;
            case "cucumber": price = 2.75m; break;
            case "tomato": price = 3.20m; break;
            case "orange": price = 1.60m; isFruit = true; break;
            case "apple": price = 0.86m; isFruit = true; break;
        }

        // Apply the daily discounts
        switch (dayOfWeek)
        {
            case "Friday":
                price = price * 0.90m;
                break;
            case "Sunday":
                price = price * 0.95m;
                break;
            case "Tuesday":
                if (isFruit)
                    price = price * 0.80m;
                break;
            case "Wednesday":
                if (!isFruit)
                    price = price * 0.90m;
                break;
            case "Thursday":
                if (productName == "banana")
                    price = price * 0.70m;
                break;
        }

        return price;
    }
}

            
        
    

