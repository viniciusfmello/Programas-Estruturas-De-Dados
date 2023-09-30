using System;
using System.Collections.Generic;
class Program
{
    static List<int> numeros = new List<int>();
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU DE OPÇÕES--------------------\n\n1)Inserir um número na lista\n2)Verificar se um número consta na lista\n3)Exibir a soma de todos números\n4)Exibir o maior número da lista\n5)Exibir o menor número da lista\n6)Remover números pares\n7)Exibir números da lista sem pares\n8)Inverter os números\n9)Encerrar o programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 9)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        InserirNumero();
                        break;

                    case 2:
                        VerificaNumero();
                        break;

                    case 3:
                        SomaNumeros();
                        break;

                    case 4:
                        int maior = Int32.MinValue;
                        for (int i = 0; i < numeros.Count; i++)
                        {
                            if (maior < numeros[i])
                            {
                                maior = numeros[i];
                            }
                        }
                        Console.WriteLine($"O maior número da lista é: {maior}");
                        break;

                    case 5:
                        int menor = Int32.MaxValue;
                        for (int i = 0; i < numeros.Count; i++)
                        {
                            if (menor > numeros[i])
                            {
                                menor = numeros[i];
                            }
                        }
                        Console.WriteLine($"O menor número da lista é: {menor}");
                        break;
                        break;

                    case 6:
                        RemoverPares();
                        break;

                    case 7:
                        ExibirSemPares();
                        break;
                    case 8:
                        InverterNumeros();
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
    static void InserirNumero()
    {
        bool tem = false;
        Console.WriteLine("Digite o número que você deseja adicionar na lista");
        int numero = int.Parse(Console.ReadLine());
        tem = numeros.Contains(numero);

        if (tem)
        {
            Console.WriteLine("\n****ESSE NÚMERO 'EXISTE NA LISTA****\n");
        }
        else
        {
            numeros.Add(numero);
            Console.WriteLine($"****NÚMERO {numero} ADICIONADO NA LISTA****\n");
        }
    }
    static void VerificaNumero()
    {
        bool tem = false;
        Console.WriteLine("Digite o número que você deseja verificar");
        int numero = int.Parse(Console.ReadLine());
        tem = numeros.Contains(numero);

        if (tem)
        {
            Console.WriteLine("\n****ESSE NÚMERO EXISTE NA LISTA****\n");
        }
        else
        {
            Console.WriteLine("****ESSE NÚMERO NÃO EXISTE NA LISTA****\n");
        }
    }
    static void SomaNumeros()
    {
        float soma = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            soma += numeros[i];
        }
        Console.WriteLine($"\nA soma de todos os números da lista é: {soma}");
    }
    static void RemoverPares()
    {
        bool tem = false;
        int num = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                numeros.Remove(numeros[i]);
                tem = true;
            }
        }
        if (tem)
        {
            Console.WriteLine("****OS NÚMEROS PARES FORAM REMOVIDOS DA LISTA****");
        }
        else
        {
            Console.WriteLine("****NÃO EXISTE NÚMEROS PARES NA LISTA****");
        }
    }
    static void ExibirSemPares()
    {
        bool tem = false;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                tem = true;
            }
        }
        if (tem)
        {
            Console.WriteLine("**** SÓ É POSSÍVEL EXIBIR OS NÚMEROS CASO OS PARES SEJAM REMOVIDOS.");
        }
        else
        {
            Console.WriteLine("****LISTA DE NÚMEROS SEM PARES****");
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
    static void InverterNumeros()
    {
        numeros.Reverse();
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}