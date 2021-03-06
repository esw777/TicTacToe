﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameBoard
    {
        private char emptySpaceChar = ' ';
        private char[,] gameBoard { get;}
        public int width { get; private set; }
        public int height { get; private set; }
        private int turnsTaken { get; set; }

        public GameBoard(int width = 3, int height = 3)
        {
            this.width = width;
            this.height = height;
            gameBoard = new char[width, height];
            resetBoard();
        }

        public GameBoard(GameBoard in_gameBoard)
        {
            this.width = in_gameBoard.width;
            this.height = in_gameBoard.height;
            gameBoard = in_gameBoard.getGameBoard();
            resetBoard();
        }

        //Returns true if the piece was successfully added
        public bool addPiece(int x, int y, char playerPiece)
        {
            bool isValidMove = false;

            if (x >= width || x < 0 || y >= height || y < 0 || !gameBoard[x,y].Equals(emptySpaceChar))
            {
                isValidMove = false;
                Console.WriteLine("AddPiece: Invalid piece position");
            }

            else
            {
                gameBoard[x, y] = playerPiece;
                isValidMove = true;
            }

            if (isValidMove)
            {
                turnsTaken++;
            }

            return isValidMove;
        }

        public bool checkForDraw()
        {
            bool result = false;

            if (turnsTaken == width * height)
            {
                result = true;
            }

            return result;
        }

        //Returns true if there are numberInARow playerPieces in a row on the gameBoard.
        public bool checkForWinner()
        {
            bool winner = false;
            bool WinnerOnLine = true;

            //Horizontal
            for (int y = 0; y < height && !winner; y++)
            {
                WinnerOnLine = true;
                for (int x = 1; x < width; x++)
                {
                    if (gameBoard[x, y].Equals(emptySpaceChar) || !gameBoard[x,y].Equals(gameBoard[0, y]))
                    {
                        WinnerOnLine = false;
                    }
                }

                winner = WinnerOnLine;
            }

            //Vertical
            WinnerOnLine = true;
            for (int x = 0; x < width && !winner; x++)
            {
                WinnerOnLine = true;
                for (int y = 1; y < height; y++)
                {
                    if (gameBoard[x, y].Equals(emptySpaceChar) || !gameBoard[x, y].Equals(gameBoard[x, 0]))
                    {
                        WinnerOnLine = false;
                    }
                }

                winner = WinnerOnLine;
            }

            //Diagonal top left to bot right
            WinnerOnLine = true;
            for (int x = 1, y = 1; x < width && y < height && !winner; x++, y++)
            { 
                if (gameBoard[x, y].Equals(emptySpaceChar) || !gameBoard[x, y].Equals(gameBoard[0, 0]))
                {
                    WinnerOnLine = false;
                }
            }
            winner = WinnerOnLine;

            //Diagonal bot left to top right
            WinnerOnLine = true;
            for (int x = 1, y = height-2; x < width && y > 0 && !winner; x++, y--)
            {
                if (gameBoard[x, y].Equals(emptySpaceChar) || !gameBoard[x, y].Equals(gameBoard[width-1, 0]))
                {
                    WinnerOnLine = false;
                }
            }
            winner = WinnerOnLine;

            return winner;
        }

        //Resets the board to a new game state.
        public void resetBoard()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    gameBoard[x, y] = emptySpaceChar;
                }
            }
            turnsTaken = 0;
        }

        //Prints gameBoard to console.
        public void printBoard()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(gameBoard[x, y]);

                    if (x + 1 != width)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();

                if (y + 1 != height)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write("--");
                    }
                }

                Console.WriteLine();
            }

        }

        //Returns a copy of the gameboard
        public char[,] getGameBoard()
        {
            return gameBoard;
        }
    }
}
