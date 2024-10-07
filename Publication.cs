using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Publication
    {
        public string? Date_publication {  get; set; }

        public string? Title { get; set; }
        // A classe Publication recebe um objeto da classe Publisher por meio de composição
        public Publisher Publisher { get; set; }
        // O construtor da classe publication recebe seus próprios atributos e o objeto da classe Publisher
        public Publication(string? date_publication, string? title, Publisher publisher)
        {
            Date_publication = date_publication;
            Title = title;
            Publisher = publisher;
        }
    }
}
