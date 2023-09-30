// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU DE OPÇÕES--------------------\n\n1 Adicionar um novo contato\n2)Atualizar informaçõesde um contato existente\n3)Excluir um contato da agenda\n4)Listar todos contatos da agenda\n5)Encerrar o programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 5)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        AdicionarContato(agenda);
                        break;

                    case 2:
                        AtualizarInfos(agenda);
                        break;

                    case 3:
                        ExcluirContato(agenda);
                        break;

                    case 4:
                        Console.WriteLine("\n****LISTA DE TODOS CONTATOS****\n");
                        for (int i = 0; i < agenda.contatos.Count; i++)
                        {
                            Console.WriteLine($"------------\nNome: {agenda.contatos[i].nome}\nTelefone: {agenda.contatos[i].telefone}\nE-mail: {agenda.contatos[i].email}\n------------\n");
                        }
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
    static void AdicionarContato(Agenda agenda)
    {
        string email = "";
        bool tem = false;
        Console.WriteLine("Digite o nome do contato");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o telefone do novo contato (APENAS NÚMEROS)");
        int telefone = int.Parse(Console.ReadLine());
        try
        {
            for (int i = 0; i < agenda.contatos.Count; i++)
            {
                if (agenda.contatos[i].telefone == telefone)
                {
                    Console.WriteLine("****ESSE TELEFONE JÁ EXISTE NA LISTA DE CONTATOS****");
                    tem = true;
                    break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("****APENAS NÚMEROS!****");
        }
        if (!tem)
        {
            Console.WriteLine("Digite o e-mail do novo contato");
            email = Console.ReadLine();
            for (int i = 0; i < agenda.contatos.Count; i++)
            {
                if (agenda.contatos[i].email == email)
                {
                    Console.WriteLine("****ESSE EMAIL JÁ EXISTE NA LISTA DE CONTATOS****");
                    tem = true;
                    break;
                }
            }
        }
        if (!tem)
        {
            nome = nome.ToUpper();
            agenda.InserirContato(nome, telefone, email);
        }
    }
    static void AtualizarInfos(Agenda agenda)
    {
        Console.WriteLine("\n****CONTATOS****\n");
        for (int i = 0; i < agenda.contatos.Count; i++)
        {
            Console.WriteLine($"------------\nNome: {agenda.contatos[i].nome}\nTelefone: {agenda.contatos[i].telefone}\nE-mail: {agenda.contatos[i].email}\n------------\n");
        }
        Console.WriteLine("Você deseja editar o contato de qual número?");
        int num = int.Parse(Console.ReadLine());
        try
        {
            bool tem = false;
            int posi = 0;
            foreach (Agenda contato in agenda.contatos)
            {
                if (contato.telefone == num)
                {
                    tem = true;
                    break;
                }
            }
            if (tem)
            {
                for (int i = 0; i < agenda.contatos.Count; i++)
                {
                    if (agenda.contatos[i].telefone == num)
                    {
                        posi = i;
                    }
                }
                Console.WriteLine("O que você deseja alterar?\n1)Nome\n2)Telefone\n3)Email");
                int opcao = int.Parse(Console.ReadLine());
                string nome, email;
                int tell = 0;

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Para qual nome você deseja substituir?");
                        nome = Console.ReadLine();
                        nome = nome.ToUpper();
                        agenda.contatos[posi].nome = nome;

                        Console.WriteLine("****NOME ALTERADO NA LISTA****\n");
                        break;

                    case 2:
                        Console.WriteLine("Para qual número você deseja substituir?");
                        tell = int.Parse(Console.ReadLine());

                        agenda.contatos[posi].telefone = tell;
                        Console.WriteLine("****TELEFONE ALTERADO NA LISTA****\n");
                        break;

                    case 3:
                        Console.WriteLine("Para qual e-mail você deseja substituir?");
                        email = Console.ReadLine();
                        agenda.contatos[posi].email = email;
                        Console.WriteLine("****E-MAIL ALTERADO NA LISTA****\n");
                        break;

                    default:
                        Console.WriteLine("****OPÇÃO INVÁLIDA****");
                        break;
                }
            }
            else
            {
                Console.WriteLine("****O NÚMERO NÃO EXISTE NA LISTA*****\n");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("****APENAS NÚMEROS!****\n");
        }
    }
    static void ExcluirContato(Agenda agenda)
    {
        Console.WriteLine("\n****CONTATOS****\n");
        for (int i = 0; i < agenda.contatos.Count; i++)
        {
            Console.WriteLine($"------------\nNome: {agenda.contatos[i].nome}\nTelefone: {agenda.contatos[i].telefone}\n------------\n");
        }
        Console.WriteLine("Digite o número do contato que deseja excluir da lista");
        int tell = int.Parse(Console.ReadLine());
        try
        {
            bool tem = false;
            int posi = 0;
            foreach (Agenda contato in agenda.contatos)
            {
                if (contato.telefone == tell)
                {
                    tem = true;
                    break;
                }
            }
            if (tem)
            {
                for (int i = 0; i < agenda.contatos.Count; i++)
                {
                    if (agenda.contatos[i].telefone == tell)
                    {
                        posi = i;
                    }
                }
                agenda.contatos.RemoveAt(posi);
                Console.WriteLine("****CONTATO REMOVIDO DA LISTA****");
            }
            else
            {
                Console.WriteLine("****O NÚMERO NÃO EXISTE NA LISTA*****\n");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("****APENAS NÚMEROS!****\n");
        }

    }
}