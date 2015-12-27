using System;

    class TelerikLogo
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());

            int width = (X + X) + ((X / 2) + 1) + (( X / 2) + 1) -3;//ширината я получавам като 2*Z и 2*Y - 3те точки при ъглите между XYZ
            int hornslength = X / 2;
            int middleDots = width - 2 * (X / 2 + 1);

            Console.Write(new string('.', hornslength));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.WriteLine(new string('.', hornslength));

            middleDots -= 2;

            int firstHornDots = (X / 2) - 1;
            int dotsAfterHorn = 0;

            for (int i = 1; i < X - 1; i++)
            {
                if (i <= X / 2)
                {
                    Console.Write(new string('.',firstHornDots));
                    Console.Write("*");
                    Console.Write(new string('.', dotsAfterHorn));
                    
                }
                else
                {
                    Console.Write(new string('.', hornslength));
                }
                // add real horns
                
                
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', i));
                middleDots -= 2;
                // add real horns
                if (i <= X / 2)
                {
                    Console.Write(new string('.', dotsAfterHorn));
                    Console.Write("*");
                    Console.Write(new string('.', firstHornDots));
                    firstHornDots--;
                    dotsAfterHorn++;
                }
                else
                {
                    Console.Write(new string('.', hornslength));
                }
                
                Console.WriteLine();
            }
            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.Write(new string('.', width / 2));
            Console.WriteLine();

            int leftRightDots = X - 2;
            middleDots = 1;
            for (int i = 0; i < X - 1; i++)
            {
                Console.Write(new string('.', hornslength));
                Console.Write(new string('.', leftRightDots));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', leftRightDots));
                Console.Write(new string('.', hornslength));
                leftRightDots --;
                middleDots +=2;
                Console.WriteLine();
            }
            middleDots -= 4;
            for (int i = 1; i < X - 1; i++)
            {
                 Console.Write(new string('.', hornslength));
                 Console.Write(new string('.', i));
                 Console.Write("*");
                 Console.Write(new string('.', middleDots));
                 Console.Write("*");
                 Console.Write(new string('.', i));
                 Console.Write(new string('.', hornslength));
                 middleDots -= 2;
                 Console.WriteLine();
            }
            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.Write(new string('.', width / 2));
            Console.WriteLine();
            Main();
    }
}
   

