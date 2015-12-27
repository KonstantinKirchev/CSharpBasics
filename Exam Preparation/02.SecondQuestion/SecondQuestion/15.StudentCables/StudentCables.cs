using System;

    class StudentCables
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalLength = 0;
            int joins = 0;
            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "meters")
                {
                    // Convert meters to centimeters
                    length = length * 100;
                }
                if (length >= 20)
                {
                    totalLength += length;
                    joins++;
                }
            }
            // Substract the lost length for joining the cables
            totalLength = totalLength - 3 * (joins - 1);

            int cablesCount = totalLength / 504;
            int remainder = totalLength % 504; // така взимам остатъка

            Console.WriteLine(cablesCount);
            Console.WriteLine(remainder);
            //uint count = uint.Parse(Console.ReadLine());
            //uint cableLength = 0;
            //uint sum = 0;
            //uint studentCables = 0;
            //uint remain = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    cableLength = uint.Parse(Console.ReadLine());
            //    string measure = Console.ReadLine();
            //    if (measure == "meters")
            //    {
            //        cableLength *= 100;
            //    }
            //    if (cableLength < 20)
            //    {
            //        cableLength = 0;
            //    }
            //    sum += cableLength;
            //}
            //sum -= 6;
            //studentCables = sum / 504;
            //remain = sum - (studentCables * 504);
            //Console.WriteLine(studentCables);
            //Console.WriteLine(remain);
            //Main();
        }
    }

