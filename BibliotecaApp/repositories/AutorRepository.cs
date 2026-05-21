using BibliotecaApp.Models;
using Dapper;
using MySqlConnector;
using System.Collections.Generic;

namespace BibliotecaApp.Repositories
{
    public class AutorRepository : IRepository<Autor>
    {
        public void Inserir(Autor entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "INSERT INTO Autor (Nome, Nacionalidade) VALUES (@Nome, @Nacionalidade)";
                conexao.Execute(sql, entidade);
            }
        }

        public IEnumerable<Autor> BuscarTodos()
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                return conexao.Query<Autor>("SELECT * FROM Autor");
            }
        }

        public void Editar(Autor entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "UPDATE Autor SET Nome = @Nome, Nacionalidade = @Nacionalidade WHERE Id = @Id";
                conexao.Execute(sql, entidade);
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "DELETE FROM Autor WHERE Id = @Id";
                conexao.Execute(sql, new { Id = id });
            }
        }
    }
}