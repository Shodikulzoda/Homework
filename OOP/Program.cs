using OOP.Models;

public class Program
{
    //public class Animal
    //{
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("Animal speak");
    //    }
    //}
    ////public class Dog : Animal
    ////{
    ////    public override void Speak()
    ////    {
    ////        Console.WriteLine(  "Dog bark");
    //    }

    //}
    //public  class BaseClass
    //  {
    //      public string Name { get; set; }

    //      public int WorkField;

    ////  }
    //public class Cat:Animal 
    //{
    //    public sealed override void Speak()
    //    {

    //    }

    //}
    //public class SmallCat:Cat
    //{

    //    //public override void Speak()
    //    //{
    //    //    Console.WriteLine(  "cats method");
    //    //}

    //}


    static void Main(string[] args)
    {
        //Animal animal=new Dog();
        //animal.Speak();
        //Person person = new Person();
        //person.Name = "alisher";
        //person.Age = 24;

        //Student student = new Student();
        //student.Name = "Ali";
        //student.Age = 34;
        //student.Grade = 4;

        //Teacher teacher = new Teacher();
        //teacher.Name = "Bobjun";
        //teacher.Age = 54;
        //teacher.Subject = "MAth";

        //person.Introduce();
        //student.Introduce();
        //student.Work();
        //teacher.Introduce();
        //teacher.Work();
        Person person=new Person();
        person.Name = "ALI";
        person.Age = 24;
        Student student=new Student();
        student.Name = "sdf";
        student.Age = 43;
        student.Grade = 23;
        student.PrintInfo();

        Teacher teacher=new Teacher();
        teacher.Name = "mallim";
        teacher.Age= 60;
        teacher.Subject = "kor";
        teacher.PrintInfo();



    }
}