using System;

namespace DesafiosGit
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MENU DE DESAFIOS =====");
                Console.WriteLine("1 - Desafio 1 (AddInts)");
                Console.WriteLine("2 - Desafio 2 (Shape - Volumes)");
                Console.WriteLine("3 - Desafio 3 (Veículo e Motor)");
                Console.WriteLine("4 - Desafio 4 (Ordenar Alunos)");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("===== DESAFIO 1 =====");
                        Desafio1.Run();
                        break;

                    case "2":
                        Console.WriteLine("===== DESAFIO 2 =====");
                        Desafio2.Run();
                        break;

                    case "3":
                        Console.WriteLine("===== DESAFIO 3 =====");
                        Desafio3.Run();
                        break;

                    case "4":
                        Console.WriteLine("===== DESAFIO 4 =====");
                        Desafio4.Run();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
