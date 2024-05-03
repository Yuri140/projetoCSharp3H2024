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
using MySql.Data.MySqlClient; //Importando dados do banco de dados

namespace ProjetoLojaABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmFuncionarios(String nome)
        {
            
            InitializeComponent();
            
            desabilitarCampos();
            txtNome.Text = nome;

        }


        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //Metodo obter codigo
        public void BuscarCodigoFunc()
        {
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "Select codFunc+1 from tbFuncionarios ORDER BY codFunc DESC;";
            conm.CommandType = CommandType.Text;
            conm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = conm.ExecuteReader();
            DR.Read();
            txtCodigo.Text = DR.GetInt32(0).ToString();

            /*Exemplo repetição while(DR.Read()){}*/

            conm.Connection = Conexao.fecharConexao();

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            habilitarCampos();
            BuscarCodigoFunc();

        }


        //metodo cadastrar funcionarios
        public void cadastrarFuncionarios()
        {
            
            MySqlCommand conm = new MySqlCommand();
            conm.CommandText = "insert into tbFuncionarios(nome,email,cpf, telCel,endereco,numero,cep,bairro,cidade,estado)values(@nome, @email, @cpf,@telCel, @endereco, @numero, @cep, @bairro, @cidade, @estado); ";
            conm.CommandType = CommandType.Text;

            conm.Parameters.Clear();
            conm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            conm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            conm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            conm.Parameters.Add("@telCel", MySqlDbType.VarChar, 10).Value = mskTelefone.Text;
            conm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEnd.Text;
            conm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = txtNumero.Text;
            conm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCEP.Text;
            conm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            conm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            conm.Parameters.Add("@estado", MySqlDbType.VarChar, 10).Value = cbbEstado.Text;


            conm.Connection = Conexao.obterConexao();
            int res = conm.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso");
            conm.Connection = Conexao.fecharConexao();

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (/*txtCodigo.Text.Equals("") ||*/ txtNome.Text.Equals("") ||
                txtEnd.Text.Equals("") || txtCidade.Text.Equals("") ||
                txtBairro.Text.Equals("") || txtNumero.Text.Equals("") ||
                txtEmail.Text.Equals("") || mskTelefone.Text.Equals("     -")
                && mskCPF.Text.Equals("   .   .   -") ||
                mskCEP.Text.Equals("     -") || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores válidos!!!",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);

            }
            else
            {
                cadastrarFuncionarios();
                Limpar();
                desabilitarCampos();
                btnNovo.Enabled = true;
            }


           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //desabilitar campos

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtNome.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtNome.Enabled = true;
            txtNumero.Enabled = true;
            mskTelefone.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
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
            txtBairro.ResetText();
            txtCidade.ResetText();
            txtEmail.ResetText();
            txtEnd.ResetText();
            txtNome.ResetText();
            txtNumero.ResetText();
            mskTelefone.ResetText();
            mskCEP.ResetText();
            mskCPF.ResetText();
            cbbEstado.ResetText();
        }

        public void BuscaCEP(String cep)
        {
            /*WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            String end = ws.consultaCEP(mskCEP.Text);
            txtEnd.Text = end.end;
            txtCidade*/
            
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            //Executar função de busca por cep
        }

       
    }
}
