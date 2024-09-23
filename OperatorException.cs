using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    public class OperatorException : Exception
    {
        public OperatorException() { }
        public OperatorException(string message) : base(message) { }

        public OperatorException(string message, Exception inner) : base(message, inner) { }

        public override string Message
        {
            get
            {
                return "Saldo insuficiente para realizar operação";
            }
        }
    }
}
