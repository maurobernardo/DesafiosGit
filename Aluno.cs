using System;

namespace DesafiosGit
{
    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }

        public override string ToString() => $"ID: {Id}, Nome: {Nome}, Nota: {Nota}";
    }
}
