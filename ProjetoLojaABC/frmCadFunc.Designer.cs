
namespace ProjetoLojaABC
{
    partial class frmCadFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFunc));
            this.gpbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFuncionarios = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbDadosUsuario.SuspendLayout();
            this.pnlFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosUsuario
            // 
            this.gpbDadosUsuario.Controls.Add(this.txtRepetirSenha);
            this.gpbDadosUsuario.Controls.Add(this.label4);
            this.gpbDadosUsuario.Controls.Add(this.txtSenha);
            this.gpbDadosUsuario.Controls.Add(this.label3);
            this.gpbDadosUsuario.Controls.Add(this.txtNome);
            this.gpbDadosUsuario.Controls.Add(this.label2);
            this.gpbDadosUsuario.Controls.Add(this.txtCodigo);
            this.gpbDadosUsuario.Controls.Add(this.label1);
            this.gpbDadosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosUsuario.Location = new System.Drawing.Point(119, 21);
            this.gpbDadosUsuario.Name = "gpbDadosUsuario";
            this.gpbDadosUsuario.Size = new System.Drawing.Size(535, 348);
            this.gpbDadosUsuario.TabIndex = 13;
            this.gpbDadosUsuario.TabStop = false;
            this.gpbDadosUsuario.Text = "Dados do Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(81, 139);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(144, 24);
            this.txtSenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 24);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(81, 51);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // pnlFuncionarios
            // 
            this.pnlFuncionarios.Controls.Add(this.btnVoltar);
            this.pnlFuncionarios.Controls.Add(this.btnLimpar);
            this.pnlFuncionarios.Controls.Add(this.btnPesquisar);
            this.pnlFuncionarios.Controls.Add(this.btnExcluir);
            this.pnlFuncionarios.Controls.Add(this.btnCadastrar);
            this.pnlFuncionarios.Controls.Add(this.btnAlterar);
            this.pnlFuncionarios.Controls.Add(this.btnNovo);
            this.pnlFuncionarios.Location = new System.Drawing.Point(2, 424);
            this.pnlFuncionarios.Name = "pnlFuncionarios";
            this.pnlFuncionarios.Size = new System.Drawing.Size(780, 115);
            this.pnlFuncionarios.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(669, 65);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 45);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(564, 65);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 45);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(459, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 45);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(345, 65);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 45);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(117, 65);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 45);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(231, 65);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 45);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 65);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 45);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtRepetirSenha.Location = new System.Drawing.Point(126, 182);
            this.txtRepetirSenha.MaxLength = 10;
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = 'l';
            this.txtRepetirSenha.Size = new System.Drawing.Size(190, 24);
            this.txtRepetirSenha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repetir Senha";
            // 
            // frmCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbDadosUsuario);
            this.Controls.Add(this.pnlFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Cadastro Funcionario";
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.gpbDadosUsuario.ResumeLayout(false);
            this.gpbDadosUsuario.PerformLayout();
            this.pnlFuncionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosUsuario;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFuncionarios;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
    }
}