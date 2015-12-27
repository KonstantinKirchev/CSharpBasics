using System;
class FruitMarket
{
    public static double GetPrice(string productName)
    {
        double price = 0;
        if (productName == "apple")
        {
            price = 0.86;
        }
        else if (productName == "banana")
        {
            price = 1.80;
        }
        else if (productName == "cucumber")
        {
            price = 2.75;
        }
        else if (productName == "orange")
        {
            price = 1.60;
        }
        else if (productName == "tomato")
        {
            price = 3.20;
        }
        return price;
    }
    static void Main()
    {
        // Fruit Market
        double currentSum = 0;
        string dayOfWeek = Console.ReadLine();
        switch (dayOfWeek)
        {
            case "Friday":
                for (int i = 0; i < 3; i++)
                {
                    double currentPrice = double.Parse(Console.ReadLine()) * GetPrice(Console.ReadLine());
                    currentSum += currentPrice;
                }
                currentSum *= 0.90; // 10% off all products
                break;

            case "Sunday":
                for (int i = 0; i < 3; i++)
                {
                    double currentPrice = double.Parse(Console.ReadLine()) * GetPrice(Console.ReadLine());
                    currentSum += currentPrice;
                }
                currentSum *= 0.95;  // 5% off all products
                break;

            case "Thursday":
                for (int i = 0; i < 3; i++)
                {
                    double quantity = double.Parse(Console.ReadLine());
                    string product = Console.ReadLine();
                    double currentPrice = 0;
                    if (product == "banana")
                    {
                        currentPrice = (quantity * GetPrice(product)) * 0.70; // 30% off bananas
                    }
                    else
                    {
                        currentPrice = quantity * GetPrice(product);
                    }
                    currentSum += currentPrice;
                }
                break;

            case "Tuesday":
                for (int i = 0; i < 3; i++)
                {
                    double quantity = double.Parse(Console.ReadLine());
                    string product = Console.ReadLine();
                    double currentPrice = 0;
                    if (product == "orange" || product == "apple" || product == "banana")
                    {
                        currentPrice = (quantity * GetPrice(product)) * 0.80; // 20% off fruits
                    }
                    else
                    {
                        currentPrice = quantity * GetPrice(product);
                    }
                    currentSum += currentPrice;
                }
                break;

            case "Wednesday":
                for (int i = 0; i < 3; i++)
                {
                    double quantity = double.Parse(Console.ReadLine());
                    string product = Console.ReadLine();
                    double currentPrice = 0;
                    if (product == "cucumber" || product == "tomato")
                    {
                        currentPrice = (quantity * GetPrice(product)) * 0.90; // 10% off vegetables
                    }
                    else
                    {
                        currentPrice = quantity * GetPrice(product);
                    }
                    currentSum += currentPrice;
                }
                break;

            default:
                for (int i = 0; i < 3; i++)
                {
                    double currentPrice = double.Parse(Console.ReadLine()) * GetPrice(Console.ReadLine());
                    currentSum += currentPrice;
                }
                break;
        }
        Console.WriteLine("{0:F2}", currentSum);
    }
}