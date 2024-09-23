using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecoesThrow
{
    public class A
    {
        public static void RenderA()
        {
            //try
            //{
            B.RenderB();
            //}catch
            //{
            //    Console.WriteLine("Tratamento em A");
            // }

        }
    }

    public class B
    {
        public static void RenderB()
        {
            try
            {
                C.RenderC();
            }
            catch
            {
                throw;
            }
        }


    }

    public class C
    {
        public static void RenderC()
        {
            throw new NotImplementedException("Método não implementado!");
        }
    }
}
