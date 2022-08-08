using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.EstruturasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if - estrutura de seleção simples 
            double x = 43.5;
            if (x >= 43.1)
            {
                Console.WriteLine("MandaLoriano");
            }

            //if else - estrutura de seleção composta
                //Quem define o tipo é o compilador
            var idade = 43.1;
            if (idade >= 43.1)
            {
                Console.WriteLine("MandaLoriano");
            }
            else 
            {
                Console.WriteLine("Grande jovem jovem");
            }

            //if else if - estrutura de seleção composta encadeada
            if (idade >= 43.1)
            {
                Console.WriteLine("MandaLoriano");
            }
            else if (idade >= 18 && idade < 43.1)
            {
                Console.WriteLine("Grande jovem jovem");
            }
            else 
            {
                Console.WriteLine("Menino(a)");
            }
            //switch - estrutura de seleção múltipla
            var dia = 25.6;
            switch () 
            {
                
            }
        }
    }
}
