using System;

class FitBoxInBox
{
    static void Main()
    {
        int firstBoxWidth = int.Parse(Console.ReadLine());
        int firstBoxHeight = int.Parse(Console.ReadLine());
        int firstBoxVolume = int.Parse(Console.ReadLine());
        int secondBoxWidth = int.Parse(Console.ReadLine());
        int secondBoxHeight = int.Parse(Console.ReadLine());
        int secondBoxVolume = int.Parse(Console.ReadLine());

        int firstSum = firstBoxWidth + firstBoxHeight + firstBoxVolume;
        int secondSum = secondBoxWidth + secondBoxHeight + secondBoxVolume;
        int[] smaller = new int[3];
        int[] bigger = new int[3];
        if (firstSum < secondSum)
        {
            smaller[0] = firstBoxWidth;
            smaller[1] = firstBoxHeight;
            smaller[2] = firstBoxVolume;
            bigger[0] = secondBoxWidth;
            bigger[1] = secondBoxHeight;
            bigger[2] = secondBoxVolume;
        }
        else if (secondSum < firstSum)
        {
            smaller[0] = secondBoxWidth;
            smaller[1] = secondBoxHeight;
            smaller[2] = secondBoxVolume;
            bigger[0] = firstBoxWidth;
            bigger[1] = firstBoxHeight;
            bigger[2] = firstBoxVolume;
        }

        if (smaller[0] < bigger[0] && smaller[1] < bigger[1] && smaller[2] < bigger[2])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smaller[0], smaller[1], smaller[2], bigger[0], bigger[1], bigger[2]);
        }
        if (smaller[0] < bigger[2] && smaller[1] < bigger[1] && smaller[2] < bigger[0])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smaller[0], smaller[1], smaller[2], bigger[2], bigger[1], bigger[0]);
        }
        if (smaller[0] < bigger[0] && smaller[1] < bigger[2] && smaller[2] < bigger[1])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smaller[0], smaller[1], smaller[2], bigger[0], bigger[2], bigger[1]);
        }
        if (smaller[0] < bigger[1] && smaller[1] < bigger[0] && smaller[2] < bigger[2])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smaller[0], smaller[1], smaller[2], bigger[1], bigger[0], bigger[2]);
        }
        if (smaller[0] < bigger[1] && smaller[1] < bigger[2] && smaller[2] < bigger[0])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smaller[0], smaller[1], smaller[2], bigger[1], bigger[2], bigger[0]);
        }
        if (smaller[0] < bigger[2] && smaller[1] < bigger[0] && smaller[2] < bigger[1])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", smaller[0], smaller[1], smaller[2], bigger[2], bigger[0], bigger[1]);
        }
    }
}