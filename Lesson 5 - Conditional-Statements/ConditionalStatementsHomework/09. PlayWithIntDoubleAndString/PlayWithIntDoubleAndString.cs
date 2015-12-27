using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("1 --> int\n2 --> double\n3 --> string\nPlease choose a type: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.Write("Please enter an integer: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(intNumber + 1);
                    break;
                case "2":
                    Console.Write("Please enter a double: ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleNumber + 1.0);
                    break;
                case "3":
                    Console.Write("Please enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("{0}*",str);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            Main();
        }
    }

