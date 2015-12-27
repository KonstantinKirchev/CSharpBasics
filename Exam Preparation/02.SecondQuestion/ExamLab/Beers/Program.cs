using System;

class Program
{
    static void Main()
    {


        string order = Console.ReadLine();
        uint totalBeers = 0;
        uint totalStacks = 0;
        while (order != "End")
        {
            string[] input = order.Split();
            uint count = uint.Parse(input[0]);
            string orders = input[1];
            
            switch (orders)
            {
                case "stacks":
                    totalStacks += count; 
                    break;
                case "beers":
                    totalBeers += count;
                    while (totalBeers >= 20)
                    {
                        totalStacks++;
                        totalBeers -= 20;
                    }
                    break;
            }
            order = Console.ReadLine();
            
            
        }
        Console.WriteLine("{0} stacks + {1} beers", totalStacks, totalBeers);
        
    }
}
		 
	
        


