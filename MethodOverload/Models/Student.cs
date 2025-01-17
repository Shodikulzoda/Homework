using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload.Models
{
    internal class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double AvarageGrade { get; set; }

        public void Deconstruct(out string name, out int age, out double avarage)
        {
            name = Name;
            age = Age;
            avarage = AvarageGrade;
        }

        public Student()
        {
            Console.WriteLine("Constructor");
        }

        ~Student()
        {
            Console.WriteLine("Deconstructor");
        }

        public void Message()
        {
            Console.WriteLine("Message Printed.");
        }

        //public void CalculateArea()
        //{
        //    double area = Math.PI *2* Math.Pow(Radius, 2);
        //    Console.WriteLine(Math.Round(area));
        //}
        //public void CalcultaeCircumference()
        //{
        //    double okrujnost = 2 * Math.PI * Radius * 2 * Math.PI * Radius;
        //    Console.WriteLine(Math.Round(okrujnost,3));
        //}
    }
}
