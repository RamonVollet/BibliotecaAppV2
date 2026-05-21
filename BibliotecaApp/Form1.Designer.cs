namespace BibliotecaApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(321, 136);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(119, 42);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnAutores
            // 
            this.btnAutores.Location = new System.Drawing.Point(321, 184);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(119, 42);
            this.btnAutores.TabIndex = 1;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            this.btnLivros.Location = new System.Drawing.Point(321, 232);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(119, 42);
            this.btnLivros.TabIndex = 2;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(321, 284);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(119, 42);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.Location = new System.Drawing.Point(321, 332);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(119, 42);
            this.btnEmprestimos.TabIndex = 4;
            this.btnEmprestimos.Text = "Emprestimos";
            this.btnEmprestimos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "SISTEMA DE CONTROLE DE BIBLIOTECA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(697, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "C#";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BibliotecaApp.Properties.Resources.Livro;
            this.pictureBox1.Location = new System.Drawing.Point(341, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmprestimos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnCategorias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

