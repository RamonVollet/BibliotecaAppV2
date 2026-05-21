using System;
using System.Collections.Generic;
using BibliotecaApp.Models;
using Dapper;
using MySqlConnector;

namespace BibliotecaApp.Repositories
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        public void Inserir(Usuario entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                ValidarDuplicados(conexao, entidade);

                string sql = "INSERT INTO Usuario (Nome, Cpf, Matricula, Telefone) VALUES (@Nome, @Cpf, @Matricula, @Telefone)";
                conexao.Execute(sql, entidade);
            }
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                return conexao.Query<Usuario>("SELECT * FROM Usuario");
            }
        }

        public void Editar(Usuario entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                ValidarDuplicados(conexao, entidade);

                string sql = @"UPDATE Usuario 
                               SET Nome = @Nome, Cpf = @Cpf, Matricula = @Matricula, Telefone = @Telefone 
                               WHERE Id = @Id";
                conexao.Execute(sql, entidade);
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "DELETE FROM Usuario WHERE Id = @Id";
                conexao.Execute(sql, new { Id = id });
            }
        }

        private void ValidarDuplicados(MySqlConnection conexao, Usuario entidade)
        {
            string sqlCpf = "SELECT COUNT(1) FROM Usuario WHERE Cpf = @Cpf AND Id != @Id";
            if (conexao.ExecuteScalar<int>(sqlCpf, entidade) > 0)
            {
                throw new InvalidOperationException("Este CPF já está cadastrado para outro usuário.");
            }

            if (!string.IsNullOrWhiteSpace(entidade.Matricula))
            {
                string sqlMatricula = "SELECT COUNT(1) FROM Usuario WHERE Matricula = @Matricula AND Id != @Id";
                if (conexao.ExecuteScalar<int>(sqlMatricula, entidade) > 0)
                {
                    throw new InvalidOperationException("Esta Matrícula já está cadastrada para outro usuário.");
                }
            }

            if (!string.IsNullOrWhiteSpace(entidade.Telefone))
            {
                string sqlTelefone = "SELECT COUNT(1) FROM Usuario WHERE Telefone = @Telefone AND Id != @Id";
                if (conexao.ExecuteScalar<int>(sqlTelefone, entidade) > 0)
                {
                    throw new InvalidOperationException("Este número de Telefone já está cadastrado para outro usuário.");
                }
            }
        }
    }
}