using System;

namespace TicTacToeGame
{
    class TicTacToeGameClass
    {
        static void Main(string[] args)
        {
            char[] board = CreationBoard();
            char userLetterChoice = ChooseUserLetter();
            ShowBoard(board);
            int index = UserMakeMove(board);
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
        public static void ShowBoard(char[] board)
        {
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("\n" + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("\n" + board[7] + " | " + board[8] + " | " + board[9]);
        }
         public static int UserMakeMove(char[] board)
            {
                Console.WriteLine("Enter the index from 1 to 9");
                int index = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (board[index] == ' ' && index>=1 && index<=9)
                    {
                        Console.WriteLine("Index is valid and free.");
                        return index;
                    }
                    else
                    {
                        Console.WriteLine("Index is invalid or not free.");
                    }
                }
            }
    }
}
