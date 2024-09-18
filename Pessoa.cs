using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PooPratica
{
    public abstract class Pessoa //classe
    {
        public Pessoa(string nome, string documento, DateTime dataNascimento) //construtor
        {
            Nome = nome;
            Documento = documento;  //Sempre inicializar as variáveis dentro do construtor
            DataNascimento = dataNascimento;
        }

        public string Nome { get; protected set; } //Encapsulamento
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public virtual void SeApresentar() //Método de apresentação 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Documento {Documento}, Data de Nascimento: {DataNascimento}");
        }
    }
}
