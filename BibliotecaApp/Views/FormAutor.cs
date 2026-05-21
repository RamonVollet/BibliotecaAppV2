using System;
using System.Windows.Forms;
using BibliotecaApp.Models;
using BibliotecaApp.Repositories;

namespace BibliotecaApp.Views
{
    public partial class FormAutor : Form
    {
        private AutorRepository _autorRepository = new AutorRepository();
        private int _idSelecionado = 0;

        public FormAutor()
        {
            InitializeComponent();
            this.Load += FormAutor_Load;
            btnExcluir.Click += btnExcluir_Click;
            dgvAutores.CellClick += dgvAutores_CellClick;
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do autor é obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var autor = new Autor
                {
                    Id = _idSelecionado,
                    Nome = txtNome.Text,
                    Nacionalidade = txtNacionalidade.Text
                };

                if (_idSelecionado == 0)
                {
                    _autorRepository.Inserir(autor);
                    MessageBox.Show("Autor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _autorRepository.Editar(autor);
                    MessageBox.Show("Autor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar banco de dados: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAutores.CurrentRow != null)
            {
                var autorSelecionado = dgvAutores.CurrentRow.DataBoundItem as Autor;

                if (autorSelecionado != null)
                {
                    _idSelecionado = autorSelecionado.Id;
                    txtNome.Text = autorSelecionado.Nome;
                    txtNacionalidade.Text = autorSelecionado.Nacionalidade;
                    btnSalvar.Text = "Atualizar Autor";
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                MessageBox.Show("Selecione um autor na tabela antes de tentar excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja excluir este autor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _autorRepository.Excluir(_idSelecionado);
                    MessageBox.Show("Autor removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}. Verifique se este autor não está vinculado a nenhum livro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtNome.Clear();
            txtNacionalidade.Clear();
            btnSalvar.Text = "Salvar Autor";
        }

        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AtualizarGrid()
        {
            try
            {
                dgvAutores.DataSource = _autorRepository.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar lista: {ex.Message}");
            }
        }
    }
}