using System;
using System.IO;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string Arquivo = "arq.txt";
        string[] palavras = File.ReadAllText(Arquivo).Split(new[] { ' ', '!', '?', ',', '.', '"' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> dicionario = new Dictionary<string, int>();
        for (int i = 0; i < palavras.Length; i++)
        {
            palavras[i] = palavras[i].ToUpper();

            if (dicionario.ContainsKey(palavras[i]))
            {
                dicionario[palavras[i]]++;
            }
            else
            {
                dicionario.Add(palavras[i], 1);
            }
        }
        while (true)
        {
            try
            {
                Console.WriteLine("\n****MENU DE OPÇÕES****\n\n1)Veriricar se uma determinada palavra consta no dinicionário\n2)Consultar quantas palavras distintas existem no dicionário\n3)Imprimir todas as palavras e frequência de ocorreêcias\n4)Encerrar Programa\n");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 4)
                {
                    Console.WriteLine("\n****PROGRAMA ENCERRADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome da palavra que deseja verificar:");
                        string palavra = Console.ReadLine();
                        palavra = palavra.ToUpper();

                        if (dicionario.ContainsKey(palavra))
                        {
                            Console.WriteLine("\n****ESSA PALAVRA EXISTE NO DICIONÁRIO***\n*");
                        }
                        else
                        {
                            Console.WriteLine("\n****ESSA PALAVRA NÃO EXISTE NO DICIONÁRIO****\n");
                        }
                        break;

                    case 2:
                        int quant_palavras = 0;
                        quant_palavras = dicionario.Count;
                        Console.WriteLine($"\n****ESSE DICIONÁRIO POSSUI {quant_palavras} PALAVRAS DISTINTAS****\n");
                        break;
                    case 3:
                        Console.WriteLine("\n****PALAVRAS DO ARQUIVO****\n");
                        foreach (KeyValuePair<string, int> d in dicionario)
                        {
                            Console.WriteLine($"Palavra: {d.Key} - Frequência de Ocorrência: {d.Value}");
                        }
                        break;

                    default:
                        Console.WriteLine("****OPÇÃO INVÁLIDA****");
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
