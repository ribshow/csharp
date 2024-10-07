using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    // A classe Book herda da classe Publication
    public class Book : Publication
    {
        public string? Sinopse {  get; set; }
        public string? Isbn { get; set; }
        // A classe Book recebe uma lista de autores, o relacionamento é uma agregação
        public List<Author> Author { get; set; } = new List<Author>();
        // A classe Book recebe uma lista de gêneros, o relacionamento é uma agregação
        public List<Gender> Gender { get; set; } = new List<Gender>();
        // No construtor da classe Book, são passados seus próprios atributos e os atributos da classe Publication
        public Book(string? sinopse, string? isbn, string? date_publication, string? title, Publisher publisher) : base(date_publication, title, publisher)
        {
            Sinopse = sinopse;
            Isbn = isbn;
        }
    }
}
