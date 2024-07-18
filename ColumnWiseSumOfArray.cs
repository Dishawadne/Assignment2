using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ColumnWiseSumOfArray
    {
        public void Display1()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 2, 2, 6 },
            { 7, 8, 4 }
        };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[col, row];
                }
                Console.WriteLine("Sum of elements in column " + row + ": " + sum);
            }
        }
    }
}
