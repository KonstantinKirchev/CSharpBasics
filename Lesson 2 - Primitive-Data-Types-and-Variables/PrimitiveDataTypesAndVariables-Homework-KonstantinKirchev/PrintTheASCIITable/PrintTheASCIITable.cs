using System;
using System.Text;

    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.BufferHeight = 2000;
            Console.OutputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.GetEncoding(1252);

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("{0} --> {1}  ",i,(char)i);      
            }
               
        }
    }


