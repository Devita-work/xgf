using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.animal
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public string Сapability { get; set; }
        public Animal(string name, int age, string type, string capability)
        {
            Name = name;
            Age = age;
            Type = type;
            Сapability = capability;
        }
        public override string ToString()
        {
            return String.Format($"{"Вид: "}{Type} {", Имя: "} { Name}{", Возраст: "} { Age}{", Способности: "} {Сapability}");
        }
    }
}