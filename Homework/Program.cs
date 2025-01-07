

internal class Program
{
    private static void Main(string[] args)
    {
        //zadacha 1
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //for (int i = a; i < b; i++)
        //{
        //    sum += i;
        //}
        //Console.WriteLine(sum);
        //zadacha 2
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //for (int i = a; i < b; i+=2)
        //{
        //  Console.WriteLine(i);
        //}
        //zadacha 3
        //primougolnik
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 20; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        // primougolniy triugolnik
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}
        //ravnostoronniy treugolnik
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = i; j <= 10; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}
        //romb

        for (int i = 0; i < 10; i++)
        {
            for (int j = i; j < 10; j++)
            {
                Console.Write(" ");
            }

            for (int k = i; k > 0; k--)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
        for (int i = 10; i > 0; i--)
        {
            for (int k = i; k < 10; k++)
                Console.Write(" ");
            for (int j = 0; j < i; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }


}
