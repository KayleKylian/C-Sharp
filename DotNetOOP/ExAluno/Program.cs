using System;

namespace DotNetOOP
{
    class Program
    {
        static void Main()
        {
            Aluno al1 = new Aluno();
            al1.nome = "Josias";
            al1.nota1 = 7;
            al1.nota2 = 7;
            al1.mensagem();
        }
    }
}