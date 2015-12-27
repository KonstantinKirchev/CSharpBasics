using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FriendBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            string friends = "0";
            string alones = "0";

            string bitString = Convert.ToString(n, 2).PadLeft(32,'0');

            char lastChar = bitString[0];
            int count = 1;
            for (int i = 1; i < bitString.Length; i++)
            {
                if (lastChar == bitString[i])
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        friends += new String(lastChar, count);
                    }
                    else
                    {
                        alones += lastChar;
                    }
                    count = 1;
                }
                lastChar = bitString[i];
            }

            if (count > 1)
            {
                friends += new String(lastChar, count);
            }
            else
            {
                alones += lastChar;
            }

            Console.WriteLine(Convert.ToUInt32(friends,2));
            Console.WriteLine(Convert.ToUInt32(alones,2));
        }
    }
}
