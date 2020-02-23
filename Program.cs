using System;
using TicTacToe;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame g = new TicTacToeGame();
            Console.WriteLine("Välkommen till " + g.Name());

        }
    }
}
