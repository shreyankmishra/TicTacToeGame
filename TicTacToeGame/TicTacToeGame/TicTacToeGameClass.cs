using System;

namespace TicTacToeGame
{
    class TicTacToeGameClass
    {
        static void Main(string[] args)
        {
            char[] board = CreationBoard();
            char userLetterChoice = ChooseUserLetter();
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
        public static char ChooseUserLetter()
        {
            while (true)
            {
                Console.WriteLine("Choose a letter between X and O");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'x' || choice == 'X' || choice == 'o' || choice == 'O')
                {
                    Console.WriteLine("User Choice is " + char.ToUpper(choice));
                    return char.ToUpper(choice);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}
