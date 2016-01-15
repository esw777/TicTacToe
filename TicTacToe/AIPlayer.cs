using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class AIPlayer : Player
    {
        public AIPlayer(GameBoard gameBoard) : base(gameBoard)
        {

        }

        public override void takeTurn()
        {



            gameBoard.addPiece(0, 0, myGamePiece);
        }
    }
}
