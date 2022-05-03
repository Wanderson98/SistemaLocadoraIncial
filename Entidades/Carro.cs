using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula62Exe2.Entidades
{
    public class Carro : Veiculo
    {
        public Carro(string marca, string modelo, long kmAtual, int ano, string cor, string placa) : base(marca, modelo, kmAtual, ano, cor, placa)
        {
        }

    }
    public class RepositorioCarros
    {
        public static List<Carro> InicializarCarros()
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("Ford", "Fiesta", 324545, 2020, "Prata", "CSD2343"));
            carros.Add(new Carro("Chevrolet", "S10", 3245645, 2021, "Preta", "KCS4843"));
            carros.Add(new Carro("Volkswagen", "Golf", 053545, 2019, "Vermelho", "GVB2673"));
            carros.Add(new Carro("Nissan", "Match",8632565, 2020, "Vermelho", "UVS3843"));
            carros.Add(new Carro("Ford", "Focus", 435545, 2021, "Prata", "KGH5436"));

            return carros;
        }
    }
}
