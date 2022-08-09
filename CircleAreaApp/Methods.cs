using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaApp
{
    public class Methods
    {
        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var answer = Math.PI * radius * radius;
            Console.WriteLine($"{Math.Round(answer, 2)} is the area of your circle.");
        }
    }
}
