using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Item
    {
        public string? Date_return { get; set; }
        // A classe item recebe uma lista de livros por meio de composição, onde o item não pode existir sem o livro
        public List<Book> Books { get; set; } = new List<Book>();   
        // No construtor da classe item, é passado seus atributos e o objeto livro da classe Book
        public Item(string? date_return, Book book)
        {
            Date_return = date_return;
            Books.Add(book);
        }
    }
}
