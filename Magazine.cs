using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    // A classe magazine herda da classe Publication
    public class Magazine : Publication
    {
        public string? Number { get; set; }

        public string? Issn { get; set; }
        // O construtor da classe magazine recebe seus próprios atributos e os atributos da classe Publication
        public Magazine(string? number, string? issn, string? date_publication, string? title, Publisher publisher) : base(date_publication, title, publisher) 
        {
            Number = number;
            Issn = issn;
        }
    }
}
