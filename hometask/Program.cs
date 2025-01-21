using hometask.models;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //TemperatureConverter temp = new TemperatureConverter();

        ////temp.Celsius = 26;
        ////temp.Farhanheit = 78;
        ////temp.ConvertToCelsius();
        ////temp.ConvertToFhranheit();
        ////Car car = new Car();
        ////car.Marka = "toyota";
        ////car.Year = 3024;
        ////car.Model = "toyota";
        ////var (model, marka, year) = car;
        //List<int> ints = new List<int>();
        //ints.Add(d);
        List<int> list = new List<int>();
        for (int i = 1; i < 10; i++)
        {
            list.Add(i);
        }

        list.Add(11);
        list.Add(12);
        Console.WriteLine(  string.Join(", ",list));

        foreach (int item in list)
        {
            if (item % 2 == 0)
            {
                list.Remove(item);
            }
        }
        //for (int i = 1; i < list.Count(); i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        list.Remove(i);
        //    }
        //}

        Console.WriteLine(string.Join(", ",list));

        //var b=  list.Find(x => x > 5);
        //  Console.WriteLine( "asd "+ b);
        //list.Reverse();
        //Console.WriteLine(list);

        //Dictionary<string, string> dict = new Dictionary<string, string>();


        //dict.Add("Россия", "Москва");
        //dict.Add("Франция", "Париж");
        //dict.Add("Германия", "Берлин");
        //dict.Add("Uzbekiston", "tashkent");
        //dict.Add("tojikiston", "dushanbe");
        //dict.Add("afganistan", "kobul");
        ////foreach (var item in dict)
        ////{
        //    if(!dict.ContainsKey("Италия"))
        //    {
        //    dict.Add("Италия", "Рим");
        //    }
        //dict.Remove("afganistan");
        //foreach (var item in dict)
        //{
        //    Console.WriteLine($"key: {item.Key}:{item.Value}");
        //}
        ////Console.WriteLine(dict.Keys == "Россия");
        //string t = "";
        //dict.TryGetValue("Германия", out t);
        //Console.WriteLine(t);


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