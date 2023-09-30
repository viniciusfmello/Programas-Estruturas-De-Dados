using System;
using System.Collections.Generic;
class Program
{
    static List<string> filmes = new List<string>();
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU DE OPÇÕES--------------------\n\n1)Inserir filme no final da lista\n2)Inserir um filme em uma posição específica\n3)Remover um filme da lista\n4)Remover um filme em uma posição específica da lista\n5)Pesquisar se um filme consta na lista\n6)Listar todos os filmes da lista\n7)Inverter a ordemdos filmes presentes na lista\n8)Ordenar lista de filmes\n9)Encerrar o Programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 9)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        InserirFilmeFinal();
                        break;

                    case 2:
                        InserirFilmeEspe();
                        break;

                    case 3:
                        RemoverFilme();
                        break;

                    case 4:
                        RemoverFilmePosi();
                        break;

                    case 5:
                        PesquisarFilme();
                        break;

                    case 6:
                        ListarTodosFilmes();
                        break;

                    case 7:
                        InverterOrdem();
                        break;

                    case 8:
                        OrdenarFilmes();
                        break;

                    default:
                        Console.WriteLine("\n****Digite uma opção válida:****\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("OPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
    static void InserirFilmeFinal()
    {
        bool tem = false;
        Console.WriteLine("Digite o nome do filme que você deseja adicionar no final da lista.");
        string nomeFilme = Console.ReadLine();
        tem = filmes.Contains(nomeFilme);
        if (tem)
        {
            Console.WriteLine("****ESSE FILME JÁ EXISTE NA LISTA****\n");

        }
        else if (!tem)
        {
            filmes.Add(nomeFilme);
            Console.WriteLine("****FILME ADICIONADO NO FINAL DA LISTA****\n");
        }

    }
    static void InserirFilmeEspe()
    {
        bool tem = false;
        try
        {
            Console.WriteLine("Digite o nome do filme que você deseja adicionar");
            string nomeFilme = Console.ReadLine();
            tem = filmes.Contains(nomeFilme);
            if (tem == true)
            {
                Console.WriteLine("****ESSE FILME JÁ EXISTE NA LISTA****");
            }
            else
            {
                Console.WriteLine("Digite a posição específica que você deseja adicionar o filme");
                int posicao = int.Parse(Console.ReadLine());
                filmes.Insert(posicao, nomeFilme);
                Console.WriteLine($"****FILME ADICIONADO NA POSIÇÃO {posicao} DA LISTA****");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("****ESSA POSIÇÃO NÃO EXISTE****");
        }
    }
    static void RemoverFilme()
    {
        bool existe = false;

        Console.WriteLine("Digite o nome do filme que você deseja remover da lista");
        string NomeFilme = Console.ReadLine();
        int posicao = filmes.BinarySearch(NomeFilme);
        if (posicao >= 0)
        {
            existe = true;
            filmes.Remove(NomeFilme);
            Console.WriteLine("****FILME REMOVIDO DA LISTA****\n");
        }
        if (!existe)
        {
            Console.WriteLine("****ESSE FILME NÃO EXISTE NA LISTA****\n");
        }
    }
    static void RemoverFilmePosi()
    {
        int posicao = 0;
        string nome;

        Console.WriteLine("Digite a posição do filme deseja remover:");
        posicao = int.Parse(Console.ReadLine());

        if (posicao > filmes.Count)
        {
            Console.WriteLine("****POSIÇÃO NÃO EXISTE NA LISTA****\n");
        }
        else
        {
            nome = filmes[posicao];
            filmes.RemoveAt(posicao);
            Console.WriteLine($"*****FILME {nome} FOI REMOVIDO****\n");
        }
    }
    static void PesquisarFilme()
    {
        bool tem = false;
        Console.WriteLine("Digite o nome do filme");
        string nomeFilme = Console.ReadLine();
        tem = filmes.Contains(nomeFilme);
        if (tem)
        {
            Console.WriteLine("***FILME PRESENTE NA LISTA!****\n");
        }
        else
        {
            Console.WriteLine("****FILME NÃO ESTÁ PRESENTE NA LISTA****\n");
        }
    }
    static void ListarTodosFilmes()
    {
        Console.WriteLine("\n****LISTA DE FILMES****\n");
        for (int i = 0; i < filmes.Count; i++)
        {
            Console.WriteLine(filmes[i]);
        }
    }
    static void InverterOrdem()
    {
        filmes.Reverse();
        Console.WriteLine("\n****FILMES INVERTIDOS****\n");

        foreach (object f in filmes)
        {
            Console.WriteLine(f);
        }
    }
    static void OrdenarFilmes()
    {
        filmes.Sort();
        Console.WriteLine("\n****FILMES ORDENADOS***\n");
        foreach (object f in filmes)
        {
            Console.WriteLine(f);
        }
    }
}