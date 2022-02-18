using System;

namespace LendaFlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de casos: ");
            int quantidadeDeCasos = int.Parse(Console.ReadLine());
            int caso = 0;

            do
            {
                caso++;
                int eliminacoes = 0;
                Console.Write("\nDigite o numero de pessoas dentro do grupo: ");
                int numeroDePessoasDentroDoCirculo = int.Parse(Console.ReadLine());
                

                Console.Write("\nDigite o numero de saltos dentro do grupo: ");
                int saltoDeUmHomemAteOutro = int.Parse(Console.ReadLine());

                do
                {
                    if (numeroDePessoasDentroDoCirculo % saltoDeUmHomemAteOutro != 0)
                    {
                        eliminacoes++;
                        numeroDePessoasDentroDoCirculo--;
                    }

                } while (numeroDePessoasDentroDoCirculo == 1);
                
                    
                       
                    
                

                

                Console.WriteLine($"Caso {caso} : {eliminacoes}");
                
            } while (caso != quantidadeDeCasos);

            

        }
    }
}
