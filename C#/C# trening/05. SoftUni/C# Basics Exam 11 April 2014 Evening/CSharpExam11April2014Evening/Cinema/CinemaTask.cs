namespace Cinema
{
    using System;

    public class CinemaTask
    {
        private static void Main()
        {
            string typeOfProjection = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());

            decimal ticketPrice = 0M;
            if (typeOfProjection == "Premiere")
            {
                ticketPrice = 12M;
            }
            else if (typeOfProjection == "Normal")
            {
                ticketPrice = 7.5M;
            }
            else if (typeOfProjection == "Discount")
            {
                ticketPrice = 5M;
            }
            else
            {
                throw new ArgumentException("Incorrect project type!");
            }

            decimal incomes = numberOfRows * numberOfColumns * ticketPrice;
            Console.WriteLine("{0:F2} leva", incomes);
        }
    }
}
