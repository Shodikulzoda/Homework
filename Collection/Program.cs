//var r=new List<string> { "apple","banan"};
//r.Add("cherry");
//Console.WriteLine(string.Join(", ",r));

//List<int> num = new List<int> { 1,2,3,4,5,6};
//num.Add(4);
Console.WriteLine("JGJg");
        List<int> num = new();
        num.Add(1);
        num.AddRange(new int[] { 1, 2, 3 });
        num.Insert(0, 123);
        num.RemoveAt(2);
        num.Clear();

        foreach (var item in num)
        {
            Console.WriteLine(item);  
        }
