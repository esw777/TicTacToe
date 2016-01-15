using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    //Is able to keep track of score over multiple games.
    //Is responsible for setting up the players and creating a gameBoard each round.
    public class RoundManager
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

            //Only Human players atm
            for (int i = 0; i < numPlayers; i++)
            {
                playerList[i] = new HumanPlayer(gameBoard);
            }

            do
            {
                playGame();

                Console.WriteLine("Play Another? (y/n)");
                if (Console.ReadLine().Equals("y"))
                {
                    donePlaying = false;
                    gameBoard.resetBoard();
                }

                else
                {
                    donePlaying = true;
                }

            } while (!donePlaying);

            return donePlaying;
        }

        //Logic loop for taking turns until a winner is found.
        private void playGame()
        {
            bool roundOver = false;
            int currentPlayer = -1;

            for (currentPlayer = 0; currentPlayer < playerList.Length && !roundOver; currentPlayer++)
            {
                playerList[currentPlayer].takeTurn();
                roundOver = gameBoard.checkForWinner();
                gameBoard.printBoard();

                //reset to player 1 if we run out of players.
                if (currentPlayer + 1 == playerList.Length)
                {
                    currentPlayer = -1;
                }
            }

            //Previous player won the game.
            if (currentPlayer > 0)
                currentPlayer--; 
            else if (currentPlayer == 0)
                currentPlayer = playerList.Length - 1;

            Console.WriteLine(playerList[currentPlayer].myName + "Wins!");
        }
    }
}
