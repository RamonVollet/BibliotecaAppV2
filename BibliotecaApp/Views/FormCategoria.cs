using System;
using System.Windows.Forms;
using BibliotecaApp.Models;
using BibliotecaApp.Repositories;

namespace BibliotecaApp.Views
{
    public partial class FormCategoria : Form
    {
        private CategoriaRepository _categoriaRepository = new CategoriaRepository();
        private int _idSelecionado = 0;

        public FormCategoria()
        {
            InitializeComponent();
            this.Load += FormCategoria_Load;
            btnExcluir.Click += btnExcluir_Click;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("A descrição é obrigatória!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var categoria = new Categoria
                {
                    Id = _idSelecionado,
                    Descricao = txtDescricao.Text
                };

                if (_idSelecionado == 0)
                {
                    _categoriaRepository.Inserir(categoria);
                    MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _categoriaRepository.Editar(categoria);
                    MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCategorias.CurrentRow != null)
            {
                var categoriaSelecionada = dgvCategorias.CurrentRow.DataBoundItem as Categoria;

                if (categoriaSelecionada != null)
                {
                    _idSelecionado = categoriaSelecionada.Id;
                    txtDescricao.Text = categoriaSelecionada.Descricao;
                    btnSalvar.Text = "Atualizar Categoria";
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma categoria na tabela antes de tentar excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _categoriaRepository.Excluir(_idSelecionado);
                    MessageBox.Show("Categoria removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtDescricao.Clear();
            btnSalvar.Text = "Salvar Categoria";
        }

        private void AtualizarGrid()
        {
            try
            {
                dgvCategorias.DataSource = _categoriaRepository.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}