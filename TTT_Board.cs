using System;

namespace TicTacToe
{
    class TTT_Board
    {
        /*
        Creates a 2 dimensional array of new square objects (details about square.js below).
        The board is a state machine, which means that it keeps tracks of different game states.
        The possible states of the board are:
            PLAYING 
            X_WINS
            O_WINS
            TIE
        The board can tell you if a square is empty and can also check if someone has won or tied the game.
        */   
        Square[,] board = new Square[3, 3];
        public bool EndOfGame()
        {
            //Fix returning true/false/null (null=tie?)
            return false;
        }
        public string isEmptySquare()
        {
            return "Oklart??";
        }
        public Square[,] State()
        {
            //returns array board 
            return board;
        }


    }
}