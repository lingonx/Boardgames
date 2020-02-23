using System;

namespace TicTacToe
{
    /*OLD:Creates a 2 dimensional array of new square objects (details about square.js below).
        The board is a state machine, which means that it keeps tracks of different game states.
        The possible states of the board are:
            PLAYING 
            X_WINS
            O_WINS
            TIE
        The board can tell you if a square is empty and can also check if someone has won or tied the game.
     */   

    class TicTacToeGame
    {
        
         //public Square[,] board = new Square[3, 3];

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
        public string isEmptySquare()
        {
            return "Oklart??";
        }
        /*public Square[,] State()
        {
            //returns array board 
            return board[,];
        }*/
    }
}
