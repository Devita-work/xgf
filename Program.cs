using ConsoleApp2.animal;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();

            pigs a1 = new pigs("Поросяш", 12, "Свинья", "Хрюкает");
            Birds a = new Birds("Вороныч", 4, "Ворон", "Каркает");
            cats a2 = new cats("Убунту", 6, "Лев", "Рычит");
            list.Add(a1);
            list.Add(a);
            list.Add(a2);
            var array = list.ToArray();
            foreach (var elem in array) Console.WriteLine(elem.ToString());
            Console.Read();

        }
    }
}