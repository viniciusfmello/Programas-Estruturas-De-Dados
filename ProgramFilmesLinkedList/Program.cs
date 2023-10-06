using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> listaFilmes = new LinkedList<string>();
        while (true)
        {
            try
            {

                Console.WriteLine("\n\n****MENU DE OPÇOES****\n\n1)Inserir filme no final da lista\n2)Inserir um filme depois de uma posição específica\n3)Inserir um flme antes de uma posição específica\n4)Remover o filme que está no final da lista\n5)Pesquisar se um filme consta na lista\n6)Listar todos filmes da lista\n7)Encerrar o Programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 7)
                {
                    Console.WriteLine("\n****PROGRAMA ENCERRADO****\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        InserirFinal(listaFilmes);
                        break;

                    case 2:
                        InserirDepoisPosicao(listaFilmes);
                        break;

                    case 3:
                        InserirAntesPosicao(listaFilmes);
                        break;

                    case 4:
                        RemoverFinal(listaFilmes);
                        break;

                    case 5:
                        PesquisarFilme(listaFilmes);
                        break;

                    case 6:
                        Console.WriteLine("\n****LISTA DE FILMES****\n");
                        foreach (string impressao in listaFilmes)
                        {
                            Console.WriteLine(impressao);
                        }
                        break;

                    default:
                        break;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("\nOPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
    static void InserirFinal(LinkedList<string> listaFilmes)
    {
        Console.WriteLine("\nDigite o nome do filme que deseja adicionar na lista");
        string nomeFilmes = Console.ReadLine();
        nomeFilmes = nomeFilmes.ToUpper();

        if (listaFilmes.Contains(nomeFilmes))
        {
            Console.WriteLine($"\n****NÃO É POSSÍVEL ADICIONAR O FILME {nomeFilmes} POIS ELE JÁ CONSTA NA LISTA****\n");
        }
        else
        {
            listaFilmes.AddLast(nomeFilmes);
            Console.WriteLine($"\n****O FILME {nomeFilmes} FOI ADICIONADO NO FINAL DA LISTA****");
        }
    }
    static void InserirDepoisPosicao(LinkedList<string> listaFilmes)
    {
        Console.WriteLine("\nDigite o nome do filme que deseja adicionar");
        string nomeFilme = Console.ReadLine();
        nomeFilme = nomeFilme.ToUpper();

        if (listaFilmes.Contains(nomeFilme))
        {
            Console.WriteLine($"\n****NÃO É POSSÍVEL ADICIONAR O FILME {nomeFilme} POIS ELE JÁ CONSTA NA LISTA****\n");
        }
        else
        {
            Console.WriteLine("\nDeseja adicionar esse filme depois de qual filme?");
            Console.WriteLine("\n****LISTA DE FILMES****\n");
            foreach (string impressao in listaFilmes)
            {
                Console.WriteLine(impressao);
            }
            string nomeDesejado = Console.ReadLine();
            nomeDesejado = nomeDesejado.ToUpper();
            if (listaFilmes.Contains(nomeDesejado))
            {
                LinkedListNode<string> NO = listaFilmes.Find(nomeDesejado);
                listaFilmes.AddAfter(NO, nomeFilme);
                Console.WriteLine($"\n****O FILME {nomeFilme} FOI ADICIONADO DEPOIS DO FILME {nomeDesejado} DA LISTA****");
            }
            else
            {
                Console.WriteLine("\n****ESSE FILME NÃO EXISTE NAS OPÇÕES****\n");
            }
        }
    }
    static void InserirAntesPosicao(LinkedList<string> listaFilmes)
    {
        Console.WriteLine("\nDeseja adicionar esse filme antes de qual filme?");
        string nomeFilme = Console.ReadLine();
        nomeFilme = nomeFilme.ToUpper();

        if (listaFilmes.Contains(nomeFilme))
        {
            Console.WriteLine($"\n****NÃO É POSSÍVEL ADICIONAR O FILME {nomeFilme} POIS ELE JÁ CONSTA NA LISTA****\n");
        }
        else
        {
            Console.WriteLine("\nDeseja adicionar esse filme antes de qual filme?");
            Console.WriteLine("\n****LISTA DE FILMES****\n");
            foreach (string impressao in listaFilmes)
            {
                Console.WriteLine(impressao);
            }
            string nomeDesejado = Console.ReadLine();
            nomeDesejado = nomeDesejado.ToUpper();
            if (listaFilmes.Contains(nomeDesejado))
            {
                LinkedListNode<string> NO = listaFilmes.Find(nomeDesejado);
                listaFilmes.AddBefore(NO, nomeFilme);
                Console.WriteLine($"\n****O FILME {nomeFilme} FOI ADICIONADO ANTES DO FILME {nomeDesejado} DA LISTA****");
            }
            else
            {
                Console.WriteLine("\n****ESSE FILME NÃO EXISTE NAS OPÇÕES****\n");
            }
        }
    }
    static void RemoverFinal(LinkedList<string> listaFilmes)
    {
        listaFilmes.RemoveLast();
        LinkedListNode<string> ultimoFilme = listaFilmes.Last;
        if (ultimoFilme != null)
        {
            Console.WriteLine($"\n****O FILME {ultimoFilme.Value} FOI REMOVIDO DO FINAL DA LISTA****\n");
        }
        else
        {
            Console.WriteLine("\n****NÃO É POSSÍVEL REMOVER FILMES DE UMA LISTA VAZIA****\n");
        }
    }
    static void PesquisarFilme(LinkedList<string> listaFilmes)
    {
        Console.WriteLine("\nDigite o nome do filme que deseja pesquisar");
        string nomeFilme = Console.ReadLine();

        if (listaFilmes.Contains(nomeFilme))
        {
            Console.WriteLine($"\n****O FILME {nomeFilme} EXISTE NA LISTA****\n");
        }
        else
        {
            Console.WriteLine($"\n****O FILME {nomeFilme} NÃO EXISTE NA LISTA****\n");
        }
    }
}