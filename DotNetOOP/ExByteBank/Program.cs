using System;

namespace ExByteBank
{
    class Program
    {
        static void Main()
        {
            ContaCorrente contaAndrey = new ContaCorrente();
            contaAndrey.titular = "Johny";
            contaAndrey.saldo = 100;
            contaAndrey.num_agency = 01;
            contaAndrey.conta = "Bradesco";

            Console.WriteLine("Saldo do Andrey: " + contaAndrey.saldo);
            
            ContaCorrente contaMarcos = new ContaCorrente();
            contaMarcos.titular = "Marcos";
            contaMarcos.saldo = 200;
            contaMarcos.num_agency = 02;
            contaMarcos.conta = "Inter";

            Console.WriteLine("Saldo do Marcos: " + contaMarcos.saldo);

            contaMarcos.Transferir(250, contaAndrey);
            Console.WriteLine("Saldo do Marcos: " + contaMarcos.saldo + " Pós Transferência de 250");

            contaMarcos.Transferir(100, contaAndrey);
            Console.WriteLine("Saldo do Marcos: " + contaMarcos.saldo + " Pós Transferência de 100");
            Console.WriteLine("Saldo do Andrey: " + contaAndrey.saldo + " Pós Transferência de 100");
        }
    }
}