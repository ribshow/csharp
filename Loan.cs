using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    // loan(Empréstimo)
    public class Loan
    {
        public string? Date_loan {  get; set; }
        // a classe Loan recebe um objeto da classe Student, por meio de associação, onde o empréstimo não pode existir sem o aluno
        public Student Student;
        // a classe Loan recebe uma lista de itens, por meio de composição, onde o empréstimo não pode existir sem o item
        public List<Item> Items { get; set; } = new List<Item>();
        // no construtor de loan, são passados os atributos da classe, o objeto Aluno, e os atributos da classe Item (data de devolução e o objeto Livro)
        public Loan(string? date_loan, Student student, string? date_return, Book book)
        {
            Date_loan = date_loan;
            Student = student;
            Items.Add(new Item(date_return, book));
        }
        // Método implementado para adicionar itens ao empréstimo
        public void addItem(string? date_return,Book book) 
        {
            Items.Add(new Item(date_return, book));
        }
    }
}
