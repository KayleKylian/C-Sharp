using System;

class ContaCorrente
{
    public int num_agency;
    public string titular, conta;
    public double saldo;

    public void Deposito(double valor)
    {
        this.saldo += valor;
    }

    public void Sacar(double valor)
    {
        if(this.saldo >= valor)
            this.saldo -= valor;
        else Console.WriteLine("Saldo inválido ou insuficiente.");
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
        if(this.saldo < valor)
            return false;
        else
        {
            this.saldo -= valor;
            destino.saldo += valor;
            return true;
        }
    }
}