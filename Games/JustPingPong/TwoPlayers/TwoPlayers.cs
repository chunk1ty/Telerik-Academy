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
        //static Random randomGenerator = new Random();
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
            //put players pad on the left/right middle of the console
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
            for (int y = firstPlayerPosition; y <= firstPlayerPosition + firstPlayerPadSize; y++)
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
            PrintAtPosition(ballPositionX, ballPositionY, 'D');
        }

        private static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.WriteLine("{0}-{1}", firstPlayerResult, secondPlayerResult);
        }

        private static void MoveFirstPlayerUp()
        {
            if (firstPlayerPosition > 0)
            {
                firstPlayerPosition--;
            }
        }

        private static void MoveFirstPlayerDown()
        {
            if (firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize - 1)
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
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize - 1)
            {
                secondPlayerPosition++;
            }
        }

        //static void SecondPlayerMove()
        //{
        //    int randomNumber = randomGenerator.Next(1, 101);  //give me a number in interval (0,1). we have only two option 0 or 1  
        //    //if (randomNumber==0)
        //    //{
        //    //    MoveSecondPlayerUp();
        //    //}
        //    //if (randomNumber==1)
        //    //{
        //    //    MoveSecondPlayerDown();
        //    //}
        //    if (randomNumber <= 70)
        //    {
        //        if (ballDirectionUp == true)
        //        {
        //            MoveSecondPlayerUp();
        //        }
        //        else
        //        {
        //            MoveSecondPlayerDown();
        //        }
        //    }
        //}

        private static void MoveBall()
        {
            if (ballPositionY == 0)
            {
                ballDirectionUp = false;
            }
            if (ballPositionY == Console.WindowHeight - 1)
            {
                ballDirectionUp = true;
            }

            if (ballPositionX == Console.WindowWidth - 1)
            {
                SetBallAtTheMiddleOfTheField();
                ballDirectionRight = false;
                ballDirectionUp = true;
                firstPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("First player wins!");
                Console.ReadKey();
            }

            if (ballPositionX == 0)
            {
                SetBallAtTheMiddleOfTheField();
                ballDirectionRight = true;
                ballDirectionUp = true;
                secondPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("Second player wins!");
                Console.ReadKey();
            }

            if (ballPositionX < 2)              //3
            {
                //firstplayer+padsize = namirame nai dolnata tochka na hilkata na 1 viq igrach
                if (ballPositionY >= firstPlayerPosition && ballPositionY < firstPlayerPosition + firstPlayerPadSize)
                {
                    ballDirectionRight = true;
                }
            }

            if (ballPositionX >= Console.WindowWidth - 3 - 1)
            {
                if (ballPositionY >= secondPlayerPosition && ballPositionY < secondPlayerPosition + secondPlayerPadSize)
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

        static void Main(string[] args)
        {
            RemoveScrollBars();
            SetInitialPosition();
            // one infinity while loop where we will do evrything
            while (true)
            {
                // move first player
                //if (Console.KeyAvailable)
                //{
                //    ConsoleKeyInfo keyInfo = Console.ReadKey();
                //    if (keyInfo.Key == ConsoleKey.UpArrow)
                //    {
                //        MoveFirstPlayerUp();
                //    }
                //    if (keyInfo.Key == ConsoleKey.DownArrow)
                //    {
                //        MoveFirstPlayerDown();
                //    }
                //}
                // move second player
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.W)
                    {
                        MoveSecondPlayerUp();
                    }
                    else if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveFirstPlayerUp();
                    }

                    if (keyInfo.Key == ConsoleKey.S)
                    {
                        MoveSecondPlayerDown();
                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveFirstPlayerDown();
                    }
                }
               
                // move the ball
                MoveBall();

                // redraw all 
                // how to do redraw 
                // 1) clear all
                Console.Clear();
                // 2) draw first player
                DrawFirstPlayer();
                // 3) draw second player
                DrawSecondPlayer();
                // 4) draw the ball
                DrawBall();
                // 5) print result
                PrintResult();

                Thread.Sleep(100);
            }
        }
    }
}
