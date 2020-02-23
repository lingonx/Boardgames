using System;

namespace NamespacePlayer
{
    class Player
    {
        /*OLD:A player keeps track of the type of player (X or O) 
        and the name of the player (if you want to display that).*/
        private string name;
        private char type;      //X or O

        public Player(string inName, char inType)
        {
            name = inName;
            type = inType;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public char Type
        {
            get => type;
            set => type = value;
        }
    }
}