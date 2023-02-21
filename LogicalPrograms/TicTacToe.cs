using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TicTacToe
    {
        static char[] arr = { '0','1', '2', '3', '4', '5', '6', '7', '8' };
        int player = 1; 
        int choice; 
        int flag = 0;
        public void play()
        {
            Random r = new Random();
            do
            {
                Console.WriteLine("Player1 is X and Player2 is O");
                Console.WriteLine();
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 plays");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Player 1 plays");
                    choice = r.Next(0, 9);
                }
                Console.WriteLine("");
                Board();
                
                
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("row already marked");
                    Console.WriteLine("\n");
                }
                flag = winner();
            }
            while (flag != 1 && flag != -1);
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      ");
        }
       
        private int winner()
        {
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return 1;
            }
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return 1;
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                return 1;
            }
            else if (arr[0] != '0' && arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
