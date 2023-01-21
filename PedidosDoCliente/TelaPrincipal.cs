using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosDoCliente
{
    public partial class TelaPrincipal : Form
    {
        Pedido.Pedido pedido = new Pedido.Pedido();

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }
    }
}
