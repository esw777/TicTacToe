using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        //Current gameBoard the player is playing on.
        protected GameBoard gameBoard;

        //Letter player is using to represent themselves.
        public char myGamePiece { get; private set; }

        //Name of player
        public string myName { get; private set; }

        //How many rounds this play has won.
        public int myNumberOfRoundWins { get; set; } = 0;

        //constructor
        public Player(GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
            setupNameAndPiece();
        }

        private void setupNameAndPiece()
        {
            Console.WriteLine("Enter name for this player: ");
            this.myName = Console.ReadLine();
            Console.WriteLine("Enter symbol for " + myName);
            this.myGamePiece = Console.ReadLine().ToCharArray()[0];
        }

        //Prompts user for a spot on the board and Attempts to place piece on that spot.
        //loops until valid input from user.
        public virtual void takeTurn()
        {
            Console.WriteLine("Player:takeTurn - Someone did not override this default method.");
        }
    }
}
