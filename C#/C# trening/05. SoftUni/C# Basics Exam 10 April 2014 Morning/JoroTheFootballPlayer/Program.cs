namespace JoroTheFootballPlayer
{
    using System;
    class Program
    {        
        static void Main()
        {
            string isLeap = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfWeekendsInHometown = int.Parse(Console.ReadLine());

            int weekends = 52;
            double result = 0;

            //double test = 50 * 2 / 3.0;
            //double result = test + 0.5;
            //Console.WriteLine("{0:f0}", result);

            if (isLeap == "t")
            {
                result += 3.0;
            }
            if (numberOfWeekendsInHometown > 0)
            {
                result += numberOfWeekendsInHometown;
                weekends -= numberOfWeekendsInHometown; 
            }
            if (numberOfHolidays > 0)
            {
                result += numberOfHolidays / 2.0;
            }
            result += weekends * 2 / 3.0;
            Console.WriteLine((int)result);
        }
    }
}
