using System;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        decimal totalPrice = 0m;
        decimal discount = 0m;
        switch (dayOfWeek)
        {
            case "Sunday":
                discount = 0.05m;
                break;
            case "Tuesday":
                discount = 0.2m;
                break;
            case "Wednesday":
                discount = 0.1m;
                break;
            case "Thursday":
                discount = 0.3m;
                break;
            case "Friday":
                discount = 0.1m;
                break;
            default:
                break;
        }
        decimal product1Price = 0m;
        switch (product1)
        {
            case "banana":
                product1Price = 1.80m;
                break;
            case "cucumber":
                product1Price = 2.75m;
                break;
            case "tomato":
                product1Price = 3.20m;
                break;
            case "orange":
                product1Price = 1.60m;
                break;
            case "apple":
                product1Price = 0.86m;
                break;
            default:
                break;
        }
        decimal product2Price = 0m;
        switch (product2)
        {
            case "banana":
                product2Price = 1.80m;
                break;
            case "cucumber":
                product2Price = 2.75m;
                break;
            case "tomato":
                product2Price = 3.20m;
                break;
            case "orange":
                product2Price = 1.60m;
                break;
            case "apple":
                product2Price = 0.86m;
                break;
            default:
                break;
        }
        decimal product3Price = 0m;
        switch (product3)
        {
            case "banana":
                product3Price = 1.80m;
                break;
            case "cucumber":
                product3Price = 2.75m;
                break;
            case "tomato":
                product3Price = 3.20m;
                break;
            case "orange":
                product3Price = 1.60m;
                break;
            case "apple":
                product3Price = 0.86m;
                break;
            default:
                break;
        }
        if (dayOfWeek == "Friday")
        {
            totalPrice = (1 - discount) * (quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price);
            Console.WriteLine("{0:F2}",totalPrice);
        }
        else if (dayOfWeek == "Sunday")
        {
            totalPrice = (1 - discount) * (quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price);
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (dayOfWeek == "Tuesday")
        {
            if (product1 == "banana" || product1 == "orange" || product1 == "apple")
            {
                product1Price = product1Price - (product1Price * discount);
            }
            if (product2 == "banana" || product2 == "orange" || product2 == "apple")
            {
                product2Price = product2Price - (product2Price * discount);
            }
            if (product3 == "banana" || product3 == "orange" || product3 == "apple")
            {
                product3Price = product3Price - (product3Price * discount);
            }
            totalPrice = quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price;
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (dayOfWeek == "Wednesday")
        {
            if (product1 == "tomato" || product1 == "cucumber")
            {
                product1Price = product1Price - (product1Price * discount);
            }
            if (product2 == "tomato" || product2 == "cucumber")
            {
                product2Price = product2Price - (product2Price * discount);
            }
            if (product3 == "tomato" || product3 == "cucumber")
            {
                product3Price = product3Price - (product3Price * discount);
            }
            totalPrice = quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price;
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (dayOfWeek == "Wednesday")
        {
            if (product1 == "tomato" || product1 == "cucumber")
            {
                product1Price = product1Price - (product1Price * discount);
            }
            if (product2 == "tomato" || product2 == "cucumber")
            {
                product2Price = product2Price - (product2Price * discount);
            }
            if (product3 == "tomato" || product3 == "cucumber")
            {
                product3Price = product3Price - (product3Price * discount);
            }
            totalPrice = quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price;
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (dayOfWeek == "Thursday")
        {
            if (product1 == "banana")
            {
                product1Price = product1Price - (product1Price * discount);
            }
            if (product2 == "banana")
            {
                product2Price = product2Price - (product2Price * discount);
            }
            if (product3 == "banana")
            {
                product3Price = product3Price - (product3Price * discount);
            }
            totalPrice = quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price;
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else
        {
            totalPrice = quantity1 * product1Price + quantity2 * product2Price + quantity3 * product3Price;
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
