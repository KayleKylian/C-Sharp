using System;

namespace ExIMC
{
    class Program
    {
        static void Main()
        {
            Pessoa person = new Pessoa();
            person.altura = 1.60;
            person.peso = 60;
            person.mensagem();
        }
    }
}