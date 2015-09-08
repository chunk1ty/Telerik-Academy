namespace TicTacToe.GameLogic
{
    using TicTacToe.Models;

    public class GameResultValidator : IGameResultValidator
    {
        // O-X
        // O-X
        // --X
        public GameResult GetResult(string board)
        {
            //horizontal
            if (board[0] != '-' && board[0] == board[1] && board[1] == board[2])
            {
                return board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[3] != '-' && board[3] == board[4] && board[4] == board[5])
            {
                return board[3] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[6] != '-' && board[6] == board[7] && board[7] == board[8])
            {
                return board[6] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            //vertical
            if (board[0] != '-' && board[0] == board[3] && board[3] == board[6])
            {
                return board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[1] != '-' && board[1] == board[4] && board[4] == board[7])
            {
                return board[1] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[2] != '-' && board[2] == board[5] && board[5] == board[8])
            {
                return board[2] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            //diagonals
            if (board[0] != '-' && board[0] == board[4] && board[4] == board[8])
            {
                return board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[6] != '-' && board[6] == board[4] && board[4] == board[2])
            {
                return board[6] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board.Contains("-"))
            {
                return GameResult.NotFinished;
            }

            return GameResult.Draw;
        }
    }
}
