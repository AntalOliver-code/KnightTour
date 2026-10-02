using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace KnightTour
{
    internal class Program
    {
        static void Move(int x, int y, List<int> memory, int board)
        {
            for (int i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0:
                        if (!memory.Contains((x + 2) + ((y + 1) * board)))
                        {
                            if ((x + 2 < board) && (y + 1 < board))
                            {
                                x += 2;
                                y += 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 1:
                        if (!memory.Contains((x + 2) + ((y - 1) * board)))
                        {
                            if ((x + 2 < board) && (y - 1 >= 0))
                            {
                                x += 2;
                                y -= 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 2:
                        if (!memory.Contains((x - 2) + ((y + 1) * board)))
                        {
                            if ((x - 2 >= 0) && (y + 1 < board))
                            {
                                x -= 2;
                                y += 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 3:
                        if (!memory.Contains((x - 2) + ((y - 1) * board)))
                        {
                            if ((x - 2 >= 0) && (y - 1 >= 0))
                            {
                                x -= 2;
                                y -= 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 4:
                        if (!memory.Contains(((y + 2) * board) + (x + 1)))
                        {
                            if ((y + 2 < board) && (x + 1 < board))
                            {
                                y += 2;
                                x += 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 5:
                        if (!memory.Contains(((y + 2) * board) + (x - 1)))
                        {
                            if ((y + 2 < board) && (x - 1 >= 0))
                            {
                                y += 2;
                                x -= 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 6:
                        if (!memory.Contains(((y - 2) * board) + (x + 1)))
                        {
                            if ((y - 2 >= 0) && (x + 1 < board))
                            {
                                y -= 2;
                                x += 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    case 7:
                        if (!memory.Contains(((y - 2) * board) + (x - 1)))
                        {
                            if ((y - 2 >= 0) && (x - 1 >= 0))
                            {
                                y -= 2;
                                x -= 1;
                                memory.Add(y * board + x);
                                Move(x, y, memory, board);
                            }
                        }
                        break;
                    default:
                        memory.RemoveAt(memory.Count() - 1);
                        y = memory.Last() / board;
                        x = memory.Last() - (y * board);
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            int board = 5;
            int x = 0;
            int y = 0;
            List<int> memory = new List<int>();
            memory.Add(0);
            Move(x, y, memory, board);
            Console.WriteLine(memory);
            Console.ReadLine();
        }
    }
}