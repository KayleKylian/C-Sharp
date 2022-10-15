using System;
class Pessoa
{
    // Atributos
    public double peso, altura;

    // Método de cálculo de IMC
    public double calculaIMC()
    {
        return peso / (altura * altura);
    }

    // Mensagem
    public void mensagem()
    {
        double imc = calculaIMC();
        string msg;

        if(imc < 18.5)
        {
            msg = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            msg = "Peso normal";
        }
        else if(imc < 30)
        {
            msg = "Acima do peso";
        }
        else if(imc < 35)
        {
            msg = "Obesidade I";
        }
        else if(imc < 40)
        {
            msg = "Obesidade II";
        }
        else msg = "Obesidade III";

        Console.WriteLine($"Seu IMC foi de {Math.Round(imc, 2)}, e está: {msg}");
    }
}