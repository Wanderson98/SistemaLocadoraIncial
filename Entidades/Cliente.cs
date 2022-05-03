using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula62Exe2.Entidades
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; }
        public long CPF { get; }
        public char Genero { get; private set; }
        public int CNH { get; private set; }

        public Cliente(string nome, DateTime dataNascimento, long cpf, char genero, int cnh)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            Genero = genero;
            CNH = cnh;
        }

        public override string ToString()
        {
            return Nome + " - " + DataNascimento.ToString("dd/MM/yyy") + " - CPF: " + CPF;
        }

    }
    public class RepositorioCliente
    {
        public static List<Cliente> InicializarCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("João Pedro", DateTime.Parse("23/06/1996"), 32454312452, 'M', 23454394));
            clientes.Add(new Cliente("Ricardo", DateTime.Parse("12/08/1987"), 32345624532, 'M', 76543495));
            clientes.Add(new Cliente("Ana Luiza", DateTime.Parse("03/02/2000"), 32454312452, 'F', 82374329));
            clientes.Add(new Cliente("Joana ", DateTime.Parse("28/11/1999"), 32454312452, 'F', 28326387));
            return clientes;
        }
    }
}
