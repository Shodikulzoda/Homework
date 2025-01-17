using MethodOverload.Models;
using System;
class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        //calculator.Add(10, 20);
        //calculator.Add(10, 20, 30);
        //calculator.Add(10, 20, 30, 40);
        //calculator.Add(10.5, 20.5); 

        //Console.WriteLine()

        //Circle circle = new Circle();
        //circle.Radius = 23;
        //circle.CalculateArea();
        //circle.CalcultaeCircumference();

        //BankAccount bankAccount = new BankAccount(1234,"Alisher",12);
        //bankAccount.Deposit(0);

        //bankAccount.Withdraw(16);
        //bankAccount.GetAccountInfo();

        Test();

        Console.WriteLine("end");

      
        Console.ReadKey();

    }

    private static void Test()
    {
        Student student = new Student();
        //student.Name = "dede";
        //student.Age = 12;
        //student.AvarageGrade = 213;
        //var (name, age, grade) = student;
        //Console.WriteLine($"name {student.Name} {age} {grade}");
        student.Message();
    }
}