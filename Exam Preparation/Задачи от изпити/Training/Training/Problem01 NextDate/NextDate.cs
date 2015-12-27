using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            string format = "d.M.yyyy";
            Console.WriteLine(date.AddDays(1).ToString(format));

        }
    }
}
