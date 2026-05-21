using BibliotecaApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCategorias.Click += btnCategorias_Click;
            btnAutores.Click += btnAutores_Click;
            btnLivros.Click += btnLivros_Click;
            btnUsuarios.Click += btnUsuarios_Click;
            btnEmprestimos.Click += btnEmprestimos_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            // Instancia e abre a tela de Categorias (Modo Modal)
            FormCategoria telaCategoria = new FormCategoria();
            telaCategoria.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            // Instancia e abre a tela de Autores
            FormAutor telaAutor = new FormAutor();
            telaAutor.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            // Instancia e abre a tela de Livros
            FormLivro telaLivro = new FormLivro();
            telaLivro.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Instancia e abre a tela de Usuários
            FormUsuario telaUsuario = new FormUsuario();
            telaUsuario.ShowDialog();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            // Instancia e abre a tela de Empréstimos (O que acabamos de ajustar!)
            FormEmprestimo telaEmprestimo = new FormEmprestimo();
            telaEmprestimo.ShowDialog();
        }
    }
}
