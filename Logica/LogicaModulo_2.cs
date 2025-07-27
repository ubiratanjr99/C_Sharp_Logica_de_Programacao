using System;
using System.Xml;

public class LogicaModulo_2
{
    public static void ValidadorCPF()
    {
        string cpf = "123.156.789-11";
        cpf = cpf.Replace(".", "").Replace("-","");
        List<char> digito_invalido = new List<char>();
        List<char> numeros = new List<char>() { '1','2','3','4','5','6','7','8','9','0' };

        foreach(char numero in cpf)
        {
            if (!numeros.Contains(numero))
            {
                digito_invalido.Add(numero);
            }
        }

        if (digito_invalido.Count == 0 && cpf.Length == 11)
        {
            Console.WriteLine("CPF válido!");
        }
        else if (cpf.Length != 11 && digito_invalido.Count == 0)
        {
            Console.WriteLine("CPF inválido!\nDigite um CPF que contenha apenas 11 dígitos.\n");
        }
        else
        {
            Console.WriteLine($"CPF inválido! Os caracteres a seguir estão errados:");
            Console.Write("Inválido: ");
            foreach (char caracter in digito_invalido)
            {
                Console.Write($"{caracter} ");
            }
        }
    }
    public static void CaixaEletronico(int saque)
    {
        Dictionary<int, int> notas = new Dictionary<int, int>();

        List<int> cedulas = new List<int>() { 100, 50, 20, 10, 5, 2 };

        int deducao = saque;

        foreach(int cedula in cedulas)
        {
            int qtd_notas = saque / cedula;
            int resto = saque % cedula;

            Console.WriteLine($"{qtd_notas} de {cedula}: {resto}");
        }
    }
}

/*

1. Validador de CPF (estrutura simples)
Peça um CPF no formato xxx.xxx.xxx-xx e verifique se ele tem apenas dígitos e a quantidade correta de números (ignore validação matemática por enquanto).

2. Caixa eletrônico
Simule um caixa eletrônico:

    Usuário digita um valor para sacar (ex: R$ 187)

    O programa devolve quantas notas de R$100, R$50, R$20, R$10, R$5 e R$2 serão entregues

3. Conversor de número para extenso (0 a 20)
Peça um número entre 0 e 20 e mostre ele por extenso (ex: 3 → "três").

# Dica: crie uma lista com os nomes dos números

4. Validador de senha forte
Peça uma senha e verifique se ela:

    Tem no mínimo 8 caracteres
    Tem pelo menos uma letra maiúscula
    Tem pelo menos um número
    Tem pelo menos um caractere especial


5. Matriz identidade
Crie uma matriz identidade de tamanho n × n, onde os valores da diagonal principal são 1 e os demais são 0.

Ex: Para n = 3

1 0 0
0 1 0
0 0 1

6. Contar frequência de letras
Peça uma frase e diga quantas vezes cada letra aparece (ignore espaços e pontuação).

Ex:

Entrada: "banana"
Saída:
b: 1
a: 3
n: 2

*/