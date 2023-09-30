using System.Text;
class Agenda
{
    public string nome = "";
    public int telefone = 0;
    public string email = "";

    public List<Agenda> contatos = new List<Agenda>();

    public void Construtor(string nome, int telefone, string email)
    {
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
    }
    public void InserirContato(string nome, int telefone, string email)
    {
        Agenda novoContato = new Agenda();
        novoContato.Construtor(nome, telefone, email);
        contatos.Add(novoContato);
        Console.WriteLine("\n****CONTATO CADASTRADO COM SUCESSO****");
    }
}