using System;

class CheckSignOfProduct
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if(firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("You have entered zero for some variables");
        } 
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber >0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign is +");
        }
        else
        {
            Console.WriteLine("The sing is -");
        }

    }
}

