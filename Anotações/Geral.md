---
title: Anotação de Estudo
output: pdf_document
---

# Anotações Gerais sobre C# e .NET

## Variáveis
**As variáveis são divididas em dois tipos, variáveis de referência, ou variáveis de valor**  

- As variáveis de referência(ou instância) não contém o valor em sí, elas possuem somente o identificador do local de armazenamento do valor, sendo um exemplo desse tipo, as classes.  
- Já as variáveis de valor, armazenam em sí mesmo seus referidos valores, como um exemplo, uma variável do tipo `int`

*Variáveis podem ter níveis de acessibilidade*

### Nomenclatura
Para nomes de variáveis, segue-se o padrão de nomenclatura camelCase, onde se inicia a primeira palavra em minúsculas, e todas as subsequentes a primeira letra em maiúscula.  

Porém há outros estilos de nomenclatura, como e.g., o padrão snake_case, onde todas as palavras são em minúsculas, porém separadas entre sublinhados( _ ).

___

## Tipos de dados
Há diversos tipos de dados para as mais variadas situações, por exemplo, para casos do tipo monetário, usa-se o tipo decimal por conta de sua maior precisão de ponto flutuante.

1. String - Define-se usando aspas duplas e a *keyword* `string`, também conhecida como *cadeia de caracteres* ou *literal*, e.g.: `string minhaVariávelLiteral = "Minha string";`
2. Char - Enquanto uma string é uma cadeia de caracteres, o tipo `char` é unicamente um caractere, e define-se usando aspas simples, contrário do tipo string, e.g.: `char minhaVariávelChar = 'a';`
3. Inteiro - Define-se usando explicitamente números e usando a *keyword* `int`, e.g.: `int minhaVariávelInteira = 15;`
4. Double - Define-se de modo semelhante ao tipo Inteiro, com a exceção de que suporta números com ponto flutuante, com uma precisão de até 15 à 17 dígitos e usa-se a *keyword* `double`(opcionalmente, adiciona-se a letra `d` após o número), e.g.: `double minhaVariávelDouble = 15.25;`
5. Decimal - Igualmente ao tipo double, suporta ponto flutuante com uma precisão de 28 à 29 dígitos, e usa-se a *keyword* `decimal` e especificar com a letra `m` após o número para declarar de modo explícito ao compilador que se trata de um número decimal,  e.g.: `decimal minhaVariávelDecimal = 15.25m;`
6. Float - Igual ao decimal, porém com uma precisão de ponto flutuante de somente 6 à 9 dígitos, e usa-se a *keyword* `float` e diferentemente do decimal, usa-se a letra `f`, e.g.: `float minhaVariávelFloat = 15.25f;`

___

## Níveis de Acessibilidade
**Os níveis de acessibilidade definem o escopo onde determinada variável, função, ou classe é assecível.**

- public - Nível de acesso público, podendo ser acessada de qualquer lugar
- private - Nível de acesso privado, onde só pode ser acessada dentro de seu escopo
- protected - Nível de acesso protegido, semelhante ao private, porém pode ser acessada de classes que herdem de seu *pai*

___

## Funções
Funções são determinados blocos de códigos a serem executados sempre que a função for chamada, sua principal funcionalidade é evitar o D.R.Y (Dont Repeat Yourself)  

### Argumentos (ou Parâmetros)
Argumentos são passados na chamada da função, normalmente necessários para sua correta execução
*Argumentos são passados entre parênteses, e.g.*: `MinhaFunção(Argumento)`

### Tipo de Retorno
Dependendo do retorno da função, deve-se utilizar diferentes palavras-chaves(keywords)

- Para retornos do tipo string, usa-se a *keyword* `string`
- Para retornos do tipo int, usa-se a *keyword* `int`
- Para retornos do tipo booleano, usa-se a *keyword* `bool`
- Para retornos do tipo decimal, usa-se a *keyword* `decimal`
- Para retornos do tipo double, usa-se a *keyword* `double`
- Para retornos vazios, onde não se retorna nada, usa-se a *keyword* `void`

e.g.:
```csharp
public string MeuMetodo()
{
    return "Essa é uma string";
}
```

___

## Classes
As classes são agrupamentos de características comuns e relacionadas, e serve de molde para a criação de objetos.

### Métodos
Métodos são funções específicas de uma classe, que resolvem determinado problema.

#### Sobrecarga de Método
Pode-se nomear mais de um método com o mesmo nome, porém seu número de argumentos deve diferir, e.g.:

```csharp
public void MeuMetodo()
{
    bla bla bla
}
public void MeuMetodo(argumento)
{
    bla bla bla
}
public void MeuMetodo(arg1, arg2)
{
    bla bla bla
}
```

___

# Anotação sobre Markdown