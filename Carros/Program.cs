using System;



namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veiculo[] veiculos = {
              new Carro(),
              new Moto(),
              new Caminhao()
            };

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.acelerar();
            }
        }
    }
}