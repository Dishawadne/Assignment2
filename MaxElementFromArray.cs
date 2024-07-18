using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MaxElementFromArray
    {
        public void max()
        {
            int[] array = { 1, 8, 6, 4, 3, 5 };
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("The Maximum Element from array:" +max);
        }
    }
}
