using System;

    class BookOrders
    {
        static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            int numberOfPackets = 0;
            int booksPerPacket = 0;
            double bookPrice = 0.0;
            double totalBooks = 0.0;
            double totalPrice = 0.0;
            double totalOfPackets = 0.0;
            double totalBooksPerPacket = 0.0;
            double books = 0.0;
            double totalTotalPrice = 0.0;
            for (int i = 0; i < numberOfOrders; i++)
            {
                numberOfPackets = int.Parse(Console.ReadLine());
                booksPerPacket = int.Parse(Console.ReadLine());
                bookPrice = double.Parse(Console.ReadLine());
                books = numberOfPackets * booksPerPacket;
                if (numberOfPackets < 10)
                {
                    totalPrice = books * bookPrice;
                }
                else if (numberOfPackets >= 10 && numberOfPackets <= 19)
                {
                    totalPrice = books * (bookPrice * 0.95);
                }
                else if (numberOfPackets >= 20 && numberOfPackets <= 29)
                {
                    totalPrice = books * (bookPrice * 0.94);
                }
                else if (numberOfPackets >= 30 && numberOfPackets <= 39)
                {
                    totalPrice = books * (bookPrice * 0.93);
                }
                else if (numberOfPackets >= 40 && numberOfPackets <= 49)
                {
                    totalPrice = books * (bookPrice * 0.92);
                }
                else if (numberOfPackets >= 50 && numberOfPackets <= 59)
                {
                    totalPrice = books * (bookPrice * 0.91);
                }
                else if (numberOfPackets >= 60 && numberOfPackets <= 69)
                {
                    totalPrice = books * (bookPrice * 0.9);
                }
                else if (numberOfPackets >= 70 && numberOfPackets <= 79)
                {
                    totalPrice = books * (bookPrice * 0.89);
                }
                else if (numberOfPackets >= 80 && numberOfPackets <= 89)
                {
                    totalPrice = books * (bookPrice * 0.88);
                }
                else if (numberOfPackets >= 90 && numberOfPackets <= 99)
                {
                    totalPrice = books * (bookPrice * 0.87);
                }
                else if (numberOfPackets >= 100 && numberOfPackets <= 109)
                {
                    totalPrice = books * (bookPrice * 0.86);
                }
                else if (numberOfPackets >= 110)
                {
                    totalPrice = books * (bookPrice * 0.85);
                }
                totalBooks += books;
                totalOfPackets += numberOfPackets;
                totalBooksPerPacket += booksPerPacket;
                totalTotalPrice += totalPrice;
                
            }
            Console.WriteLine(totalBooks);
            Console.WriteLine("{0:F2}", totalTotalPrice);
        }
    }

