using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            }
        }


        /*
         *  Pattern 1:
         * 
         *  1
         *  9       2
         *  10      8       3
         *  14      11      7       4
         *  15      13      12      6       5
         */

        public static void Pattern1_usingMatric_usingWhileLoop()
        {

            Console.Write("No of rows: ");
            int num = 1, max = 0, x = 0, y = 0, rows;
            int[,] matrix;
            bool increment = true;

            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            matrix = new int[rows, rows];

            for (int i = 0; i <= rows; i++)
            {
                max += i;
            }

            //max will be 15 for 5 rows
            while (num <= max)
            {
                matrix[x, y] = num++;
                if (increment)
                {
                    x++;
                    y++;
                }
                else
                {
                    x--;
                    y--;
                }
                if (x == rows || y == -1)
                {
                    increment = !increment;
                    if (y == -1)
                    {
                        y++;
                        x += 2;
                    }
                    if (x == rows)
                    {
                        x--;
                        y -= 2;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();
        }
        public static void Pattern1_usingMatric_usingForLoop()
        {
            Console.Write("No of rows: ");
            int num, rows, max = 0, x = 0, y = 0;
            bool increment = true;
            int[,] matrix;

            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            matrix = new int[rows, rows];

            for (int i = 0; i <= rows; i++)
            {
                max += i;
            }

            //max will be 15 for 5 row
            for (num = 1; num <= max; num++)
            {
                matrix[x, y] = num;
                if (increment)
                {
                    x++;
                    y++;
                }
                else
                {
                    x--;
                    y--;
                }
                if (x == rows || y == -1)
                {
                    increment = !increment;
                    if (y == -1)
                    {
                        y++;
                        x += 2;
                    }
                    if (x == rows)
                    {
                        x--;
                        y -= 2;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();
        }

        /*
         *  Pattern 2:
         * 
         *                                   1
         *                           9       2
         *                   10      8       3
         *           14      11      7       4
         *   15      13      12      6       5
         */

        public static void Pattern2_invert_usingMatric_usingForLoop()
        {
            Console.Write("No of rows: ");
            int num, rows, max = 0, x = 0, y = 0;
            bool increment = true;
            int[,] matrix;

            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            matrix = new int[rows, rows];

            for (int i = 0; i <= rows; i++)
            {
                max += i;
            }
            int k = rows - 1;
            //max will be 15 for 5 row
            for (num = 1; num <= max; num++)
            {
                k = rows - 1 - x;
                matrix[x, k + y] = num;
                if (increment)
                {
                    x++;
                    y++;
                }
                else
                {
                    x--;
                    y--;
                }
                if (x == rows || y == -1)
                {
                    increment = !increment;
                    if (y == -1)
                    {
                        y++;
                        x += 2;
                    }
                    if (x == rows)
                    {
                        x--;
                        y -= 2;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.Write($"\t");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}
