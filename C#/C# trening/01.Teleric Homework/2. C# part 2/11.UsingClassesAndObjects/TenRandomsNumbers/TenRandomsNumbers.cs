using System;

class TenRandomsNumbers
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomNumber = rand.Next(100,201);
            Console.WriteLine(randomNumber);
        }
    }
}
