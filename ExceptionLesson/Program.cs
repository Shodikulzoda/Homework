using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionLesson
{
    internal class Program
    {
        public int age;
        static void Main(string[] args)
        {

            //try
            //{
            //    int t = 0;
            //    int a = 10 /t ;

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"oshibka : {ex}");
            //}

            //MyClass myClass=new MyClass(-1);
            //try
            //{

            //    Console.WriteLine("vvedite 1 chislo: ");
            //    int a = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("vvedite 2 chislo: ");

            //    int b = Convert.ToInt16(Console.ReadLine());

            //    if (a < 0 && b < 0)
            //    {
            //        throw new ArgumentException("deleniya na nol");
            //    }
            //}
            //catch (FormatException ex)
            //{

            //    Console.WriteLine($"oshibaka format {ex.Message}");
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine($"trying divide to zero {ex}");
            //}
            ////ArrayList arr=new ArrayList();
            //try
            //{
            //    string filepath = "example.txt";
            //    string con = "test";
            //    File.WriteAllText(filepath, con);
            //    Console.WriteLine("saved");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            try
            {
                string filepath = "exampmle.txt";

                string con = File.ReadAllText(filepath);
                Console.WriteLine(con);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
    public class InvalidAgeExeption : Exception
    {
        public InvalidAgeExeption(string message) : base(message) { }
    }

    //public class ExeptionTest:Exception
    //  {
    //      public ExeptionTest(string message ) : base( message ) { }
    //  }

    //public class MyClass
    //{

    //    public MyClass(int age)
    //    {
    //        if (age < 0 || age > 120)
    //        {
    //            throw new InvalidOperationException("vozrast doljen bit beetwen 0;120");
    //        }
    //    }
    //}
}
