using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    public class Circle
    {

        //constructor - bears the same name as the class, which is used to create an instance of a class (the object)
        //              secondary objective of a construct: it can be used as a normal method
        public Circle(double radius, string colour)
        {
            Radius = 0; //setting to default values
            Colour = "Black";
        }

        public double Radius { get; set; } //property

        /// displays the radius value of the instance when called
       
        public string GetRadius()
        {
            return "Radius: " + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
