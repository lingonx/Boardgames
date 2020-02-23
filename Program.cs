using System;
using TicTacToe;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToe = new TicTacToeGame();
            Console.WriteLine("Game to play: " + ticTacToe.Name());
            Console.WriteLine("y/n");

        }
    }
}
