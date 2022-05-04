using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula62Exe2.Services;
using Aula62Exe2.Entidades;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Aula62Exe2
{
    public partial class Resultado : MaterialForm
    {
        public Locacao Locacao { get; set; }

        public Resultado()
        {
            InitializeComponent();
        }

        public Resultado( Locacao locacao)
        {
            InitializeComponent();
            Locacao = locacao;
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            Locacao.FinalizarLocacao();

            lblCliente.Text = Locacao.Cliente.ToString();
            lblVeiculo.Text = Locacao.Veiculo.ToString();
            if(Locacao.Duracao.TotalHours <= 12)
            {
                lblDuracao.Text = $"{Math.Ceiling(Locacao.Duracao.TotalHours).ToString()} Horas";
            }
            else
            {
                lblDuracao.Text = $"{Math.Ceiling(Locacao.Duracao.TotalDays).ToString()} Dias";
            }

            lblValorTotal.Text = Locacao.ValorTotal.ToString("F2");
            if (Locacao.Avaria)
            {
                lblAvaria.Text = "Sim";
            }
            else
            {
                lblAvaria.Text = "Não";
                lblValorAvaria.Visible = false;
            }

            lblValorAvaria.Text = Locacao.ValorAvaria.ToString("F2");
            lblSeguro.Text = Locacao.ValorSeguro().ToString("F2");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
