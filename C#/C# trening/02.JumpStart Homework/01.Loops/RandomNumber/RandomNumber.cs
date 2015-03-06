using System;

class RandomNumber
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 10);  //[1..9]
        //Console.WriteLine(randomNumber);
        int someNumber;
        int tryNumber = 2;
      
        do
        {
            Console.Write("Try to guess the number: ");
            someNumber = int.Parse(Console.ReadLine());

            if (someNumber<=0 || someNumber>=10)
            {
                Console.WriteLine("Uncorect input!You must enter number in range [1..9]");
                break;
            }
            else
            {
                if (someNumber==randomNumber)
                {
                    break;
                }
                if ( someNumber < randomNumber)
                {
                    Console.WriteLine("The number is BIGGER than: {0}.",someNumber);
                    Console.WriteLine("You have {0} guesses left.", tryNumber);
                    Console.WriteLine();   
                }

                else if (someNumber > randomNumber)
                {
                    Console.WriteLine("The number is SMALLER than: {0}.", someNumber);
                    Console.WriteLine("You have {0} guesses left", tryNumber);
                    Console.WriteLine();   
                }
            }
            tryNumber--;
     
        } while (tryNumber >= 0 || randomNumber == someNumber);

        if (randomNumber != someNumber)
        {
            Console.WriteLine("You lose!The number was {0}", randomNumber);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("You win!");
        }
        
    }
}

