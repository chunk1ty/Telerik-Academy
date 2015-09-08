using System;
using System.Numerics;

class BinaryDigitsCount
{
    static void Main()
    {
        byte bit = byte.Parse(Console.ReadLine());
        int size = int.Parse(Console.ReadLine());
        long [] myArray = new long [size];

        for (int i = 0; i < size; i++)
        {
            myArray[i] = long.Parse(Console.ReadLine());
        }

        long temp = 0;
        int counter = 0;
        if (bit==0)
        {
            for (int i = 0; i < size; i++)
            {
                counter = 0;
                temp = myArray[i];
                string binaryString = Convert.ToString(temp, 2);
                BigInteger binaryInt = BigInteger.Parse(binaryString);
                while (binaryInt != 0)
                {
                    BigInteger digit = binaryInt % 10;
                    if (digit == 0)
                    {
                        counter++;
                    }
                    binaryInt /= 10;    
                }
                Console.WriteLine(counter);   
            }
            
        }
        else
        {
            for (int i = 0; i < size; i++)
            {
                counter = 0;
                temp = myArray[i];
                string binaryString = Convert.ToString(temp, 2);
                BigInteger binaryInt = BigInteger.Parse(binaryString);
                while (binaryInt != 0)
                {
                    BigInteger digit = binaryInt % 10;
                    if (digit == 1)
                    {
                        counter++;
                    }
                    binaryInt /= 10;
                }
                Console.WriteLine(counter);

            }
            
        }
    }
}
