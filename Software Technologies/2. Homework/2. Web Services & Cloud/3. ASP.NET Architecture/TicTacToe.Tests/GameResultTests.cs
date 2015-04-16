namespace TicTacToe.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TicTacToe.GameLogic;

    [TestClass]
    public class GameResultTests
    {
        private IGameResultValidator validator;

        [TestInitialize]
        public void InitializeGameResultValidator()
        {
            this.validator = new GameResultValidator();
        }

        [TestMethod]
        public void FirstPlayerWinsByRightDiagonal()
        {
            var expectedResult = GameResult.WonByX;
            var board = "XO-OX---X";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsByRightDiagonal()
        {
            var expectedResult = GameResult.WonByO;
            var board = "OXXXO---O";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsByLeftDiagonal()
        {
            var expectedResult = GameResult.WonByX;
            var board = "OOXXXOXOX";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsByLeftDiagonal()
        {
            var expectedResult = GameResult.WonByO;
            var board = "XXO-OXOXO";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsByFirstHorizontal()
        {
            var expectedResult = GameResult.WonByX;
            var board = "XXXOO----";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsBySecondHorizontal()
        {
            var expectedResult = GameResult.WonByX;
            var board = "OO-XXX---";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsByThirdHorizontal()
        {
            var expectedResult = GameResult.WonByX;
            var board = "OO-XO-XXX";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsByFirstVertical()
        {
            var expectedResult = GameResult.WonByX;
            var board = "X--X--XOO";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsBySecondVertical()
        {
            var expectedResult = GameResult.WonByX;
            var board = "OXOXXOOXX";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstPlayerWinsByThirdVertical()
        {
            var expectedResult = GameResult.WonByX;
            var board = "-OX-OX--X";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsByFirstHorizontal()
        {
            var expectedResult = GameResult.WonByO;
            var board = "OOOXX---X";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsBySecondHorizontal()
        {
            var expectedResult = GameResult.WonByO;
            var board = "XX-OOO--X";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsByThirdHorizontal()
        {
            var expectedResult = GameResult.WonByO;
            var board = "XX-X--OOO";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsByFirstVertical()
        {
            var expectedResult = GameResult.WonByO;
            var board = "OX-O--OXX";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsBySecondVertical()
        {
            var expectedResult = GameResult.WonByO;
            var board = "XOXOOXXOX";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondPlayerWinsByThirdVertical()
        {
            var expectedResult = GameResult.WonByO;
            var board = "-XO-XOX-O";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DrawCheck()
        {
            var expectedResult = GameResult.Draw;
            var board = "XOXXXOOXO";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NotFinishedCheck()
        {
            var expectedResult = GameResult.NotFinished;
            var board = "-X-O-----";

            var actualResult = this.validator.GetResult(board);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}