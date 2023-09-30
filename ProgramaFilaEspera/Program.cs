using System;
using System.Text;
using System.Collections.Generic;
class Program
{
    static Queue<int> filaIC = new Queue<int>();
    static Queue<int> filaMestrado = new Queue<int>();
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU PRINCIPAL--------------------\n\nQual fila você deseja gerenciar?\n\n1)Fila de espera interessados em bolsas de INICIAÇÃO CIENTÍFICA\n2)Fila de espera de interessados em bolsas de MESTRADO\n3)Encerrar o programa");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 3)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****\n");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        MenuIniciacao();
                        break;

                    case 2:
                        MenuMestrado();
                        break;

                    default:
                        Console.WriteLine("****OPÇÃO INVÁLIDA****");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("OPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
    static void MenuIniciacao()
    {
        while (true)
        {
            Console.WriteLine("\n--------------------MENU DE OPÇÕES INICIAÇÃO CIENTÍFICA--------------------\n\n1)Inserir um aluno na fila de espera de bolsas de IC\n2)Remover um aluno da fila de espera de IC\n3)Mostrar fila de espera de bolsas de IC\n4)Pesquisar aluno na fila de espera de IC\n5)Mostrar qual aluno que está no início da fila de espera de bolsas de IC\n6)Ir ao MENU de MESTRADO\n7)Voltar ao MENU principal");
            int opcao = int.Parse(Console.ReadLine());
            try
            {
                if (opcao == 7)
                {
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        bool tem = false;
                        Console.WriteLine("Digite o código do aluno");
                        int codigoIC = int.Parse(Console.ReadLine());
                        tem = filaIC.Contains(codigoIC);

                        if (tem)
                        {
                            Console.WriteLine($"\n****O ALUNO DE CÓDIGO {codigoIC} JÁ ESTÁ NA FILA DE IC****\n");
                        }
                        else
                        {
                            filaIC.Enqueue(codigoIC);
                            Console.WriteLine("\n****ALUNO ADICIONADO NO FINAL DA FILA DE IC****\n");
                        }
                        break;
                    case 2:
                        int id = 0;
                        id = filaIC.Dequeue();
                        Console.WriteLine($"\n****ALUNO COM ID {id} FOI REMOVIDO DA FILA DE IC****\n");
                        filaIC.Enqueue(filaIC.Dequeue());
                        break;
                    case 3:
                        Console.WriteLine("\n*****ALUNOS NA FILA DE INICIAÇÃO CIENTÍFICA****\n");
                        foreach (int f in filaIC)
                        {
                            Console.WriteLine(f);
                        }
                        break;
                    case 4:
                        bool tem1 = false;
                        Console.WriteLine("Digite o id do aluno que deseja pesquisar na fila de IC.");
                        int id1 = int.Parse(Console.ReadLine());
                        tem1 = filaIC.Contains(id1);
                        if (tem1)
                        {
                            Console.WriteLine($"\n****O ALUNO DE ID {id1} ESTÁ PRESENTE NA FILA DE IC****\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n****O ALUNO DE ID {id1} NÃO ESTÁ PRESENTE NA FILA DE IC*****\n");
                        }
                        break;
                    case 5:
                        int primeiroFila = 0;
                        primeiroFila = filaIC.Peek();
                        Console.WriteLine($"\n****O PRIMEIRO ALUNO DA FILA DE IC TEM O ID {primeiroFila}****\n");
                        break;
                    case 6:
                        MenuMestrado();
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
    static void MenuMestrado()
    {
        while (true)
        {
            Console.WriteLine("\n--------------------MENU DE OPÇÕES MESTRADO--------------------\n\n1)Inserir um aluno na fila de espera de bolsas de MESTRADO\n2)Remover um aluno da fila de espera de MESTRADO\n3)Mostrar fila de espera de bolsas de MESTRADO\n4)Pesquisar aluno na fila de espera de MESTRADO\n5)Mostrar qual aluno que está no início da fila de espera de bolsas de MESTRADO\n6)Ir ao MENU de Iniciação Científica\n7)Voltar ao menu principal");
            int opcao = int.Parse(Console.ReadLine());
            try
            {
                if (opcao == 7)
                {
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        bool tem = false;
                        Console.WriteLine("Digite o código do aluno");
                        int codigoMestrado = int.Parse(Console.ReadLine());
                        tem = filaMestrado.Contains(codigoMestrado);
                        if (tem)
                        {
                            Console.WriteLine($"\n****O ALUNO DE CÓDIGO {codigoMestrado} JÁ ESTÁ NA FILA DE MESTRADO****\n");
                        }
                        else
                        {
                            filaMestrado.Enqueue(codigoMestrado);
                            Console.WriteLine("\n****ALUNO ADICIONADO NO FINAL DA FILA DE MESTRADO****\n");
                        }
                        break;
                    case 2:
                        int id = 0;
                        id = filaMestrado.Dequeue();
                        Console.WriteLine($"\n****ALUNO COM ID {id} FOI REMOVIDO DA FILA DE MESTRADO****\n");
                        filaMestrado.Enqueue(filaMestrado.Dequeue());
                        break;
                    case 3:
                        Console.WriteLine("\n*****ALUNOS NA FILA DE MESTRADO****\n");
                        foreach (int f in filaMestrado)
                        {
                            Console.WriteLine(f);
                        }
                        break;
                    case 4:
                        bool tem1 = false;
                        Console.WriteLine("Digite o id do aluno que deseja pesquisar na fila de mestrado");
                        int id1 = int.Parse(Console.ReadLine());
                        tem1 = filaMestrado.Contains(id1);
                        if (tem1)
                        {
                            Console.WriteLine($"\n****O ALUNO DE ID {id1} ESTÁ PRESENTE NA FILA DE MESTRADO****\n");
                        }
                        else
                        {
                            Console.WriteLine($"\n****O ALUNO DE ID {id1} NÃO ESTÁ PRESENTE NA FILA DE MESTRADO*****\n");
                        }
                        break;
                    case 5:
                        int primeiroFila = 0;
                        primeiroFila = filaMestrado.Peek();
                        Console.WriteLine($"\n****O PRIMEIRO ALUNO DA FILA DE MESTRADO TEM O ID {primeiroFila}****\n");
                        break;
                    case 6:
                        MenuIniciacao();
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
}