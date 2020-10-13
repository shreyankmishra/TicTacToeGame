using System;

namespace TicTacToeGame
{
    class TicTacToeGameClass
    {
        static void Main(string[] args)
        {
            char[] board = CreationBoard();
        }
        public static char[] CreationBoard()
        {
            char[] board = new char[10];
            for(int j=0; j<board.Length; j++)
            {
                board[j] = ' ';
            }
            return board;
        }
    }
}
