using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace tictactoe
{
    class Program
    {     
        static void Main(string[] args)
        {
            bool done = false;

           

                int player = 0;
#region InitializeBoard
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
#endregion InitializeBoard

            do
            {
#region userInput
                

                for (int k = 0; k < 10; k++)
                {
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 1: enter value to cross");
                        string value = Console.ReadLine();

                        switch (value)
                        {
                            case "1":

                                if (board[0, 0].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[0, 0] = "X";
                                    player++;
                                }
                                break;
                            case "2":
                                if (board[0, 1].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[0, 1] = "X";
                                    player++;
                                }
                                break;
                            case "3":
                                if (board[0, 2].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[0, 2] = "X";
                                    player++;
                                }
                                break;
                            case "4":
                                if (board[1, 0].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[1, 0] = "X";
                                    player++;
                                }
                                break;
                            case "5":
                                if (board[1, 1].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[1, 1] = "X";
                                    player++;
                                }
                                break;
                            case "6":
                                if (board[1, 2].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[1, 2] = "X";
                                    player++;
                                }
                                break;
                            case "7":
                                if (board[2, 0].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[2, 0] = "X";
                                    player++;
                                }
                                break;
                            case "8":
                                if (board[2, 1].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[2, 1] = "X";
                                    player++;
                                }
                                break;
                            case "9":
                                if (board[2, 2].Equals("O"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[2, 2] = "X";
                                    player++;
                                }
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
                                if (board[0, 0].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[0, 0] = "O";
                                    player++;
                                }
                                break;
                            case "2":
                                if (board[0, 1].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[0, 1] = "O";
                                    player++;
                                }
                                break;
                            case "3":
                                if (board[0, 2].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[0, 2] = "O";
                                    player++;
                                }
                                break;
                            case "4":
                                if (board[1, 0].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[1, 0] = "O";
                                    player++;
                                }
                                break;
                            case "5":
                                if (board[1, 1].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[1, 1] = "O";
                                    player++;
                                }
                                break;
                            case "6":
                                if (board[1, 2].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[1, 2] = "O";
                                    player++;
                                }
                                break;
                            case "7":
                                if (board[2, 0].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[2, 0] = "O";
                                    player++;
                                }
                                break;
                            case "8":
                                if (board[2, 1].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[2, 1] = "O";
                                    player++;
                                }
                                break;
                            case "9":
                                if (board[2, 2].Equals("X"))
                                {
                                    Console.WriteLine("number already taken");
                                }
                                else
                                {
                                    board[2, 2] = "O";
                                    player++;
                                }
                                break;
                            default:
                                Console.WriteLine("invalid selection");
                                break;
                        }

                    }

#region SetUpdatedBoard
                    for (int i = 0; i < rowLength; i++)
                    {
                        Console.WriteLine(done);
                        for (int j = 0; j < colLength; j++)
                        {
                            Console.Write(" {0} ", board[i, j] + "\t");

                        }
                        Console.WriteLine();

                    }
#endregion SetUpdatedBoard
#region CheckForWinner
                    //check for winner
                    if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                    {

                        Console.WriteLine("endgame");
                        
                        done = true;
                        Console.WriteLine(done);
                    }
                    if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
                    {

                        Console.WriteLine("endgame");

                        done = true;
                        Console.WriteLine(done);
                    }
                    if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
                    {

                        Console.WriteLine("endgame");

                        done = true;
                        Console.WriteLine(done);
                    }
                    if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                    {

                        Console.WriteLine("endgame");

                        done = true;
                        Console.WriteLine(done);
                    }
                    if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                    {

                        Console.WriteLine("endgame");

                        done = true;
                        Console.WriteLine(done);
                    }
#endregion CheckForWinner

                }
                #endregion userInput
            } while (done == false);
                Console.Read();                      
        }                     
    }
}
