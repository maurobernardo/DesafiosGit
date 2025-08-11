using System;

namespace DesafiosGit
{
    class Veiculo
    {
        private Motor motor = new Motor();
        public double Velocidade { get; set; }
        public double Distancia { get; set; }

        public void Viajar(double destino)
        {
            if (Distancia > destino)
                throw new Exception("Erro: Tentou viajar além do destino!");

            motor.Ligar();
            Console.WriteLine($"Viajando {Distancia} km a {Velocidade} km/h...");
            motor.Desligar();
        }
    }
}
