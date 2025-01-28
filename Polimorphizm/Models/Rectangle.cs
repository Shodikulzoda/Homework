using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Polimorphizm.Models
{
    internal class Rectangle : Shape
    {
        public double CornerA { get; set; }
        public double CornerB { get; set; }


        public override void CalculateArea()
        {
            double area =Math.Round( CornerA * CornerB,2);
            Console.WriteLine($"Area is equal to {area}");
        }
        public override void CalculatePerimeter()
        {
            double P = Math.Round((CornerA + CornerB) * 2,2);
            Console.WriteLine($"Perimetr of Rectangle equal to {P}");
        }
    }
}
