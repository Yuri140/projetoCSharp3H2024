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
            if (rdbCodigo.Checked)
            {
                if (txtDescricao.Text.Equals(""))
                {
                    MessageBox.Show("Não posso pesquisar", "Campo indefinido");
                }
                else
                {
                    //Busca por codigo
                }

            }
            if (rdbNome.Checked)
            {

            }
        }
    }
}
