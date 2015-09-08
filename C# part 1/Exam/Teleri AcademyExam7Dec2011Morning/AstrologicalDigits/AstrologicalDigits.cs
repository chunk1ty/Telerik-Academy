using System;
using System.Numerics;

    class AstrologicalDigits
    {
        static void Main()
        {
            //int sumDigit = 0;
            //while (true)
            //{
            //    int ch = Console.Read();
            //    if ((ch == -1) || (ch=='\n') || (ch=='\r'))
            //    {
            //        break;
            //    }
            //    if (ch>= '0'&& ch <='9')
            //    {
            //        char nextChar = (char)ch;
            //        int digit = nextChar - '0';
            //        sumDigit += digit;   
            //    }
                
            //}

            //while (sumDigit>9)
            //{
            //    int finalSum = 0;
            //    while (sumDigit>0)
            //    {
            //        int lastDigit = sumDigit % 10;
            //        finalSum += lastDigit;
            //        sumDigit = sumDigit / 10;
            //    }
            //    sumDigit = finalSum;
                
            //}
            //Console.WriteLine(sumDigit);

            string text = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9')
                {
                    int toInt = int.Parse(text[i].ToString());
                    sum += toInt;   
                }
            }
             
            while (sum>9)
            {
                int finalNum = 0;
                while (sum > 0)
                {
                    int lastDigit = sum % 10;
                    finalNum += lastDigit;
                    sum = sum / 10;
                }
                sum = finalNum;
            }
            Console.WriteLine(sum);

        }
    }

