using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            /*
            Console.WriteLine("Please press a key to continue");
            Console.ReadLine();

            Console.WriteLine(p.FullName);
            Console.ReadKey();*/

            Console.WriteLine("Please input Address: ");
            p.Address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(p.DelimitAddress(','));
            Console.WriteLine("Press a key to terminate the app");
            Console.ReadKey();
        }
    }
}
