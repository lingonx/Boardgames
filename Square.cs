using System;

namespace TicTacToe
{
    class Square
    {
        /*A square can have 3 states: empty, X, or O.*/
        private char state; //empty, X, or O
        public char State
        {
            get => state;
            set => state = value;
        }

    }
}
