namespace PooPratica
{
    public class Estudante : Pessoa //Classe estudante herdando atributos da Classe pessoa
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento) //Passando por parametro os atributos recebidos da classe pessoa e adicionando os novos
            : base(nome, documento, dataNascimento) // Adicionar explicação futuramente
        {
            Turma = turma; //Inicializando os novos atributos dentro do construtor
            Notas = new List<int> { 5, 10, 15, 20, 21 };
        }
        public string Turma { get; private set; } //Encapsulamento
        public List<int> Notas { get; private set; }

        public override void SeApresentar() //Sobrescrita
        {
            base.SeApresentar();

            var media = Notas.Average();

            Console.WriteLine($"Sou estudante da turma {Turma}, e possuo {media} de Média");
        }
    }
}
