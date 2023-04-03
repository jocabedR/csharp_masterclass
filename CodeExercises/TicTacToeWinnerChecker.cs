using System;

namespace Coding.Exercise
{
    public class TicTacToe
    {
        public static bool Checker(string[,] board)
        {
            //horizontal
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1]
                    && board[i, 0] == board[i, 2]) return true;
            }

            //vertical
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] == board[1, i]
                    && board[1, i] == board[2, i]) return true;
            }

            //diagonal
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;

            return false;
        }
    }
}
