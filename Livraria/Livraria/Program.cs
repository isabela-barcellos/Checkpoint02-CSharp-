using Livraria;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("Assim que começa", "Collen Hoover", 2021);


            livro1.ExibirInformacoes();

        }
    }
}
