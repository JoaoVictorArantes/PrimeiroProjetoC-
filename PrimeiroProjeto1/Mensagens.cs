using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto1
{
    static internal class Mensagens // TUDO EM PUBLIC STATIC PARA QUE EU POSSA USAR ESSAS CLASSE/METODOS SEM TER QUE CRIAR UM OBJETO.
    {
        public static void ola()
        {
            Console.WriteLine("Olá! Tudo bem?");
        }
            
        public static void esperando()
        {
            Console.WriteLine("Estou esperando algo, o que? não sei kkkk");
        }

        public static void tchau()
        {
            Console.WriteLine("Até mais! Obrigado por usar o meu programa! :)");
        }
    }
}
