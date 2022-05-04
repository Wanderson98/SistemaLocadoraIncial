using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula62Exe2.Entidades;
using Aula62Exe2.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Aula62Exe2
{
    public partial class Form1 : MaterialForm
    {

        List<Carro> carros = RepositorioCarros.InicializarCarros();
        List<Moto> motos = RepositorioMoto.InicializarMotos();
        List<Cliente> clientes = RepositorioCliente.InicializarCliente();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Cliente cliente in clientes)
            {
                cbbClientes.Items.Add(cliente);
            }

            rbtnCarros.Checked = true;
            rbtnAvariaSim.Checked = true;
            
           
        }

     

        private void rbtnCarros_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnCarros.Checked)
            {
                cbbVeiculos.Items.Clear();
                foreach (Carro item in carros)
                {
                    cbbVeiculos.Items.Add(item);
                }
            }
        }

        private void rbtnMotos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnMotos.Checked)
            {
                cbbVeiculos.Items.Clear();
                foreach (Moto item in motos)
                {
                    cbbVeiculos.Items.Add(item);
                }
            }
        }

        private void rbtnAvariaSim_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rbtnAvariaSim.Checked)
            {
                lblValorAvaria.Visible = true;
                txtValorAvaria.Visible = true;
            }
            else
            {
                lblValorAvaria.Visible = false;
                txtValorAvaria.Visible = false;
            }
        }

       

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = clientes[cbbClientes.SelectedIndex];
            Veiculo veiculo;
            if (rbtnMotos.Checked)
            {
                veiculo = motos[cbbVeiculos.SelectedIndex];
            }
            else
            {
                veiculo = carros[cbbVeiculos.SelectedIndex];
            }
            double valorPorHora = double.Parse(txtValorPorHora.Text);
            double valorPorDia = double.Parse(txtValorPorDia.Text);
            double seguro = double.Parse(txtSeguro.Text);
            double valorAvaria = 0;
            DateTime dataInicial = DateTime.Parse(txtDataInicial.Text);
            DateTime dataEntrega = DateTime.Parse(txtDataDeEntrega.Text);
            bool avaria = false;
            if (rbtnAvariaSim.Checked)
            {
                valorAvaria = double.Parse(txtValorAvaria.Text);
                avaria = true;
            }
            Locacao locacao = new Locacao(cliente, veiculo, dataInicial, dataEntrega, valorPorHora, valorPorDia, seguro, valorAvaria, avaria);
            Resultado resultado = new Resultado(locacao);
            resultado.ShowDialog();
        }
    }
}
