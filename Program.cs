using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static int rows;
        static int columns;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 40;

            Console.WriteLine("input a number which will be the dimensions of your board.");
            // int dimensions = Int32.Parse(Console.ReadLine());
            rows = Int32.Parse(Console.ReadLine());
            columns = Int32.Parse(Console.ReadLine());
            //columns = Int32.Parse(Console.ReadLine());
            Console.Clear();

            int turnCount = 0;
            bool gameRunning = true;
            char player = 'X';

            char gameWinner = new char();

            char[,] board = new char[rows, columns];
            // List<int> colCollection = new list<int>();

            Console.WriteLine("Welcome to Artun's Tic Tac Toe game!");
            Console.WriteLine("Player 1: X  Player 2: O");

            while (gameRunning)
            {
                PrintBoard(board);
                int selection = Convert.ToInt32(Console.ReadLine()); //user input

                int rowSelection = (selection - 1) / columns;
                int columnSelection = (selection - 1) % columns;

                if (selection <= rows * columns && selection > 0) 
                {
                    if (board[rowSelection, columnSelection] != 'X' && board[rowSelection, columnSelection] != 'O')
                    {
                        board[rowSelection, columnSelection] = player;
                        turnCount++;
                    }
                } //place character


                //determine winner
                bool filled = false;

                for (int i = 0; !filled && i < rows; i++) //check for horizontal win
                {
                    filled = true;
                    for (int j = 0; j < columns; j++)
                    {
                        if (board[i, j] != player)
                        {
                            filled = false;
                            break;
                        }
                    }
                }

                for (int j = 0; !filled && j < columns; j++) //check for vertical win
                {
                    filled = true;
                    for (int i = 0; i < rows; i++)
                    {
                        if (board[i, j] != player)
                        {
                            filled = false;
                            break;
                        }
                    }
                }

                if(rows == columns) //only check diagonals if rows == columns
                {
                    filled = true;
                    for (int i = 0; i < rows; i++) // check for diagonal top left to bottom right
                    {
                        if(board[i,i] != player)
                        {
                            filled = false;
                            break;
                        }
                    }
                    if (filled == false)
                    {
                        filled = true;
                        for (int i = 0; i < rows; i++) // check for diagonal top right to bottom left
                        {
                            if (board[i, (columns - 1) - i] != player)
                            {
                                filled = false;
                                break;
                            }
                        }
                    }
                } 
                if (filled) //determine winner
                {
                    gameRunning = false;
                    gameWinner = player;
                }

                else if (turnCount >= rows * columns && gameRunning == false) //in the case of a draw
                {
                    gameRunning = false;
                    gameWinner = '0';
                } 

                player = PlayerSwitch(player);
                Console.Clear();
                
            }  // while

            Console.Clear();

            if (gameWinner == 'X')
            {
                Console.WriteLine("Player 1 is the winner! Player 1 won after: " + turnCount + " turns.");
                Console.ReadKey();
            }
            else if (gameWinner == 'O')
            {
                Console.WriteLine("Player 2 is the winner! Player 2 won after: " + turnCount + " turns.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The game is a draw. (" + turnCount + " turns)");
                Console.ReadKey();
            }

        }//main funcion

        static void PrintBoard(char[,] board)
        {
            //lines at the top of the board
            for (int lines = 0; lines < columns; lines++)
            {
                Console.Write("----");
            }
            Console.Write("-");
            Console.WriteLine();


            for (int row = 0; row < rows; row++)
            {
                Console.Write("| ");

                for (int col = 0; col < columns; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();

                //Lines at the bottom of the '|'
                for (int lines2 = 0; lines2 < columns; lines2++)
                {
                    Console.Write("----");
                }
                Console.Write("-");
                Console.WriteLine();
            }
          

        }//printboard funcion

        static char PlayerSwitch(char player)
        {
            if (player == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }//playerswitch funciton
    }
}
