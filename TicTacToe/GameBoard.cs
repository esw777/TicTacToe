using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameBoard
    {
        private int[,] gameBoard { get; }
        private int width { get; }
        private int height { get; }

        public GameBoard(int width = 3, int height = 3)
        {
            this.width = width;
            this.height = height;
            gameBoard = new int[width, height];
        }

        //Returns true if the piece was successfully added
        public bool addPiece(int x, int y, char playerPiece)
        {
            bool isValidMove = false;



            return isValidMove;
        }

        //Returns true if there are numberInARow playerPieces in a row on the gameBoard.
        public bool checkForWinner(char playerPiece, int numberInARow = 3)
        {
            bool winner = false;



            return winner;
        }

        //Resets the board to a new game state.
        public void resetBoard()
        {

        }

        //Prints gameBoard to console.
        public void printBoard()
        {


        }

    }
}
