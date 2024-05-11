using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmPesquisarUsuarios : Form
    {
        public frmPesquisarUsuarios()
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
            comm.CommandText = "select * from tbUsuario where codUsu = @codUsu";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUSu", MySqlDbType.Int32, 11).Value = codigo;

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

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (!rdbCodigo.Checked && !rdbNome.Checked)
            {
                MessageBox.Show("Selecione qual tipo de pesquisa deseja saber", "Campo indefinido");
            }
            else
            {
                if (rdbCodigo.Checked)
                {
                    buscaPorCodigo(Convert.ToInt32(txtDescricao.Text));
                }
                else if (rdbNome.Checked)
                {
                    BuscaPorNome(txtDescricao.Text);
                }


            }
        }
    }
}
