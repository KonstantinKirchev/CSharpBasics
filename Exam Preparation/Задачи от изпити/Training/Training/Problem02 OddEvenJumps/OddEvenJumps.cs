using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;
class OddEvenJumps
{
    static void Main()
    {
        //Odd-Even-Jumps 70/100
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());


        string joinedInput = Regex.Replace(input, @"\s+", "").ToLower();

        string oddLetters = string.Empty;
        string evenLetters = string.Empty;

        for (int i = 0; i < joinedInput.Length; i += 2)
        {
            oddLetters += joinedInput[i];
          
        }
        for(int i = 1; i < joinedInput.Length; i+=2)
        {
            evenLetters += joinedInput[i];
        }
     

        BigInteger oddResult = 0;
        for (int i = 0; i < oddLetters.Length; i++)
        {
            if ((i + 1) % oddJump == 0)
            {
                oddResult *= (int)oddLetters[i];
            }
            else
            {
                oddResult += (int)oddLetters[i];
            }
        }

        BigInteger evenResult = 0;
        for (int i = 0; i < evenLetters.Length; i++)
        {
            if ((i + 1) % evenJump == 0)
            {
                evenResult *= (int)evenLetters[i];
            }
            else
            {
                evenResult += (int)evenLetters[i];
            }
        }

        string oddHex = oddResult.ToString("X");
        if(oddHex[0] == '0')
        {
            string final = oddHex.TrimStart('0');
            Console.WriteLine("Odd: {0:X}", final);
        }
        else
        {
            Console.WriteLine("Odd: {0}", oddHex);
        }

        string evenHex = evenResult.ToString("X");
        Console.WriteLine("Even: {0}", evenHex);

    }
}
