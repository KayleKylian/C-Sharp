using System;

class Aluno
{
    // Atributos
    public string ?nome;
    public double nota1, nota2;

    // Métodos - Média
    public double media()
    {
        return (nota1 + nota2) / 2 ;
    }

    // Métodos - Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    // Métodos - Mensagem
    public void mensagem()
    {
        // Obtém a média
        double obterMedia = media();

        // Obtem a situação
        string obterSituacao = situacao(obterMedia);

        // Mensagem
        Console.WriteLine($"{nome} está {obterSituacao}, com média {obterMedia}");
    }
}