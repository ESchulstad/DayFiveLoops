using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFiveLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;
            while(counter<10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            
            int sum = 0;
            int counter = 1;
            while(counter<=10)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine(sum);
            */

            Console.WriteLine("Pick a number to count from and to.");

            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int i = low;

            while(i<= high)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
