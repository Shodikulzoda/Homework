

using Homework;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John";
        person.Age = 30;
        person.City = "New York";
        person.Introduce();

        Person person2 = new Person();
        person2.Name = "Jane";
        person2.Age = 25;
        person2.City = "Chicago";
        person2.Introduce();

        Person person3 = new Person();
person.Name = "Tom";
        person.Age = 40;
        person.City = "Los Angeles";
        person.Introduce();


    }


}
