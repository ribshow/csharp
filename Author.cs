using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    // A classe author herda da classe People
    public class Author : People
    {
        public string? Nationality { get; set; }

        // A classe author recebe uma lista de livros, o relacionamento é uma agregação, o autor pode existir sem que o livro exista
        public List<Book> Books { get; set; } = new List<Book>();

        // Por meio da herança da classe People, a classse author recebe o atributo name
        public Author(string? nationality, string? name) : base(name)
        {
            Nationality = nationality;
        }
    }
}
