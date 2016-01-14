using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class HumanPlayer : Player
    {
        public HumanPlayer(GameBoard gameBoard) : base(gameBoard)
        {
           
        }

        public override void takeTurn()
        {



            gameBoard.addPiece(0, 0, myGamePiece);
        }
    }
}
