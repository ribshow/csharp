using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecaoPersonalizada
{
    public class CustomException : Exception
    {
        // construtor vazio
        public CustomException() { }

        // construtor recebe a mensagem e passa a mensagem para o pai (:base)
        public CustomException(string message) : base(message) { }
        // construtor que recebe a mensage, o objeto exception e passando para 
        // a classe pai message e inner (:base)
        public CustomException(string message, Exception inner) : base(message, inner) { }

        // redefinindo a mensagem da classe pai
        public override string Message
        {
            get
            {
                return "Essa é a nova mensagem!";
            }
        }
    }
}
