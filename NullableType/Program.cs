using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//string str = null;
//int? d;
//Nullable<int> v = new Nullable<int>();
////if(str is null   
//// {

//// }
//void PrintUpper(string? text)
//{
//    if (text is null)
//    {
//        Console.WriteLine("dfs");
//        return;

//    }

internal class Program
{
    private static void Main(string[] args)
    {
        //NullableType nullableType = null;
        //string nullableType=null;
        //int? value = nullableType.Length;
        //Console.WriteLine();
        //string? name = null;
        //int? nameLength = name?.Length; // If name is null, nameLength will also be null.

        //Console.WriteLine(nameLength);
        //try
        //{
        //    Console.WriteLine("vvedite imia");
        //    string name = Console.ReadLine();
        //    if (name == string.Empty)
        //        throw new ArgumentNullException("pustoy");
        //    Console.WriteLine("vosrast ot 18 do 65");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    if (age >= 18 || age <= 65)

        //    Console.WriteLine("vvedite zarplatu");

        //    int salary = Convert.ToInt32(Console.ReadLine());
        //    if (salary <= 0)
        //        throw new ArgumentException("neverny salary");
        //    Console.WriteLine($"{name} {age} {salary}");


        //}
        //catch (FormatException ex)
        //{
        //    throw new InvalidAgeExeption("neverny vozrast");
        //}

        //try
        //{
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    int salary = Convert.ToInt32(Console.ReadLine());

        //}
        //catch (Exception ex)
        //{
        //    throw;
        //}
        try
        {
            Console.Write("Введите возраст: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if (age < 0 || age > 120) ;
            throw new InvalidAgeExeption("Возраст должен быть от 0 до 120.");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (salary <= 0)
                throw new Logger("neverny zarplata"); 
           
            Console.WriteLine($"Возраст: {age}");
        }
        catch (FormatException ex)
        {

          
        }
        catch (InvalidAgeExeption ex)
        {
            Console.WriteLine($"Ошибка возраста: {ex}");
        }catch(Logger ex)
        {
            Console.WriteLine("neverny chislo: "+ex.Message);
            
        }


    }
}

public class InvalidAgeExeption : Exception
{
    public InvalidAgeExeption(string message) : base(message) { }

}
public class InvalidSalaryException : Exception
{
    public InvalidSalaryException(string message) : base(message) { }

}
public class Logger : Exception
{
    public Logger(string message) : base(message) { }

}

