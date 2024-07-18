using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class RowWiseSumOf2DArray
    {
       public void Dispaly()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine("Sum of elements in row " + row + ": " + sum);
            }
        } 

    }
}
