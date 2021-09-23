using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Distance: ");
            double distance = Double.Parse(Console.ReadLine());
            Console.Write("Walking speed: ");
            double walkingSpeed = Double.Parse(Console.ReadLine());
            Console.Write("Driving speed: ");
            double drivingSpeed = Double.Parse(Console.ReadLine());

            /* Its hard to write all calculations in program to find time formula for 3 travelers but
               to get fastest time, traveler needs to spent 2/7 time on foot and 5/7 time on bike */
            double time = ((distance / walkingSpeed) * 2 / 7) + ((distance / drivingSpeed) * 5 / 7);
            Console.WriteLine("Time to reach destination: " + time + " h");
        }
    }
}
