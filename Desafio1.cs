using System;

namespace DesafiosGit
{
    class Desafio1
    {
        public static void Run()
        {
            if (AddInts(out int soma, out bool sucesso))
                Console.WriteLine($"Soma realizada com sucesso! Resultado: {soma}");
            else
                Console.WriteLine("Erro ao realizar a soma.");
        }

        static bool AddInts(out int soma, out bool sucesso)
        {
            soma = 0;
            sucesso = true;

            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"Digite o {i}º número inteiro: ");
                    soma += int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                sucesso = false;
                return false;
            }

            return true;
        }
    }
}
