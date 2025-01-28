using Polimorphizm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 23;
            circle.CalculatePerimeter();
            circle.CalculateArea();

            Rectangle rectangle = new Rectangle();
            rectangle.CornerA = 10;
            rectangle.CornerB = 10;
            rectangle.CalculatePerimeter();
            rectangle.CalculateArea();

            Triangle triangle = new Triangle();
            triangle.CornerA = 12;
            triangle.CornerB = 11;
            triangle.CornerC= 13;
            triangle.CalculatePerimeter();
            triangle.CalculateArea();
        }
    }
}
