using System;
using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<int> list2 = new List<int>();

            list2.Add(2);
            list2.Add(1);
            list2.Add(2);
            list2.Add(2);

            int number2 = list2.Find(n => n == 1);
            Console.WriteLine(number2);

            //List<int> numberList = list2.FindAll(n => n == 1);
            //Console.WriteLine(numberList);


            var list = new MyList();

            list.Add(4);
            list.Add(2);
            list.Add(6);
            list.Add(8);

            list.Insert(3, 99);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

            Console.WriteLine($"Contains 4: {list.Contains(4)}");
            Console.WriteLine($"Contains 98: {list.Contains(98)}");

            Console.WriteLine("Before swap:");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            list.Swap(0, 1);
            Console.WriteLine("After swap:");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            Console.WriteLine("Find method:");
            Console.WriteLine(list.Find(n => n == 231));
            Console.WriteLine(list.Find(n => n == 4));
            Console.WriteLine(list.Find(n => n % 2 == 0));
        }
    }
}
