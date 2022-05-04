using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula62Exe2.Entidades;

namespace Aula62Exe2.Services
{
    public class Locacao
    {
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime DataIncial { get; set; }
        public DateTime DataEntrega { get; set; }
        public double ValorPorHora { get; set; }
        public TimeSpan Duracao { get; set; }
        public double ValorPorDia { get; set; }
        public double ValorTotal { get; set; }
        public double ValorAvaria { get; set; }
        public double Seguro { get; set; }
        public bool Avaria { get; set; }

        public Locacao(Cliente cliente, Veiculo veiculo, DateTime dataIncial, DateTime dataEntrega, double valorPorHora, double valorPorDia, double seguro, double valorAvaria, bool avaria)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            DataIncial = dataIncial;
            DataEntrega = dataEntrega;
            ValorPorHora = valorPorHora;
            ValorPorDia = valorPorDia;
            Seguro = seguro;
            Avaria = avaria;
            ValorAvaria = valorAvaria;
        }

        public void FinalizarLocacao()
        {
            Duracao = DataEntrega.Subtract(DataIncial);
            if(Duracao.TotalHours <= 12) {
                ValorTotal = Math.Ceiling(Duracao.TotalHours) * ValorPorHora + CalcularAvaria() ;
            }
            else
            {
                ValorTotal = Math.Ceiling(Duracao.TotalDays) * ValorPorDia + CalcularAvaria();
            }
        }

        public double CalcularAvaria()
        {
            if (!Avaria)
            {
                return ValorAvaria;
            }
            else
            {
                if(ValorAvaria > Seguro)
                {        
                    return ValorAvaria - Seguro;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double ValorSeguro()
        {
            if(Seguro < ValorAvaria)
            {
                Seguro = 0;
            }
            else
            {
                Seguro -= ValorAvaria;  
            }

            return Seguro;
        }
    }
}
