using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula62Exe2.Entidades
{
    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo, long kmAtual, int ano, string cor, string placa) : base(marca, modelo, kmAtual, ano, cor, placa)
        {
        }

       
    }

    public class RepositorioMoto
    {
        public static List<Moto> InicializarMotos()
        {
            List<Moto> motos = new List<Moto>();
            motos.Add(new Moto("Honda", "CG 160", 324556, 2020, "Vermelha", "CFG2343"));
            motos.Add(new Moto("Honda", "BROS 160", 324556, 2021, "Preta", "GST6449"));
            motos.Add(new Moto("Yamaha", "FAZER 250", 632456, 2019, "Preta", "CJH0543"));
            motos.Add(new Moto("Kawasaki", "Z400", 556, 2022, "Verde", "GFD0023"));
            return motos;
        }
    }
}
