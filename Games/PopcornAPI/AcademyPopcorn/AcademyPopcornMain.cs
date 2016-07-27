using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 300);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            InitializeWalls(engine);

            InitializeBlocks(engine, startRow, startCol, endCol);

            InitializeBall(engine);

            InitializeRacket(engine);

            InitializeTestObject(engine);
        }

        private static void InitializeTestObject(Engine engine)
        {
            engine.AddObject(new TrailObject(new MatrixCoords(WorldRows / 2, WorldCols / 2)));
        }

        private static void InitializeWalls(Engine engine)
        {
            int ceillingRow = 0;
            for (int ceilingColumn = 0; ceilingColumn < WorldCols; ceilingColumn++)
            {
                var wallBlock = new IndestructibleBlock(new MatrixCoords(ceillingRow, ceilingColumn));

                engine.AddObject(wallBlock);
            }

            int leftMostColumn = 0;
            int rightMostColumn = WorldCols - 1;
            for (int sideROw = 1; sideROw < WorldRows; sideROw++)
            {
                var leftWallBlock = new IndestructibleBlock(new MatrixCoords(sideROw, leftMostColumn));
                var righttWallBlock = new IndestructibleBlock(new MatrixCoords(sideROw, rightMostColumn));

                engine.AddObject(leftWallBlock);
                engine.AddObject(righttWallBlock);
            }
        }

        private static void InitializeRacket(Engine engine)
        {
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        private static void InitializeBall(Engine engine)
        {
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);
        }

        private static void InitializeBlocks(Engine engine, int startRow, int startCol, int endCol)
        {
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }
        }

        
    }
}
