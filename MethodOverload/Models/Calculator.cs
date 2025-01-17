using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload.Models
{
    class Calculator
    {
        //public void Add(int a, int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine($"result is {result}");

        //}
        //public void Add(int a, int b, int c)
        //{
        //    int result = a + b + c;
        //    Console.WriteLine($"result is {result}");

        //}
        //public int Add(int a, int b, int c, int d)
        //{
        //    int result = a + b + c + d;
        //    return result;
        //}
        //public void Add(double a, double b)
        //{
        //    double result = a + b;
        //    Console.WriteLine($"result is{result}");
        //}

        public void Increment(ref int val)
        {
            val++;
            Console.WriteLine(val);
        }
      public  void Increment(int val)
        {
            val++;
            Console.WriteLine(val);
        }
        int Sum(int x, int y)
        {
            return x * y;
        }

    }
}
