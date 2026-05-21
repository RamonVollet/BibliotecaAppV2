using System;
using System.Windows.Forms;
using BibliotecaApp.Models;
using BibliotecaApp.Repositories;

namespace BibliotecaApp.Views
{
    public partial class FormEmprestimo : Form
    {
        private EmprestimoRepository _emprestimoRepository = new EmprestimoRepository();
        private LivroRepository _livroRepository = new LivroRepository();
        private UsuarioRepository _usuarioRepository = new UsuarioRepository();

        //Variável de controle: 0 para cadastrar novo, maior que 0 se estiver editando/excluindo
        private int _idSelecionado = 0;

        public FormEmprestimo()
        {
            InitializeComponent();

            this.Load += FormEmprestimo_Load;

            // Vincular o clique da tabela para carregar as informações nos campos
            dgvEmprestimos.CellClick += dgvEmprestimos_CellClick;

            //Vincular o clique do novo botão de excluir
            btnExcluir.Click += btnExcluir_Click;
        }

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLivro.DataSource = _livroRepository.BuscarTodos();
                cmbLivro.DisplayMember = "Titulo";
                cmbLivro.ValueMember = "Id";

                cmbUsuario.DataSource = _usuarioRepository.BuscarTodos();
                cmbUsuario.DisplayMember = "Nome";
                cmbUsuario.ValueMember = "Id";

                AtualizarGrid();
            }
            catch (Exception ex) { MessageBox.Show("Erro de carregamento: " + ex.Message); }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cmbLivro.SelectedValue == null || cmbUsuario.SelectedValue == null)
            {
                MessageBox.Show("Selecione um Livro e um Usuário válidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDevolucao.Value.Date < dtpEmprestimo.Value.Date)
            {
                MessageBox.Show("A data de devolução não pode ser menor que a data de empréstimo!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var emprestimo = new Emprestimo
                {
                    Id = _idSelecionado,
                    LivroId = (int)cmbLivro.SelectedValue,
                    UsuarioId = (int)cmbUsuario.SelectedValue,
                    DataEmprestimo = dtpEmprestimo.Value,
                    DataDevolucao = dtpDevolucao.Value
                };

                if (_idSelecionado == 0)
                {

                    _emprestimoRepository.Inserir(emprestimo);
                    MessageBox.Show("Registro de empréstimo gravado com sucesso!", "Sucesso");
                }
                else
                {

                    _emprestimoRepository.Editar(emprestimo);
                    MessageBox.Show("Registro de empréstimo atualizado com sucesso!", "Sucesso");
                }

                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao registrar empréstimo: " + ex.Message);
            }
        }


        private void dgvEmprestimos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEmprestimos.CurrentRow != null)
            {
                var emprestimoSelecionado = dgvEmprestimos.CurrentRow.DataBoundItem as Emprestimo;

                if (emprestimoSelecionado != null)
                {
                    _idSelecionado = emprestimoSelecionado.Id;
                    cmbLivro.SelectedValue = emprestimoSelecionado.LivroId;
                    cmbUsuario.SelectedValue = emprestimoSelecionado.UsuarioId;
                    dtpEmprestimo.Value = emprestimoSelecionado.DataEmprestimo;

                    if (emprestimoSelecionado.DataDevolucao.HasValue)
                        dtpDevolucao.Value = emprestimoSelecionado.DataDevolucao.Value;

                    btnSalvar.Text = "Atualizar Empréstimo";
                }
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                MessageBox.Show("Selecione um empréstimo na tabela antes de tentar excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja remover este empréstimo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _emprestimoRepository.Excluir(_idSelecionado);
                    MessageBox.Show("Empréstimo removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir empréstimo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            if (cmbLivro.Items.Count > 0) cmbLivro.SelectedIndex = 0;
            if (cmbUsuario.Items.Count > 0) cmbUsuario.SelectedIndex = 0;
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            btnSalvar.Text = "Salvar Empréstimo";
        }

        private void dgvEmprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void AtualizarGrid()
        {
            try { dgvEmprestimos.DataSource = _emprestimoRepository.BuscarTodos(); } catch { }
        }
    }
}