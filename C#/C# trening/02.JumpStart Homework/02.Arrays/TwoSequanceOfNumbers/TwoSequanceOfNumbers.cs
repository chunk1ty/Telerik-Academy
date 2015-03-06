using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoSequanceOfNumbers
{
    static void Main()
    {
        int[] firstArray = { 8, 2, 10, 3, 7 };
        int[] secondArray = { 6, 8, 3, 17 };

        CheckNumberInTwoSequence(firstArray,secondArray);
        CheckNumberInTwoSequence(secondArray, firstArray);
        Console.WriteLine();
    }

    static void CheckNumberInTwoSequence(int[] myArrayOne,int[] myArrayTwo)
    {
        for (int i = 0; i < myArrayOne.Length; i++)
        {
            bool check = true;
            for (int j = 0; j < myArrayTwo.Length; j++)
            {
                if (myArrayOne[i] == myArrayTwo[j])
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.Write("{0} ", myArrayOne[i]);
            }
        }   

    }
}

