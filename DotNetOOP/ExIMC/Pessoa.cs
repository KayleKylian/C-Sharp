using System;

class Pessoa
{
    // Atributos
    public double peso, altura;

    // Método de cálculo de IMC
    public double CalculaIMC()
    {
        return peso / (altura * altura);
    }

    // Situação
    public string situacao(double imc)
    {
        string retorno;

        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Peso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if(imc < 40)
        {
            retorno = "Obesidade II";
        }
        else retorno = "Obesidade III";

        return retorno;
    }

    public void mensagem()
    {
        // Obter cálculo
        double imc = CalculaIMC();
        // Obter situação
        string situation = situacao(imc);

        // Mensagem
        Console.WriteLine($"Seu IMC foi de: {Math.Round(imc, 2)}");
        Console.WriteLine($"Sua situação é: {situation}");
    }
}