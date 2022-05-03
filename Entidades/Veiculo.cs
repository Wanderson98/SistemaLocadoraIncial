using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula62Exe2.Entidades.Enums;

namespace Aula62Exe2.Entidades
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public long KmAtual { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

        public Veiculo(string marca, string modelo, long kmAtual, int ano, string cor, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            KmAtual = kmAtual;
            Ano = ano;
            Cor = cor;
            Placa = placa;
        }

        public override string ToString()
        {
            return Marca + " - " + Modelo + " - " + Ano + " - " + Cor;
        }
    }


}
