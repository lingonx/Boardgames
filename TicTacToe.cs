using System;

namespace TicTacToe
{
    /*Creates an instance of a board, 
    two players and keeps track of whose turn it is. 
    The game will be responsible for making a move on 
    the board and making sure that the move is valid. 
    Also, it will be able to identify when someone has won*/

    class TicTacToeGame
    {
        

        public TicTacToeGame()
        {
            
        }
        public string Name(){
            return "Tic tac toe";
        }
        public string WhosTurn()
        {
            //Fix
            return "SPELARE 1 ELLER SPELARE 2???";
        }
        public string EndOfGame()
        {
            //Fix get status from board 
            return "SPELARE 1 ELLER SPELARE 2???";
        }
        public bool move() //param x,y square?
        {
            
            if(moveIsValid())
            {
                //fix move logic
                return true;
            }
            return false;
        }
        private bool moveIsValid()
        {
            //fix
            return false;
        }

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
