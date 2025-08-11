using System;

namespace DesafiosGit
{
    class Desafio4
    {
        public static void Run()
        {
            Aluno[] alunos = new Aluno[]
            {
                new Aluno { Id = 3, Nome = "Maria", Nota = 8.5 },
                new Aluno { Id = 1, Nome = "João", Nota = 9.0 },
                new Aluno { Id = 2, Nome = "Ana", Nota = 7.5 }
            };

            Console.WriteLine("\nOrdenado por ID:");
            Array.Sort(alunos, (a, b) => a.Id.CompareTo(b.Id));
            foreach (var aluno in alunos) Console.WriteLine(aluno);

            Console.WriteLine("\nOrdenado por Nota:");
            Array.Sort(alunos, (a, b) => a.Nota.CompareTo(b.Nota));
            foreach (var aluno in alunos) Console.WriteLine(aluno);
        }
    }
}
