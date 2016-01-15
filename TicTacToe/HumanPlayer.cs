using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(GameBoard gameBoard) : base(gameBoard)
        {
           
        }

        public override void takeTurn()
        {
            bool haveValidInput = false;
            int xPosUserInput = -1;
            int yPosUserInput = -1;

            do
            {
                gameBoard.printBoard();
                Console.WriteLine(myName + "'s Turn. Player symbol = " + myGamePiece + ".");
                Console.WriteLine("Enter a position to place your piece. Use format X,Y");

                string[] tmpStringArray = Console.ReadLine().Split(',');
                if (tmpStringArray.Length != 2)
                {
                    haveValidInput = false;
                    Console.WriteLine("Invalid Input, please use format X,Y.");
                }

                else
                {
                    if (Int32.TryParse(tmpStringArray[0], out xPosUserInput) && Int32.TryParse(tmpStringArray[1], out yPosUserInput))
                    {
                        if (gameBoard.addPiece(xPosUserInput-1, yPosUserInput-1, myGamePiece))
                        {
                            haveValidInput = true;
                        }

                        else
                        {
                            Console.WriteLine("Invalid board position");
                            haveValidInput = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input, please use format X,Y.");
                    }
                }
            } while (!haveValidInput);
        }
    }
}
