using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    
    internal class Student : Person
    {

        public int Grade { get; set; }


        //public override void Work()
        //{
        //    Console.WriteLine(  $"Student uchitsiya {Grade}");
        //}
        //public override void MakeSound()
        //{
        //    throw new NotImplementedException();
        //}
        ////public override void MakeSound()
        //{
        //    Console.WriteLine(  "MIaw");        }
        //public override void Work()
        //{
        //    Console.WriteLine($"student grade {Grade}");
        //}

       

        public override void PrintInfo()
        {
            Console.WriteLine($"Name {Name} age {Age} work {Grade}");
        }
        public override void Work()
        {
            Console.WriteLine("df");
        }
        //public 
    }
}
