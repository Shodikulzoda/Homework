using hometask.models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        //List<int> ints = new List<int>();
        ////ints.Add(d);
        //for (int i = 1; i < 10; i++)
        //{
        //    list.Add(i);
        //}

        //list.Add(11);
        //list.Add(12);

        //list = list.Where(x=>x%2==0).ToList();
        //list = list.Select(i => i % 2 == 0).ToList();
        List<int> list = new List<int> {1,2,3,4,5,6,7,8 };
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

        //Console.WriteLine(string.Join(", ",list));

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
        /*  Create a parent class Shape with:

  A property for Color
  A virtual method CalculateArea()
  A virtual method DisplayInfo()


  Create two child classes:

  Circle with a Radius property
  Rectangle with Width and Height properties


  Both child classes should:

  Override CalculateArea() with the correct formula
  Override DisplayInfo() to show all properties and the calculated area*/






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