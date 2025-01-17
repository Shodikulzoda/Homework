using hometask.models;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        TemperatureConverter temp = new TemperatureConverter();

        //temp.Celsius = 26;
        //temp.Farhanheit = 78;
        //temp.ConvertToCelsius();
        //temp.ConvertToFhranheit();
        Car car = new Car();
        car.Marka = "toyota";
        car.Year = 3024;
        car.Model = "toyota";
        

    }

   

    //public void Test()
    //{
    //    Car car = new Car();
    //    car.Model = "fd";
    //    car.Marka = "sadf";
    //    car.Year = 34;
    //    var (model, marka, year) = car;
    //}
}