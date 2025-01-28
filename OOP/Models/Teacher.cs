using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class Teacher : Person , IPrintable
    {
        public string Subject { get; set; }


        //public override void Work()
        //{
        //    Console.WriteLine($"Teacher teching{Subject}");
        //}
        //public void Say()
        //{
        //    Console.WriteLine("");
        //}


        public void PrintInfo()
        {
            Console.WriteLine($"Name {Name} age {Age} work {Subject}");
        }
    }
}
