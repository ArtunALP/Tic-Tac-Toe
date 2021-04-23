using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.ForegroundColor = ConsoleColor.White;
           Console.WindowHeight = 40;
           
           const int rows = 3;
           const int columns = 3;

           bool gameRunning = true;
           int player = 1;
           int turnNumber = 0;

           int gameWinner = new int();

           char[,] board = new char[rows,columns];
           
          
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
                    board[rowSelection,columnSelection] = 'X';
                    turnNumber ++;
                    player = PlayerSwitch(player);
                }
                else if(player == 2)
                {
                    board[rowSelection,columnSelection] = 'O';
                    turnNumber++;
                    player = PlayerSwitch(player);
                }

                    Console.Clear();
                    PrintBoard(board);
                //win conditions for player 1 
                if(board[0,0] == 'X' && board[0,1] == board[0,0] && board[0,2] == board[0,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                if(board[1,0] == 'X' && board[1,1] == board[1,0] && board[1,2] == board[1,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                if(board[2,0] == 'X' && board[2,1] == board[2,0] && board[2,2] == board[2,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                if(board[0,0] == 'X' && board[0,1] == board[0,0] && board[2,0] == board[0,0])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                if(board[0,1] == 'X' && board[1,1] == board[0,1] && board[2,1] == board[0,1])
                {
                    gameWinner = 1;
                    gameRunning = false;
                }
                if(board[0,2] == 'X' && board[1,2] == board[0,2] && board[2,2] == board[0,1])
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
                if(board[1,0] == 'O' && board[1,1] == board[1,0] && board[1,2] == board[1,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                if(board[2,0] == 'O' && board[2,1] == board[2,0] && board[2,2] == board[2,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                if(board[0,0] == 'O' && board[0,1] == board[0,0] && board[2,0] == board[0,0])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                if(board[0,1] == 'O' && board[1,1] == board[0,1] && board[2,1] == board[0,1])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
                if(board[0,2] == 'O' && board[1,2] == board[0,2] && board[2,2] == board[0,1])
                {
                    gameWinner = 2;
                    gameRunning = false;
                }
           }
            
/*             while(gameRunning == false)
            {
                Console.Clear();
                if(gameWinner == 1)
                {
                    Console.WriteLine("Player 1 is the winner!");
                    Console.WriteLine("Do you want to play again? type 'YES' if you do and type 'NO' to exit the game");
                    string p1r = Console.ReadLine();
                    if(p1r == "YES")
                    {
                        gameRunning = true;
                    }
                    else 
                    {
                        Console.ReadKey();
                    }
                }
                else if(gameWinner == 2)
                {
                    Console.WriteLine("Player 2 is the winner!");
                    Console.WriteLine("Do you want to play again? type 'YES' if you do and type 'NO' to exit the game");
                    string p2r = Console.ReadLine();
                    if(p2r == "YES")
                    {
                        gameRunning = true;
                    }
                    else 
                    {
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("The game is a draw.");
                    Console.WriteLine("Do you want to play again? type 'YES' if you do and type 'NO' to exit the game");
                    string nWr = Console.ReadLine();
                    if(nWr == "YES")
                    {
                        gameRunning = true;
                    }
                    else 
                    {
                        Console.ReadKey();
                    }
                }
            } */

           
           
        }

        static void PrintBoard(char[,] board)
        {
            for (int rows = 0; rows < 3; rows++)
            {
              Console.Write("| ");
              for (int columns = 0; columns < 3; columns++)
              {
                  Console.Write(board[rows,columns]);
                  Console.Write(" | ");
              }   
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
