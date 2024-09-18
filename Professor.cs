namespace PooPratica
{
    public class Professor : Pessoa //Classe professor herdando atributos da Classe pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento) //Passando por parametro os atributos recebidos da classe pessoa e adicionando os novos
            : base(nome, documento, dataNascimento) //
        {
            Salario = salario; //Inicializando os novos atributos dentro do construtor
            Turmas = new List<string> { "A", "B", "C" };
        }

        public List<string> Turmas { get; private set; } //Encapsulamento
        public decimal Salario { get; private set; }
    }
}
