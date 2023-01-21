using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosDoCliente.Produto
{
    public partial class Produtos : Form
    {
        public string NomeProduto { private get; set; }
        public Double PrecoProduto { get; set; }

        public Produtos()
        {
            InitializeComponent();
        }

        private void txtCadastroProd_Click(object sender, EventArgs e)
        {
            NomeProduto = txtNomeProd.Text;
            PrecoProduto = Double.Parse(txtPreco.Text);

            Close();


        }

        public string RetornarNomeProduto()
        {
            return NomeProduto;
        }
        public Double RetornarPrecoProduto()
        {
            return PrecoProduto;
        }
    }
}
