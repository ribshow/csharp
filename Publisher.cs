using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    // A classe publisher herda da classe pessoas
    public class Publisher : People
    {
        public string? Cnpj { get; set; }
        // A classe publisher recebe uma lista de publicações, o relacionamento é uma agregação, o publisher pode existir sem que a publicação exista
        public List<Publication> Publications { get; set; } = new List<Publication>();
        // O construtor da classe publisher seu atributo e o atributo da classe pessoas
        public Publisher(string? cnpj, string? name) : base(name)
        {
            Cnpj = cnpj;
        }
    }
}
