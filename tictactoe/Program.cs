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
        static string[,] board = new string[3, 3]
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
                };
        static int rowLength = board.GetLength(0);
        static int colLength = board.GetLength(1);
        static void Main(string[] args)
        {
           
             int player = 1;
            #region InitializeBoard
            
            setBoard();

#endregion InitializeBoard


#region userInput


            do
            {
               
                if (player == 1)
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
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
                                player = 2;
                            }
                            break;
                        default:
                            Console.WriteLine("invalid selection");
                            break;
                    }
#region CheckForWinner
                  
                    if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                    {

                        Console.WriteLine("Player {0} wins", player -1);
                        player = 3;

                    }
                    else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
                    {

                        Console.WriteLine("Player {0} wins", player - 1);
                        player = 3;

                    }
                    else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
                    {

                        Console.WriteLine("Player {0} wins", player - 1);
                        player = 3;

                    }
                    else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                    {


                        Console.WriteLine("Player {0} wins", player - 1);
                        player = 3;

                    }
                    else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                    {

                        Console.WriteLine("Player {0} wins", player - 1);
                        player = 3;

                    }
                    
#endregion CheckForWinner

                

                }
                else if (player == 2)
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
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
                                player = 1;
                            }
                            break;
                        default:
                            Console.WriteLine("invalid selection");
                            break;
                    }

#region CheckForWinner
                   
                    if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                    {

                        Console.WriteLine("Player {0} wins", player +1);
                        player = 3;

                    }
                    else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
                    {

                        Console.WriteLine("Player {0} wins", player + 1);
                        player = 3;

                    }
                    else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
                    {

                        Console.WriteLine("Player {0} wins", player + 1);
                        player = 3;

                    }
                    else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                    {



                        Console.WriteLine("Player {0} wins", player + 1);
                        player = 3;

                    }
                    else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                    {

                        Console.WriteLine("Player {0} wins", player + 1);
                        player = 3;

                    }
                    
#endregion CheckForWinner

                }




#region SetUpdatedBoard
                for (int i = 0; i < rowLength; i++)
                {

                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write(" {0} ", board[i, j] + "\t");

                    }
                    Console.WriteLine();

                }
#endregion SetUpdatedBoard
                    ;
                
            }
            while (player != 3);
            
#endregion userInput
            Console.WriteLine("press key to exit");
            
            Console.ReadKey();
        }       
        

        public static void setBoard()
        {
            
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(" {0} ", board[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
