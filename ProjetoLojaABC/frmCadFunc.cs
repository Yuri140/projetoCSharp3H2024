﻿using System;
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
    public partial class frmCadFunc : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadFunc()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void Limpar()
        {
            txtCodigo.ResetText();
            txtNome.ResetText();
            txtSenha.ResetText();
            txtRepetirSenha.ResetText();
            
        }

        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetirSenha.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

        }

        public void cadastrarUsuario()
        {

            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "insert into tbUsuario(nome, senha)values(@nome, @senha); ";
            conm.CommandType = CommandType.Text;

            conm.Parameters.Clear();
            conm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            conm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;


            conm.Connection = Conexao.obterConexao();
            int res = conm.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso");
            conm.Connection = Conexao.fecharConexao();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarUsuario();
            Limpar();
            desabilitarCampos();
            btnNovo.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            habilitarCampos();
            BuscarCodigoUsu();
        }

        public void AlterarUsuario(int codUsu)
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "Update tbUsuario set nome = @nome, senha = @senha where codUsu = @codUsu";
            conm.CommandType = CommandType.Text;
            conm.Parameters.Clear();
            conm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            conm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;


            conm.Connection = Conexao.obterConexao();
            int res = conm.ExecuteNonQuery();
            MessageBox.Show("Alterado com sucesso");
            conm.Connection = Conexao.fecharConexao();
        }

        public void ExcluirUsuario(int codUsu)
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "Delete from tbUsuario where codUsu = @codUsu";
            conm.CommandType = CommandType.Text;
            conm.Parameters.Clear();
            conm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codUsu;


            conm.Connection = Conexao.obterConexao();
            int res = conm.ExecuteNonQuery();
            MessageBox.Show("Excluido com sucesso");
            Limpar();
            conm.Connection = Conexao.fecharConexao();
        }

        public void BuscarCodigoUsu()
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "Select codUsu+1 from tbUsuario ORDER BY codUsu DESC;";
            conm.CommandType = CommandType.Text;
            conm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = conm.ExecuteReader();
            DR.Read();
            txtCodigo.Text = DR.GetInt32(0).ToString();

            /*Exemplo repetição while(DR.Read()){}*/

            conm.Connection = Conexao.fecharConexao();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }
    }
}
