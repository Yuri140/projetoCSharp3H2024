using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            Desabilitar();
        }

        public void Desabilitar()

        {
            rdbNome.Checked = false;
            rdbCodigo.Checked = false;
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!rdbCodigo.Checked && !rdbNome.Checked)
            {
                MessageBox.Show("Selecione qual tipo de pesquisa deseja saber", "Campo indefinido");
            }
            else
            {
                if (rdbCodigo.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Campo descrição não definido", "Campo indefinido");
                    }
                    else
                    {
                        //Busca por codigo

                    }

                }

                if (rdbNome.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Campo descrição não definido", "Campo indefinido");
                    }
                    else
                    {
                        //Busca por codigo
                    }
                }

            
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            lstPesquisar.Items.Clear();
            lstPesquisar.Items.Add(" 1 - José Rocha - 25 anos ");
            
        }
    }
}
