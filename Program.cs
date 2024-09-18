
using PooPratica;
using System.Runtime.CompilerServices;

static void Main(string[] args)
{
    var professor = new Professor(6500, "Lucas", "XXX.XXX.XXX-XX", new DateTime(1992, 1, 1));
    var estudante = new Estudante("A", "Luis", "XXX.XXX.XXX-XX", new DateTime(2002, 22, 02));

    var pessoas = new List<Pessoa> { estudante, professor };

    foreach (var pessoa in pessoas)
    {
        pessoa.SeApresentar();
    }

    Console.Read();
}
