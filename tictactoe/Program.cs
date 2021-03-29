using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start == true)
            {

            
            int player = 0;
            
            //initialize and display board

            string[,] board = new string[3, 3] 
            { 
                { "1", "2", "3" }, 
                { "4", "5", "6" }, 
                { "7", "8", "9" } 
            };

            int rowLength = board.GetLength(0);
            int colLength = board.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(" {0} ", board[i, j] + "\t");

                }
                Console.WriteLine();
            }

            for (int k = 0; k < 10; k++)
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 1: enter value to cross");
                    string value = Console.ReadLine();

                    switch (value)
                    {
                        case "1":
                            board[0, 0] = "X";
                            break;
                        case "2":
                            board[0, 1] = "X";
                            break;
                        case "3":
                            board[0, 2] = "X";
                            break;
                        case "4":
                            board[1, 0] = "X";
                            break;
                        case "5":
                            board[1, 1] = "X";
                            break;
                        case "6":
                            board[1, 2] = "X";
                            break;
                        case "7":
                            board[2, 0] = "X";
                            break;
                        case "8":
                            board[2, 1] = "X";
                            break;
                        case "9":
                            board[2, 2] = "X";
                            break;
                        default:
                            Console.WriteLine("invalid selection");
                            break;
                    }
                }
                else
                {

                    Console.WriteLine("Player 2: enter value to cross");
                    string value = Console.ReadLine();
                    switch (value)
                    {
                        case "1":
                            board[0, 0] = "O";
                            break;
                        case "2":
                            board[0, 1] = "O";
                            break;
                        case "3":
                            board[0, 2] = "O";
                            break;
                        case "4":
                            board[1, 0] = "O";
                            break;
                        case "5":
                            board[1, 1] = "O";
                            break;
                        case "6":
                            board[1, 2] = "O";
                            break;
                        case "7":
                            board[2, 0] = "O";
                            break;
                        case "8":
                            board[2, 1] = "O";
                            break;
                        case "9":
                            board[2, 2] = "O";
                            break;
                        default:
                            Console.WriteLine("invalid selection");
                            break;
                    }

                }
                    for (int i = 0; i < rowLength; i++)
                    {
                        for (int j = 0; j < colLength; j++)
                        {
                            Console.Write(" {0} ", board[i, j] + "\t");

                        }
                        Console.WriteLine();
                    }
                    

                    player++;
            }
           
                
            
                
             


            Console.Read();
            }

        }

        
    }
}
