using System;

    class BitFlipper
    {
        static void Main()
        {
            long num = (long)ulong.Parse(Console.ReadLine());
            string str = Convert.ToString(num, 2).PadLeft(64, '0');
            Console.WriteLine(str);
            char[] array = str.ToCharArray();
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i]==array[i-1] && array[i]==array[i-2])
                {
                    if (array[i]=='0')
                    {
                        array[i] = '1';
                        array[i - 1] = '1';
                        array[i - 2] = '1';
                    }
                    else 
                    {
                        array[i] = '0';
                        array[i - 1] = '0';
                        array[i - 2] = '0';
                    }
                    i += 2;
                }
            }
            Console.WriteLine(array);
            Console.WriteLine(Convert.ToUInt64(new string(array),2));
        }
    }

