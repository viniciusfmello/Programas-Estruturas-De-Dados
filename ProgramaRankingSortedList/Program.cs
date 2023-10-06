using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> ranking = new SortedList<int, string>();
        while (true)
        {
            try
            {
                Console.WriteLine("\n****MENU DE OPÇÕES****\n\n1)Adicionar um novo jogador\n2)Verificar pontuação de um jogador\n3)Remover um jogador\n4)Exibir Ranking\n5)Encerrar programa\n");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 5)
                {
                    Console.WriteLine("\n****PROGRAMA ENCERRADO****\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do jogador");
                        string nome = Console.ReadLine();
                        nome = nome.ToUpper();
                        if (ranking.ContainsValue(nome))
                        {
                            Console.WriteLine($"****O JOGADOR {nome} JÁ EXISTE NO RANKING****");
                        }
                        else
                        {
                            Console.WriteLine("Digite a pontuação do jogador");
                            int pontuacao = int.Parse(Console.ReadLine());

                            if (ranking.ContainsKey(pontuacao))
                            {
                                Console.WriteLine($"****A PONTUAÇÃO{pontuacao} JÁ EXISTE NO RANKING****");
                            }
                            else
                            {
                                ranking.Add(pontuacao, nome);
                                Console.WriteLine($"\n*****JOGADOR {nome} ADICIONADO NO RANKING****\n");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome do jogador que deseja saber a pontuação");
                        string nomePontuacao = Console.ReadLine();
                        nomePontuacao = nomePontuacao.ToUpper();

                        if (ranking.ContainsValue(nomePontuacao))
                        {
                            foreach (KeyValuePair<int, string> d in ranking)
                            {
                                if (d.Value == nomePontuacao)
                                {
                                    Console.WriteLine($"\n****A PONTUAÇÃO DO JOGADOR {nomePontuacao} É: {d.Key}****\n");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n****JOGAR NÃO EXISTE NO RANKING****\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome do jogador que deseja remover");
                        string nomeRemover = Console.ReadLine();
                        nomeRemover = nomeRemover.ToUpper();
                        if (ranking.ContainsValue(nomeRemover))
                        {
                            int indice = ranking.IndexOfValue(nomeRemover);
                            ranking.RemoveAt(indice);
                            Console.WriteLine($"\n**** O JOGADOR {nomeRemover} FOI REMOVIDO DO RANKING****\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n****NÃO EXISTE JOGADOR COM ESSE NOME****\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n****RANKING PONTUAÇÃO****\n");
                        foreach (KeyValuePair<int, string> r in ranking)
                        {
                            Console.WriteLine($"Pontuação: {r.Key} - Jogador: {r.Value}");
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