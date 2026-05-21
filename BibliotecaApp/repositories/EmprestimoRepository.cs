using System.Collections.Generic;
using BibliotecaApp.Models;
using Dapper;
using MySqlConnector;

namespace BibliotecaApp.Repositories
{
    public class EmprestimoRepository : IRepository<Emprestimo>
    {
        public void Inserir(Emprestimo entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = @"INSERT INTO Emprestimo (LivroId, UsuarioId, DataEmprestimo, DataDevolucao) 
                               VALUES (@LivroId, @UsuarioId, @DataEmprestimo, @DataDevolucao)";
                conexao.Execute(sql, entidade);
            }
        }

        public IEnumerable<Emprestimo> BuscarTodos()
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                return conexao.Query<Emprestimo>("SELECT * FROM Emprestimo");
            }
        }
        public void Editar(Emprestimo entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = @"UPDATE Emprestimo 
                               SET LivroId = @LivroId, UsuarioId = @UsuarioId, 
                                   DataEmprestimo = @DataEmprestimo, DataDevolucao = @DataDevolucao 
                               WHERE Id = @Id";
                conexao.Execute(sql, entidade);
            }
        }
        public void Excluir(int id)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "DELETE FROM Emprestimo WHERE Id = @Id";
                conexao.Execute(sql, new { Id = id });
            }
        }
    }
}