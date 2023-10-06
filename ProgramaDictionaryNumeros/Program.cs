using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números você deseja adicionar na lista?");
        int quant = int.Parse(Console.ReadLine());

        List<int> numeros = new List<int>(quant);
        Dictionary<int, int> dicionarioNumeros = new Dictionary<int, int>();
        int num = 0;
        Console.WriteLine($"Digite os {quant} números para preencher a lista");
        for (int i = 0; i < quant; i++)
        {
            num = int.Parse(Console.ReadLine());
            numeros.Add(num);
            if (dicionarioNumeros.ContainsKey(numeros[i]))
            {
                dicionarioNumeros[numeros[i]]++;
            }
            else
            {
                dicionarioNumeros.Add(numeros[i], 1);
            }
        }

        while (true)
        {
            try
            {
                Console.WriteLine("\n\n****MENU DE OPÇÕES*****\n\n1)Verificar se um número consta no dicionário\n2)Consultar quantidade de números distintos\n3)Imprimir todos números e suas frequências\n4)Encerrar programa\n");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 4)
                {
                    Console.WriteLine("\n****PROGRAMA ENCERRADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o número que deseja pesquisar no dicionário:");
                        int numero = int.Parse(Console.ReadLine());

                        if (dicionarioNumeros.ContainsKey(num))
                        {
                            Console.WriteLine("\n****O NÚMERO EXISTE NO DICIÓNÁRIO****\n");
                        }
                        else
                        {
                            Console.WriteLine("\n****O NÚMERO NÃO EXISTE NO DICIÓNÁRIO****\n");
                        }
                        break;
                    case 2:
                        int quant_num = 0;
                        foreach (KeyValuePair<int, int> d in dicionarioNumeros)
                        {
                            if (d.Value >= 1)
                            {
                                quant_num++;
                            }
                        }
                        quant_num = dicionarioNumeros.Count;
                        Console.WriteLine($"\n****ESSE DICIONÁRIO TEM {quant_num} NÚMEROS DISTINTOS****");
                        break;
                    case 3:
                        Console.WriteLine("\n****NÚMEROS DO DICIONÁRIO****\n");
                        foreach (KeyValuePair<int, int> d in dicionarioNumeros)
                        {
                            Console.WriteLine($"Número: {d.Key} - Frequência: {d.Value}");
                        }
                        break;
                    default:
                        Console.WriteLine("\n****OPÇÃO INVÁLIDA****\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nOPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
}