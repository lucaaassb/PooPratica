
using PooPratica;
using System.Runtime.CompilerServices;

static void Main(string[] args)
{
    var professor = new Professor(6500, "Lucas", "XXX.XXX.XXX-XX", new DateTime(1992, 1, 1)); //Inicialização usando as classes criadas
    var estudante = new Estudante("A", "Luis", "XXX.XXX.XXX-XX", new DateTime(2002, 22, 02));

    var pessoas = new List<Pessoa> { estudante, professor };

    foreach (var pessoa in pessoas) //Foreach percorrendo a lista de pessoas criadas acima e usando o método Apresentar em cada uma delas
    {
        pessoa.SeApresentar();
    }

    Console.Read();
}
