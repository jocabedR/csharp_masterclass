using System.Numerics;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] Grid =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        static void Main(string[] args)
        {
            int turn = 1;
            char player;

            do {
                if (turn % 2 == 0) player = 'O';
                else player = 'X';

                Game(player);

                if (Checker(player))
                {
                    Console.WriteLine("{0} has won!!!", player);
                    break;
                }
                if (turn == 9) {
                    Console.WriteLine("There is no winner, can you play again! c;");
                    break;
                }
                turn++;
            } while (true);
            Console.ReadLine();
        }

        static void Game(char player) {
            PrintGrid();
            Console.WriteLine("\nPlayer {0}'s turn.", player);
            Console.WriteLine("Plis choose a cell: ");
            char cell = Console.ReadLine()[0];
            bool cellFounded = false;

            if (Char.IsDigit(cell)) {
                for (int i = 0; i < Grid.GetLength(0); i++)
                {
                    for (int j = 0; j < Grid.GetLength(1); j++)
                    {
                        if (Grid[i, j] == 'X' || Grid[i, j] == 'O') {
                            Console.WriteLine("\nThe cell is already full.");
                            Game(player);
                        }
                        if (Grid[i,j] == cell) {
                            Grid[i, j] = player;
                            cellFounded = true;
                            break;
                        }
                    }

                    if (cellFounded) break;
                }
            } else
            {
                Console.WriteLine("Wrong input.");
                Game(player);
            }
        }

        public static bool Checker(char player) {
            //horizontal
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                if (Grid[i, 0] == Grid[i, 1]
                    && Grid[i, 0] == Grid[i, 2]
                    && Grid[i, 2] == player) return true;
            }

            //vertical
            for (int i = 0; i < Grid.GetLength(1); i++)
            {
                if (Grid[0, i] == Grid[1, i]
                    && Grid[1, i] == Grid[2, i]
                    && Grid[2, i] == player) return true;
            }

            //diagonal
            if (Grid[0, 0] == Grid[1, 1] && Grid[1, 1] == Grid[2, 2] && Grid[2, 2] == player) return true;
            if (Grid[0, 2] == Grid[1, 1] && Grid[1, 1] == Grid[2, 0] && Grid[2, 0] == player) return true;

            return false;
        }

        public static void PrintGrid() {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                Console.WriteLine(" ___  ___  ___ ");
                Console.WriteLine("|_{0}_||_{1}_||_{2}_|", Grid[i,0], Grid[i, 1], Grid[i, 2]);
            }
        }
    }
}