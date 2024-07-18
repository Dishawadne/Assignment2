using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class DisplaySumAvg
    {
      public void display()
        {
            int[] num = new int[10];
            Console.WriteLine("enter numbers");
            for (int i = 0; i < 5; i++)
            {

                num[i] = Convert.ToByte(Console.ReadLine());
            }
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }

            float avg = (float)sum / num.Length;
            Console.WriteLine($"Sum is {sum} Avg is {avg}");

        }
    }
}
