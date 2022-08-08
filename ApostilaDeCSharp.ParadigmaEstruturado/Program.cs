using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             sequência - TopDown
             
            
            passo 4
            passo 5
             */
            string repetir;
            do
            {
                //Passo 1 - Entrada de Dados 
                Console.WriteLine("Qual o aluno");
                string nome = Console.ReadLine();

                //passo 2 - Processamento
                string resposta;
                if (nome.Equals("Regys"))
                {
                    resposta = ("Nosso representante");
                }
                else
                {
                    resposta = ("Chame o representante!");
                }

                //Passo 3 - Saída
                Console.WriteLine(resposta);
                Console.ReadLine();

                //Passo 4 -     
                Console.WriteLine("Deseja sair? Y-N ");
                repetir = Console.ReadLine().ToUpper();
               
            } while (!repetir.Equals("Y"));

            int[] notas = new int[4];
            notas[0] = 9;
            notas[1] = 21;
            notas[2] = 7;
            notas[3] = 10;
            Console.WriteLine("Mostre as notas");
            double soma = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(notas[i]);
                    soma = soma + notas[i];
            }
            double media = soma / notas.Length;
            Console.WriteLine($"media:{soma}");
            Console.WriteLine($"media:{media}");
            Console.ReadKey();
        }
    }
}
