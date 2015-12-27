using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            string[] number = Console.ReadLine().Split(' ');
            int even_Product = 1;
            int odd_Product = 1;
            for (int i = 0; i < number.Length; i++)
            {
                int a = Convert.ToInt32(number[i]);
                if (i % 2 == 0)
                {
                    odd_Product *= a;
                }
                else
                {
                    even_Product *= a;
                }  
            }
            if (even_Product==odd_Product)
            {
                Console.WriteLine("yes\nproduct = {0}",even_Product);
            }
            else
            {
                Console.WriteLine("No\nodd_product = {0}\neven_product = {1}",odd_Product,even_Product);
            }

            Main(); 
        }
    }

