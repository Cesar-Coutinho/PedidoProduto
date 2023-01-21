using PedidosDoCliente.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosDoCliente.ItemDoPedido
{
    public partial class ItensDoPedido : Form
    {
        Produtos produtos = new Produtos();

        public string NomeProduto { get; set; }
        public double PrecoTotal { get; set; }
        public string PrecoProduto { get; set; }



        public string[] Produto { get; set; }


        public ItensDoPedido()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            produtos.ShowDialog();

            NomeProduto = produtos.RetornarNomeProduto();
            PrecoProduto = produtos.RetornarPrecoProduto().ToString();

            //txtPreco.Text = PrecoProduto;//double.Parse(txtQuantidade.Text) <= 0 ? "0" : (double.Parse($"{PrecoProduto:F2}") * double.Parse($"{ txtQuantidade.Text:F2}")).ToString();
            //PrecoTotal = PrecoProduto * Double.Parse(txtQuantidade.Text);

            //btnCadastrarProduto.Enabled = !(double.Parse(txtPreco.Text) > 0);

            




        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string RetornarValores()
        {
            return NomeProduto + "/" + PrecoTotal +"/"+ PrecoProduto;
        }
    }
}
