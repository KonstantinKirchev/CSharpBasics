﻿using System;

    class InsideTheBuilding
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());
            bool isInsideBuilding1 = ((x1 >= 0 && x1 <= 3 * h) && (y1 >= 0 && y1 <= h)) || ((x1 >= h && x1 <= 2 * h) && (y1 >= h && y1 <= 4 * h));
            bool isInsideBuilding2 = ((x2 >= 0 && x2 <= 3 * h) && (y2 >= 0 && y2 <= h)) || ((x2 >= h && x2 <= 2 * h) && (y2 >= h && y2 <= 4 * h));
            bool isInsideBuilding3 = ((x3 >= 0 && x3 <= 3 * h) && (y3 >= 0 && y3 <= h)) || ((x3 >= h && x3 <= 2 * h) && (y3 >= h && y3 <= 4 * h));
            bool isInsideBuilding4 = ((x4 >= 0 && x4 <= 3 * h) && (y4 >= 0 && y4 <= h)) || ((x4 >= h && x4 <= 2 * h) && (y4 >= h && y4 <= 4 * h));
            bool isInsideBuilding5 = ((x5 >= 0 && x5 <= 3 * h) && (y5 >= 0 && y5 <= h)) || ((x5 >= h && x5 <= 2 * h) && (y5 >= h && y5 <= 4 * h));
            Console.WriteLine(isInsideBuilding1 == true ? "inside" : "outside");
            Console.WriteLine(isInsideBuilding2 == true ? "inside" : "outside");
            Console.WriteLine(isInsideBuilding3 == true ? "inside" : "outside");
            Console.WriteLine(isInsideBuilding4 == true ? "inside" : "outside");
            Console.WriteLine(isInsideBuilding5 == true ? "inside" : "outside");
        }
    }
