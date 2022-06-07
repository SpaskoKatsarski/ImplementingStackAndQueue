using System;

namespace StartUp
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var list = new MyList();

            list.Add(4);
            list.Add(2);
            list.Add(6);
            list.Add(8);

            list.InsertAt(0, 99);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

        }
    }
}
