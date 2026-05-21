namespace BibliotecaApp.Views
{
    partial class FormLivro
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
            this.lbl_titulo_livro = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbl_ano_publicacao = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lbl_catgoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lbl_autores = new System.Windows.Forms.Label();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_livro
            // 
            this.lbl_titulo_livro.AutoSize = true;
            this.lbl_titulo_livro.Location = new System.Drawing.Point(16, 14);
            this.lbl_titulo_livro.Name = "lbl_titulo_livro";
            this.lbl_titulo_livro.Size = new System.Drawing.Size(76, 13);
            this.lbl_titulo_livro.TabIndex = 0;
            this.lbl_titulo_livro.Text = "Título do Livro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(19, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lbl_ano_publicacao
            // 
            this.lbl_ano_publicacao.AutoSize = true;
            this.lbl_ano_publicacao.Location = new System.Drawing.Point(16, 57);
            this.lbl_ano_publicacao.Name = "lbl_ano_publicacao";
            this.lbl_ano_publicacao.Size = new System.Drawing.Size(97, 13);
            this.lbl_ano_publicacao.TabIndex = 2;
            this.lbl_ano_publicacao.Text = "Ano de Publicação";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(19, 74);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 3;
            // 
            // lbl_catgoria
            // 
            this.lbl_catgoria.AutoSize = true;
            this.lbl_catgoria.Location = new System.Drawing.Point(19, 101);
            this.lbl_catgoria.Name = "lbl_catgoria";
            this.lbl_catgoria.Size = new System.Drawing.Size(96, 13);
            this.lbl_catgoria.TabIndex = 4;
            this.lbl_catgoria.Text = "Categoria (Gênero)";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(19, 117);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // lbl_autores
            // 
            this.lbl_autores.AutoSize = true;
            this.lbl_autores.Location = new System.Drawing.Point(19, 145);
            this.lbl_autores.Name = "lbl_autores";
            this.lbl_autores.Size = new System.Drawing.Size(119, 13);
            this.lbl_autores.TabIndex = 6;
            this.lbl_autores.Text = "Selecione o(s) Autor(es)";
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(19, 161);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAutores.Size = new System.Drawing.Size(120, 95);
            this.lstAutores.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(18, 264);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Cadastrar Livro";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(176, 30);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(445, 257);
            this.dgvLivros.TabIndex = 9;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(18, 293);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir Livro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lstAutores);
            this.Controls.Add(this.lbl_autores);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lbl_catgoria);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lbl_ano_publicacao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbl_titulo_livro);
            this.Name = "FormLivro";
            this.Text = "FormLivro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_livro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lbl_ano_publicacao;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lbl_catgoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lbl_autores;
        private System.Windows.Forms.ListBox lstAutores;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Button btnExcluir;
    }
}