using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphizm.Models
{

    internal class Triangle:Shape
    {
        public double CornerA { get; set; }
        public double CornerB { get; set; }
        public double CornerC { get; set; }

        public override void CalculateArea()
        {
            double A = Math.Round(1 / 2 * CornerA * CornerB,2);
            Console.WriteLine($"Area equal to {A}");
        }
        public override void CalculatePerimeter()
        {
            double p =Math.Round( CornerA + CornerB + CornerC,2);  
            Console.WriteLine($"Perimetr equal to {p}");  
        }
    }
}
