using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PedidosDoCliente.Cliente;
using PedidosDoCliente.Enum;
using PedidosDoCliente.ItemDoPedido;

namespace PedidosDoCliente.Pedido
{
    public partial class Pedido : Form
    {
        public CadastroCliente client { get; set; }
        CadastroCliente cadastroCliente = new CadastroCliente();
        ItensDoPedido itemDoPedido = new ItensDoPedido();
        public Pedido()
        {
            InitializeComponent();

            cmbStatus.Items.Add(StatusDoPedido.Pagamento_Pendente);
            cmbStatus.Items.Add(StatusDoPedido.Processando);
            cmbStatus.Items.Add(StatusDoPedido.Enviado);
            cmbStatus.Items.Add(StatusDoPedido.Entregue);

            cmbStatus.Text = StatusDoPedido.Pagamento_Pendente.ToString();

        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            cadastroCliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemDoPedido.ShowDialog();

            string[] prod = itemDoPedido.RetornarValores().Split('/');

            string nomeProduto = prod[0];
            string precoTotal = prod[1];
            string preco = prod[2];


            TabelaDoProduto.Text = $"Nome do Produto: {nomeProduto} \nPreço do Produto: R${preco:F2}\nPreço total do Produto: R${precoTotal:F2}";

        }
    }
}
