using System;

class AddPointToGivenScores
{
    static void Main()
    {
        Console.Write("Applies bonus scores in the range [1..9] : ");
        int choiceOption = int.Parse(Console.ReadLine());

        switch (choiceOption)
        {
            case 1:
            case 2:
            case 3:
                Console.Write("Enter Points: ");
                int firstPoint = int.Parse(Console.ReadLine());
                firstPoint = firstPoint * 10;
                Console.WriteLine("Your score is : "+firstPoint);
                break;
            case 4:
            case 5:
            case 6:
                Console.Write("Enter Points : ");
                int secondPoint = int.Parse(Console.ReadLine());
                secondPoint = secondPoint * 100;
                Console.WriteLine("Your score is : " + secondPoint);
                break;
            case 7:
            case 8:
            case 9:
                Console.Write("Enter Points : ");
                int thirdPoint = int.Parse(Console.ReadLine());
                thirdPoint = thirdPoint * 1000;
                Console.WriteLine("Your score is : " + thirdPoint);
                break;
            default:
                Console.WriteLine("Incorrect input!");
                break;
        }
    }
}

