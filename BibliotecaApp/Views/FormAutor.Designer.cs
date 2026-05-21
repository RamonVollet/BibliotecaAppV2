namespace BibliotecaApp.Views
{
    partial class FormAutor
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
            this.lbl_nome_autor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_nacionalidade = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome_autor
            // 
            this.lbl_nome_autor.AutoSize = true;
            this.lbl_nome_autor.Location = new System.Drawing.Point(13, 13);
            this.lbl_nome_autor.Name = "lbl_nome_autor";
            this.lbl_nome_autor.Size = new System.Drawing.Size(78, 13);
            this.lbl_nome_autor.TabIndex = 0;
            this.lbl_nome_autor.Text = "Nome do Autor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbl_nacionalidade
            // 
            this.lbl_nacionalidade.AutoSize = true;
            this.lbl_nacionalidade.Location = new System.Drawing.Point(13, 57);
            this.lbl_nacionalidade.Name = "lbl_nacionalidade";
            this.lbl_nacionalidade.Size = new System.Drawing.Size(75, 13);
            this.lbl_nacionalidade.TabIndex = 2;
            this.lbl_nacionalidade.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(16, 73);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidade.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar Autor";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(141, 13);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(343, 150);
            this.dgvAutores.TabIndex = 5;
            this.dgvAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(16, 129);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir Autor";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.lbl_nacionalidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl_nome_autor);
            this.Name = "FormAutor";
            this.Text = "FormAutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_autor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_nacionalidade;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Button btnExcluir;
    }
}