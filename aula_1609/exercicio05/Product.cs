using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public Product(string? name, decimal price) 
        {
            Name = name;
            Price = price;
        }

        public void Show(Product p)
        {
            Console.WriteLine($"Nome: {p.Name}, Preço: {p.Price}");
        }

        public decimal Sum(Product p, Product m, Product j, Product h, Product i)
        {
            return p.Price + m.Price + j.Price + h.Price + i.Price;
        }

        public decimal Average(Product p, Product m, Product j, Product h, Product i)
        {
            return (p.Price + m.Price + j.Price + h.Price + i.Price) / 5;
        }
    }
}
