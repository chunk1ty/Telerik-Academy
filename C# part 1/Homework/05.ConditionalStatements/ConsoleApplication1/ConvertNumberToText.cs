using System;

class ConvertNumberToText
{
    static void Main()
    {
        Console.Write("Enter a number in range [0..999] - ");
        int numberOption = int.Parse(Console.ReadLine());


        switch (numberOption)
        {
            case 0:
                if (numberOption == 0)
                {
                    Console.WriteLine("Zero");   
                }
                break;


            default:
                break;
        }
    }
}

