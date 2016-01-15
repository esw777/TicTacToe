using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe;

namespace UnitTest
{
    class UnitTest
    {
        public UnitTest()
        {
            
        }

        public bool runAllTests()
        {
            bool result = true;

            if (!gameBoardTests())
            {
                result = false;
                Console.WriteLine("GameBoardTests FAILED");
            }

            //Commented out because it requires manual input.
        /*
            if (!humanPlayerTests())
            {
                result = false;
                Console.WriteLine("HumanPlayerTests FAILED");
            }
        */

            if (result)
            {
                Console.WriteLine("\nAll tests PASS");
            }

            else
            {
                Console.WriteLine("\nAll tests FAILED");
            }
            return result;
        }
        
        public bool gameBoardTests()
        {
            bool result = true;

            #region printBoardTests
            GameBoard gameBoard = new GameBoard();
            gameBoard.printBoard();

            GameBoard gameBoard2 = new GameBoard(5,5);
            gameBoard2.printBoard();

            GameBoard gameBoard3 = new GameBoard(3, 5);
            gameBoard3.printBoard();
            #endregion

            #region addPieceTests
            //AddPiece Test 1 - add a valid piece in valid position
            gameBoard.addPiece(0,0,'P');
            if (gameBoard.getGameBoard()[0,0] != 'P')
            {
                result = false;
                Console.WriteLine("AddPiece Test 1 failed  " + gameBoard.getGameBoard()[0,0]);
            }
            //AddPiece Test 2 - add a valid piece in an invalid position
            if (gameBoard.addPiece(4, 4, 'P'))
            {
                result = false;
                Console.WriteLine("AddPiece Test 2 failed");
            }
            //AddPiece test 3 - verify adding on bigger boards works.
            if (!gameBoard2.addPiece(4,4,'5'))
            {
                result = false;
                Console.WriteLine("AddPiece Test 3 failed");
            }
            #endregion
            #region resetBoardTests
            //ResetBoard test 1 - verify board is reset properly.
            gameBoard.resetBoard();
            gameBoard.addPiece(1, 1,'X');
            gameBoard.resetBoard();
            if (gameBoard.getGameBoard()[1,1] == 'X')
            {
                result = false;
                Console.WriteLine("ResetBoard test 1 failed");
            }
            #endregion
            #region CheckForWinnerTests
            //CheckForWinner Test 1 - top horizontal row winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 0, 'X');
            gameBoard.addPiece(1, 0, 'X');
            gameBoard.addPiece(2, 0, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 1 failed");
            }
            //CheckForWinner Test 2 - top horizontal row no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 0, 'X');
            gameBoard.addPiece(1, 0, 'O');
            gameBoard.addPiece(2, 0, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 2 failed");
            }

            //CheckForWinner Test 3 - middle horizontal row winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 1, 'X');
            gameBoard.addPiece(1, 1, 'X');
            gameBoard.addPiece(2, 1, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 3 failed");
            }
            //CheckForWinner Test 4 - middle horizontal row no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 1, 'X');
            gameBoard.addPiece(1, 1, 'O');
            gameBoard.addPiece(2, 1, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 4 failed");
            }

            //CheckForWinner Test 5 - bottom horizontal row winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 2, 'X');
            gameBoard.addPiece(1, 2, 'X');
            gameBoard.addPiece(2, 2, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 5 failed");
            }
            //CheckForWinner Test 6 - bottom horizontal row no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 2, 'X');
            gameBoard.addPiece(1, 2, 'O');
            gameBoard.addPiece(2, 2, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 6 failed");
            }

            //CheckForWinner Test 7 - left vertical column winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 0, 'X');
            gameBoard.addPiece(0, 1, 'X');
            gameBoard.addPiece(0, 2, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 7 failed");
            }
            //CheckForWinner Test 8 - left vertical column no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 0, 'X');
            gameBoard.addPiece(1, 0, 'O');
            gameBoard.addPiece(2, 0, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 8 failed");
            }

            //CheckForWinner Test 9 - middle vertical column winner
            gameBoard.resetBoard();
            gameBoard.addPiece(1, 0, 'X');
            gameBoard.addPiece(1, 1, 'X');
            gameBoard.addPiece(1, 2, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 9 failed");
            }
            //CheckForWinner Test 10 - middle vertical column no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 1, 'X');
            gameBoard.addPiece(1, 1, 'O');
            gameBoard.addPiece(2, 1, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 10 failed");
            }

            //CheckForWinner Test 11 - right vertical column winner
            gameBoard.resetBoard();
            gameBoard.addPiece(2, 0, 'X');
            gameBoard.addPiece(2, 1, 'X');
            gameBoard.addPiece(2, 2, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 11 failed");
            }
            //CheckForWinner Test 12 - right vertical column no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 2, 'X');
            gameBoard.addPiece(1, 2, 'O');
            gameBoard.addPiece(2, 2, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 12 failed");
            }

            //CheckForWinner Test 13 - diagonal top left to bottom right winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 0, 'X');
            gameBoard.addPiece(1, 1, 'X');
            gameBoard.addPiece(2, 2, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 13 failed");
            }
            //CheckForWinner Test 14 - diagonal top left to bottom right no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(0, 0, 'X');
            gameBoard.addPiece(1, 1, 'O');
            gameBoard.addPiece(2, 2, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 14 failed");
            }

            //CheckForWinner Test 15 - diagonal bottom left to top right winner
            gameBoard.resetBoard();
            gameBoard.addPiece(2, 0, 'X');
            gameBoard.addPiece(1, 1, 'X');
            gameBoard.addPiece(0, 2, 'X');
            if (!gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 15 failed");
            }
            //CheckForWinner Test 16 - diagonal bottom left to top right no winner
            gameBoard.resetBoard();
            gameBoard.addPiece(2, 0, 'X');
            gameBoard.addPiece(1, 1, 'O');
            gameBoard.addPiece(0, 2, 'X');
            if (gameBoard.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 16 failed");
            }

            //CheckForWinner Test 17 - middle vertical row winner non 3x3
            gameBoard2.resetBoard();
            gameBoard2.addPiece(0, 0, 'X');
            gameBoard2.addPiece(0, 1, 'X');
            gameBoard2.addPiece(0, 2, 'X');
            gameBoard2.addPiece(0, 3, 'X');
            gameBoard2.addPiece(0, 4, 'X');
            if (!gameBoard2.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 17 failed");
            }
            //CheckForWinner Test 18 - middle vertical row no winner non 3x3
            gameBoard2.resetBoard();
            gameBoard2.addPiece(0, 0, 'X');
            gameBoard2.addPiece(0, 1, 'X');
            gameBoard2.addPiece(0, 2, 'X');
            gameBoard2.addPiece(0, 3, 'O');
            gameBoard2.addPiece(0, 4, 'X');
            if (gameBoard2.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 18 failed");
            }
            //CheckForWinner Test 19 - diagonal top left to bottom right winner non 3x3
            gameBoard2.resetBoard();
            gameBoard2.addPiece(0, 0, 'X');
            gameBoard2.addPiece(1, 1, 'X');
            gameBoard2.addPiece(2, 2, 'X');
            gameBoard2.addPiece(3, 3, 'X');
            gameBoard2.addPiece(4, 4, 'X');
            if (!gameBoard2.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 19 failed");
            }

            //CheckForWinner Test 20 - diagonal top left to bottom right no winner non 3x3
            gameBoard2.resetBoard();
            gameBoard2.addPiece(0, 0, 'X');
            gameBoard2.addPiece(1, 1, 'X');
            gameBoard2.addPiece(2, 2, 'O');
            gameBoard2.addPiece(3, 3, 'X');
            gameBoard2.addPiece(4, 4, 'X');
            if (gameBoard2.checkForWinner())
            {
                result = false;
                Console.WriteLine("CheckForWinner Test 20 failed");
            }
            #endregion

            return result;
        } //end GameBoardTests

        public bool humanPlayerTests()
        {
            bool result = true;
            bool doneTesting = false;

            GameBoard gameBoard = new GameBoard();
            Player player1 = new HumanPlayer(gameBoard);

            while (!doneTesting)
            {
                player1.takeTurn();
                gameBoard.printBoard();

                Console.WriteLine("Continue testing Human input? (y/n)");
                if (Console.ReadLine().Equals("n"))
                {
                    doneTesting = true;
                }
            }
            

            return result;
        }

    }//end class unit test
}//end namespace UnitTest
