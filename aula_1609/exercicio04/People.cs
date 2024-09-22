using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    internal class People
    {
        string? Name { get; set; }
        int? Age { get; set; }

        public void Show(People data)
        {
            Console.WriteLine($"Nome : {data.Name}, Idade: {data.Age}");
        }

        public People(string? name, int? age)
        {
            Name = name;
            Age = age;
        }
    }
}
