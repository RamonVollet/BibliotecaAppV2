namespace BibliotecaApp.Views
{
    partial class FormEmprestimo
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
            this.lbl_livro = new System.Windows.Forms.Label();
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lbl_data_retirada = new System.Windows.Forms.Label();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lbl_data_limite = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_livro
            // 
            this.lbl_livro.AutoSize = true;
            this.lbl_livro.Location = new System.Drawing.Point(13, 13);
            this.lbl_livro.Name = "lbl_livro";
            this.lbl_livro.Size = new System.Drawing.Size(89, 13);
            this.lbl_livro.TabIndex = 0;
            this.lbl_livro.Text = "Selecione o Livro";
            // 
            // cmbLivro
            // 
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(16, 30);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(121, 21);
            this.cmbLivro.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(16, 58);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(102, 13);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Selecione o Usuário";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(19, 75);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 3;
            // 
            // lbl_data_retirada
            // 
            this.lbl_data_retirada.AutoSize = true;
            this.lbl_data_retirada.Location = new System.Drawing.Point(19, 103);
            this.lbl_data_retirada.Name = "lbl_data_retirada";
            this.lbl_data_retirada.Size = new System.Drawing.Size(88, 13);
            this.lbl_data_retirada.TabIndex = 4;
            this.lbl_data_retirada.Text = "Data de Retirada";
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.Location = new System.Drawing.Point(22, 120);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(200, 20);
            this.dtpEmprestimo.TabIndex = 5;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(22, 163);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(200, 20);
            this.dtpDevolucao.TabIndex = 6;
            // 
            // lbl_data_limite
            // 
            this.lbl_data_limite.AutoSize = true;
            this.lbl_data_limite.Location = new System.Drawing.Point(22, 147);
            this.lbl_data_limite.Name = "lbl_data_limite";
            this.lbl_data_limite.Size = new System.Drawing.Size(130, 13);
            this.lbl_data_limite.TabIndex = 7;
            this.lbl_data_limite.Text = "Data Limite de Devolução";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Registrar Empréstimo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(245, 13);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.Size = new System.Drawing.Size(543, 343);
            this.dgvEmprestimos.TabIndex = 9;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(22, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir Emprestimo";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbl_data_limite);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpEmprestimo);
            this.Controls.Add(this.lbl_data_retirada);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.cmbLivro);
            this.Controls.Add(this.lbl_livro);
            this.Name = "FormEmprestimo";
            this.Text = "FormEmprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_livro;
        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lbl_data_retirada;
        private System.Windows.Forms.DateTimePicker dtpEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label lbl_data_limite;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Button btnExcluir;
    }
}