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
           
            lstPesquisar.Items.Add(txtDescricao.Text);
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstPesquisar.Items.Clear();
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*int i = lstPesquisar.SelectedIndex;

           
            MessageBox.Show("O valor da linha é " + nome + " O numero da linha é " + i);*/

            String nome = lstPesquisar.SelectedItem.ToString();

            frmFuncionarios abrir = new frmFuncionarios(nome);
            abrir.Show();
            this.Hide();

        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {

           

            if (e.KeyCode == Keys.Enter)
            {
                if (txtDescricao.Text.Equals(""))
                {
                    MessageBox.Show("Erro! descrição não pode estar vazio", "Erro!");
                }
                else
                {
                    lstPesquisar.Items.Add(txtDescricao.Text);
                    txtDescricao.Clear();
                }

                
                
            }
        }
    }
}
