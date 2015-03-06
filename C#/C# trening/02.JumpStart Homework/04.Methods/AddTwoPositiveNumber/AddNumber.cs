using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoPositiveNumber
{
    class AddNumber
    {
        static void Main()
        {
            int[] firstNumber = { 9,6,9,8};     // -> 9698
            int[] secondNumber = { 9, 7, 2};    // -> 972

            // first i find which array is bigger , because my alrorithm work with bigger array 
            int firstLen = firstNumber.Length;
            int secondLen = secondNumber.Length;

            if (firstLen > secondLen)
            {
                AddEachNumber(firstNumber, secondNumber);    
            }
            else
            {
                AddEachNumber(secondNumber,firstNumber);
            }  
        }

        //add each number(in both arrays) and save this number in list
        static void AddEachNumber (int[] first, int[] second)
        {
            List<int> result = new List<int>();            
            
            int j = second.Length - 1;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                if (j < 0)
                {
                    result.Add(first[i]);
                }
                else
                {
                    result.Add(first[i] + second[j]);
                }
                j--;
            }
            EndNumber(result);            
        }
        
        // and this is the most complicated part of my algorithm ...
        static void EndNumber (List<int> inputList)
        {
            //if transfer occurs in the last position (ако възникне пренос на последната позиция (не съм много сигурен дали така се пише на англииски ))
            // i add one more element with value 0
            inputList.Add(0);
                      
            for (int i = 0; i < inputList.Count ; i++)
            {
                if (inputList[i] >= 10)
                {
                    // on temp i assign current value 
                    int temp = inputList[i];
                    // on the current value i assign last digit
                    inputList[i] = temp % 10;
                    // and increase next element with transfer(преноса)
                    inputList[i + 1] += temp / 10;
                }
            }
            inputList.Reverse();
            string resultAsString = string.Join("", inputList.ToArray());
            // i parse resultAsString because can be something like "0983231" and with this parse i will remove 1st zero
            int result = int.Parse(resultAsString);

            Console.WriteLine("The result is {0}", result);
        }
    }
}
