using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int inCircle = 0;
           
            double probability = 0;
            Random rand = new Random();

            Console.WriteLine("Enter a random number:");
            int length = int.Parse(Console.ReadLine());

            Coordinates[] arr = new Coordinates[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = new Coordinates(rand);
                double h = arr[i].hypot(arr[i].X, arr[i].Y);
                //Console.WriteLine($" h: {h}");
                if (h > 1)
                {
                    
                }
                else if (h <= 1 && h >= 0)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("invalid hyptonuse");
                }

                //Console.WriteLine(counter);
            }
            Console.WriteLine(counter);

            inCircle = counter;

            probability = 4.0 * ((double)inCircle / (double)length);

            Console.WriteLine();
            Console.WriteLine($"Approximated Pi = {probability.ToString()}, and actual PI = {Math.PI}");
            double difference = Math.Abs(Math.PI - probability);
            Console.WriteLine($" The Absolute value is: {difference}");
            Console.ReadLine();
        }
        
    }
}
