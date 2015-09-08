using System;

namespace Slides
{

    //BIG SHIT !!!
    class Ball
    {
        public Ball(int width, int height, int depth)
        {
            this.BallWidth = width;
            this.BallHeight = height;
            this.BallDepth = depth;
        }
        public int BallWidth { get; set; }
        public int BallHeight { get; set; }
        public int BallDepth { get; set; }
    }
    class Slides3D
    {
        private static int width, depth, height;
        private static string[, ,] cube;
        private static Ball cubeBall;
        static void Main()
        {
            ReadInput();
            ProcessesBallCommands();
        }

        static void ProcessesBallCommands()
        {
            while (true)
            {
                string currCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];

                string[] splitedCell = currCell.Split();

                string command = splitedCell[0];

                switch (command)
                {
                    case "S": ProccessBallSlides(splitedCell[1]); break;
                    case "T": break;
                    case "B": break;
                    case "E": break;
                    default: throw new ArgumentException("Invalid command!");                        
                }
            }
        }

        static void ProccessBallSlides(string command)
        {

            switch (command)
            {
                case "R": 
                    cubeBall.BallHeight++;
                    cubeBall.BallWidth++;
                    break;
                case "L":
                    cubeBall.BallWidth--;
                    cubeBall.BallHeight++; 
                    break;
                case "F":
                    cubeBall.BallDepth++;
                    cubeBall.BallHeight++; 
                    break;
                case "B":
                    cubeBall.BallDepth--;
                    cubeBall.BallHeight++;
                    break;
                case "FL": 
                    cubeBall.BallDepth++;
                    cubeBall.BallWidth--;
                    cubeBall.BallHeight++; 
                    break;
                case "FR":
                    cubeBall.BallDepth++;
                    cubeBall.BallHeight++;
                    cubeBall.BallWidth++;
                    break;
                case "BL":
                    cubeBall.BallDepth--;
                    cubeBall.BallWidth--;
                    cubeBall.BallHeight++; 
                    break;
                case "BR": 
                    cubeBall.BallDepth--;
                    cubeBall.BallWidth++;
                    cubeBall.BallHeight++;  
                    break;
                default: throw new ArgumentException("Invalid slide command!");                   
            }
            if ()
            {
                
            }
        }

        private static bool IsPassable(Ball ball)
        {
            if (ball.BallWidth >=0 && ball.BallHeight >= 0 && ball.BallDepth >=0 && ball.BallWidth < width && ball.BallHeight <height && ball.BallDepth < depth)
            {
                return true;
            }
            return false;
        }

        static void ReadInput()
        {
            string[] rawNumbers = Console.ReadLine().Split();
            width = int.Parse(rawNumbers[0]);
            depth = int.Parse(rawNumbers[1]);
            height = int.Parse(rawNumbers[2]);

            cube = new string[width, height, depth];
            //първо се обхожда по височината
            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContent = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }

            string[] rawBallCoords = Console.ReadLine().Split();
            int ballWidth = int.Parse(rawBallCoords[0]);
            int ballDepth = int.Parse(rawBallCoords[1]);

            cubeBall = new Ball (ballWidth,0,ballDepth);
        }
    }
}