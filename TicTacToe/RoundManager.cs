using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    //Is able to keep track of score over multiple games.
    //Is responsible for setting up the players and creating a gameBoard each round.
    class RoundManager
    {
        int numPlayers;
        int numRounds;
        Player[] playerList;
        GameBoard gameBoard;

        public RoundManager(int numPlayers)
        {
            this.numPlayers = numPlayers;
            playerList = new Player[numPlayers];
        }

        //Starts a new game of tic tac toe.
        //Creates/resets the gameboard and keeps track of scores.
        public bool nextRound()
        {
            bool donePlaying = false;

            //Setup Board
            if (gameBoard == null)
                gameBoard = new GameBoard();
            else
                gameBoard.resetBoard();



            return donePlaying;
        }

        //Logic loop for taking turns until a winner is found.
        private void playGame()
        {
            bool roundOver = false;

            while (!roundOver)
            {
                playerList[0].takeTurn();
                roundOver = gameBoard.checkForWinner('X');
                gameBoard.printBoard();
                if (!roundOver)
                {
                    playerList[1].takeTurn();
                    roundOver = gameBoard.checkForWinner('O');
                    gameBoard.printBoard();
                }
            }


        }
    }
}
