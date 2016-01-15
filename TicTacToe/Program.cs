using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPlayers = 0;
            bool validInput = false;

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            //get number of players
            while (!validInput)
            {
                Console.WriteLine("Enter number of players:");
                string tmpString = Console.ReadLine();
                if (Int32.TryParse(tmpString, out numPlayers))
                {
                    if (numPlayers > 0)
                        validInput = true;
                }

                else
                {
                    Console.WriteLine("Invalid Input");
                } 
            }

            //Starts the game.
            RoundManager roundManager = new RoundManager(numPlayers);
            roundManager.nextRound();
        }
    }
}
