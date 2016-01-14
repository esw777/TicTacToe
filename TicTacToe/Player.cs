using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        //Current gameBoard the player is playing on.
        protected GameBoard gameBoard;

        //Letter player is using to represent themselves.
        protected char myGamePiece { get; set; }

        //How many rounds this play has won.
        protected int myNumberOfRoundWins { get; set; } = 0;

        //constructor
        public Player(GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
        }

        //Prompts user for a spot on the board and Attempts to place piece on that spot.
        //loops until valid input from user.
        public virtual void takeTurn()
        {
            Console.WriteLine("Player:takeTurn - Someone did not override this default method.");
        }
    }
}
