using System;
using NamespaceSquare;
using NamespaceBoard;

namespace NamespaceBoard
{
    class Board
    {
        /*OLD:Creates an instance of a board, 
        two players and keeps track of whose turn it is. 
        The game will be responsible for making a move on 
        the board and making sure that the move is valid. 
        Also, it will be able to identify when someone has won*/
        private int x, y;

        public Board(int inx, int iny)
        {
            x = inx;
            y = iny;
            Board[,] board = new Board[x,y];
        }
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }

        

    }
}