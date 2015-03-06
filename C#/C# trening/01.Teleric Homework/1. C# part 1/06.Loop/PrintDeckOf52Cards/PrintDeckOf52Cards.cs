using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        //First Solution
        //string color = null;

        //for (int colorsOfCards = 1; colorsOfCards <= 4; colorsOfCards++)
        //{
        //    switch (colorsOfCards)
        //    {
        //        case 1: color = "Club"; break;
        //        case 2: color = "Diamond"; break;
        //        case 3: color = "Heart"; break;
        //        case 4: color = "Spade"; break;
        //    }
        //    Console.WriteLine();
        //    for (int numbersOfCards = 2; numbersOfCards <= 52; numbersOfCards++)
        //    {
        //        switch (numbersOfCards)
        //        {
        //            case 2: Console.WriteLine("2 " + color); break;
        //            case 3: Console.WriteLine("3 " + color); break;
        //            case 4: Console.WriteLine("4 " + color); break;
        //            case 5: Console.WriteLine("5 " + color); break;
        //            case 6: Console.WriteLine("6 " + color); break;
        //            case 7: Console.WriteLine("7 " + color); break;
        //            case 8: Console.WriteLine("8 " + color); break;
        //            case 9: Console.WriteLine("9 " + color); break;
        //            case 10: Console.WriteLine("10 " + color); break;
        //            case 11: Console.WriteLine("J " + color); break;
        //            case 12: Console.WriteLine("Q " + color); break;
        //            case 13: Console.WriteLine("K " + color); break;
        //            case 14: Console.WriteLine("A " + color); break;


        //        }
        //    }
        //}

        //Second Solution

        string number=null;
        for (int numberOfCards = 2; numberOfCards <=14; numberOfCards++)
        {
            switch (numberOfCards)
            {
                case 2: number = "2"; break;
                case 3: number = "3"; break;
                case 4: number = "4"; break;
                case 5: number = "5"; break;
                case 6: number = "6"; break;
                case 7: number = "7"; break;
                case 8: number = "8"; break;
                case 9: number = "9"; break;
                case 10: number = "10"; break;
                case 11: number = "J"; break;
                case 12: number = "Q"; break;
                case 13: number = "K"; break;
                case 14: number = "A"; break;
            }
            Console.WriteLine();
            for (int colors = 1; colors <= 4; colors++)
            {
                switch(colors)
                {
                    case 1: Console.WriteLine(number + " Club");  break;
                    case 2: Console.WriteLine(number + " Diamond"); break;
                    case 3: Console.WriteLine(number + " Heart"); break;
                    case 4: Console.WriteLine(number + " Spades"); break;
                }
            }
        }
    }
}
