using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
           const int rows = 3; 
           const int columns = 3;
        static void Main(string[] args)
        {
           Console.ForegroundColor = ConsoleColor.White;
           Console.WindowHeight = 40;
           
/*            const int rows = 3;
           const int columns = 3;
 */        int turnCount = 0;
           bool gameRunning = true;
           int player = 1;

           int gameWinner = new int();

           char[,] board = new char[rows,columns];
          // List<int> colCollection = new list<int>();
           
          
           Console.WriteLine("Welcome to Artun's Tic Tac Toe game!");
           Console.WriteLine("Player 1: X  Player 2: O");
           PrintBoard(board);
           
           while(gameRunning)
           {
               int selection = Convert.ToInt32(Console.ReadLine());

               int rowSelection = (selection - 1) / rows;
               int columnSelection = (selection - 1) % columns;
                 
                if(player == 1)
                {
                    if(board[rowSelection,columnSelection] != 'X' && board[rowSelection,columnSelection] != 'O')
                    {
                    board[rowSelection,columnSelection] = 'X';
                    turnCount++;
                    player = PlayerSwitch(player);
                    }
                    else
                    {
                        player = 1;
                    }
                }
                else if(player == 2)
                {
                    if(board[rowSelection,columnSelection] != 'X' && board[rowSelection,columnSelection] != 'O')
                    {
                    board[rowSelection,columnSelection] = 'O';
                    player = PlayerSwitch(player);
                    turnCount++;
                    }
                    else
                    {
                        player = 2;
                    }
                }

                    Console.Clear();
                    PrintBoard(board);
                //win conditions for player 1 
                if(board[0,0] == 'X' && board[0,1] == board[0,0] && board[0,2] == board[0,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[1,0] == 'X' && board[1,1] == board[1,0] && board[1,2] == board[1,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[2,0] == 'X' && board[2,1] == board[2,0] && board[2,2] == board[2,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[0,0] == 'X' && board[1,0] == board[0,0] && board[2,0] == board[0,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[0,1] == 'X' && board[1,1] == board[0,1] && board[2,1] == board[0,1])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[0,2] == 'X' && board[1,2] == board[0,2] && board[2,2] == board[0,1])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[0,0] == 'X' && board[1,1] == board[0,0] && board[2,2] == board[0,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                else if(board[0,2] == 'X' && board[1,1] == board[0,2] && board[2,0] == board[0,2])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                
                //win conditions for player 2
                if(board[0,0] == 'O' && board[0,1] == board[0,0] && board[0,2] == board[0,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[1,0] == 'O' && board[1,1] == board[1,0] && board[1,2] == board[1,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[2,0] == 'O' && board[2,1] == board[2,0] && board[2,2] == board[2,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[0,0] == 'O' && board[1,0] == board[0,0] && board[2,0] == board[0,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[0,1] == 'O' && board[1,1] == board[0,1] && board[2,1] == board[0,1])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[0,2] == 'O' && board[1,2] == board[0,2] && board[2,2] == board[0,1])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[0,0] == 'O' && board[1,1] == board[0,0] && board[2,2] == board[0,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                else if(board[0,2] == 'O' && board[1,1] == board[0,2] && board[2,0] == board[0,2])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                
                //in the case of a draw
                if(turnCount >= 9){
                    gameWinner = 3;
                    gameRunning = false;
                }


           }
            
            
            
                Console.Clear();
                if(gameWinner == 1)
                {
                    Console.WriteLine("Player 1 is the winner! Player 1 won after: " + turnCount + " turns.");
                    Console.WriteLine("Do you want to play again? type 'YES' if you do and type 'NO' to exit the game");
                    Console.ReadKey();
                }
                else if(gameWinner == 2)
                {
                    Console.WriteLine("Player 2 is the winner! Player 2 won after: " + turnCount + " turns.");
                    Console.WriteLine("Do you want to play again? type 'YES' if you do and type 'NO' to exit the game");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The game is a draw.");
                    Console.ReadKey();
                }
             

           
           
        }

        static void PrintBoard(char[,] board)
        {
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
                  Console.Write(board[row,col]);
                  Console.Write(" | ");
              }   
              Console.WriteLine();
           
              for (int lines2 = 0; lines2 < rows; lines2++)
              {
                  Console.Write("----");
              }
              Console.Write("-");
              Console.WriteLine();
           }

        }

        static int PlayerSwitch(int player)
        {
            if(player == 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
