using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosDoCliente.Cliente
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            txtData.Enabled = false;
            txtData.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length == 0)
            {
                MessageBox.Show("Campo Nome é obrigatório.","Campo Obrigatório!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.ToUpperInvariant().Contains("GMAIL.COM"))
            {
                MessageBox.Show("Formato de Email inválido");
            }
            else
            {

                string caminho = $@"C:\Users\czarf\OneDrive\Área de Trabalho\Banco de Dados\Cadastro{txtNome.Text}.txt";
                //@"C:\Users\czarf\OneDrive\Área de Trabalho\Teste.txt"

                if (!File.Exists(caminho))
                {
                    File.Create(caminho);
                }

                if (File.Exists(caminho))
                {
                    try
                    {
                        File.AppendAllText(caminho, $"\nData: {txtData.Text}\nEmail: {txtEmail.Text}\nNome: {txtNome.Text}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
