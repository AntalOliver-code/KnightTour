using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightTour
{
    internal class Program
    {
        static void Move(int x, int y, List<int> memory)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        if ((x + 2 < 8) && (y + 1 < 8))
                        {
                            x += 2;
                            y += 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }
                        break;
                    case 1:
                        if ((x + 2 < 8) && (y - 1 >= 0))
                        {
                            x += 2;
                            y -= 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }
                        break;
                    case 2:
                        if ((x - 2 >= 0) && (y + 1 < 8))
                        {
                            x -= 2;
                            y += 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }                        
                        break;
                    case 3:
                        if ((x - 2 >= 0) && (y - 1 >= 0))
                        {
                            x -= 2;
                            y -= 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }                        
                        break;
                    case 4:
                        if ((y + 2 < 8) && (x + 1 < 8))
                        {
                            y += 2;
                            x += 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }                        
                        break;
                    case 5:
                        if ((y + 2 < 8) && (x - 1 >= 0))
                        {
                            y += 2;
                            x -= 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }                        
                        break;
                    case 6:
                        if ((y - 2 >= 0) && (x + 1 < 8))
                        {
                            y -= 2;
                            x += 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }                        
                        break;
                    case 7:
                        if ((y - 2 >= 0) && (x - 1 >= 0))
                        {
                            y -= 2;
                            x -= 1;
                            memory.Add(y * 5 + x);
                            Move(x, y, memory);
                        }                        
                        break;
                    default:
                        memory.RemoveAt(-1);
                        y = memory.Last() / 5;
                        x = memory.Last() - (y * 5);
                        break;
                } 
            }
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            List<int> memory = new List<int>();
            memory.Add(0);
            Move(x, y, memory);
            Console.WriteLine(memory);
        }
    }
}