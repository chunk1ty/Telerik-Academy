using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JustPingPong
{
    class JustPingPong
    {
        // position of out ball
        static int ballPositionX = 0;
        static int ballPositionY = 0;
        // position of first player bat(hilkata) and second (computer)
        static int firstPlayerPosition = 0;
        static int secondPlayerPosition = 0;
        // length of pad size (hilkata)
        static int firstPlayerPadSize = 7;
        static int secondPlayerPadSize = 7;
        //save result
        static int firstPlayerResult = 0;
        static int secondPlayerResult = 0;
        // random move second player
        static Random randomGenerator = new Random();
        // determines if the ball direction is up
        static bool ballDirectionUp = true;
        static bool ballDirectionRight = true;


        static void RemoveScrollBars()
        {
            //remove scrollbar
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            //change color
            Console.ForegroundColor = ConsoleColor.Red;
        }

        private static void SetInitialPosition()
        {
            //put players pad on the left/right middle of the console (slagame posredata hilkite na igrachite)
            firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            secondPlayerPosition = Console.WindowHeight / 2 - secondPlayerPadSize / 2;
            //put ball on the middle of the console
            SetBallAtTheMiddleOfTheField();
        }

        static void SetBallAtTheMiddleOfTheField()
        {
            ballPositionX = Console.WindowWidth / 2;
            ballPositionY = Console.WindowHeight / 2;
        }

        private static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);               // zadavame kordinati na kursora
            Console.Write(symbol);
        }

        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition; y <=firstPlayerPosition + firstPlayerPadSize; y++)
            {
     //           PrintAtPosition(0, y, '|');
                PrintAtPosition(1, y, '|');
            }
        }

        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y <= secondPlayerPosition + secondPlayerPadSize; y++)
            {
       //         PrintAtPosition(Console.WindowWidth - 1, y, '|');
                PrintAtPosition(Console.WindowWidth - 2, y, '|');
            }
        }

        private static void DrawBall()
        {
            PrintAtPosition(ballPositionX, ballPositionY, 'o');
        }

        private static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1,0);
            Console.WriteLine("{0}-{1}",firstPlayerResult,secondPlayerResult);
        }

        private static void MoveFirstPlayerUp()
        {
            if (firstPlayerPosition>0)
            {
                firstPlayerPosition--;    
            }  
        }

        private static void MoveFirstPlayerDown()
        {
            if (firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize-1)
            {
                firstPlayerPosition++;     
            }     
        }

        private static void MoveSecondPlayerUp()
        {
            if (secondPlayerPosition > 0)
            {
                secondPlayerPosition--;
            }
        }

        private static void MoveSecondPlayerDown()
        {
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize-1)
            {
                secondPlayerPosition++;
            }
        }

        static void SecondPlayerMove()
        {
           int randomNumber = randomGenerator.Next(1, 101);  
           if (randomNumber <= 80 )
           {
                if (ballDirectionUp == true)
                {
                    MoveSecondPlayerUp();
                }
                else
                {
                    MoveSecondPlayerDown();
                }
           }
        }

        private static void MoveBall()
        {
            if (ballPositionY == 0)
            {
                ballDirectionUp = false;
            }
            if (ballPositionY==Console.WindowHeight-1)
            {
                ballDirectionUp = true;    
            }

            if (ballPositionX == Console.WindowWidth-1)
            {
                SetBallAtTheMiddleOfTheField();
                ballDirectionRight = false;
                ballDirectionUp = true;
                firstPlayerResult++;

                Console.SetCursorPosition(33, 1);
                Console.CursorVisible = false;
                Console.WriteLine("Left player win!");
                Console.SetCursorPosition(33, 2);
                Console.WriteLine("Press SPACE for continue.");
                Console.SetCursorPosition(33, 3);
                Console.WriteLine("Press Escape for back to menu.");
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    MoveBall();
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Main();
                }
                
            }

            if (ballPositionX == 0)
            {
                SetBallAtTheMiddleOfTheField();
                ballDirectionRight = true;
                ballDirectionUp = true;
                secondPlayerResult++;
                Console.SetCursorPosition(33,1);
                Console.WriteLine("Right player win!");
                Console.SetCursorPosition(33, 2);
                Console.WriteLine("Press SPACE for continue.");
                Console.SetCursorPosition(33, 3);
                Console.WriteLine("Press Escape for back to menu.");
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    MoveBall();
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Main();
                }
            }

            if (ballPositionX < 3)
            {
                //firstplayer+padsize = namirame nai dolnata tochka na hilkata na 1 viq igrach
                if (ballPositionY >= firstPlayerPosition && ballPositionY < firstPlayerPosition + firstPlayerPadSize )    
                {
                    ballDirectionRight = true;   
                }
            }

            if (ballPositionX >= Console.WindowWidth - 3 - 1 )
            {
                if (ballPositionY >= secondPlayerPosition && ballPositionY < secondPlayerPosition+secondPlayerPadSize)
                {
                    ballDirectionRight = false;
                }   
            }

            if (ballDirectionUp)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }
            if (ballDirectionRight)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
        }

        static  void VsComputer()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    while (Console.KeyAvailable) { Console.ReadKey();}
                    if (keyInfo.Key == ConsoleKey.W)
                    {
                        MoveFirstPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.S)
                    {
                        MoveFirstPlayerDown();
                    }
                }
                SecondPlayerMove();
                MoveBall();
                Console.Clear();
                DrawFirstPlayer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                Thread.Sleep(100);
            }
        }

        static void ForTwoPlayers ()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    while (Console.KeyAvailable) { Console.ReadKey(); }
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveSecondPlayerUp();
                    }
                    else if (keyInfo.Key == ConsoleKey.W)
                    {
                        MoveFirstPlayerUp();
                    }

                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveSecondPlayerDown();
                    }
                    else if (keyInfo.Key == ConsoleKey.S)
                    {
                        MoveFirstPlayerDown();
                    }
                }
                MoveBall();
                Console.Clear();
                DrawFirstPlayer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                Thread.Sleep(100);
            }
        }

        static void PlayersControl()
        {
            Console.Clear();
            Console.WriteLine(@"

             _____________________________________________________
            |   Move                  |    For Up    |   For Down |
            |_________________________|______________|____________|
            |   Left Player           |      W       |      S     |
            |_________________________|______________|____________|   
            |   Right Player          |    ArrorUp   |  ArrorDown | 
            |_________________________|______________|____________|
                    
");
        } 

       

        static void Main()
        {
            RemoveScrollBars();
            SetInitialPosition();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string menuForGame = "MENU";
            string vsComputer = "Single player";
            string playerVsPlayer = "Multiplayer";
            string playersControls = "Controls";
            string exitFromGame = "Exit";
            string oneOrTwo = "Select option (1, 2 ,3 or 4) and after that press enter : ";
            int optionOne = 1;
            int optionTwo = 2;
            int optionThree = 3;
            int optionFour = 4;

            Console.WriteLine("{0,42}",menuForGame);
            Console.WriteLine();
            Console.WriteLine("{0,42} | {1} |",vsComputer,optionOne);
            Console.WriteLine("{0,40}   | {1} |",playerVsPlayer,optionTwo);
            Console.WriteLine("{0,37}      | {1} |", playersControls, optionThree);
            Console.WriteLine("{0,33}          | {1} |", exitFromGame, optionFour);
            Console.WriteLine();
            Console.Write("{0,68}", oneOrTwo);
            int choseOption = int.Parse(Console.ReadLine()); 
            //if (Console.ReadKey(true).Key == ConsoleKey.D1)
            //{
            //    VsComputer();   
            //}
            //else if (Console.ReadKey().Key == ConsoleKey.D2)
            //{
            //    ForTwoPlayers();
            //}
            //else if (Console.ReadKey().Key == ConsoleKey.D3)
            //{
            //    PlayersControl();
            //}
            //else
            //{
                
            //}

            switch (choseOption)
            {
                case 1: VsComputer(); break;
                case 2: ForTwoPlayers(); break;
                case 3: PlayersControl(); break;
                case 4: Environment.Exit(4); break;
                default: Console.WriteLine("Uncorect input"); break;
            }   
        }  
    }
}
