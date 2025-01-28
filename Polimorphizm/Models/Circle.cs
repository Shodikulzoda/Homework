using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphizm.Models
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public override void CalculateArea()
        {

            double A = Math.Round(Math.PI * (Math.Pow(Radius,2)),2);
            Console.WriteLine($"Circul area is {A}");
        }
        public override void CalculatePerimeter()
        {
            double p = Math.Round(2 * Math.PI * Radius,2);
            Console.WriteLine($"Parametr of Circul is { p}");
        }
    }
}
