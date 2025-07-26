using System;
using System.Net.Http.Headers;
using System.Numerics;

public class LogicaModulo_1
{
    public static void VerificaParImpar()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Clear();

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é PAR.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ÍMPAR.");
        }
    }
    public static void VerificaMaiorNumero()
    {
        int numero_1 = 2;
        int numero_2 = 1;

        if (numero_1 > numero_2)
        {
            Console.Write($"Maior número: {numero_1}");
        }
        else
        {
            Console.Write($"Maior número: {numero_2}");
        }
    }
    public static void SomarDezNumeros()
    {
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        int soma = 0;

        foreach (int numero in numeros)
        {
            soma = soma + numero;
        }

        Console.Write($"A soma dos números é: {soma}");
    }
    public static void ContagemRegressiva()
    {
        int numero = 10;

        Console.WriteLine("Contagem regressiva:");
        while (numero >= 0)
        {
            Console.WriteLine(numero);
            numero = numero - 1;
        }
    }   
    public static void Tabuada(int numero)
    {
        Console.WriteLine($"Tabuada de {numero}:");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numero}x{i} = {numero * i}");
        }
    }
    public static void VerificarNumeroPrimo(int numero)
    {
        if (numero/numero == 1 && numero/1 == numero)
        {
            Console.Write($"O número {numero} É PRIMO.");
        }
        else
        {
            Console.Write($"O número {numero} NÃO É PRIMO.");
        }
    }
    public static void TentativasSenha()
    {
        int limite_de_tentativas = 2;
        string senha_correta = "strong_password";
        string tentativa;

        Console.Write("Digite uma senha: ");
        tentativa = Console.ReadLine();

        while (tentativa != senha_correta && limite_de_tentativas > 0)
        {
            Console.Clear();
            Console.WriteLine("Senha incorreta! Tente novamente.");
            limite_de_tentativas -= 1;
            Thread.Sleep(2000);
            
            Console.Clear();
            Console.WriteLine($"Faltam {limite_de_tentativas + 1} tentativa(s)");
            Console.Write("Digite uma senha: ");
            tentativa = Console.ReadLine();
        }

        if (tentativa == senha_correta)
        {
            Console.Clear();
            Console.Write("Parabéns! Você digitou a Senha correta!");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Nenhuma das senhas digitadas corresponde a correta.\n");
        }

        Thread.Sleep(3000);
    }
    public static void ContarVogais(string palavra)
    {
        string palavra_formatada = palavra.ToLower();
        int contagem_de_vogais = 0;

        List<char> lista_de_vogais = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

        foreach (char letra in palavra_formatada)
        {
            if (lista_de_vogais.Contains(letra))
            {
                contagem_de_vogais++;
            }
        }

        if (contagem_de_vogais == 1)
        {
            Console.Write($"A palavra '{palavra}' tem {contagem_de_vogais} vogal.\n");
        }
        else if (contagem_de_vogais > 1)
        {
            Console.Write($"A palavra '{palavra}' tem {contagem_de_vogais} vogais.\n");
        }
        else
        {
            Console.Write($"A palavra '{palavra}' não possui nenhuma vogal.\n");
        }
        Thread.Sleep(3000);
    }
    public static void AdivinharNumero()
    {
        Random numero_aleatorio = new Random();
        int numero_sorteado = numero_aleatorio.Next(1, 11);
        
        Console.Write("Digite um número de entre 1 e 10: ");
        int tentativa = int.Parse(Console.ReadLine());

        if (tentativa > 10)
        {
            Console.Clear();
            Console.Write($"Número inválido!\nVocê digitou o número {tentativa}, porém só são aceitos números entre 1 e 10!\n");
        }
        else if (tentativa == numero_sorteado)
        {
            Console.Clear();
            Console.Write($"Você acertou, parabéns!\nO número secreto é {numero_sorteado}\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Tentativa incorreta!\n\nNúmero secreto: {numero_sorteado}\nSua tentativa: {tentativa}");
        }
        Thread.Sleep(3000);
    }
}