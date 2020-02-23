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
        TTT_Board b = new TTT_Board();

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


    }
}
