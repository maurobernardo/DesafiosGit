using System;

namespace DesafiosGit
{
    class Shape
    {
        double comprimento, largura, altura, raio;

        public Shape(double comprimento, double largura, double altura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
            this.altura = altura;
        }

        public Shape(double raio, double altura = 0)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public double VolumeCubo() => comprimento * largura * altura;
        public double VolumeCone() => (1.0 / 3.0) * Math.PI * Math.Pow(raio, 2) * altura;
        public double VolumeEsfera() => (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
    }
}
