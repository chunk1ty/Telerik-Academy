using System;

class Kamikadze
{
    static void Main()
    {
        int target1 = 5;
        int target2 = 17;
        int target3 = 12;

        Console.WindowWidth = 20;         //Tune(nastroivame) the console
        Console.WindowHeight = 25;        //Width and height 

        int tries = 2;
        int scores = 0;
        
        while (true)
	    {
            Console.Clear();
            PrintTarget(target1);
            PrintTarget(target2);
            PrintTarget(target3);
        

            int x = Console.WindowWidth / 2;        // on the middle
            int y = Console.WindowHeight - 1;      //nai dolnata poziciq
            Console.CursorVisible = false;
            Console.Title = "Ank";
            Console.BufferHeight = Console.WindowHeight; //remove
            Console.BufferWidth = Console.WindowWidth;  //scrollbar 

            PrintPlayer(x,y);

            var key = Console.ReadKey();

            if (key.Key != ConsoleKey.Spacebar)
            {
                continue;
            }

            while (true)
            {
                System.Threading.Thread.Sleep(80);   //delay(zabavqne)

                if (Console.KeyAvailable)    //check for press key
                {
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow) // ako tekushtiq natisnat klavish e lqvata strelka
                    { 
                        if (x > 0)
                        {
                            x--; // za da se dviji nalqvo trqbva da se namalq x ca
                            Console.Write(" ");
                        }
                    }
                    else if (key.Key == ConsoleKey.RightArrow) // ako tekushtiq natisnat klavish e dqsnata strelka
                    {
                        if (x < Console.WindowWidth-1)
                        {
                            x++;          // za da se dviji na dqsno trqbva da se uvelichava x sa
                            Console.Write(" ");
                        }
                    }
                }

                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                y--;
                if (y < 0)         //t.e kogato stigne -1 izlez ot cikala
                {
                    break;
                }
                else if (y == 0)
                {
                    if (x == target1)
                    {
                        target1 = -1;
                        scores++;
                    }
                    else if (x==target2)
                    {
                        target2 = -1;
                        scores++;
                    }
                    else if (x == target3)
                    {
                        target3 = -1;
                        scores++;
                    }
                    else
                    {
                        tries--;
                        if (tries==0)
                        {
                            PrintResult("You Lost!");  
                            return;
                        }
                    }

                    if (scores == 3)
                    { 
                        PrintResult("You Won!");
                        return;
                    }
                }
                PrintPlayer(x, y);
            }
        }
    }

    private static void PrintResult(string result)
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 2 - result.Length / 2, Console.WindowHeight / 2);
        Console.Write(result);
        Console.ReadKey();
    }

    private static void PrintTarget(int x)          //print stars
    {
        if (x > -1 && x < Console.WindowWidth)
        {
            Console.SetCursorPosition(x, 0);
            Console.Write("*");
        }     
    }

    private static void PrintPlayer(int x,int y)     //print player
    {
        Console.SetCursorPosition(x, y);
        Console.Write("+");
        Console.CursorLeft--;
    }

}

