using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    // A classe student herda de pessoas
    public class Student : People
    {
        public string? Ra {  get; set; }
        // A classe student recebe uma lista de empréstimos, o relacionamento é uma agregação, o student pode existir sem que o empréstimo exista
        public List<Loan> Loan { get; set; } = new List<Loan>();
        // O construtor da classe student recebe seus atributos e o atributo da classe pessoas
        public Student(string? ra, string? name) : base(name)
        {
            Ra = ra;
        }
    }
}
