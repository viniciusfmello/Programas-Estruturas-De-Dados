using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SortedList<string, List<string>> dicionario = new SortedList<string, List<string>>();
        while (true)
        {
            try
            {
                Console.WriteLine("\n****MENU DE OPÇÕES****\n\n1)Adicionar uma nova palavra e seus sinonimos\n2)Pesquisar sinônimo de uma palavra\n3)Exibir o dicionário em ordem alfabética\n4)Excluir palavra\n5)Encerrar o programa\n");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 5)
                {
                    Console.WriteLine("\n****PROGRAMA ENCERRADO****\n");
                    break;

                }
                switch (opcao)
                {
                    case 1:
                        CadastrarPalavra(dicionario);
                        break;

                    case 2:
                        PesquisarSinonimos(dicionario);
                        break;

                    case 3:
                        ExibirDicionario(dicionario);
                        break;
                    case 4:
                        ExcluirPalavra(dicionario);
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
    static void CadastrarPalavra(SortedList<string, List<string>> dicionario)
    {
        List<string> sinonimos = new List<string>();
        Console.WriteLine("\nDigite a palavra que deseja adicionar");
        string palavra = Console.ReadLine();
        palavra = palavra.ToUpper();

        if (dicionario.ContainsKey(palavra))
        {
            Console.WriteLine("\n****ESSA PALAVRA JÁ EXISTE NO DICIONÁRIO****\n");
        }
        else
        {
            while (true)
            {
                Console.WriteLine("\nDigite o sinônimo dessa palavra");
                string sinonimoPalavra = Console.ReadLine();
                sinonimoPalavra = sinonimoPalavra.ToUpper();
                sinonimos.Add(sinonimoPalavra);

                Console.WriteLine("\nVocê deseja adicionar mais sinônimos?\n1)Sim\n2)Não");
                int deseja = int.Parse(Console.ReadLine());
                if (deseja == 2)
                {
                    dicionario.Add(palavra, sinonimos);
                    Console.WriteLine("\n****PALAVRA E SINÔNIMO(S) ADICONADAS NO DICIONÁRIO****\n");
                    break;
                }
                switch (deseja)
                {
                    case 1:
                        break;
                    default:
                        Console.WriteLine("\n****OPÇÃO INVÁLIDA****\n");
                        break;
                }
            }
        }
    }
    static void PesquisarSinonimos(SortedList<string, List<string>> dicionario)
    {
        List<string> palavras = new List<string>();
        Console.WriteLine("Digite o nome da palavra que deseja consultar os sinônimos.");
        string palavra = Console.ReadLine();
        palavra = palavra.ToUpper();
        if (dicionario.ContainsKey(palavra))
        {
            foreach (KeyValuePair<string, List<string>> d in dicionario)
            {
                if (d.Key == palavra)
                {
                    palavras = d.Value;
                }
            }
            Console.WriteLine($"\n****SINONIMOS DA PALAVRA {palavra}****\n");
            for (int i = 0; i < palavras.Count; i++)
            {
                Console.WriteLine(palavras[i]);
            }
        }
        else
        {
            Console.WriteLine($"\n****A PALAVRA {palavra} NÃO EXISTE NO DICIONÁRIO****\n");
        }
    }
    static void ExibirDicionario(SortedList<string, List<string>> dicionario)
    {
        Console.WriteLine("\n****PALAVRAS DO DICIONÁRIO EM ORDEM ALFABÉTICA****\n");
        foreach (KeyValuePair<string, List<string>> d in dicionario)
        {
            Console.WriteLine($"Palavra: {d.Key}");
        }
    }
    static void ExcluirPalavra(SortedList<string, List<string>> dicionario)
    {
        Console.WriteLine("Digite a palavra que você deseja remover do dicionário");
        string palavra = Console.ReadLine();
        palavra = palavra.ToUpper();

        if (dicionario.ContainsKey(palavra))
        {
            dicionario.Remove(palavra);
            Console.WriteLine($"\n*****PALAVRA {palavra} REMOVIDA DO DICIONÁRIO****\n");
        }
        else
        {
            Console.WriteLine("\n****ESSA PALAVRA NÃO EXISTE NO DICIONÁRIO****\n");
        }
    }
}
