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
        public static int board = 5;
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 0");
                                Console.ReadLine();
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
                                // valamiért az x 0-ról 4-re ment ebben a részben
                                MyVariables.memory.Add(MyVariables.y * MyVariables.board + MyVariables.x);
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 1");
                                Console.ReadLine();
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 2");
                                Console.ReadLine();
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 3");
                                Console.ReadLine();
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 4");
                                Console.ReadLine();
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 5");
                                Console.ReadLine();
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 6");
                                Console.ReadLine();
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
                                Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case 7");
                                Console.ReadLine();
                                Move();
                                
                            }
                        }
                        break;
                    default:
                        MyVariables.memory.RemoveAt(MyVariables.memory.Count() - 1);
                        MyVariables.y = MyVariables.memory.Last() / MyVariables.board;
                        MyVariables.x = MyVariables.memory.Last() - (MyVariables.y * MyVariables.board);
                        Console.WriteLine($"x: {MyVariables.x}, y: {MyVariables.y}, memory: {string.Join(", ", MyVariables.memory)} case default");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            MyVariables.memory.Add(0);

            Move();
            Console.WriteLine("=================THIS IS STILL WORK IN PROGRESS MAY NOT WORK AS EXPECTED==================");
            Console.WriteLine($"Final order of moves: {string.Join(", ", MyVariables.memory)}");
            Console.ReadLine();
        }
    }
}