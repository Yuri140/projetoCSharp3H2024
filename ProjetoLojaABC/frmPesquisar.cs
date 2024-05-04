using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public void buscaPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where codFunc = @codFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codigo;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            lstPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }

        public void BuscaPorNome(string nome)
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "Select * from tbfuncionarios where nome like '%" + nome + "%';";
            conm.CommandType = CommandType.Text;
            conm.Connection = Conexao.obterConexao();

            conm.Parameters.Clear();
            conm.Parameters.Add("@nome", MySqlDbType.String, 100).Value = nome;

            MySqlDataReader DR;
            DR = conm.ExecuteReader();

            while (DR.Read())
            {
                lstPesquisar.Items.Add(DR.GetString(1));
            }
            Conexao.fecharConexao();

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
                        buscaPorCodigo(Convert.ToInt32(txtDescricao.Text));

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
                        //Busca por nome
                        BuscaPorNome(txtDescricao.Text);
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
