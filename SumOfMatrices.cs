using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumOfMatrices
    {
        public void displaySum()
        {
            int[,] matrix1 = {
            { 1, 5, 3 },
            { 6, 5, 4 },
            { 9, 8, 9 }
        };

            int[,] matrix2 = {
            { 9, 2, 7 },
            { 5, 5, 4 },
            { 3, 2, 9 }
        };

            int[,] sumMatrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("Sum of the two 3x3 matrices is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
