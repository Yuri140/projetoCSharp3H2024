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
using MySql.Data;

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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") || txtNome.Text.Equals("") ||
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
                MessageBox.Show("Cadastrado com sucesso!!!",
               "Mensagem do sistema", MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
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
            txtCodigo.Enabled = true;
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

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            habilitarCampos();
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
            
        }
    }
}
