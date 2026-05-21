using System.Collections.Generic;
using BibliotecaApp.Models;
using Dapper;
using MySqlConnector;

namespace BibliotecaApp.Repositories
{
    public class CategoriaRepository : IRepository<Categoria>
    {
        public void Inserir(Categoria entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "INSERT INTO Categoria (Descricao) VALUES (@Descricao)";
                conexao.Execute(sql, entidade);
            }
        }

        public IEnumerable<Categoria> BuscarTodos()
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                return conexao.Query<Categoria>("SELECT * FROM Categoria");
            }
        }

        public void Editar(Categoria entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "UPDATE Categoria SET Descricao = @Descricao WHERE Id = @Id";
                conexao.Execute(sql, entidade);
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "DELETE FROM Categoria WHERE Id = @Id";
                conexao.Execute(sql, new { Id = id });
            }
        }
    }
}