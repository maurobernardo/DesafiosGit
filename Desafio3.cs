using System;

namespace DesafiosGit
{
    class Desafio3
    {
        public static void Run()
        {
            try
            {
                Veiculo carro = new Veiculo();

                Console.Write("Informe a velocidade (km/h): ");
                carro.Velocidade = double.Parse(Console.ReadLine());

                Console.Write("Informe a distância a percorrer (km): ");
                carro.Distancia = double.Parse(Console.ReadLine());

                Console.Write("Informe o destino (km): ");
                double destino = double.Parse(Console.ReadLine());

                carro.Viajar(destino);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
