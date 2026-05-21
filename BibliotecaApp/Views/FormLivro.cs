using System;
using System.Windows.Forms;
using BibliotecaApp.Models;
using BibliotecaApp.Repositories;

namespace BibliotecaApp.Views
{
    public partial class FormLivro : Form
    {
        private LivroRepository _livroRepository = new LivroRepository();
        private CategoriaRepository _categoriaRepository = new CategoriaRepository();
        private AutorRepository _autorRepository = new AutorRepository();

        private int _idSelecionado = 0;

        public FormLivro()
        {
            InitializeComponent();
            this.Load += FormLivro_Load;
            btnExcluir.Click += btnExcluir_Click;
            dgvLivros.CellClick += dgvLivros_CellClick;
        }

        private void FormLivro_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCategoria.DataSource = _categoriaRepository.BuscarTodos();
                cmbCategoria.DisplayMember = "Descricao";
                cmbCategoria.ValueMember = "Id";

                lstAutores.DataSource = _autorRepository.BuscarTodos();
                lstAutores.DisplayMember = "Nome";
                lstAutores.ValueMember = "Id";

                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados iniciais: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Título e Categoria são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstAutores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um autor para o livro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var libro = new Livro
                {
                    Id = _idSelecionado,
                    Titulo = txtTitulo.Text,
                    AnoPublicacao = int.TryParse(txtAno.Text, out int ano) ? ano : DateTime.Now.Year,
                    CategoriaId = (int)cmbCategoria.SelectedValue
                };

                foreach (Autor autorSelecionado in lstAutores.SelectedItems)
                {
                    libro.Autores.Add(autorSelecionado);
                }

                if (_idSelecionado == 0)
                {
                    _livroRepository.Inserir(libro);
                    MessageBox.Show("Livro cadastrado com sucesso associado aos seus autores!", "Sucesso");
                }
                else
                {
                    _livroRepository.Editar(libro);
                    MessageBox.Show("Livro atualizado com sucesso!", "Sucesso");
                }

                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLivros.CurrentRow != null)
            {
                var livroSelecionado = dgvLivros.CurrentRow.DataBoundItem as Livro;

                if (livroSelecionado != null)
                {
                    _idSelecionado = livroSelecionado.Id;
                    txtTitulo.Text = livroSelecionado.Titulo;
                    txtAno.Text = livroSelecionado.AnoPublicacao.ToString();
                    cmbCategoria.SelectedValue = livroSelecionado.CategoriaId;

                    var autoresDoLivro = _livroRepository.BuscarAutoresIdsDoLivro(_idSelecionado);

                    lstAutores.ClearSelected();

                    for (int i = 0; i < lstAutores.Items.Count; i++)
                    {
                        var autorDoCombo = lstAutores.Items[i] as Autor;
                        if (autorDoCombo != null && autoresDoLivro.Contains(autorDoCombo.Id))
                        {
                            lstAutores.SetSelected(i, true);
                        }
                    }

                    btnSalvar.Text = "Atualizar Livro";
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                MessageBox.Show("Selecione um livro na tabela antes de tentar excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja excluir este livro e desvincular seus autores?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _livroRepository.Excluir(_idSelecionado);
                    MessageBox.Show("Livro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtTitulo.Clear();
            txtAno.Clear();
            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            lstAutores.ClearSelected();
            btnSalvar.Text = "Cadastrar Livro";
        }

        private void System_AtualizarGrid()
        {
            try
            {
                dgvLivros.DataSource = _livroRepository.BuscarTodos();
            }
            catch { }
        }

        private void ResetGrid()
        {
            System_AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            ResetGrid();
        }
    }
}