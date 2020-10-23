using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object (instance) ->> object is when you create a space in memory and you start assigning values to the template you created earlier
            Circle c = new Circle(); //eg of an  object = c
            c.Radius = 5;

            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {c.GetArea()}, Perimeter is {c.GetPerimeter()}");

            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}
