using System;

namespace DesafiosGit
{
    class Desafio2
    {
        public static void Run()
        {
            Shape cubo = new Shape(3, 3, 3);
            Shape cone = new Shape(2, 5);
            Shape esfera = new Shape(4);

            Console.WriteLine($"Volume do Cubo: {cubo.VolumeCubo():F2}");
            Console.WriteLine($"Volume do Cone: {cone.VolumeCone():F2}");
            Console.WriteLine($"Volume da Esfera: {esfera.VolumeEsfera():F2}");
        }
    }
}
