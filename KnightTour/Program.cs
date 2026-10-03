using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnightTour
{
    public static class MyVariables
    {
        public static int x = 0;
        public static int y = 0;
        public static int board = 0;
        public static List<int> memory = new List<int>();
    }
    internal class Program
    {

        static void Move()
        {
            for (int i = 0; i < 9; i++)
            {
                if (MyVariables.memory.Count() == MyVariables.board * MyVariables.board)
                {
                    return;
                }
                switch (i)
                {
                    case 0:
                        if (!MyVariables.memory.Contains((MyVariables.x + 2) + ((MyVariables.y + 1) * MyVariables.board)))
                        {
                            if ((MyVariables.x + 2 < MyVariables.board) && (MyVariables.y + 1 < MyVariables.board))
                            {
                                MyVariables.x += 2;
                                MyVariables.y += 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();

                            }
                        }
                        break;
                    case 1:
                        if (!MyVariables.memory.Contains((MyVariables.x + 2) + ((MyVariables.y - 1) * MyVariables.board)))
                        {
                            if ((MyVariables.x + 2 < MyVariables.board) && (MyVariables.y - 1 >= 0))
                            {
                                MyVariables.x += 2;
                                MyVariables.y -= 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();
                            }
                        }
                        break;
                    case 2:
                        if (!MyVariables.memory.Contains((MyVariables.x - 2) + ((MyVariables.y + 1) * MyVariables.board)))
                        {
                            if ((MyVariables.x - 2 >= 0) && MyVariables.y + 1 < MyVariables.board)
                            {
                                MyVariables.x -= 2;
                                MyVariables.y += 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();


                            }
                        }
                        break;
                    case 3:
                        if (!MyVariables.memory.Contains((MyVariables.x - 2) + ((MyVariables.y - 1) * MyVariables.board)))
                        {
                            if ((MyVariables.x - 2 >= 0) && (MyVariables.y - 1 >= 0))
                            {
                                MyVariables.x -= 2;
                                MyVariables.y -= 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();

                            }
                        }
                        break;
                    case 4:
                        if (!MyVariables.memory.Contains(((MyVariables.y + 2) * MyVariables.board) + (MyVariables.x + 1)))
                        {
                            if ((MyVariables.y + 2 < MyVariables.board) && (MyVariables.x + 1 < MyVariables.board))
                            {
                                MyVariables.y += 2;
                                MyVariables.x += 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();

                            }
                        }
                        break;
                    case 5:
                        if (!MyVariables.memory.Contains(((MyVariables.y + 2) * MyVariables.board) + (MyVariables.x - 1)))
                        {
                            if ((MyVariables.y + 2 < MyVariables.board) && (MyVariables.x - 1 >= 0))
                            {
                                MyVariables.y += 2;
                                MyVariables.x -= 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();

                            }
                        }
                        break;
                    case 6:
                        if (!MyVariables.memory.Contains(((MyVariables.y - 2) * MyVariables.board) + (MyVariables.x + 1)))
                        {
                            if ((MyVariables.y - 2 >= 0) && (MyVariables.x + 1 < MyVariables.board))
                            {
                                MyVariables.y -= 2;
                                MyVariables.x += 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();

                            }
                        }
                        break;
                    case 7:
                        if (!MyVariables.memory.Contains(((MyVariables.y - 2) * MyVariables.board) + (MyVariables.x - 1)))
                        {
                            if ((MyVariables.y - 2 >= 0) && (MyVariables.x - 1 >= 0))
                            {
                                MyVariables.y -= 2;
                                MyVariables.x -= 1;
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Move();

                            }
                        }
                        break;
                    default:
                        MyVariables.memory.RemoveAt(MyVariables.memory.Count() - 1);
                        MyVariables.y = MyVariables.memory.Last() / MyVariables.board;
                        MyVariables.x = MyVariables.memory.Last() - (MyVariables.y * MyVariables.board);
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WARNING this process may take a while to complete depending on the size of the board.");
            Console.WriteLine("Enter the size of the board (n for an n x n board):");
            MyVariables.board = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Calculating the knight's tour...");
            MyVariables.memory.Add(0);

            Move();
            Console.Clear();
            Console.WriteLine($"Final order of moves: {string.Join(", ", MyVariables.memory)}");
            Console.ReadLine();
        }
    }
}