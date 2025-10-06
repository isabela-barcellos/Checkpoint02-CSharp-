using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Livraria
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicado;

        public Livro(string titulo, string autor, int anoPublicado)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicado = anoPublicado;

        }
        public void ExibirInformacoes()
        {
            Console.WriteLine(Titulo +" - " + Autor + " (" + AnoPublicado + ")" );
        }
    }
}





