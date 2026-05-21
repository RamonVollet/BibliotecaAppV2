using System.Collections.Generic;
using BibliotecaApp.Models;
using Dapper;
using MySqlConnector;

namespace BibliotecaApp.Repositories
{
    public class LivroRepository : IRepository<Livro>
    {
        public void Inserir(Livro entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sqlLivro = @"INSERT INTO Livro (Titulo, AnoPublicacao, CategoriaId) 
                                    VALUES (@Titulo, @AnoPublicacao, @CategoriaId);
                                    SELECT LAST_INSERT_ID();";

                int livroId = conexao.QuerySingle<int>(sqlLivro, entidade);

                foreach (var autor in entidade.Autores)
                {
                    string sqlRelacao = "INSERT INTO Livro_Autor (LivroId, AutorId) VALUES (@LivroId, @AutorId)";
                    conexao.Execute(sqlRelacao, new { LivroId = livroId, AutorId = autor.Id });
                }
            }
        }

        public IEnumerable<Livro> BuscarTodos()
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                return conexao.Query<Livro>("SELECT * FROM Livro");
            }
        }
        public void Editar(Livro entidade)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sqlLivro = "UPDATE Livro SET Titulo = @Titulo, AnoPublicacao = @AnoPublicacao, CategoriaId = @CategoriaId WHERE Id = @Id";
                conexao.Execute(sqlLivro, entidade);

                string sqlDeletarRelacoes = "DELETE FROM Livro_Autor WHERE LivroId = @Id";
                conexao.Execute(sqlDeletarRelacoes, new { Id = entidade.Id });

                foreach (var autor in entidade.Autores)
                {
                    string sqlRelacao = "INSERT INTO Livro_Autor (LivroId, AutorId) VALUES (@LivroId, @AutorId)";
                    conexao.Execute(sqlRelacao, new { LivroId = entidade.Id, AutorId = autor.Id });
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sqlRelacoes = "DELETE FROM Livro_Autor WHERE LivroId = @Id";
                conexao.Execute(sqlRelacoes, new { Id = id });

                string sqlLivro = "DELETE FROM Livro WHERE Id = @Id";
                conexao.Execute(sqlLivro, new { Id = id });
            }
        }
        public List<int> BuscarAutoresIdsDoLivro(int livroId)
        {
            using (var conexao = new MySqlConnection(Config.StringConexao))
            {
                string sql = "SELECT AutorId FROM Livro_Autor WHERE LivroId = @LivroId";
                return conexao.Query<int>(sql, new { LivroId = livroId }).AsList();
            }
        }
    }
}