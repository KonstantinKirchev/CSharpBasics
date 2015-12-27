using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string firstStr = "The \"use\" of quotations causes difficulties.";
            string secondStr = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("{0}\n{1}",firstStr,secondStr);
        }
    }

