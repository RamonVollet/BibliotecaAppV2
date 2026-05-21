using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BibliotecaApp.Models;
using BibliotecaApp.Repositories;

namespace BibliotecaApp.Views
{
    public partial class FormUsuario : Form
    {
        private UsuarioRepository _usuarioRepository = new UsuarioRepository();
        private int _idSelecionado = 0;

        public FormUsuario()
        {
            InitializeComponent();
            this.Load += FormUsuario_Load;
            btnExcluir.Click += btnExcluir_Click;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Nome e CPF são obrigatórios!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("O CPF digitado é inválido!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefone.Text) && !ValidarTelefone(txtTelefone.Text))
            {
                MessageBox.Show("O número de telefone digitado é inválido! Insira um formato válido com DDD.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = new Usuario
                {
                    Id = _idSelecionado,
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Matricula = txtMatricula.Text,
                    Telefone = txtTelefone.Text
                };

                if (_idSelecionado == 0)
                {
                    _usuarioRepository.Inserir(usuario);
                    MessageBox.Show("Usuário/Leitor registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _usuarioRepository.Editar(usuario);
                    MessageBox.Show("Dados do usuário atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuarios.CurrentRow != null)
            {
                var usuarioSelecionado = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;

                if (usuarioSelecionado != null)
                {
                    _idSelecionado = usuarioSelecionado.Id;
                    txtNome.Text = usuarioSelecionado.Nome;
                    txtCpf.Text = usuarioSelecionado.Cpf;
                    txtMatricula.Text = usuarioSelecionado.Matricula;
                    txtTelefone.Text = usuarioSelecionado.Telefone;

                    btnSalvar.Text = "Atualizar Usuário";
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                MessageBox.Show("Selecione um usuário na tabela antes de tentar excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja excluir este usuário/leitor definitivamente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _usuarioRepository.Excluir(_idSelecionado);
                    MessageBox.Show("Usuário removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}. Verifique se este usuário não possui empréstimos pendentes vinculados a ele.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtNome.Clear();
            txtCpf.Clear();
            txtMatricula.Clear();
            txtTelefone.Clear();
            btnSalvar.Text = "Registrar Leitor";
        }

        private void RazaoGrid()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.Columns.Clear();
                dgvUsuarios.AutoGenerateColumns = false;

                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Width = 150 });
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "CPF", Width = 100 });
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Matricula", HeaderText = "Matrícula", Width = 90 });
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone", Width = 110 });

                dgvUsuarios.DataSource = _usuarioRepository.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar tabela: " + ex.Message);
            }
        }

        private void AtualizarGrid()
        {
            RazaoGrid();
        }

        private bool ValidarCpf(string cpf)
        {
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            if (cpf.Length != 11) return false;

            bool todosIguais = true;
            for (int i = 1; i < 11; i++)
            {
                if (cpf[i] != cpf[0]) todosIguais = false;
            }
            if (todosIguais) return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            tempCpf = tempCpf + digito1;
            soma = 0;

            for (int i = 0; i < 10; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(digito1.ToString() + digito2.ToString());
        }

        private bool ValidarTelefone(string telefone)
        {
            string numeroLimpo = Regex.Replace(telefone, @"[^\d]", "");
            return numeroLimpo.Length == 10 || numeroLimpo.Length == 11;
        }
    }
}