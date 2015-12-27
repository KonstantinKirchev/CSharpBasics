using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralSystemConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Numeral System Conversions
            int dec = 1234;
            // calculate binary and hexadecimal representation using static methods
            string bin = DecToBin(dec);
            string hex = DecToHex(dec);
            // print results
            Console.WriteLine("dec: {0}   bin: {1}   hex: {2}", dec, bin, hex);

            bin = "1100101";
            // calculate decimal and hexadecimal representation using static methods
            dec = BinToDec(bin);
            hex = BinToHex(bin);
            // print results
            Console.WriteLine("bin: {0}   dec: {1}   hex: {2}", bin, dec, hex);

            hex = "ABC";
            // calculate decimal and binary representation using static methods
            dec = HexToDec(hex);
            bin = HexToBin(hex);
            // print results
            Console.WriteLine("hex: {0}   dec: {1}   bin: {2}", hex, dec, bin);

        }

        static string DecToBin(int dec)
        {
            // check if dec < 0 and write err message
            if (dec < 0) { Console.WriteLine("Error - not work with negative numbers!"); return "0"; }
            // check if dec = 0 returns "0"
            if (dec == 0) { return "0"; }
            string bin = "";
            // converts dec in binary numerical system and retrns it as a string
            while (dec > 0)
            {
                int x = dec % 2;
                dec = dec / 2;
                bin = x.ToString() + bin;
            }
            return bin;
        }

        static string DecToHex(int dec)
        {
            // check if dec < 0 and write err message
            if (dec < 0) { Console.WriteLine("Error - not work with negative numbers!"); return "0"; }
            // check if dec = 0 returns "0"
            if (dec == 0) { return "0"; }
            // converts dec in hexadecimal numerical system and retrns it as a string
            string hex = "";
            int dec2 = dec;
            while (dec2 > 0)
            {
                int x = dec2 % 16;
                dec2 = dec2 / 16;
                if (x < 10) { hex = x.ToString() + hex; }
                if (x == 10) { hex = "A" + hex; }
                if (x == 11) { hex = "B" + hex; }
                if (x == 12) { hex = "C" + hex; }
                if (x == 13) { hex = "D" + hex; }
                if (x == 14) { hex = "E" + hex; }
                if (x == 15) { hex = "F" + hex; }
            }
            return hex;
        }

        static int BinToDec(string bin)
        {
            // check if string bin is empty and write err message
            if (bin.Length < 1) { Console.WriteLine("Error - input mast be a valid binary number!"); return 0; }
            double pw = 0;
            double result = 0;
            // convert string bin into double result
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin.Substring(i, 1) == "1")
                {
                    result = result + Math.Pow(2, pw);
                }
                // if in string bin have a different simbol from 0 and 1 write err message
                else if (bin.Substring(i, 1) != "0")
                {
                    Console.WriteLine("Error - input mast be a valid binary number!");
                    return 0;
                }
                pw++;
            }
            // converts a double result into integer
            int result2 = Convert.ToInt32(result);
            return result2;
        }

        static string BinToHex(string bin)
        {
            // converts bin to decimal number result1
            int result1 = BinToDec(bin);
            // converts decimal number result1 into hexadecimal number (represented as a string)
            string result = DecToHex(result1);
            return result;
        }

        static int HexToDec(string hex)
        {
            // check if string hex is empty and write err message
            if (hex.Length < 1) { Console.WriteLine("Error - input mast be a valid hexadecimal number!"); return 0; }
            // converts hex into decimal number, using Math.Pow() method
            double sum = 0;
            double pw = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                string num = hex.Substring(i, 1);
                if (num == "A" || num == "a") { sum = sum + 10 * Math.Pow(16, pw); }
                else if (num == "B" || num == "b") { sum = sum + 11 * Math.Pow(16, pw); }
                else if (num == "C" || num == "c") { sum = sum + 12 * Math.Pow(16, pw); }
                else if (num == "D" || num == "d") { sum = sum + 13 * Math.Pow(16, pw); }
                else if (num == "E" || num == "e") { sum = sum + 14 * Math.Pow(16, pw); }
                else if (num == "F" || num == "f") { sum = sum + 15 * Math.Pow(16, pw); }
                else { sum = sum + double.Parse(num) * Math.Pow(16, pw); }
                pw++;
            }
            // convert double sum into int
            int result = Convert.ToInt32(sum);
            return result;
        }

        static string HexToBin(string hex)
        {
            // convert hex into decimal number dec
            int dec = HexToDec(hex);
            // convert dec into binary number bin (represented as a string)
            string bin = DecToBin(dec);
            return bin;
        

        }
    }
}
