using System;

    class XBits
    {
        static void Main()
        {
            //string[] numbers = new string[8];
            //int counter = 0;
            //for (int i = 0; i < 8; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    numbers[i] = Convert.ToString(num, 2).PadLeft(32, '0');
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 30; j++)
            //    {
            //        if (numbers[i].Substring(j, 3) == "101" && numbers[i + 1].Substring(j, 3) == "010" && numbers[i + 2].Substring(j, 3) == "101")
            //        {
            //            counter++;
            //        }
            //    }
            //}
            //Console.WriteLine(counter);
            int[] numbers = new int[8]; // инициализирам си масив с 8 елемента, защото на входа ми подават винаги 8 числа
            int counter = 0; // Този каунтър ми трябва за да отброява в цикъла колко броя хиксове е намерила програмата
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); // С този цикъл си пълня масива с 8 числа
            }
            for (int row = 0; row < 6; row++) // цикъла ми върти до 6 а не до 8 реда тъй като при всяка итерация вземам по 3 реда.
            {
                int mask = 7;
                for (int col = 0; col < 30; col++) // този цикъл ми обхожда всичките 32 бита, но тъй като всеки път проверявам 3 поредни бита цикъла върти 30 пъти
                {
                    int firstRow = (numbers[row] >> col) & mask;
                    int secondRow = (numbers[row + 1] >> col) & mask;
                    int thirdRow = (numbers[row + 2] >> col) & mask;
                    if (firstRow == 5 && secondRow == 2 && thirdRow == 5) // това са съответно 101/010/101
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

   
//        //input
//        int countX = 0;
//        int num1 = 0;
//        int num2 = 0;
//        int num3 = 0;

//        for (int i = 0; i < 6; i++)
//        {
//            if (i == 0)
//            {
//                num1 = int.Parse(Console.ReadLine());
//                num2 = int.Parse(Console.ReadLine());
//                num3 = int.Parse(Console.ReadLine());
//            }
//            else
//            {
//                num1 = num2;
//                num2 = num3;
//                num3 = int.Parse(Console.ReadLine());
//            }
//            //logic
//            for (int bitPos = 0; bitPos < 32; bitPos++)
//            {
//                bool top = ((num1 >> bitPos) & 7) == 5;
//                bool mid = ((num2 >> bitPos) & 7) == 2;
//                bool bot = ((num3 >> bitPos) & 7) == 5;

//                if (top && mid && bot)
//                {
//                    countX++;
//                }
//            }
//        }

//        //output
//        Console.WriteLine(countX);
//    }
//}
        }
    }

